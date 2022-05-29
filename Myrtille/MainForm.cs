using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.XlsIO;
using System.Text.RegularExpressions;
using System.IO;
using OfficeOpenXml;
using System.Threading.Tasks;
using Syncfusion.WinForms.Controls;

namespace Myrtille
{
    public partial class MainForm : SfForm
    {

        private DataSet AppDataSet = new DataSet();

        private DataTable people = new DataTable();
        private DataTable dayoffs = new DataTable();
        private DataTable related = new DataTable();

    
        public MainForm()
        {
            InitializeComponent();

        }

        private async void toolStripBtnEffectif_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            //create a list to hold all the values
            List<string> excelData = new List<string>();
            if (openFileDialogEffectif.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialogEffectif.FileName;
                //            }
                Utils utils = new Utils();
                sfDataGridEffectif.ShowBusyIndicator = true;

                ExcelPackage ep = await utils.LoadExcelFromFile(filePath);

                ExcelWorksheets worksheets = ep.Workbook.Worksheets;

                if (worksheets.Count != 1)
                { throw new ArgumentException("Le fichier excel Effectif ne doit comporter qu'un seul classeur "); }
                else
                {
                    ExcelWorksheet worksheet = worksheets[0];
                    ExcelColumnCollection columns = worksheet.Columns;
                    ExcelRowsCollection rows = worksheet.Rows;

                    for (int j = worksheet.Dimension.Start.Column; j <= worksheet.Dimension.End.Column; j++)
                    {
                        DataColumn headerColumn = new DataColumn();
                        headerColumn.DataType = worksheet.Cells[1, j].Value.GetType();
                        headerColumn.ColumnName = (j - 1).ToString() + "-" + worksheet.Cells[1, j].Value.ToString();
                        headerColumn.Caption = worksheet.Cells[1, j].Value.ToString();
                        people.Columns.Add(headerColumn);
                    }

                    panelWaitForPeople.Visible = false;

                    //loop all rows
                    for (int i = worksheet.Dimension.Start.Row + 1; i <= worksheet.Dimension.End.Row; i++)
                    {
                        DataRow peopleRow = people.NewRow();
                        //loop all columns in a row
                        for (int j = worksheet.Dimension.Start.Column; j <= worksheet.Dimension.End.Column; j++)
                        {
                            peopleRow[j - 1] = worksheet.Cells[i, j].Value;
                        }
                        people.Rows.Add(peopleRow);
                    }
                }
            

            people.TableName = "Effectif";
//            people = effectif.createTableFromExcel(ep);

                AppDataSet.Tables.Add(people);

                                sfDataGridEffectif.DataSource = AppDataSet;
                                sfDataGridEffectif.DataMember = "Effectif";
                                sfDataGridEffectif.ShowBusyIndicator = false;

                sfDataGridEffectif.Columns["0-Matricule"].AllowSorting = true;
               sfDataGridEffectif.Columns["1-Nom usuel"].AllowSorting = true;
                //sfDataGridEffectif.FilterRowPosition = RowPosition.Top;
                sfDataGridEffectif.Columns[0].FilterRowEditorType = "MultiSelectComboBox";

                panelWaitForPeople.Visible = false;

                if (AppDataSet.Tables.Count == 2)
                {
                    DataTable dt = createResultats();
                    dt = AnalyseRelation(dt);
                    dt = AnalyseDatesAbsences(dt);
                }
            }
        }

        private async void toolStripBtnAbsences_ClickAsync(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            //create a list to hold all the values
            List<string> excelData = new List<string>();
            if (openFileDialogAbsences.ShowDialog() == DialogResult.OK)


            {
                filePath = openFileDialogAbsences.FileName;
                //           }
                Utils utils = new Utils();

                sfDataGridAbsences.ShowBusyIndicator = true;

                ExcelPackage ep = await utils.LoadExcelFromFile(filePath);

                ExcelWorksheets worksheets = ep.Workbook.Worksheets;

                if (worksheets.Count != 1)
                { throw new ArgumentException("Le fichier excel Absences ne doit comporter qu'un seul classeur "); }
                else
                {
                    ExcelWorksheet worksheet = worksheets[0];
                    ExcelColumnCollection columns = worksheet.Columns;
                    ExcelRowsCollection rows = worksheet.Rows;

                    for (int j = worksheet.Dimension.Start.Column; j <= worksheet.Dimension.End.Column; j++)
                    {
                        DataColumn headerColumn = new DataColumn();
                        headerColumn.DataType = worksheet.Cells[1, j].Value.GetType();
                        headerColumn.ColumnName = (j - 1).ToString() + "-" + worksheet.Cells[1, j].Value.ToString();
                        headerColumn.Caption = worksheet.Cells[1, j].Value.ToString();
                        dayoffs.Columns.Add(headerColumn);
                    }

                    panelWaitForDayOff.Visible = false;

                    //loop all rows
                    for (int i = worksheet.Dimension.Start.Row + 1; i <= worksheet.Dimension.End.Row; i++)
                    {
                        DataRow dayoffRow = dayoffs.NewRow();
                        //loop all columns in a row
                        for (int j = worksheet.Dimension.Start.Column; j <= worksheet.Dimension.End.Column; j++)
                        {
                            dayoffRow[j - 1] = worksheet.Cells[i, j].Value;
                        }
                        dayoffs.Rows.Add(dayoffRow);
                    }
                }

                dayoffs.TableName = "Absences";

                //                   dayoffs = absences.LoadExcelFromFile(filePath);


                AppDataSet.Tables.Add(dayoffs);

                AppDataSet.EnforceConstraints = false;
                sfDataGridAbsences.DataSource = AppDataSet;
                sfDataGridAbsences.DataMember = "Absences";

                panelWaitForDayOff.Visible = false;

                if (AppDataSet.Tables.Count == 2)
                {
                    DataTable dt = createResultats();
                    dt = AnalyseRelation(dt);
                }
            }
        }

        private DataTable createResultats()
        {
            DataColumn parentColumn = AppDataSet.Tables["Effectif"].Columns["0-Matricule"];
            DataColumn childColumn = AppDataSet.Tables["Absences"].Columns["0-TGI"];
            DataRelation relation = new System.Data.DataRelation("PeopleAbsences", parentColumn, childColumn);

            AppDataSet.Relations.Add(relation);

            DataTable result = new DataTable();
            result.TableName = "Resultat";

            string[] resultColumnsNames = new string[] { "0-NB", "0-Erreur", "0-TGI", "0-Nom", "0-Prenom", "0-Motif", "0-Debut", "0-Fin" };
            Type[] resultColumnsTypes = new Type[] { typeof(int), typeof(String), typeof(String), typeof(String), typeof(String), typeof(String), typeof(DateTime), typeof(DateTime) };
            for (int i = 0; i < resultColumnsNames.Length; i++)
            {
                DataColumn col = new DataColumn();
                col.ColumnName = resultColumnsNames[i];
                col.DataType = resultColumnsTypes[i];
                result.Columns.Add(col);
            }

            return result;
        }

        private DataTable AnalyseDatesAbsences(DataTable result)
        {

            return result;
        }

        private DataTable AnalyseTypeAbsences(DataTable result)
        {

            return result;
        }
        private DataTable AnalyseRelation(DataTable result)
        {

                        AbsenceForPerson absenceForPerson = new AbsenceForPerson();

            panelWaitForResults.Visible = false;
            sfDataGridResult.ShowBusyIndicator = true;
            DataRelation relation = AppDataSet.Relations[0];

            AppDataSet.Tables.Add(result);
            sfDataGridResult.DataSource = AppDataSet;
            sfDataGridResult.DataMember = "Resultat";

            sfDataGridResult.Columns[0].AllowGrouping = true;
            sfDataGridResult.Columns[0].FilterRowEditorType = "Numeric";

            foreach (DataRow persRow in AppDataSet.Tables["Effectif"].Rows)
            {
                if (persRow.GetChildRows(relation).Length > 0)
                {
                    foreach (DataRow absRow in persRow.GetChildRows(relation))
                    {
//                        DataRow row = result.NewRow();
                        //AbsenceForPerson abs = absenceForPerson.createAbsenceForPerson(persRow.GetChildRows(relation).Length, absRow);
                        //DateTime absDebut = (DateTime)abs.Debut_Absence;
                        //DateTime absFin = (DateTime)abs.Fin_Absence;
                        //DateTime Start = (DateTime)sfDateTimeStart.Value;
                        //DateTime Stop = (DateTime)sfDateTimeStop.Value;
                        //if (DateTime.Compare(absDebut, Start) >0  & 
                        //        (DateTime.Compare(absDebut, Stop) <0) {

                        //}

                    //    row[0] = abs.NbMatches;
                    //    row[2] = abs.TGI;
                    //    row[3] = abs.LastName;
                    //    row[4] = abs.FirstName;
                    //    row[5] = abs.Motif;
                    //    row[6] = abs.Debut_Absence;
                    //    row[7] = abs.Fin_Absence;
                    //    result.Rows.Add(row);
                    }
                }
                else
                {
                    DataRow row = result.NewRow();
                    row[0] = 0;
                    row[1] = "PAS D'ABSENCE";
                    row[2] = persRow[0];
                    row[3] = persRow[1];
                    row[4] = persRow[2];
                    result.Rows.Add(row);
                }
            }
//            result.AcceptChanges();
            sfDataGridResult.ShowBusyIndicator = false;






            return result;
        }


        private void onBtnRefreshClicked(object sender, EventArgs e)
        {
 //           AnalyseRelation();
        }

        private void sfDataGridEffectif_AutoGeneratingColumn(object sender, Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnArgs e)
        {
            string pattern = "^[0-9]+-";
            var data = Regex.Split(e.Column.HeaderText, pattern);
            e.Column.HeaderText = Regex.Split(e.Column.HeaderText, pattern)[1];
            e.Column.HeaderStyle.BackColor = Color.Black;
                e.Column.HeaderStyle.TextColor = Color.Snow;
        }

        private void sfDataGridAbsences_autoGeneratingColumn(object sender, Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnArgs e)
        {
            string pattern = "^[0-9]+-";
            var data = Regex.Split(e.Column.HeaderText, pattern);
            e.Column.HeaderText = Regex.Split(e.Column.HeaderText, pattern)[1];
            e.Column.HeaderStyle.BackColor = Color.Black;
            e.Column.HeaderStyle.TextColor = Color.Snow;
        }

        private void onStartDateChanged(object sender, Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventArgs e)
        {

        }

        private void onStopDateChanged(object sender, Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventArgs e)
        {

        }

        //private void sfDataGridResult_RowValidating(object sender, Syncfusion.WinForms.DataGrid.Events.RowValidatingEventArgs e)
        //{
        //    var data = e.DataRow.RowData as AbsenceForPerson;
        //    if (data.NbMatches == 0)
        //    {
        //        e.IsValid = false;
        //        e.ErrorMessage = "Cette personne n'a pas d'absence enregistrée";
        //    }
        //}
    }
}

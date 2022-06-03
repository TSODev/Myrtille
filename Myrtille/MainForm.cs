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
using System.Windows.Forms.VisualStyles;

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
            this.Style.TitleBar.TextHorizontalAlignment = HorizontalAlignment.Left;
            this.Style.TitleBar.TextVerticalAlignment = VerticalAlignment.Center;

            //Sets the back color and fore color of the title bar.
            this.Style.TitleBar.BackColor = Color.Black;
            this.Style.TitleBar.ForeColor = Color.White;

            //Sets the fore color of the title bar buttons
            this.Style.TitleBar.CloseButtonForeColor = Color.White;
            this.Style.TitleBar.MinimizeButtonForeColor = Color.White;
            this.Style.TitleBar.MaximizeButtonForeColor = Color.White;

            //Sets the hover state back color of the title bar buttons
            this.Style.TitleBar.CloseButtonHoverBackColor = Color.DarkGray;
            this.Style.TitleBar.MinimizeButtonHoverBackColor = Color.DarkGray;
            this.Style.TitleBar.MaximizeButtonHoverBackColor = Color.DarkGray;

            //Sets the pressed state back color of the title bar buttons
            this.Style.TitleBar.CloseButtonPressedBackColor = Color.Gray;
            this.Style.TitleBar.MaximizeButtonPressedBackColor = Color.Gray;
            this.Style.TitleBar.MinimizeButtonPressedBackColor = Color.Gray;

            //Sets the back color of the client area.
 //           this.Style.BackColor = Color.CornflowerBlue;

            sfDateTimeStart.Culture = new System.Globalization.CultureInfo("fr-FR");
            sfDateTimeStop.Culture = new System.Globalization.CultureInfo("fr-FR");
            sfDateTimeStart.MonthCalendar.ShowFooter = false;
            sfDateTimeStop.MonthCalendar.ShowFooter = false;
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
                UtilsAsync utils = new UtilsAsync();
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
                    tabPageAdvPeople.ImageIndex=0;
                    tabPageAdvResults.ImageIndex=1;
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
                    dt = AnalyseRelationAsync(dt);
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
                UtilsAsync utils = new UtilsAsync();

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
                AppDataSet.Tables.Add(dayoffs);

                AppDataSet.EnforceConstraints = false;
                sfDataGridAbsences.DataSource = AppDataSet;
                sfDataGridAbsences.DataMember = "Absences";

                panelWaitForDayOff.Visible = false;
                tabPageAdvDayOffs.ImageIndex = 0;
                tabPageAdvResults.ImageIndex = 1;

                if (AppDataSet.Tables.Count == 2)
                {
                    DataTable dt = createResultats();
                    dt = AnalyseRelationAsync(dt);
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
            tabPageAdvResults.ImageIndex = 0;
            sfDateTimeStart.Enabled = true;
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

        private bool checkDateInRange(AbsenceForPerson abs)
        {
            DateTime absDebut = (DateTime)abs.Debut_Absence;
            DateTime absFin = (DateTime)abs.Fin_Absence;
            DateTime Start = (DateTime)sfDateTimeStart.Value;
            DateTime Stop = (DateTime)sfDateTimeStop.Value;
            bool hasDateError = false;

            if (absDebut.InRange(Start, Stop))
            {
                if (!absFin.InRange(Start, Stop))
                    hasDateError = true;
            }
            else
                hasDateError = true;

            return hasDateError;
        }

        private bool checkDateInRange(string debut, string fin, DateTime start, DateTime stop)
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CreateSpecificCulture("fr-FR");
            System.Globalization.DateTimeStyles styles = System.Globalization.DateTimeStyles.None;
            DateTime absdebut = DateTime.Now;
            DateTime absfin = DateTime.Now;
            if (debut != "")
            {
                absdebut = DateTime.Parse(debut, culture, styles);
            }
            if (fin != "")
            {
                absfin = DateTime.Parse(fin, culture, styles);
            }

            bool hasDateError = false;
            DateTime absDebut;
            if (absdebut.InRange(start, stop))
            {
                if (!absfin.InRange(start, stop))
                    hasDateError = true;
            }
            else
                hasDateError = true;

            return hasDateError;
        }

        private DataRow rowProcess(DataRow persRow)
        {
            DataRelation relation = AppDataSet.Relations[0];
            AbsenceForPerson absenceForPerson = new AbsenceForPerson();
            DataTable result = AppDataSet.Tables[2];

            DataRow row = result.NewRow();
            row[1] = "OK";

            if (persRow.GetChildRows(relation).Length > 0)
                {
                    foreach (DataRow absRow in persRow.GetChildRows(relation))
                    {
                        AbsenceForPerson abs = absenceForPerson.createAbsenceForPerson(persRow.GetChildRows(relation).Length, absRow);

                        if (checkDateInRange(abs))
                        {

                            row[0] = abs.NbMatches;
                            row[1] = "DATES NON VALIDES";
                            row[2] = abs.TGI;
                            row[3] = abs.LastName;
                            row[4] = abs.FirstName;
                            row[5] = abs.Motif;
                            row[6] = abs.Debut_Absence;
                            row[7] = abs.Fin_Absence;

                        }
                    }
                }
                else
                {

                    row[0] = 0;
                    row[1] = "PAS D'ABSENCE";
                    row[2] = persRow[0];
                    row[3] = persRow[1];
                    row[4] = persRow[2];

                }
//            result.Rows.Remove(row);
            return (row);
        }
        private void AllRowsProcess()
        {

            DataTable result = AppDataSet.Tables[2];
            result.Clear();

            foreach (DataRow persRow in AppDataSet.Tables["Effectif"].Rows)
            {
                DataRow row = result.NewRow();
                row = rowProcess(persRow);
                if (row[1].ToString() != "OK") result.Rows.Add(row);
            }
            integerTBRecords.Text = result.Rows.Count.ToString();
        }
        private DataTable AnalyseRelationAsync(DataTable result)
        {
            panelWaitForResults.Visible = false;

            sfDataGridResult.ShowBusyIndicator = true;

            AppDataSet.Tables.Add(result);
            sfDataGridResult.DataSource = AppDataSet;
            sfDataGridResult.DataMember = "Resultat";
            sfDataGridResult.AllowGrouping = true;
            sfDataGridResult.AllowFiltering = true;
            sfDataGridResult.Columns[0].AllowGrouping = true;
            sfDataGridResult.Columns[0].FilterRowEditorType = "Numeric";

            AllRowsProcess();

            sfDataGridResult.ShowBusyIndicator = false;
            sfDataGridResult.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.AllCells;

            return result;
        }


 //       private void onBtnRefreshClicked(object sender, EventArgs e)
 //       {
 ////           AnalyseRelation();
 //       }

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

        private void onStartDateChangedAsync(object sender, Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventArgs e)
        {
            tabPageAdvResults.ImageIndex = 1;
            if (!backgroundWorkerAllRows.IsBusy)
                backgroundWorkerAllRows.RunWorkerAsync();
            sfDateTimeStop.MinDateTime = (DateTime)sfDateTimeStart.Value;
            sfDateTimeStop.Enabled = true;
        }

            private void AllRowsProcess(object sender, DoWorkEventArgs e)
        {
            DataTable result = AppDataSet.Tables[2];
            int nb = 0;
            int allRowsCount = AppDataSet.Tables["Effectif"].Rows.Count;

            result.Clear();
            sfDataGridResult.Invoke(new Action(() => sfDataGridResult.ShowBusyIndicator = true));

            foreach (DataRow persRow in AppDataSet.Tables["Effectif"].Rows)
            {
                DataRow row = result.NewRow();
                nb += 100;
                row = rowProcess(persRow);
                if (row[1].ToString() != "OK") result.Rows.Add(row);
                //                backgroundWorkerAllRows.ReportProgress(result.Rows.Count);
                backgroundWorkerAllRows.ReportProgress(nb/allRowsCount);

            }
            sfDataGridResult.Invoke(new Action(() => sfDataGridResult.ShowBusyIndicator = false));
        }
        private void onStopDateChangedAsync(object sender, Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventArgs e)
        {
            sfDataGridResult.ShowBusyIndicator = true;
            tabPageAdvResults.ImageIndex = 1;
            if (!backgroundWorkerAllRows.IsBusy)
                backgroundWorkerAllRows.RunWorkerAsync();
        }

        private void onWorkerComplete(object sender, RunWorkerCompletedEventArgs e)
        {
//            sfDataGridResult.ShowBusyIndicator = false;
            tabPageAdvResults.ImageIndex = 0;
            sfDataGridResult.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.AllCells;
        }

        private void toolStripBtnRefresh_Click(object sender, EventArgs e)
        {
            //tabPageAdvResults.ImageIndex = 1;
            //if (!backgroundWorkerAllRows.IsBusy)
            //    backgroundWorkerAllRows.RunWorkerAsync();
        }

        private void onWorkerProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //sfDataGridResult.Invoke(new Action(() => sfDataGridResult.ShowBusyIndicator = true));
            progressBarAdvAnalyse.Invoke(new Action(() => progressBarAdvAnalyse.Value = e.ProgressPercentage));
            //progressBarAdvAnalyse.Value = e.ProgressPercentage;
            tabPageAdvResults.ImageIndex = 1;
        }

    }
}

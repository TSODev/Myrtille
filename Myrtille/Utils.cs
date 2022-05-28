using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using System.IO;
using System.Data;
using System.Windows.Forms;

namespace Myrtille
{

    public class Effectif
    {
//        public Principal_Form principal;
        public List<Personne> EffectifList = new List<Personne>();



        private DataTable MakeEffectifTable(List<Personne> people, List<string> columnNames, List<Type> columnTypes)
        {
        DataTable EffectifDataTable = new DataTable("Effectif");
        DataColumn column;
        DataRow row;

            EffectifDataTable.TableName = "Effectif";
            for (int i = 0; i < columnNames.Count; i++)
            {
                column = new DataColumn();
                column.ColumnName = i.ToString() + "-" + columnNames[i];
                column.DataType = columnTypes[i];
                EffectifDataTable.Columns.Add(column);  
            }
            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = EffectifDataTable.Columns["1-Matricule"];
            EffectifDataTable.PrimaryKey = PrimaryKeyColumns;

            for (int r = 0; r < people.Count; r++)
            {
                row = EffectifDataTable.NewRow();
                row[0] = people[r].Matricule;
                row[1] = people[r].Nom;
                row[2] = people[r].Prenom;
                row[3] = people[r].Anciennete_GRP;
                row[4] = people[r].Anciennete_PA;
                row[5] = people[r].Anciennete_SOC;
                row[6] = people[r].Periode_Fin;
                row[7] = people[r].Societe;
                row[8] = people[r].Etablissement;
                row[9] = people[r].Unite_Org;
                row[10] = people[r].Gestionnaire;
                row[11] = people[r].Forfait_Jour;
                row[12] = people[r].Forfait_Heure;
                row[13] = people[r].Heure_Par_Semaine;
                row[14] = people[r].Modalité;
                row[15] = people[r].Paye_tps_plein;
                row[16] = people[r].Presence_tps_plein;
                row[17] = people[r].Qualif_code;
                row[18] = people[r].Qualif_Desc;
                row[19] = people[r].Classification;
                row[20] = people[r].Motif;
                row[21] = people[r].Code_att;
                row[22] = people[r].Libelle_att;
                EffectifDataTable.Rows.Add(row);   
            }

            return EffectifDataTable;
        }

        //public async Task ProcessReadAsync(string filePath)
        //{
        //    try
        //    {
        //        if (File.Exists(filePath) != false)
        //        {
        //            List<byte> text = await ReadByteArrayAsync(filePath);
        //            Console.WriteLine(text);
        //        }
        //        else
        //        {
        //            Console.WriteLine($"file not found: {filePath}");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}

        async Task<List<byte>> ReadByteArrayAsync(string filePath)
        {
            var sourceStream =
                new FileStream(
                    filePath,
                    FileMode.Open, FileAccess.Read, FileShare.Read,
                    bufferSize: 4096, useAsync: true);

//            var sb = new StringBuilder();

            byte[] buffer = new byte[0x1000];
            List<byte> bufferedStream = new List<byte>();
            int numRead;
            while ((numRead = await sourceStream.ReadAsync(buffer, 0, buffer.Length)) != 0)
            {
                bufferedStream.AddRange(buffer);
            }

            return bufferedStream;
        }

        public async Task<ExcelPackage> LoadExcelFromFile(string filePath)
        {
            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            //           Byte[] buffer = File.ReadAllBytes(filePath);
            List<byte> buffer = await ReadByteArrayAsync(filePath);

            MemoryStream stream = new MemoryStream();
            foreach (byte b in buffer)
            {
                stream.WriteByte((byte)b);
            }
            ExcelPackage excelPackage = new ExcelPackage(stream);

            buffer = null;
            stream = null;

            return excelPackage;
         }

        public DataTable createTableFromExcel(ExcelPackage excelPackage)
        { 
            ExcelWorksheets worksheets = excelPackage.Workbook.Worksheets;
            List<string> columnNames = new List<string>();
            List<Type> columnTypes = new List<Type>();
            if (worksheets.Count != 1)
            { throw new ArgumentException("Le fichier excel Effectif ne doit comporter qu'un seul classeur "); } 
            else 
            {
                ExcelWorksheet worksheet = worksheets[0];
                ExcelColumnCollection columns = worksheet.Columns;
                ExcelRowsCollection rows = worksheet.Rows;


                for (int j = worksheet.Dimension.Start.Column; j <= worksheet.Dimension.End.Column; j++)
                {
                   columnNames.Add(worksheet.Cells[1, j].Value.ToString());
                   columnTypes.Add(worksheet.Cells[1, j].Value.GetType());
                }

                //loop all rows
                for (int i = worksheet.Dimension.Start.Row+1; i <= worksheet.Dimension.End.Row; i++)
                {
                    //loop all columns in a row
                    List<string> attributes = new List<String>();
                    for (int j = worksheet.Dimension.Start.Column; j <= worksheet.Dimension.End.Column; j++)
                    {

                        //add the cell data to the List
                        if (worksheet.Cells[i, j].Value != null)
                        {
                            attributes.Add(worksheet.Cells[i, j].Value.ToString());
                        }
                    }
                    Personne personne = new Personne();
                   
                    personne = personne.createPersonFromExcelCells(attributes);
                    EffectifList.Add(personne);
 
                }

            }
            Console.WriteLine("Effectif de : " + EffectifList.Count + " personnes");
            excelPackage = null;
            DataTable EffectifTable = MakeEffectifTable(EffectifList, columnNames, columnTypes);
            return EffectifTable;
        }
    
    }

    public class Absences
    {
//        public Principal_Form principal;
        public List<Absence> AbsencesList = new List<Absence>();



        private DataTable MakeAbsencesTable(List<Absence> absences, List<string> columnNames, List<Type> columnTypes)
        {
            DataTable AbsencesDataTable = new DataTable("Absences");
            DataColumn column;
            DataRow row;

            AbsencesDataTable.TableName = "Absences";
            for (int i = 0; i < columnNames.Count; i++)
            {
                column = new DataColumn();
                column.ColumnName = i.ToString() + "-" + columnNames[i];
                column.DataType = columnTypes[i];
                AbsencesDataTable.Columns.Add(column);
            }
            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = AbsencesDataTable.Columns["1-TGI"];
            AbsencesDataTable.PrimaryKey = PrimaryKeyColumns;

            for (int r = 0; r < absences.Count; r++)
            {
                row = AbsencesDataTable.NewRow();
                row[0] = absences[r].TGI;
                row[1] = absences[r].Nom;
                row[2] = absences[r].Prenom;
                row[3] = absences[r].NR;
                row[4] = absences[r].Pos_Activite;
                row[5] = absences[r].Lib_Pos_Activite;
                row[6] = absences[r].Regime_Paye;
                row[7] = absences[r].Lib_Regime_Paye;
                row[8] = absences[r].Tem_Temps_Partiel;
                row[9] = absences[r].Etp_Travaille;
                row[10] = absences[r].Etp_Paye;
                row[11] = absences[r].Societe;
                row[12] = absences[r].Lib_Societe;
                row[13] = absences[r].Etablissement;
                row[14] = absences[r].Lib_Etablissement;
                row[15] = absences[r].Departement;
                row[16] = absences[r].Lib_Departement;
                row[17] = absences[r].Centre_De_Cout;
                row[18] = absences[r].Lib_Centre_de_Cout;
                row[19] = absences[r].Resp_TGI;
                row[20] = absences[r].Resp_Nom;
                row[21] = absences[r].Resp_Prenom;
                row[22] = absences[r].Gest_TGI;
                row[23] = absences[r].Gest_Nom;
                row[24] = absences[r].Gest_Prenom;
                row[25] = absences[r].Motif_Absence;
                row[26] = absences[r].Lib_Motif_Absence;
                row[27] = absences[r].Debut_Absence;
                row[28] = absences[r].Fin_Absence;
                row[29] = absences[r].Tem_Absence_Matin;
                row[30] = absences[r].Tem_Absence_Apres_Midi;
                row[31] = absences[r].Tem_Absence_Paye;
                row[32] = absences[r].Tem_Absence_RTT;

                AbsencesDataTable.Rows.Add(row);
            }

            return AbsencesDataTable;
        }

        async Task<List<byte>> ReadByteArrayAsync(string filePath)
        {
            var sourceStream =
                new FileStream(
                    filePath,
                    FileMode.Open, FileAccess.Read, FileShare.Read,
                    bufferSize: 4096, useAsync: true);

            //            var sb = new StringBuilder();

            byte[] buffer = new byte[0x1000];
            List<byte> bufferedStream = new List<byte>();
            int numRead;
            while ((numRead = await sourceStream.ReadAsync(buffer, 0, buffer.Length)) != 0)
            {
                bufferedStream.AddRange(buffer);
            }

            return bufferedStream;
        }
        public async Task<ExcelPackage> LoadExcelFromFile(string filePath)
        {
            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            //           Byte[] buffer = File.ReadAllBytes(filePath);
            List<byte> buffer = await ReadByteArrayAsync(filePath);

            MemoryStream stream = new MemoryStream();
            foreach (byte b in buffer)
            {
                stream.WriteByte((byte)b);
            }
            ExcelPackage excelPackage = new ExcelPackage(stream);

            buffer = null;
            stream = null;

            return excelPackage;
        }

        public DataTable createTableFromExcel(ExcelPackage excelPackage)
        {


            ExcelWorksheets worksheets = excelPackage.Workbook.Worksheets;
            List<string> columnNames = new List<string>();
            List<Type> columnTypes = new List<Type>();
            if (worksheets.Count != 1)
            { throw new ArgumentException("Le fichier excel Absences ne doit comporter qu'un seul classeur "); }
            else
            {
                ExcelWorksheet worksheet = worksheets[0];
                ExcelColumnCollection columns = worksheet.Columns;
                ExcelRowsCollection rows = worksheet.Rows;


                for (int j = worksheet.Dimension.Start.Column; j <= worksheet.Dimension.End.Column; j++)
                {
                    columnNames.Add(worksheet.Cells[1, j].Value.ToString());
                    columnTypes.Add(worksheet.Cells[1, j].Value.GetType());
                }

//                Console.WriteLine(columns.EndColumn);
//                Console.WriteLine(rows.EndRow);

                //                principal.progressBarMaxInit = rows.EndRow;
                //                principal.progressBarValue = 0;
                //                principal.startBackgroudWorker();

                //loop all rows
                for (int i = worksheet.Dimension.Start.Row + 1; i <= worksheet.Dimension.End.Row; i++)
                {
                    //                   if (i % 10 == 0 ) 
                    //                   {
                    //                        principal.progressBarValue += 10;
                    //                        principal.progressBarRefresh();
                    //                        principal.ReportProgess((100 * i) / rows.EndRow);
                    //                    }
                    //loop all columns in a row
                    List<string> attributes = new List<String>();
                    for (int j = worksheet.Dimension.Start.Column; j <= worksheet.Dimension.End.Column; j++)
                    {

                        //add the cell data to the List
                        if (worksheet.Cells[i, j].Value != null)
                        {
                            attributes.Add(worksheet.Cells[i, j].Value.ToString());
                            Console.Write(worksheet.Cells[i, j].Value.ToString(), i , j);
                        }
                        else
                        {
                            attributes.Add(null);
                        }
                    }
                    Absence absence = new Absence();

                    absence = absence.createAbsencesFromExcelCells(attributes);
                    AbsencesList.Add(absence);

                }
                //                principal.progressBarValue = 0;

            }
//            Console.WriteLine("Absences de : " + AbsencesList.Count + " absences");
            excelPackage = null;
            DataTable AbsencesTable = MakeAbsencesTable(AbsencesList, columnNames, columnTypes);
            return AbsencesTable;
        }

    }

}

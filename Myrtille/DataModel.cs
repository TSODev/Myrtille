using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using OfficeOpenXml;
using System.Globalization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Myrtille
{
    public class Personne
    {
        private string _matricule;
        private string _nom;
        private string _prenom;
        private DateTime _anciennete_GRP;
        private DateTime _anciennete_PA;
        private DateTime _anciennete_SOC;
        private DateTime _periode_fin;
        private String _societe;
        private String _etablissement;
        private String _unite_org;
        private String _gestionaire;
        private int _forfait_jour;
        private decimal _forfait_heure;
        private decimal _heure_par_semaine;
        private string _modalité;
        private decimal _paye_tps_plein;
        private decimal _presence_tps_plein;
        private string _qualif_code;
        private string _qualif_desc;
        private string _classification;
        private string _motif;
        private string _code_att;
        private string _libelle_att;

        public Personne createPersonFromExcelCells(List<string> values)
        {
            CultureInfo culture = CultureInfo.CreateSpecificCulture("fr-FR");
            DateTimeStyles styles = DateTimeStyles.None;
            this._matricule = values[0];
            this._nom = values[1];
            this._prenom = values[2];
            if (values[3] != "") this._anciennete_GRP = DateTime.Parse(values[3],culture,styles);
            if (values[4] != "") this._anciennete_PA = DateTime.Parse(values[4], culture, styles);
            if (values[5] != "") this._anciennete_SOC = DateTime.Parse(values[5], culture, styles);   
 //           this._periode_fin = DateTime.Parse(values[6], culture, styles);
            this._societe = values[7];
            this._etablissement = values[8];
            this._unite_org = values[9];
            this._gestionaire = values[10];
            if (values[11] != null) this._forfait_jour = Int16.Parse(values[11]);
            this._forfait_heure = System.Convert.ToDecimal(values[12]);
            this._heure_par_semaine = System.Convert.ToDecimal(values[13]);
            this._modalité = values[14];
            this._paye_tps_plein = System.Convert.ToDecimal(values[15]);
            this._presence_tps_plein = System.Convert.ToDecimal(values[16]);
            this._qualif_code = values[17];
            this._qualif_desc = values[18];
            this._classification = values[19];
            this._motif = values[20];
            this._code_att = values[21];
            this._libelle_att = values[22];




            return this;
        }

        public string Matricule
        {
            get
            {
                return _matricule;
            }
            set
            {
                _matricule = value;
            }
        }

        // Navigation property that returns a collection of Absences.

        public string Nom
        {
            get
            {
                return _nom;
            }
            set
            {
                _nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return _prenom;
            }
            set
            {
                _prenom = value;
            }
        }

        public System.DateTime Anciennete_GRP
        {
            get { return _anciennete_GRP; }
            set {  _anciennete_GRP = value;}
        }

        public System.DateTime Anciennete_PA
        {
            get { return _anciennete_PA; }
            set { _anciennete_PA = value; }
        }

        public System.DateTime Anciennete_SOC
        {
            get { return _anciennete_SOC; }
            set { _anciennete_SOC = value; }
        }

        public System.DateTime Periode_Fin
        {
            get { return _periode_fin; }
            set { _periode_fin = value; }
        }

        public string Societe
        {
            get { return _societe; }
            set { _societe = value; }
        }

        public string Etablissement
        {
            get { return _etablissement; }
            set { _etablissement = value; }
        }

        public string Unite_Org
        {
            get { return _unite_org; }
            set { _unite_org = value; }
        }


        public string Gestionnaire
        {
            get { return _gestionaire; }
            set { _gestionaire = value; }
        }

        public int Forfait_Jour
        {
            get { return _forfait_jour; }
            set { _forfait_jour = value; }
        }

        public decimal Forfait_Heure
        {
            get { return _forfait_heure; }
            set { _forfait_heure = value; }
        }

        public decimal Heure_Par_Semaine
        {
            get { return _heure_par_semaine; }
            set { _heure_par_semaine = value; }
        }

        public string Modalité
        {
            get { return _modalité; }
            set { _modalité = value; }
        }

        public decimal Paye_tps_plein
        {
            get { return _paye_tps_plein; }
            set { _paye_tps_plein = value; }
        }

        public decimal Presence_tps_plein
        {
            get { return _presence_tps_plein; }
            set { _presence_tps_plein = value; }
        }

        public string Qualif_code
        {
            get { return _qualif_code; }
            set { _qualif_code = value; }
        }

        public string Qualif_Desc
        {
            get { return _qualif_desc; }
            set { _qualif_desc = value; }
        }

        public string Classification
        {
            get { return _classification; }
            set { _classification = value; }
        }

        public string Motif
        {
            get { return _motif; }
            set { _motif = value; }
        }

        public string Code_att
        {
            get { return _code_att; }
            set { _code_att = value; }
        }
        public string Libelle_att
        {
            get { return _libelle_att; }
            set { _libelle_att = value; }
        }
    }

    public class Absence
    {
        // Define private property variables.
        private string _tgi;
        private string _nom;
        private string _prenom;
        private int _nr;
        private string _pos_activite;
        private string _lib_pos_activite;
        private string _regime_paye;
        private string _lib_regime_paye;
        private string _tem_temps_partiel;
        private int _etp_travaille;
        private int _etp_paye;
        private int _societe;
        private string _lib_societe;
        private string _etablissement;
        private string _lib_etablissement;
        private int _departement;
        private string _lib_departement;
        private int _centre_de_cout;
        private string _lib_centre_de_cout;
        private string _resp_tgi;
        private string _resp_nom;
        private string _resp_prenom;
        private string _gest_tgi;
        private string _gest_nom;
        private string _gest_prenom;
        private string _motif_abs;
        private string _lib_motif_abs;
        private DateTime _debut_abs;
        private DateTime _fin_abs;
        private string _tem_abs_matin;
        private string _tem_abs_apres_midi;
        private string _tem_abs_paye;
        private string _tem_abs_rtt;                        // Boolean ?

        public Absence createAbsencesFromExcelCells(List<string> values)
        {
            CultureInfo culture = CultureInfo.CreateSpecificCulture("fr-FR");
            DateTimeStyles styles = DateTimeStyles.None;
            this._tgi = values[0];
            this._nom = values[1];
            this._prenom = values[2];
            this._nr = Int16.Parse(values[3]);
            this._pos_activite = values[4];
            this._lib_pos_activite = values[5];
            this._regime_paye = values[6];
            this._lib_regime_paye = values[7];
            this._tem_temps_partiel = values[8];
            if (values[9] != null) this._etp_travaille = Int16.Parse(values[9]);
            if (values[10] != null) this._etp_paye = Int16.Parse(values[10]);
            if (values[11] != null) this._societe = Int16.Parse(values[11]);
            this._lib_societe = values[12];
            this._etablissement = values[13];
            this._lib_etablissement = values[14];
            if (values[15] != null) this._departement = Int16.Parse(values[15]);
            this._lib_departement = values[16];
            if (values[17] != null) this._centre_de_cout = Int16.Parse(values[17]);
            this._lib_centre_de_cout = values[18];
            this._resp_tgi = values[19];
            this._resp_nom = values[20];
            this._resp_prenom = values[21];
            this._gest_tgi = values[22];
            this._gest_nom = values[23];
            this._gest_prenom = values[24];
            this._motif_abs = values[25];
            this._lib_motif_abs = values[26];

            if (values[27] != "") this._debut_abs = DateTime.Parse(values[27], culture, styles);
            if (values[28] != "") this._fin_abs = DateTime.Parse(values[28], culture, styles);

            this._tem_abs_matin = values[29];
            this._tem_abs_apres_midi = values[30];
            this._tem_abs_paye = values[31];
            this._tem_abs_rtt = values[32];

            return this;
        }


        public string TGI
        {
            get
            {
                return _tgi;
            }
            set
            {
                _tgi = value;
            }
        }

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public string Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }

        public int NR
        {
            get { return _nr; }
            set { _nr = value; }
        }

        public string Pos_Activite
        {
            get { return _pos_activite; }
            set { _pos_activite = value; }
        }

        public string Lib_Pos_Activite
        {
            get { return _lib_pos_activite; }
            set { _lib_pos_activite = value; }
        }

        public string Regime_Paye
        {
            get { return _regime_paye; }
            set { _regime_paye = value; }
        }

        public string Lib_Regime_Paye
        {
            get { return _lib_regime_paye; }
            set { _lib_regime_paye = value; }
        }

        public string Tem_Temps_Partiel
        {
            get { return _tem_temps_partiel; }
            set { _tem_temps_partiel = value; }
        }
        public int Etp_Travaille
        {
            get { return _etp_travaille; }
            set { _etp_travaille = value; }
        }

        public int Etp_Paye
        {
            get { return _etp_paye; }
            set { _etp_paye = value; }
        }

        public int Societe
        {
            get { return _societe; }
            set { _societe = value; }
        }

        public string Lib_Societe
        {
            get { return _lib_societe; }
            set { _lib_societe = value; }
        }


        public string Etablissement
        {
            get { return _etablissement; }
            set { _etablissement = value; }
        }

        public string Lib_Etablissement
        {
            get { return _lib_etablissement; }
            set { _lib_etablissement = value; }
        }

        public int Departement
        {
            get { return _departement; }
            set { _departement = value; }
        }
        public string Lib_Departement
        {
            get { return _lib_departement; }
            set { _lib_departement = value; }
        }

        public int Centre_De_Cout
        {
            get { return _centre_de_cout; }
            set { _centre_de_cout = value; }
        }

        public string Lib_Centre_de_Cout
        {
            get { return _lib_centre_de_cout; }
            set { _lib_centre_de_cout = value; }
        }

        public string Resp_TGI
        {
            get { return _resp_tgi; }
            set { _resp_tgi = value; }
        }

        public string Resp_Nom
        {
            get { return _resp_nom; }
            set { _resp_nom = value; }
        }

        public string Resp_Prenom
        {
            get { return _resp_prenom; }
            set { _resp_prenom = value; }
        }


        public string Gest_TGI
        {
            get { return _gest_tgi; }
            set { _gest_tgi = value; }
        }

        public string Gest_Nom
        {
            get { return _gest_nom; }
            set { _gest_nom = value; }
        }


        public string Gest_Prenom
        {
            get { return _gest_prenom; }
            set { _gest_prenom = value; }
        }

        public string Motif_Absence
        {
            get { return _motif_abs; }
            set { _motif_abs = value; }
        }

        public string Lib_Motif_Absence
        {
            get { return _lib_motif_abs; }
            set { _lib_motif_abs = value; }
        }


        public DateTime Debut_Absence
        {
            get { return _debut_abs; }
            set { _debut_abs = value; }
        }


        public DateTime Fin_Absence
        {
            get { return _fin_abs; }
            set { _fin_abs = value; }
        }

        public string Tem_Absence_Matin
        {
            get { return _tem_abs_matin; }
            set { _tem_abs_matin = value; }
        }

        public string Tem_Absence_Apres_Midi
        {
            get { return _tem_abs_apres_midi; }
            set { _tem_abs_apres_midi = value; }
        }

        public string Tem_Absence_Paye
        {
            get { return _tem_abs_paye; }
            set { _tem_abs_paye = value; }
        }

        public string Tem_Absence_RTT
        {
            get { return _tem_abs_rtt; }
            set { _tem_abs_rtt = value; }
        }

    }

    public class AbsenceForPerson : IDataErrorInfo
    {
        private int _nbMatches;
        private string _errorMessage;
        private string _tgi;
        private string _lastname;
        private string _firstname;
        private string _motif;
        private DateTime? _debut;
        private DateTime? _fin;



        public AbsenceForPerson createAbsenceForPerson(int nb, DataRow row) 
        {
            CultureInfo culture = CultureInfo.CreateSpecificCulture("fr-FR");
            DateTimeStyles styles = DateTimeStyles.None;
            AbsenceForPerson absenceForPerson = new AbsenceForPerson();
            absenceForPerson._nbMatches = nb;
            absenceForPerson.TGI = row.ItemArray[0].ToString();
            absenceForPerson.LastName = row.ItemArray[1].ToString();
            absenceForPerson.FirstName = row.ItemArray[2].ToString();
            if (nb > 0)
            {
                absenceForPerson.Motif = row.ItemArray[25].ToString();
                if (row.ItemArray[27] != null) absenceForPerson.Debut_Absence = DateTime.Parse((string)row.ItemArray[27], culture,styles);
                if (row.ItemArray[28] != null) absenceForPerson.Fin_Absence = DateTime.Parse((string)row.ItemArray[28], culture,styles);
            }
            else
            {
                absenceForPerson.ErrorMessage = "PAS D ABSENCE";
            }

            return absenceForPerson;
        }

        //       private int nbMatches;

        //       public event PropertyChangedEventHandler PropertyChanged;

        public string this[string columnName]
        {
            get
            {
                if (columnName == "NB" && this.NbMatches == 0)
                    return "cette personne n'a pas d'absence enregistrée";

                return string.Empty;
            }
        }
        public int NbMatches
        {
            get { return _nbMatches; }
            set { _nbMatches = value; }
        }

        public string ErrorMessage
        {
            get { return _errorMessage; }
            set { _errorMessage = value; }
        }
        public string TGI
        {
            get { return _tgi; }
            set { _tgi = value; }
        }

        public string LastName
        {
            get { return _lastname; }
            set { _lastname = value; }
        }

        public string FirstName
        {
            get { return _firstname; }
            set { _firstname = value; }
        }

        public string Motif
        {
            get { return _motif; }
            set { _motif = value; }
        }

        public DateTime? Debut_Absence
        {
            get { return _debut; }
            set { _debut = value; }
        }

        public DateTime? Fin_Absence
        {
            get { return _fin; }
            set { _fin = value; }
        }

        public string Error => throw new NotImplementedException();

 //       public string this[string columnName] => throw new NotImplementedException();
    }

}

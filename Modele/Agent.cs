using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormationSNCF.Modele
{
    [Serializable]
    /// <summary>
    /// Classe métier : représente un agent de l'entreprise
    /// </summary>
    public class Agent
    {
        private int _numero;
        private string _civilite;
        private string _prenom;
        private string _nom;
        private string _adresse1;
        private string _adresse2;
        private string _codePostal;
        private string _ville;
        private DateTime _dateNaissance;
        private DateTime _dateEmbauche;
        private Lieu _lieuDeTravaille;

        /// <summary>
        /// Obtient le numero de l'agent
        /// </summary>
        public int Numero
        {
            get { return _numero; }
        }
        /// <summary>
        /// Obtient ou définit la civilité de l'agent
        /// </summary>
        public string Civilite
        {
            get { return _civilite; }
            set { _civilite = value; }
        }
        /// <summary>
        /// Obtient le prénom de l'agent
        /// </summary>
        public string Prenom
        {
            get { return _prenom; }
        }
        /// <summary>
        /// Obtient le nom de l'agent
        /// </summary>
        public string Nom
        {
            get { return _nom; }
        }
        /// <summary>
        /// Obtient ou définit l'adresse de résidence de l'agent
        /// </summary>
        public string Adresse1
        {
            set { _adresse1 = value; }
            get { return _adresse1; }
        }
        /// <summary>
        /// Obtient ou définit le complément d'adresse de résidence de l'agent
        /// </summary>
        public string Adresse2
        {
            set { _adresse2 = value; }
            get { return _adresse2; }
        }
        /// <summary>
        /// Obtient ou définit le code postal de résidence de l'agent
        /// </summary>
        public string CodePostal
        {
            set { _codePostal = value; }
            get { return _codePostal; }
        }
        /// <summary>
        /// Obtient ou définit la ville de résidence de l'agent
        /// </summary>
        public string Ville
        {
            set { _ville = value; }
            get { return _ville; }
        }
        /// <summary>
        /// Obtient ou définit la date de naissance de l'agent
        /// </summary>
        public DateTime DateNaissance
        {
            set { _dateNaissance = value; }
            get { return _dateNaissance; }
        }
        /// <summary>
        /// Obtient ou définit la date d'embauche de l'agent dans l'entreprise
        /// </summary>
        public DateTime DateEmbauche
        {
            get { return _dateEmbauche; }
            set { _dateEmbauche = value; }
        }
        /// <summary>
        /// Obtient ou définit le lieu de résidence de l'agent
        /// </summary>
        public Lieu LieuDeTravaille
        {
            get { return _lieuDeTravaille; }
            set { _lieuDeTravaille = value; }
        }

        /// <summary>
        /// Initialise un nouvel Agent SNCF
        /// </summary>
        /// <param name="numero">Le code de l'agent</param>
        /// <param name="civilite">La civilité de l'agent</param>
        /// <param name="prenom">Le prénom de l'agent</param>
        /// <param name="nom">Le nom de l'agent</param>
        /// <param name="adresse1">L'adresse de résidence de l'agent</param>
        /// <param name="adresse2">Le complément d'adresse de résidence de l'agent</param>
        /// <param name="codePostal">Le code postal de résidence de l'agent</param>
        /// <param name="ville">La ville de résidence de l'agent</param>
        /// <param name="dateNaissance">La date de naissance de l'agent</param>
        /// <param name="dateEmbauche">La date d'embauche de l'agent dans l'entreprise</param>
        public Agent(int numero, string civilite, string prenom, string nom, string adresse1, string adresse2, string codePostal, string ville, DateTime dateNaissance, DateTime dateEmbauche)
        {
            _numero = numero;
            _civilite = civilite;
            _prenom = prenom;
            _nom = nom;
            _adresse1 = adresse1;
            _adresse2 = adresse2;
            _codePostal = codePostal;
            _ville = ville;
            _dateNaissance = dateNaissance;
            _dateEmbauche = dateEmbauche;
        }

        /// <summary>
        /// Initialise un nouvel Agent SNCF
        /// </summary>
        /// <param name="numero">Le code de l'agent</param>
        /// <param name="civilite">La civilité de l'agent</param>
        /// <param name="prenom">Le prénom de l'agent</param>
        /// <param name="nom">Le nom de l'agent</param>
        public Agent(int numero, string civilite, string prenom, string nom)
        {
            _numero = numero;
            _civilite = civilite;
            _prenom = prenom;
            _nom = nom;
        }

        /// <summary>
        /// Compare deux agents à partir de leur numero, nom et prénom
        /// </summary>
        /// <param name="unAgent">Un agent à comparer</param>
        /// <returns>Vrai si il s'agit du même code agent, faux dans le cas contraire</returns>
        public override bool Equals(object unAgent)
        {
            bool memeInfoAgent = false;
            Agent a = unAgent as Agent;
            if (a != null)
            {
                if (_numero == a._numero && _nom == a._nom && _prenom == a.Prenom)
                    memeInfoAgent = true;
            }
            return memeInfoAgent;
        }

        /// <summary>
        /// Sert de fonction de hachage pour un type particulier
        /// </summary>
        /// <returns>Une clé de hachage</returns>
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        /// <summary>
        /// retourne le nom et le présnom de l'agent.
        /// </summary>
        /// <returns>L'agent SNCF</returns>
        public override string ToString()
        {
            return string.Format("{0} {1}", _prenom, _nom);
        }

        

    }
}

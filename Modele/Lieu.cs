using System;
using System.Collections.Generic;
using FormationSNCF.Ressources;


namespace FormationSNCF.Modele
{
    [Serializable]
    /// <summary>
    /// Représente un lieu de formation ou un lieu de travail
    /// </summary>
    public class Lieu
    {
        private int _numero;
        private string _libelle;
        private string _codePostal;
        private string _telephone;

        /// <summary>
        /// Obtient l'identifiant du lieu
        /// </summary>
        public int Numero
        {
            get { return _numero; }
        }
        /// <summary>
        /// Obtient le libelle du lieu
        /// </summary>
        public string LibelleLieu
        {
            get { return _libelle; }
        }
        /// <summary>
        /// Obtient le code postal du lieu
        /// </summary>
        public string CodePostal
        {
            get { return _codePostal; }
        }
        /// <summary>
        /// Obtient le numéro de téléphone de l'accueil du lieu de formation
        /// </summary>
        public string Telephone
        {
            get { return _telephone; }
        }

        /// <summary>
        /// Initialise un nouveau Lieu
        /// </summary>
        /// <param name="numero">un identifiant du lieu</param>
        /// <param name="libelle">un libelle du lieu</param>
        /// <param name="codePostal">Un code postal du lieu</param>
        /// <param name="telephone">Un numéro de téléphone</param>
        public Lieu(int numero, string libelle, string codePostal, string telephone)
        {
            _numero = numero;
            _libelle = libelle;
            _codePostal = codePostal;
            _telephone = telephone;
        }

        /// <summary>
        /// Compare deux lieu à partir de leur numero
        /// </summary>
        /// <param name="unLieu">Un lieu</param>
        /// <returns>Vrai si il s'agit du même numero, false dans le cas contraire</returns>
        public override bool Equals(object unLieu)
        {
            bool memeNumeroLieu = false;
            Lieu lieu = unLieu as Lieu;
            if (lieu != null)
            {
                if (lieu._numero == _numero)
                    memeNumeroLieu = true;
            }
            return memeNumeroLieu;
        }
        /// <summary>
        /// Sert de fonction de hachage pour un type particulier
        /// </summary>
        /// <returns>Une clé de hachage</returns>
        public override int GetHashCode()
        {
            return _numero;
        }
        /// <summary>
        /// retourne le numéro et le code postal du lieu
        /// </summary>
        /// <returns>Le numéro et le code postal du lieu</returns>
        public override string ToString()
        {
            return string.Format("{0} {1}", _libelle, _codePostal);
        }



    }
}

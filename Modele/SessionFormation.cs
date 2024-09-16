using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace FormationSNCF.Modele
{
    [Serializable]
    /// <summary>
    /// Classe métier : représente une session de formation
    /// </summary>
    public class SessionFormation
    {

        private int _numero;
        private byte _nombreMaxParticipant;
        private DateTime _dateSession;
        private decimal _coutPrevu;
        private Lieu _lieuDeFormation;
        private List<Agent> _inscrits;

        public List<Agent> Inscrits
        {
            get { return _inscrits; }
            set { _inscrits = value; }
        }


        /// <summary>
        /// Obtient le numéro de session de formation
        /// </summary>
        public int Numero
        {
            get { return _numero; }
        }
        /// <summary>
        /// Obtient ou définit le nombre maximum de participant
        /// </summary>
        public byte NombreMaxParticipant
        {
            get { return _nombreMaxParticipant; }
            set { _nombreMaxParticipant = value; }
        }
        /// <summary>
        /// Obtient ou définit la date de session de formation
        /// </summary>
        public DateTime DateSession
        {
            get { return _dateSession; }
            set { _dateSession = value; }
        }
        /// <summary>
        /// Obtient ou définit le coût prévu de la session de formation
        /// </summary>
        public decimal CoutPrevu
        {
            get { return _coutPrevu; }
            set { _coutPrevu = value; }
        }
             
       
        /// <summary>
        /// Obtient ou définit le lieu de la session de formation
        /// </summary>
        public Lieu LieuDeFormation
        {
            get { return _lieuDeFormation; }
            set { _lieuDeFormation = value; }
        }


        /// <summary>
        /// Initialise une nouvelle session de formation
        /// </summary>
        /// <param name="numero">Un numéro de session</param>
        /// <param name="nombreMaxParticipant">Le nombre de participant maximum à la session de formation</param>
        /// <param name="dateSession">La date de la session de formation</param>
        /// <param name="coutPrevu">Le coût prévu de la formation</param>
        public SessionFormation(int numero, byte nombreMaxParticipant, DateTime dateSession, Decimal coutPrevu)
        {
            _numero = numero;
            NombreMaxParticipant = nombreMaxParticipant;
            DateSession = dateSession;
            CoutPrevu = coutPrevu;           
            _inscrits = new List<Agent>();
        }

        /// <summary>
        /// Inscrit un agent à une session de formation
        /// </summary>
        /// <param name="unAgent">Un agent</param>
        public void Inscription(Agent unAgent)
        {
            if (!_inscrits.Contains(unAgent))
            {
                _inscrits.Add(unAgent);

            }
        }


        /// <summary>
        /// Vérifie si un agent est inscrit à la session de formation
        /// </summary>
        /// <param name="unAgent">Un agent</param>
        /// <returns>Vrai si l'agent est inscrit, Faux dans le cas contraire</returns>
        public bool ExisteInscription(Agent unAgent)
        {
            return _inscrits.Contains(unAgent);
        }

        /// <summary>
        /// Désinscrit un Agent d'une session de formation
        /// </summary>
        /// <param name="unAgent">L'agent à desinscrire</param>
        /// <returns>Vrai en cas de suppression, false dans le cas contraire</returns>
        public bool SupprimerInscription(Agent unAgent)
        {
            return _inscrits.Remove(unAgent);
        }

        /// <summary>
        /// Compare deux session de formation à partir de leur numero
        /// </summary>
        /// <param name="unLieu">Un lieu</param>
        /// <returns>Vrai si il s'agit du même numero, false dans le cas contraire</returns>
        public override bool Equals(object uneSessionDeFormation)
        {
            bool memeNumeroSessionDeFormation = false;
            SessionFormation sf = uneSessionDeFormation as SessionFormation;
            if (sf != null)
                if (sf._numero == _numero)
                    memeNumeroSessionDeFormation = true;
            return memeNumeroSessionDeFormation;
        }
        /// <summary>
        /// Sert de fonction de hachage pour un type particulier
        /// </summary>
        /// <returns>Une clé de hachage</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// retourne le numéro de session de formation
        /// </summary>
        /// <returns>le numéro de session de formation</returns>
        public override string ToString()
        {
            return string.Format("N° : {0} Le : {1} à : {2} ", _numero.ToString(), DateSession.ToShortDateString(), _lieuDeFormation);
        }

    }

}

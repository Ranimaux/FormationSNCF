using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.ObjectModel;

namespace FormationSNCF.Modele
{
    [Serializable]
    /// <summary>
    /// Classe métier : Représente une action de formation
    /// </summary>
    public class ActionFormation
    {
        private string _codeAction;
        private string _intitule;
        private decimal _cout;
        private int _duree;
        private DateTime _dateCreation;
        private List<SessionFormation> _lesSessionsDeFormation;

        /// <summary>
        /// Obtient la collection de session de formation de l'action de formation
        /// </summary>
        /// <remarks>La collection est en lecture seule</remarks>
        public ReadOnlyCollection<SessionFormation> SessionsFormation
        {
            get
            {
                return new ReadOnlyCollection<SessionFormation>(_lesSessionsDeFormation);
            }
            
        }

        /// <summary>
        /// Obtient le code de l'action de formation
        /// </summary>
        public string CodeAction
        {
            get { return _codeAction; }
        }
        /// <summary>
        /// Obtient l'intitulé de l'action de formation
        /// </summary>
        public string Intitule
        {
            get { return _intitule; }
        }
        /// <summary>
        /// Obtient ou définit le coût de l'action de formation
        /// </summary>
        public decimal Cout
        {
            get { return _cout; }
            set { _cout = value; }
        }
        /// <summary>
        /// Obtient ou définit la durée de l'action de formation
        /// </summary>
        public int Duree
        {
            get { return _duree; }
            set { _duree = value; }
        }
        /// <summary>
        /// Obtient ou définit la date de création de l'action de formation
        /// </summary>
        public DateTime DateCreation
        {
            get { return _dateCreation; }
            set { _dateCreation = value; }
        }

        /// <summary>
        /// Initialise une action de formation
        /// </summary>
        /// <param name="codeAction">Le code de l'action de formation</param>
        /// <param name="intitule">L'intitulé de l'action de formation</param>
        /// <param name="cout">Le coût de l'action de formation</param>
        /// <param name="duree">La durée de l'action de formation</param>
        /// <param name="date">La date de l'action de formation</param>
        public ActionFormation(string codeAction, string intitule, decimal cout, int duree, DateTime date)
        {
            _codeAction = codeAction;
            _intitule = intitule;
            _cout = cout;
            _duree = duree;
            _dateCreation = date;
            _lesSessionsDeFormation = new List<SessionFormation>();
        }

        /// <summary>
        /// Initialise une session de formation pour cette action.
        /// </summary>
        /// <remarks>Cette session de formation est ajouté à la collection "lesSessionsDeFormation"</remarks>
        /// <param name="numero"></param>
        /// <param name="nombreMaxParticipant"></param>
        /// <param name="dateSession"></param>
        /// <param name="coutPrevu"></param>
        public void AjouterSessionDeFormation(int numero, byte nombreMaxParticipant, DateTime dateSession, Decimal coutPrevu)
        {
            SessionFormation sf = new SessionFormation(numero, nombreMaxParticipant, dateSession, coutPrevu);
            _lesSessionsDeFormation.Add(sf);
        }

        /// <summary>
        /// Supprime une session de formation
        /// </summary>
        /// <param name="numero">numéro de session de formation</param>
        /// <returns>retourne true en cas de succès, false dans le cas contraire</returns>
        public bool SupprimerSessionDeFormation(int numero)
        {
            return _lesSessionsDeFormation.Remove(ObtenirSessionFormation(numero));
        }

        /// <summary>
        /// Retourne une session de formation de l'action de formation 
        /// </summary>
        /// <param name="numeroSessionFormation">Le numéro de session de formation</param>
        /// <returns>La session de formation, null si le numéro de session n'est pas référencé</returns>
        public SessionFormation ObtenirSessionFormation(int numeroSessionFormation)
        {
            SessionFormation sessionFormation = null;
            foreach (SessionFormation sfCourante in _lesSessionsDeFormation)
            {
                if (sfCourante.Numero == numeroSessionFormation)
                {
                    sessionFormation = sfCourante;
                    break;
                }
            }
            return sessionFormation;            
        }

        /// <summary>
        /// Compare deux actions de formation à partir de leur code
        /// </summary>
        /// <param name="actionDeFormation">Une action de formation</param>
        /// <returns>Vrai si il s'agit de la même action de formation, Faux dans le cas contraire</returns>
        public override bool Equals(object actionDeFormation)
        {
            bool memeActionDeFormation = false;
            ActionFormation af = actionDeFormation as ActionFormation;
            if (af != null)
            {
                if (af._codeAction == _codeAction)
                {
                    memeActionDeFormation = true;
                }
            }
            return memeActionDeFormation;
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
        /// Retourne l'intitulé de l'action de formation
        /// </summary>
        /// <returns>L'intitulé de l'action de formation</returns>
        public override string ToString()
        {
            return _intitule;
        }
    }


}

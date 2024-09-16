using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace FormationSNCF.Modele
{
    [Serializable]
    /// <summary>
    /// Classe métier : représente une activité
    /// </summary>
    public class Activite
    {
        private string _libelleActivite;
        private List<ActionFormation> _lesActionsFormation;

        /// <summary>
        /// Obtient le libellé de l'activité
        /// </summary>
        public string LibelleActivite
        {
            get { return _libelleActivite; }
        }

        /// <summary>
        /// Obtient la collection d'action de formation de l'activité
        /// </summary>
        public ReadOnlyCollection<ActionFormation> LesActionsFormation
        {
            get => new ReadOnlyCollection<ActionFormation>(_lesActionsFormation);
        }

        /// <summary>
        /// Initialise une activité
        /// </summary>
        /// <param name="libelleActivite"></param>
        public Activite(string libelleActivite)
        {
            _libelleActivite = libelleActivite;
            _lesActionsFormation = new List<ActionFormation>();
        }

        /// <summary>
        /// Ajoute une action de formation à l'activité
        /// </summary>
        /// <param name="codeAction">Le code de l'action d'une formation ajoutée</param>
        /// <param name="intitule">L'intituté de l'action de formation ajoutée</param>
        /// <param name="cout">Le coût de l'action de formation ajoutée</param>
        /// <param name="duree">La durée de l'action de formation ajoutée</param>
        /// <param name="date">La date de l'action de formation ajoutée</param>
        public void AjouterActionFormation(string codeAction, string intitule, decimal cout, int duree, DateTime date)
        {
            ActionFormation uneActionDeFormation = new ActionFormation(codeAction, intitule, cout, duree, date);
            _lesActionsFormation.Add(uneActionDeFormation);
        }

        /// <summary>
        /// Obtient une action de formation à partir d'un code d'action de formation
        /// </summary>
        /// <param name="codeAction">Le code de l'action de formation souhaitée</param>
        /// <returns></returns>
        public ActionFormation ObtenirActionFormation(string codeAction)
        {
            ActionFormation actionFormation = null;
            foreach (ActionFormation uneActionDeFormation in _lesActionsFormation)
            {
                if (uneActionDeFormation.CodeAction == codeAction)
                {
                    actionFormation = uneActionDeFormation;
                    break;
                }
            }
            return actionFormation;
        }

        /// <summary>
        /// Vérifie l'égalité entre l'activité courante et l'objet transmis en paramètre
        /// </summary>
        /// <param name="uneActivite">Une activité</param>
        /// <returns>Vrai en cas d'égalité, faux dans le cas contraire</returns>
        public override bool Equals(object uneActivite)
        {
            bool memeLibelleActivite = false;
            Activite uneActiviteTranstypeDeObjet = uneActivite as Activite;
            if (uneActiviteTranstypeDeObjet != null)
            {
                if (uneActiviteTranstypeDeObjet.LibelleActivite == _libelleActivite)
                {
                    memeLibelleActivite = true;
                }
            }
            return memeLibelleActivite;
        }

        /// <summary>
        /// Supprime une action de formation à l'activité à partir d'un code d'action de formation.
        /// </summary>
        /// <param name="codeAction">Le code de l'action de formation à supprimer</param>
        /// <returns>Vrai si la suppression est effective, faux dans le cas contraire</returns>
        public bool SupprimerActionFormation(string codeAction)
        {
            ActionFormation uneActionDeFormation = ObtenirActionFormation(codeAction);
            return _lesActionsFormation.Remove(uneActionDeFormation);
        }


    }
}

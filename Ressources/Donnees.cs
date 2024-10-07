using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FormationSNCF.Modele;

namespace FormationSNCF.Ressources
{
    /// <summary>
    /// Classe qui permet l'accès aux données sérialisées
    /// </summary>
    public static class Donnees
    {
        private static List<Activite> _collectionActivite;
        private static List<Agent> _collectionAgent;
        private static List<Agent> _collectionArchiveAgent;
        private static List<Lieu> _collectionLieu;

        /// <summary>
        /// Obtient la liste des activités de formation
        /// </summary>
        /// <remarks>Les activités contiennent les actions de formations et les sessions de formations</remarks>
        public static List<Activite> CollectionActivite
        {
            get
            {
                if (_collectionActivite == null)
                {
                    _collectionActivite = (List<Activite>)Persistances.ChargerDonnees("Activite");
                    if (_collectionActivite == null)
                        _collectionActivite = new List<Activite>();
                }
                return Donnees._collectionActivite;
            }
            set { Donnees._collectionActivite = value; }
        }
        /// <summary>
        /// Obtient la liste des agents
        /// </summary>
        public static List<Agent> CollectionAgent
        {
            get
            {
                if (_collectionAgent == null)
                {
                    _collectionAgent = (List<Agent>)Persistances.ChargerDonnees("Agent");
                    if (_collectionAgent == null)
                        _collectionAgent = new List<Agent>();
                }
                return Donnees._collectionAgent;
            }
        }

        public static List<Agent> AgentArchive
        {
            get
            {
                if(_collectionArchiveAgent == null)
                {
                    _collectionArchiveAgent = (List<Agent>)Persistances.ChargerDonnees("AgentArchive");
                    if (_collectionArchiveAgent == null)
                        _collectionArchiveAgent = new List<Agent>();

                }
                return Donnees._collectionArchiveAgent;
            }
            set
            {
                if(_collectionAgent != null)
                {
                    _collectionArchiveAgent = _collectionAgent;
                    Persistances.SauvegarderDonnees("AgentArchive", _collectionArchiveAgent);
                }
            }
        }

        /// <summary>
        /// Obtient la liste des lieux
        /// </summary>
        public static List<Lieu> CollectionLieu
        {
            get
            {
                if (_collectionLieu == null)
                {
                    _collectionLieu = (List<Lieu>)Persistances.ChargerDonnees("Lieu");
                    if (_collectionLieu == null)
                        _collectionLieu = new List<Lieu>();
                }
                return Donnees._collectionLieu;
            }
        }
      
        /// <summary>
        /// Sérialise l'intégralité des données de l'application
        /// </summary>
        public static void SauvegardeDonnees()
        {
            Persistances.SauvegarderDonnees("Agent", _collectionAgent);
            Persistances.SauvegarderDonnees("Activite", _collectionActivite);
            Persistances.SauvegarderDonnees("Lieu", _collectionLieu);
            Persistances.SauvegarderDonnees("AgentArchive", _collectionArchiveAgent);
        }


    }
}

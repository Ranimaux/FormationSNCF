using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace FormationSNCF.Ressources
{
    /// <summary>
    /// Classe de gestion des sauvegardes de données sur fichier
    /// </summary>
    public static class Persistances
    {
        private static string repertoireApplication = Environment.CurrentDirectory + @"\";

        /// <summary>
        /// Charge une collection stockée dans un fichier de sauvegarde
        /// </summary>
        /// <param name="nomFichier">Le nom du fichier de sauvegarde de la collection</param>
        /// <returns>Une collection</returns>
        public static IList ChargerDonnees(string nomFichier)
        {

            FileStream fs = null;
            IList listeItem = null;

            try
            {

                fs = new FileStream(repertoireApplication + nomFichier, FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                try
                {
                    listeItem = (IList)formatter.Deserialize(fs);
                }
                catch (SerializationException err)
                {
                    Persistances.FichierLog(err);
                }
                finally
                {
                    fs.Close();

                }


            }
            catch (Exception erreur)
            {

            }
            return listeItem;

        }

        /// <summary>
        /// Sauvegarde une collection dans un fichier de sauvegarde
        /// </summary>
        /// <param name="nomFichier">Le nom du fichier de sauvegarde</param>
        /// <param name="collection">La collection sauvegardée</param>
        public static void SauvegarderDonnees(string nomFichier, IList collection)
        {
            FileStream file = null;

            try
            {
                file = File.Open(repertoireApplication + nomFichier, FileMode.OpenOrCreate);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(file, collection);
            }
            catch (Exception err)
            {
                Persistances.FichierLog(err);
            }
            finally
            {
                if (file != null)
                    file.Close();
            }

        }

        /// <summary>
        /// Charge un objet stockée dans un fichier de sauvegarde
        /// </summary>
        /// <param name="nomFichier">Le nom du fichier de sauvegarde de l'objet</param>
        /// <returns>Un objet</returns>
        public static object ChargerObjet(string nomFichier)
        {
            FileStream fs = null;
            object objet = null;

            try
            {
                fs = new FileStream(repertoireApplication + nomFichier, FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                try
                {
                    objet = (object)formatter.Deserialize(fs);
                }
                catch (SerializationException erreur)
                {

                }
                finally
                {
                    fs.Close();
                }


            }
            catch (Exception erreur)
            {

            }
            return objet;
        }

        /// <summary>
        /// Sauvegarde un objet dans un fichier de sauvegarde
        /// </summary>
        /// <param name="nomFichier">Le nom du fichier de sauvegarde</param>
        /// <param name="obj">L'objet sauvegardé</param>
        public static void SauvegarderObjet(string nomFichier, object obj)
        {
            FileStream file = null;
            try
            {
                file = File.Open(repertoireApplication + nomFichier, FileMode.OpenOrCreate);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(file, obj);
            }
            catch (Exception err)
            {
                Persistances.FichierLog(err);
            }
            finally
            {
                if (file != null)
                {
                    file.Close();
                }
            }
        }

        private static void FichierLog(Exception exception)
        {
            string path = repertoireApplication + @"\erreur";
            try
            {
                StreamWriter sw = new StreamWriter(path, true);
                sw.WriteLine("Date : " + DateTime.Now + " Message : " + exception.Message);
                sw.Close();
            }
            catch (IOException IOExcep)
            {
                throw new NotImplementedException();
            }
        }
    }
}

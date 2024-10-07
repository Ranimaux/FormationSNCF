using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormationSNCF.Modele;
using System.Text.RegularExpressions;

namespace FormationSNCF.Ressources
{
    class Utilitaire
    {
        public static bool EstAuFormatTelephone(string formatTelephone)
        {
            bool auFormatTelephone = false;

            if (formatTelephone.Length == 10)
            {
                auFormatTelephone = Regex.IsMatch(formatTelephone, @"^[0-9]+[^a-zA-Z]$");
            }
            return auFormatTelephone;
        }

        public static bool EstAuFormatDateJJMMAAAA(string formatDate)
        {
            bool auFormatDate = false;

            if(formatDate.Length == 10)
            {
                auFormatDate = Regex.IsMatch(formatDate, @"^\d{2}/\d{2}/\d{4}$");
            }

            return auFormatDate;
        }

        public static bool EstAuFormatCodePostal(string formatCodePostal)
        {
            bool auFormatCodePostal = false;

            if (formatCodePostal.Length == 5)
            {
                auFormatCodePostal = Regex.IsMatch(formatCodePostal, @"^[0-9]+[^a-zA-Z]$");

            }

            return auFormatCodePostal;
        }

        public static bool EstUneValeurEntiere(string valeurEntiere)
        {
            bool uneValeurEntiere = false;
            uneValeurEntiere = Regex.IsMatch(valeurEntiere, @"^\d+$");
            return uneValeurEntiere;
        }

        public static bool EstUneValeurDecimal(string valeurDecimal)
        {
            bool uneValeurDecimal = false;
            uneValeurDecimal = Regex.IsMatch(valeurDecimal, @"^\d+(\.\d+)?$");
            return uneValeurDecimal;
        }
    }
}

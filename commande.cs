using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSQL
{
    class Commande
    {
        private int numero;
        private int code_v;
        private int code_c;
        private DateTime date_livraison;
        private DateTime date_commande;
        private double total_ht;
        private double total_tva;
        private string etat;



        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Code_v
        {
            get { return code_v; }
            set { code_v = value; }
        }
        public string Code_c
        {
            get { return code_c; }
            set { code_c = value; }
        }
        public string Date_livraison
        {
            get { return date_livraison.ToString(); }
            set { cp = value; }
        }
        public string Date_commande
        {
            get { return date_commande.ToString(); }
            set { date_commande = value; }
        }
        public string Total_ht
        {
            get { return total_ht; }
            set { total_ht = value; }
        }
        public string Total_tva
        {
            get { return total_tva; }
            set { total_tva = value; }
        }
        public string Etat
        {
            get { return etat; }
            set { etat = value; }
        }
    }
}

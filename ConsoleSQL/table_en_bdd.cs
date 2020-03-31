using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSQL
{
    public class Commande
    {
        private int numero;
        private int code_v;
        private int code_c;
        private DateTime date_livraison;
        private DateTime date_commande;
        private double total_ht;
        private double total_tva;
        private int etat;



        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public int Code_v
        {
            get { return code_v; }
            set { code_v = value; }
        }
        public int Code_c
        {
            get { return code_c; }
            set { code_c = value; }
        }
        public DateTime Date_livraison
        {
            get { return date_livraison; }
            set { date_livraison = value; }
        }
        public DateTime Date_commande
        {
            get { return date_commande.Date; }
            set { date_commande = value; }
        }
        public double Total_ht
        {
            get { return total_ht; }
            set { total_ht = value; }
        }
        public double Total_tva
        {
            get { return total_tva; }
            set { total_tva = value; }
        }
        public int Etat
        {
            get { return etat; }
            set { etat = value; }
        }
    }

    public class Client
    {
        private string code_c;
        private string nom;
        private string adresse;
        private string cp;
        private string ville;
        private string telephone;


        public string Code_c
        {
            get { return code_c; }
            set { code_c = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }
        public string Cp
        {
            get { return cp; }
            set { cp = value; }
        }
        public string Ville
        {
            get { return ville; }
            set { ville = value; }
        }
        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }
    }

    public class ComboSource
    {
        public long Id { get; set; }
        public string Libelle { get; set; }
    }
}

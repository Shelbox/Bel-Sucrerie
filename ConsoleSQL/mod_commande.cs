using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Dapper;

namespace ConsoleSQL
{
    public partial class mod_commande : Form
    {
        public static Commande Commande;

        public mod_commande(Commande uneCommande)
        {
            InitializeComponent();
            this.numero.Text = uneCommande.Numero.ToString();
            this.code_v.Text = uneCommande.Code_v.ToString();
            this.code_c.Text = uneCommande.Code_c.ToString();
            this.date_livraison.Value =  uneCommande.Date_livraison;
            this.date_commande.Value =  uneCommande.Date_commande;
            this.total_ht.Text =  uneCommande.Total_ht.ToString();
            this.total_tva.Text =  uneCommande.Total_tva.ToString();
            this.total_tva.Text =  uneCommande.Total_tva.ToString();    
            this.etat.Checked =  uneCommande.Etat == 1 ? true : false;

            //On récupère le client à modifier
            Commande = uneCommande;
        }


        private void btn_delete_Click(object sender, EventArgs e)
        {
            var sql = "DELETE FROM commande " +
                    "WHERE numero = '" + Commande.Numero + "'; ";

            try
            {
                //Connection
                string _connectionString = "Server=127.0.0.1; Database=sucrerie; UID=root; Pwd=";
                MySqlConnection connection = new MySqlConnection(_connectionString);

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader MyReader;
                connection.Open();
                MyReader = cmd.ExecuteReader();
                while (MyReader.Read())
                {
                }

                MessageBox.Show("Supression Ok ! ");

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR ! ");
            }

            this.Close();
        }

        private void btn_ajout_Click(object sender, EventArgs e)
        {
            Commande.Code_v = Convert.ToInt32(this.code_c.Text);
            Commande.Code_c = Convert.ToInt32(this.code_c.Text);
            Commande.Date_livraison = this.date_livraison.Value;
            Commande.Date_commande = this.date_livraison.Value;
            Commande.Total_ht = Convert.ToInt32(this.total_ht.Text);
            Commande.Total_tva = Convert.ToInt32(this.total_tva.Text);
            Commande.Etat = this.etat.Checked == true ? 1 : 0;

            var sql = "INSERT INTO commande VALUES ('', " +
                        "'" + Commande.Code_v + "'," +
                        "'" + Commande.Code_c + "'," +
                        "'" + Commande.Date_livraison + "'," +
                        "'" + Commande.Date_commande + "'," +
                        "'" + Commande.Total_ht + "' " +
                        "'" + Commande.Total_tva + "' " +
                        "'" + Commande.Etat + "'); ";

            try
            {
                //Connection
                string _connectionString = "Server=127.0.0.1; Database=sucrerie; UID=root; Pwd=";
                MySqlConnection connection = new MySqlConnection(_connectionString);

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader MyReader;
                connection.Open();
                MyReader = cmd.ExecuteReader();
                while (MyReader.Read())
                {
                }

                MessageBox.Show("Ajout Ok ! ");

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR ! ");
            }

            this.Close();

        }

        private void no_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yes_Click(object sender, EventArgs e)
        {
            Commande.Code_v = Convert.ToInt32(this.code_v.Text);
            Commande.Code_c = Convert.ToInt32(this.code_c.Text);
            Commande.Date_livraison = this.date_livraison.Value.Date;
            Commande.Date_commande = this.date_livraison.Value.Date;
            Commande.Total_ht = Convert.ToDouble(this.total_ht.Text);
            Commande.Total_tva = Convert.ToDouble(this.total_tva.Text);
            Commande.Etat = this.etat.Checked == true ? 1 : 0;

            var sql = "UPDATE commande SET " +
                        " code_v = '" + Commande.Code_v + "'," +
                        " code_c = '" + Commande.Code_c + "'," +
                        " date_livraison = '" + Commande.Date_livraison.Date + "'," +
                        " date_commande = '" + Commande.Date_commande.Date + "'," +
                        " total_ht = '" + Commande.Total_ht + "', " +
                        " total_tva = '" + Commande.Total_tva + "', " +
                        " etat = '" + Commande.Etat + "' " +
                    "WHERE numero = " + Commande.Numero + "; ";

            try
            {
                //Connection
                string _connectionString = "Server=127.0.0.1; Database=sucrerie; UID=root; Pwd=";
                MySqlConnection connection = new MySqlConnection(_connectionString);

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader MyReader;
                
                MyReader = cmd.ExecuteReader();
                while (MyReader.Read())
                {
                }

                MessageBox.Show("Modification Ok ! ");

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR ! ");
            }

            this.Close();
        }
    }
}


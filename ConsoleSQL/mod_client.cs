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
    public partial class mod_client : Form
    {
        public static Client Client;


        public mod_client(Client unClient)
        { 
            InitializeComponent();

            this.code_c.Text = unClient.Code_c;
            this.nom.Text = unClient.Nom;
            this.adresse.Text = unClient.Adresse;
            this.cp.Text = unClient.Cp;
            this.ville.Text = unClient.Ville;
            this.telephone.Text = unClient.Telephone;
            //On récupère le client à modifier
            Client = unClient;
        }

        private void yes_Click(object sender, EventArgs e)
        {

            Client.Nom = this.nom.Text;
            Client.Adresse = this.adresse.Text;
            Client.Cp = this.cp.Text;
            Client.Ville = this.ville.Text;
            Client.Telephone = this.telephone.Text;
            
            var sql = "UPDATE client SET " +
                        " nom = '" + Client.Nom + "'," +
                        " adresse = '" + Client.Adresse + "'," +
                        " cp = '" + Client.Cp + "'," +
                        " ville = '" + Client.Ville + "'," +
                        " telephone = '" + Client.Telephone + "' " +
                    "WHERE code_c = '" + Client.Code_c + "'; ";

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

                MessageBox.Show("Modification Ok ! ");

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

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var sql = "DELETE FROM client " +
                    "WHERE code_c = '" + Client.Code_c + "'; ";

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
            Client.Nom = this.nom.Text;
            Client.Adresse = this.adresse.Text;
            Client.Cp = this.cp.Text;
            Client.Ville = this.ville.Text;
            Client.Telephone = this.telephone.Text;

            var sql = "INSERT INTO client VALUES ('', " +
                        "'" + Client.Nom + "'," +
                        "'" + Client.Adresse + "'," +
                        "'" + Client.Cp + "'," +
                        "'" + Client.Ville + "'," +
                        "'" + Client.Telephone + "'); ";

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
    }
}

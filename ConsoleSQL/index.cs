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
    public partial class index : Form
    {
        public static List<Commande> dataCommande;
        public static List<Client> dataClient;
        public string table;

        public index()
        {
            InitializeComponent();
            //Config dataGrid
            grille.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grille.MultiSelect = false;
            grille.ReadOnly = true;

            string sql = "SHOW TABLES";
    
            string _connectionString = "Server=127.0.0.1; Database=sucrerie; UID=root; Pwd=";
            MySqlConnection connection = new MySqlConnection(_connectionString);
            connection.Open();

            List<string>listTable = connection.Query<string>(sql).ToList();
            var ComboTable = new List<ComboSource>();

            int i = 0;
            foreach (string table in listTable)
            {
                ComboTable.Add(new ComboSource() { Id = i, Libelle = table });
                i++;
            }

            selectTable.DataSource = ComboTable;
            selectTable.DisplayMember = "Libelle";
            selectTable.ValueMember = "Id";
        }

       

        private void select_SelectedIndexChanged(object sender, EventArgs e)
        {
            string _connectionString = "Server=127.0.0.1; Database=sucrerie; UID=root; Convert Zero Datetime=True";
            MySqlConnection connection = new MySqlConnection(_connectionString);

            //Nettoyage de la "grid"
            grille.DataSource = null;
            grille.Rows.Clear();

            table = selectTable.Text;
            string sql;
            
            switch (table)
            {
                case "commande":
                     sql = "SELECT* FROM commande";
                        try{
                            MySqlCommand cmd = new MySqlCommand(sql, connection);

                            dataCommande = connection.Query<Commande>(sql).ToList();
                            grille.DataSource = dataCommande;
                        }
                        catch (Exception ex){
                            MessageBox.Show(ex.ToString());
                        }
                    break;
                case "client":
                    sql = "SELECT* FROM client";
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(sql, connection);

                        dataClient = connection.Query<Client>(sql).ToList();
                        grille.DataSource = dataClient;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    break;
            }


        }

        private void recherche_Click(object sender, EventArgs e)
        {
            string _connectionString = "Server=127.0.0.1; Database=sucrerie; UID=root; Pwd=";
            MySqlConnection connection = new MySqlConnection(_connectionString);

            //Nettoyage de la "grid"
            grille.DataSource = null;
            grille.Rows.Clear();

            table = selectTable.Text;
            string sql;

            switch (table)
            {
                case "commande":
                    sql = "SELECT* FROM commande";
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(sql, connection);

                        dataCommande = connection.Query<Commande>(sql).ToList();
                        grille.DataSource = dataCommande;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    break;
                case "client":
                    sql = "SELECT* FROM client";
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(sql, connection);

                        dataClient = connection.Query<Client>(sql).ToList();
                        grille.DataSource = dataClient;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    break;
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = grille.CurrentCell.RowIndex;

            switch (table)
            {
                case "client":
                    //Fait apparait la fenètre
                    mod_client mod_client = new mod_client(dataClient[index]);
                    mod_client.Show();
                    break;
                case "commande":
                    //Fait apparait la fenètre
                    mod_commande mod_commande = new mod_commande(dataCommande[index]);
                    mod_commande.Show();
                    break;
            }

  

        }



    }
}

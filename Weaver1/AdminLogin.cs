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
namespace Weaver1
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "datasource=127.0.0.1;port=3306;username=root;password=root";
            string query = "SELECT admin_password FROM opendental.admin_tbl WHERE admin_id='"+ this.textBox1.Text+"';";
            
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmd = new MySqlCommand(query, conDatabase);
            MySqlDataReader myReader;
            try
            {
                conDatabase.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    MessageBox.Show(myReader.GetString("admin_password"));
                    //if (myReader. == this.textBox2.Text)
                    //{
                    //    MessageBox.Show("Checked");
                    //}
                }
                
                MessageBox.Show("DB Query executed");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
    }
}

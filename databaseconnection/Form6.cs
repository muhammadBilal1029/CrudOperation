using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace databaseconnection
{
    public partial class Form6 : Form
    {
        private Form1 form1;
        public Form6(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text.Trim();
            string email = textBox3.Text.Trim();
            string password = textBox4.Text.Trim();
            string name = textBox2.Text.Trim();
            string constr = @"Data Source=SPARTALAPTOP;
            initial Catalog=Bilal;
            Integrated Security=true;";
            SqlConnection obj = new SqlConnection(constr);
            obj.Open();
            string sqlupdate = "UPDATE sig_log SET name = @name, email = @email, password = @password WHERE id = @id";

            SqlCommand cmd = new SqlCommand(sqlupdate, obj);

            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@id", id);

            if (cmd.ExecuteNonQuery()> 0)
            {
                MessageBox.Show("Record Updated successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("An error occurred while deleting record: ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

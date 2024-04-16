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
    public partial class Form3 : Form
    {
        private Form1 form1;
        public Form3(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void signup()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = @"Data Source=SPARTALAPTOP;
            initial Catalog=Bilal;
           Integrated Security=true;";
            SqlConnection obj = new SqlConnection(constr);
            obj.Open();
            //string sqlCreateTable = @"CREATE TABLE signup_login (
            //name NVARCHAR(50),
            // email NVARCHAR(50),
            // password NVARCHAR(50)
            //)";
            string sqlinsert = @"insert into sig_log(ID,name,email,password)values(@ID,@name,@email,@password)";
            SqlCommand cmd = new SqlCommand(sqlinsert, obj);
            cmd.Parameters.AddWithValue("@ID", textBox4.Text);
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@email", textBox2.Text);
            cmd.Parameters.AddWithValue("@password", textBox3.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Signup successful!", "Signup", MessageBoxButtons.OK, MessageBoxIcon.Information);
             this.Close();
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.Show();
        }
    }
}

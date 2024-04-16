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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string constr = @"Data Source=SPARTALAPTOP;
           // initial Catalog=Bilal;
          // Integrated Security=true;";
           // SqlConnection obj = new SqlConnection(constr);
           // obj.Open();
           // string sqlselect = "select * from Bilal";
           // SqlDataAdapter obj2 = new SqlDataAdapter(sqlselect, constr);
          //  DataSet ds = new DataSet();
          //  obj2.Fill(ds);
            //dataGridView1.DataSource = ds.Tables[0];
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.signup();
            form3.Show();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string constr = @"Data Source=SPARTALAPTOP;
            initial Catalog=Bilal;
            Integrated Security=true;";
            SqlConnection obj = new SqlConnection(constr);
             obj.Open();
             string sqlselect = "select * from sig_log";
             SqlDataAdapter obj2 = new SqlDataAdapter(sqlselect, obj);
             DataSet ds = new DataSet();
             obj2.Fill(ds);
            Form2 form2 = new Form2(this);

          
            form2.DisplayRecords(ds);

            
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(this);
            form4.login();
            form4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(this);
            form5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(this);
            form6.Show();

        }
    }
}

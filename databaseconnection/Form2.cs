using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace databaseconnection
{
    public partial class Form2 : Form
    {
        private Form1 form1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
    }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }
        public void DisplayRecords(DataSet ds)
        {
           if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
               {
                  dataGridView1.DataSource = ds.Tables[0];
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            form1.Show();
        }
    }
}

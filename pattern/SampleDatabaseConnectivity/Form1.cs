using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SampleDatabaseConnectivity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=ADMIN-PC\\SQLEXPRESS; Integrated Security = true; Database = master");
            SqlCommand cmd = new SqlCommand("Select * from stud3", con);
            SqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();
            while(dr.Read() ){
                listBox1.Items.Add(dr.GetString(0));
                listBox2.Items.Add(dr.GetString(1));
                listBox3.Items.Add(dr.GetString(2));
            }
        }
    }
}

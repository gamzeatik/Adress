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

namespace ASKO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-GAMZE;Initial Catalog=ASKO;Integrated Security=True");

            if (textBox_search.Text != "")
            {
                dataGridView_search.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                DataSet ds = new DataSet();
                DataView dv = new DataView();

                string command = "select * from tbl_asko where TCNO like '%" + textBox_search.Text + "%';";

                sqlConnection.Open();
                sqlDataAdapter = new SqlDataAdapter(command, sqlConnection);
                sqlDataAdapter.Fill(ds);
                dv = new DataView(ds.Tables[0]);
                dataGridView_search.DataSource = dv;
                sqlConnection.Close();
            }
            else if (textBox_search.Text=="")
            {
                dataGridView_search.Refresh();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

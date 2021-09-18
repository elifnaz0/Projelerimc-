using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace İlişkili_Tablolar_ile_Birleştirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection(@"Data Source=LENOVO\SQLEXPRESS;Initial Catalog=Test;Integrated Security=True");
        void List()
        {
            SqlDataAdapter dat = new SqlDataAdapter("Execute Test", bgl);
            DataTable dt = new DataTable();
            dat.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            List();
        }
    }
}

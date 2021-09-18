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

namespace Film_Arsivim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection(@"Data Source=LENOVO\SQLEXPRESS;Initial Catalog=FilmArsivim;Integrated Security=True");
        void filmler()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TblFilmler", bgl);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            filmler();
        }

        void temizle()
        {
            textFilmAd.Text = "";
            textKategori.Text = "";
            textLink.Text = "";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand ekle = new SqlCommand("Insert into TblFilmler (AD,KATEGORİ,LINK) values (@a1,@a2,@a3)", bgl);
            ekle.Parameters.AddWithValue("@a1", textFilmAd.Text);
            ekle.Parameters.AddWithValue("@a2", textKategori.Text);
            ekle.Parameters.AddWithValue("@a3", textLink.Text);
            ekle.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("Film Kaydetildi", "BİLGİ", MessageBoxButtons.OK);
            filmler();
            temizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string link = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            webBrowser1.Navigate(link);
        }

        private void btnHakkımızda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Proje Elifnaz Küçüker Tarafından 5 Eylül 2021'de Yapılmıştır", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnÇıkış_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public enum renk{AliceBlue, Bisque, DeepPink, ForestGreen};
        private void btnRenk_Click(object sender, EventArgs e)
        {
            renk c = (renk)(new Random()).Next(0, 4);
            switch (c)
            {
                case renk.Bisque:
                    this.BackColor = Color.Bisque;
                    break;
                case renk.DeepPink:
                    this.BackColor = Color.DeepPink;
                    break;
                case renk.AliceBlue:
                    this.BackColor = Color.AliceBlue;
                    break;
                case renk.ForestGreen:
                    this.BackColor = Color.ForestGreen;
                    break;
                    
            }
        }
        
       
    }
}

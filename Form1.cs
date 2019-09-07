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

namespace MarketOtomasyon
{
    public partial class Form1 : Form
    {
        public Form2 frm2;
        public Form3 frm3;
        public Form4 frm4;
        public Form5 frm5;
        public Form6 frm6;
        public Form1()
        {

            frm2 = new Form2();
            frm3 = new Form3();
            frm4 = new Form4();
            frm5 = new Form5();
            frm6 = new Form6();


            InitializeComponent();
        }
        public string sorgu = "Data Source=LAPTOP-SVCPKSN9\\NSQL;Initial Catalog=MarketOtomasyonu;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sorgu);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {

            }
        }


        private void btn_musteri(object sender, EventArgs e)
        {
            frm2.ShowDialog();

        }

        private void btn_calisan(object sender, EventArgs e)
        {
            frm3.ShowDialog();
        }

        private void btn_tedarik(object sender, EventArgs e)
        {
            frm4.ShowDialog();

        }
        private void btn_urunler(object sender, EventArgs e)
        {
            frm5.ShowDialog();

        }
        private void btn_siparis(object sender,EventArgs e)
        {
            frm6.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        SqlConnection bag = new SqlConnection("Data Source = LAPTOP-SVCPKSN9\\NSQL ; Initial Catalog = MarketOtomasyonu; Integrated Security = True");
        string komut1 = "Select * from Musteriler";
       
        private void button2_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilerial();
            sqlveriyaz();
        }
        
        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            komut1 = "Select * from Musteriler where MusteriAd like '" + textBox6.Text.ToString() + "%'";
            DataTable tablo = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(komut1, bag);
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(komut1, bag);
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
        private void dataGridView1_CellClick(object sender,DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
        void listele()
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(komut1, bag);
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(komut1, bag);
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            komut1 = "Select * from Musteriler where MusteriYas  ='" + textBox7.Text.ToString() + "'";
            DataTable tablo = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(komut1, bag);
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            komut1 = "Select * from Musteriler where MusteriCinsiyet ='" + textBox8.Text.ToString() + "'";
            DataTable tablo = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(komut1, bag);
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Silmek istediginizden emin misiniz", "Dikkat", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (bag.State == ConnectionState.Closed)
                {
                    bag.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = bag;
                    cmd.CommandText = "delete from Musteriler where MusteriId=@numara";
                    cmd.Parameters.AddWithValue("@numara", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    bag.Close();
                    listele();
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (bag.State == ConnectionState.Closed)
            {
                bag.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = bag;
                cmd.CommandText = "update Musteriler set MusteriAd='" + textBox2.Text + "',MusteriSoyAd='" + textBox3.Text + "',MusteriYas='" + int.Parse(textBox4.Text) + "',MusteriCinsiyet='" + textBox5.Text + "'where MusteriId=@numara";
                cmd.Parameters.AddWithValue("@numara", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                bag.Close();
                listele();
                temizle();
                MessageBox.Show("Güncelleme başarılı şekilde tamamlandı.");



            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

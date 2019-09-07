using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MarketOtomasyon
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection("Data Source = LAPTOP-SVCPKSN9\\NSQL ; Initial Catalog = MarketOtomasyonu; Integrated Security = True");

        string komut2 = "Select * from Calisanlar";
        

        private void button3_Click(object sender, EventArgs e)
        {
            verilerial1();
            sqlveriyaz1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            temizle1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter adp1 = new SqlDataAdapter(komut2, bag);
            adp1.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            komut2 = "Select * from Calisanlar where CalisanlarId ='" + textBox7.Text.ToString() + "'";
            DataTable tablo = new DataTable();
            SqlDataAdapter adp1 = new SqlDataAdapter(komut2, bag);
            adp1.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            komut2 = "Select * from Calisanlar where CalisanlarAdi like '" + textBox8.Text.ToString() + "%'";
            DataTable tablo = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(komut2, bag);
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        void listele1()
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(komut2, bag);
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(komut2, bag);
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediginizden emin misiniz", "Dikkat", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (bag.State == ConnectionState.Closed)
                {
                    bag.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = bag;
                    cmd.CommandText = "delete from Calisanlar where CalisanlarId=@numara";
                    cmd.Parameters.AddWithValue("@numara", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    bag.Close();
                    listele1();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (bag.State == ConnectionState.Closed)
            {
                bag.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = bag;
                cmd.CommandText = "update Calisanlar set CalisanlarAdi='" + textBox2.Text + "',CalisanlarSoyAdi='" + textBox3.Text + "',CalisanlarTelNo='" + int.Parse(textBox4.Text) + "',CalisanlarAdres='" + textBox5.Text + "'where CalisanlarId=@numara";
                cmd.Parameters.AddWithValue("@numara", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                bag.Close();
                listele1();
                temizle1();
                MessageBox.Show("Güncelleme başarılı şekilde tamamlandı.");



            }
        }

        
    }
}

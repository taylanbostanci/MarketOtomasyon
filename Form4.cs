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
    public partial class Form4 : Form
    {
        SqlConnection bag = new SqlConnection("Data Source = LAPTOP-SVCPKSN9\\NSQL ; Initial Catalog = MarketOtomasyonu; Integrated Security = True");
        string komut1 = "Select * from Tedarikci";
        
        public Form4()
        {
            InitializeComponent();
        }

        void listele()
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(komut1, bag);
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
        void temizle()
        {

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(komut1, bag);
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
           
        }
        private void button6_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bag.State == ConnectionState.Closed)
            {
                bag.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = bag;
                cmd.CommandText = "update Tedarikci set TedarikciAdi='" + textBox2.Text + "',TedarikciAdres='" + textBox3.Text + "',TedarikciTelNo='" + int.Parse(textBox4.Text) +  "'where TedarikciId=@numara";
                cmd.Parameters.AddWithValue("@numara", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                bag.Close();
                listele();
                temizle();
                MessageBox.Show("Güncelleme başarılı şekilde tamamlandı.");



            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilerial();
            sqlveriyaz();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediginizden emin misiniz", "Dikkat", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (bag.State == ConnectionState.Closed)
                {
                    bag.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = bag;
                    cmd.CommandText = "delete from Tedarikci where TedarikciId=@numara";
                    cmd.Parameters.AddWithValue("@numara", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    bag.Close();
                    listele();
                }
            }
        }
    }
}

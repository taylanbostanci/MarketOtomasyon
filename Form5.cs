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
    public partial class Form5 : Form
    {
        SqlConnection bag = new SqlConnection("Data Source = LAPTOP-SVCPKSN9\\NSQL ; Initial Catalog = MarketOtomasyonu; Integrated Security = True");
        string komut1 = "Select * from Urunler";
        string komut2 = "Select UrunId,UrunIsmi,KategoriAd,TedarikciAd,Alisfiyat,Satisfiyat from Urunler";
            

        void listele()
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(komut2, bag);
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        void temizle()
        {

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
           
            textBox1.Focus();
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
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

        }
        
        public Form5()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            temizle();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            
            if (bag.State == ConnectionState.Closed)
            {
                
                Decimal alisfiyat = Decimal.Parse(textBox5.Text);
                Decimal satisfiyat = Decimal.Parse(textBox6.Text);
                bag.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = bag;
                cmd.CommandText = "update Urunler set UrunIsmi='" + textBox2.Text + "',KategoriAd='" + textBox3.Text + "',TedarikciAd='" + textBox4.Text + "',Alisfiyat= '" + textBox5.Text + "' ,Satisfiyat='" + textBox6.Text + "' where UrunId=@numara";
                cmd.Parameters.AddWithValue("@numara", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                bag.Close();
                listele();
                temizle();
                MessageBox.Show("Güncelleme başarılı şekilde tamamlandı.");


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilerial();
            sqlveriyaz();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediginizden emin misiniz", "Dikkat", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (bag.State == ConnectionState.Closed)
                {
                    bag.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = bag;
                    cmd.CommandText = "delete from urunler where UrunId=@numara";
                    cmd.Parameters.AddWithValue("@numara", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    bag.Close();
                    listele();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

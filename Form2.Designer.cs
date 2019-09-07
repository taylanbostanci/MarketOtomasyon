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
    public partial class Form2
    {
        SqlConnection con = new SqlConnection();
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Musteri Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Yas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cinsiyet";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(136, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(136, 106);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(136, 140);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(136, 173);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.ImageKey = "iconfinder_Save_27876.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(332, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 86);
            this.button1.TabIndex = 2;
            this.button1.Text = "KAYDET";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "iconfinder_Remove_27874.png");
            this.ımageList1.Images.SetKeyName(1, "iconfinder_Save_27876.png");
            this.ımageList1.Images.SetKeyName(2, "iconfinder_Synchronize_27883.png");
            this.ımageList1.Images.SetKeyName(3, "iconfinder_Log Out_27856.png");
            this.ımageList1.Images.SetKeyName(4, "iconfinder_Undo_27885.png");
            this.ımageList1.Images.SetKeyName(5, "iconfinder_Text Document_27884.png");
            // 
            // button2
            // 
            this.button2.ImageKey = "iconfinder_Undo_27885.png";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(332, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 76);
            this.button2.TabIndex = 3;
            this.button2.Text = "TEMIZLE";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ImageKey = "iconfinder_Text Document_27884.png";
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(407, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 86);
            this.button3.TabIndex = 4;
            this.button3.Text = "LISTELE";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(758, 179);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(618, 41);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "ISME GORE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(616, 106);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(152, 24);
            this.button5.TabIndex = 7;
            this.button5.Text = "YAŞA GORE";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(612, 173);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(154, 27);
            this.button6.TabIndex = 8;
            this.button6.Text = "CINSIYETE GORE";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(567, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "ARA";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(567, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "ARA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(567, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "ARA";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(618, 12);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(150, 20);
            this.textBox6.TabIndex = 11;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(618, 76);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(150, 20);
            this.textBox7.TabIndex = 12;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(616, 143);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(150, 20);
            this.textBox8.TabIndex = 13;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // button7
            // 
            this.button7.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.ImageKey = "iconfinder_Log Out_27856.png";
            this.button7.ImageList = this.ımageList1;
            this.button7.Location = new System.Drawing.Point(455, 169);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(94, 76);
            this.button7.TabIndex = 14;
            this.button7.Text = "KAPAT";
            this.button7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.ImageKey = "iconfinder_Remove_27874.png";
            this.button8.ImageList = this.ımageList1;
            this.button8.Location = new System.Drawing.Point(482, 61);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(67, 86);
            this.button8.TabIndex = 15;
            this.button8.Text = "KAYIT SİL";
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.ImageKey = "iconfinder_Synchronize_27883.png";
            this.button9.ImageList = this.ımageList1;
            this.button9.Location = new System.Drawing.Point(254, 61);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(72, 86);
            this.button9.TabIndex = 16;
            this.button9.Text = "GUNCELLE";
            this.button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 450);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        string ad, soyad, yas, cinsiyet, id, komut;
        string bag1 = "Data Source = LAPTOP-SVCPKSN9\\NSQL ; database = MarketOtomasyonu; Integrated Security = True";
        
        
        void temizle()
        {

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox1.Focus();
        }
        void verilerial()
        {
            id = textBox1.Text;
            ad = textBox2.Text;
            soyad = textBox3.Text;
            yas = textBox4.Text;
            cinsiyet = textBox5.Text;
           

        }
        void sqlveriyaz()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source = LAPTOP-SVCPKSN9\\NSQL ; database = MarketOtomasyonu; Integrated Security = True";

                komut = "insert into Musteriler(MusteriId,MusteriAd,MusteriSoyAd,MusteriYas,MusteriCinsiyet)values('" + id + "','" + ad + "','" + soyad + "','" + yas + "','" + cinsiyet + "')";
                con.Open();
                SqlCommand komutsatiri = new SqlCommand(komut, con);
                komutsatiri.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("veri girişi başarılı");
            }
            catch (Exception hata)
            {

                MessageBox.Show("bir hata meydana geldi!!" + hata.ToString());

            }











        }

        private Button button3;
        private DataGridView dataGridView1;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label6;
        private Label label10;
        private Label label7;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Button button7;
        private Button button8;
        private Button button9;
        private ImageList ımageList1;
    }
    }
    



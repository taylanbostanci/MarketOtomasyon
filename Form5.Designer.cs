
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
    partial class Form5
    {
        string id, ad, katadi, tedadi, alisfiyat,satisfiyat,komut;

        void verilerial()
        {
            id = textBox1.Text;
            ad = textBox2.Text;
            katadi = textBox3.Text;
            tedadi = textBox4.Text;
            alisfiyat = textBox5.Text;
            satisfiyat = textBox6.Text;



        }
        void sqlveriyaz()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source = LAPTOP-SVCPKSN9\\NSQL ; database = MarketOtomasyonu; Integrated Security = True";

                komut = "insert into Urunler(UrunId,UrunIsmi,KategoriAd,TedarikciAd,Alisfiyat,Satisfiyat)values('" + id + "','" + ad + "','" +katadi + "','" + tedadi+ "','"+alisfiyat+"','"+satisfiyat+"')";
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(730, 186);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "URUN ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "URUN ISMI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "KATEGORI ADI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "TEDARIKCI ADI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "ALIS FIYAT";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "SATIS FIYAT";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(101, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(101, 110);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(365, 39);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 2;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(365, 78);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 2;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(365, 114);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 2;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // button1
            // 
            this.button1.ImageKey = "iconfinder_Save_27876.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(677, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 94);
            this.button1.TabIndex = 3;
            this.button1.Text = "KAYDET";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "iconfinder_Save_27876.png");
            this.ımageList1.Images.SetKeyName(1, "iconfinder_Synchronize_27883.png");
            this.ımageList1.Images.SetKeyName(2, "iconfinder_Remove_27874.png");
            this.ımageList1.Images.SetKeyName(3, "iconfinder_Log Out_27856.png");
            this.ımageList1.Images.SetKeyName(4, "iconfinder_Text Document_27884.png");
            this.ımageList1.Images.SetKeyName(5, "iconfinder_Undo_27885.png");
            // 
            // button2
            // 
            this.button2.ImageKey = "iconfinder_Synchronize_27883.png";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(595, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 94);
            this.button2.TabIndex = 3;
            this.button2.Text = "GUNCELLE";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ImageKey = "iconfinder_Remove_27874.png";
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(595, 142);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 85);
            this.button3.TabIndex = 3;
            this.button3.Text = "SİL";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.ImageIndex = 4;
            this.button4.ImageList = this.ımageList1;
            this.button4.Location = new System.Drawing.Point(677, 142);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 85);
            this.button4.TabIndex = 3;
            this.button4.Text = "LİSTELE";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button5.ImageKey = "iconfinder_Log Out_27856.png";
            this.button5.ImageList = this.ımageList1;
            this.button5.Location = new System.Drawing.Point(514, 142);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 85);
            this.button5.TabIndex = 3;
            this.button5.Text = "KAPAT";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.ImageKey = "iconfinder_Undo_27885.png";
            this.button6.ImageList = this.ımageList1;
            this.button6.Location = new System.Drawing.Point(514, 29);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 94);
            this.button6.TabIndex = 4;
            this.button6.Text = "TEMIZLE";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ImageList ımageList1;
        private Button button6;
    }
}
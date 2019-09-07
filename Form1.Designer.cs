namespace MarketOtomasyon
{
    partial class Form1
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.musteri = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // musteri
            // 
            this.musteri.ImageKey = "iconfinder_User_27887.png";
            this.musteri.ImageList = this.ımageList1;
            this.musteri.Location = new System.Drawing.Point(358, 12);
            this.musteri.Name = "musteri";
            this.musteri.Size = new System.Drawing.Size(212, 75);
            this.musteri.TabIndex = 0;
            this.musteri.Text = "MUSTERI ISLEMLER";
            this.musteri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.musteri.UseVisualStyleBackColor = true;
            this.musteri.Click += new System.EventHandler(this.btn_musteri);
            // 
            // button6
            // 
            this.button6.ImageKey = "iconfinder_Copy v2_27839.png";
            this.button6.ImageList = this.ımageList1;
            this.button6.Location = new System.Drawing.Point(358, 98);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(212, 82);
            this.button6.TabIndex = 1;
            this.button6.Text = "CALISAN ISLEMLER";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btn_calisan);
            // 
            // button7
            // 
            this.button7.ImageKey = "iconfinder_Next_27860.png";
            this.button7.ImageList = this.ımageList1;
            this.button7.Location = new System.Drawing.Point(36, 93);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(218, 87);
            this.button7.TabIndex = 2;
            this.button7.Text = "TEDARIKCI ISLEMLER";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btn_tedarik);
            // 
            // button8
            // 
            this.button8.ImageKey = "iconfinder_Edit_27845.png";
            this.button8.ImageList = this.ımageList1;
            this.button8.Location = new System.Drawing.Point(36, 12);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(218, 75);
            this.button8.TabIndex = 3;
            this.button8.Text = "URUNLER ISLEM";
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.btn_urunler);
            // 
            // button9
            // 
            this.button9.ImageKey = "iconfinder_Forward_27850.png";
            this.button9.ImageList = this.ımageList1;
            this.button9.Location = new System.Drawing.Point(36, 186);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(218, 79);
            this.button9.TabIndex = 4;
            this.button9.Text = "SIPARIS ISLEMLERI";
            this.button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.btn_siparis);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "iconfinder_User_27887.png");
            this.ımageList1.Images.SetKeyName(1, "iconfinder_Copy v2_27839.png");
            this.ımageList1.Images.SetKeyName(2, "iconfinder_Remove_27874.png");
            this.ımageList1.Images.SetKeyName(3, "iconfinder_Edit_27845.png");
            this.ımageList1.Images.SetKeyName(4, "iconfinder_Next_27860.png");
            this.ımageList1.Images.SetKeyName(5, "iconfinder_Log Out_27856.png");
            this.ımageList1.Images.SetKeyName(6, "iconfinder_Forward_27850.png");
            // 
            // button10
            // 
            this.button10.ImageKey = "iconfinder_Log Out_27856.png";
            this.button10.ImageList = this.ımageList1;
            this.button10.Location = new System.Drawing.Point(358, 186);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(212, 87);
            this.button10.TabIndex = 5;
            this.button10.Text = "CIKIS";
            this.button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Form1
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 446);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.musteri);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button musteri;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button10;
    }
}


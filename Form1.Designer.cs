namespace XML_Kullanımı_Ve_Döviz_Ofisi_Uygulaması
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ButtonDolarAlisKur = new System.Windows.Forms.Button();
            this.ButtonDolarSatisKur = new System.Windows.Forms.Button();
            this.ButtonEuroAlisKur = new System.Windows.Forms.Button();
            this.ButtonEuroSatisKur = new System.Windows.Forms.Button();
            this.LabelDolarAlis = new System.Windows.Forms.Label();
            this.LabelEuroAlis = new System.Windows.Forms.Label();
            this.LabelDolarSatis = new System.Windows.Forms.Label();
            this.LabelEuroSatis = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxKur = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMiktar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxToplam = new System.Windows.Forms.TextBox();
            this.ButtonDovizBoz = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OliveDrab;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dolar Alış: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Firebrick;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(197, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dolar Satış: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.OliveDrab;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(27, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Euro Alış: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Firebrick;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(201, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Euro Satış: ";
            // 
            // ButtonDolarAlisKur
            // 
            this.ButtonDolarAlisKur.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ButtonDolarAlisKur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonDolarAlisKur.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonDolarAlisKur.Location = new System.Drawing.Point(43, 161);
            this.ButtonDolarAlisKur.Name = "ButtonDolarAlisKur";
            this.ButtonDolarAlisKur.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonDolarAlisKur.Size = new System.Drawing.Size(164, 49);
            this.ButtonDolarAlisKur.TabIndex = 4;
            this.ButtonDolarAlisKur.Text = "$ Alış Kur";
            this.ButtonDolarAlisKur.UseMnemonic = false;
            this.ButtonDolarAlisKur.UseVisualStyleBackColor = false;
            this.ButtonDolarAlisKur.Click += new System.EventHandler(this.ButtonDolarAlisKur_Click);
            // 
            // ButtonDolarSatisKur
            // 
            this.ButtonDolarSatisKur.BackColor = System.Drawing.Color.Firebrick;
            this.ButtonDolarSatisKur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonDolarSatisKur.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonDolarSatisKur.Location = new System.Drawing.Point(43, 216);
            this.ButtonDolarSatisKur.Name = "ButtonDolarSatisKur";
            this.ButtonDolarSatisKur.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonDolarSatisKur.Size = new System.Drawing.Size(164, 49);
            this.ButtonDolarSatisKur.TabIndex = 5;
            this.ButtonDolarSatisKur.Text = "$ Satış Kur";
            this.ButtonDolarSatisKur.UseMnemonic = false;
            this.ButtonDolarSatisKur.UseVisualStyleBackColor = false;
            this.ButtonDolarSatisKur.Click += new System.EventHandler(this.ButtonDolarSatisKur_Click);
            // 
            // ButtonEuroAlisKur
            // 
            this.ButtonEuroAlisKur.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ButtonEuroAlisKur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonEuroAlisKur.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonEuroAlisKur.Location = new System.Drawing.Point(43, 271);
            this.ButtonEuroAlisKur.Name = "ButtonEuroAlisKur";
            this.ButtonEuroAlisKur.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonEuroAlisKur.Size = new System.Drawing.Size(164, 49);
            this.ButtonEuroAlisKur.TabIndex = 6;
            this.ButtonEuroAlisKur.Text = "€ Alış Kur";
            this.ButtonEuroAlisKur.UseMnemonic = false;
            this.ButtonEuroAlisKur.UseVisualStyleBackColor = false;
            this.ButtonEuroAlisKur.Click += new System.EventHandler(this.ButtonEuroAlisKur_Click);
            // 
            // ButtonEuroSatisKur
            // 
            this.ButtonEuroSatisKur.BackColor = System.Drawing.Color.Firebrick;
            this.ButtonEuroSatisKur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonEuroSatisKur.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonEuroSatisKur.Location = new System.Drawing.Point(43, 326);
            this.ButtonEuroSatisKur.Name = "ButtonEuroSatisKur";
            this.ButtonEuroSatisKur.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonEuroSatisKur.Size = new System.Drawing.Size(164, 49);
            this.ButtonEuroSatisKur.TabIndex = 7;
            this.ButtonEuroSatisKur.Text = "€ Satış Kur";
            this.ButtonEuroSatisKur.UseMnemonic = false;
            this.ButtonEuroSatisKur.UseVisualStyleBackColor = false;
            this.ButtonEuroSatisKur.Click += new System.EventHandler(this.ButtonEuroSatisKur_Click);
            // 
            // LabelDolarAlis
            // 
            this.LabelDolarAlis.AutoSize = true;
            this.LabelDolarAlis.BackColor = System.Drawing.Color.OliveDrab;
            this.LabelDolarAlis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelDolarAlis.Location = new System.Drawing.Point(113, 9);
            this.LabelDolarAlis.Name = "LabelDolarAlis";
            this.LabelDolarAlis.Size = new System.Drawing.Size(18, 20);
            this.LabelDolarAlis.TabIndex = 9;
            this.LabelDolarAlis.Text = "0";
            // 
            // LabelEuroAlis
            // 
            this.LabelEuroAlis.AutoSize = true;
            this.LabelEuroAlis.BackColor = System.Drawing.Color.OliveDrab;
            this.LabelEuroAlis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelEuroAlis.Location = new System.Drawing.Point(113, 38);
            this.LabelEuroAlis.Name = "LabelEuroAlis";
            this.LabelEuroAlis.Size = new System.Drawing.Size(18, 20);
            this.LabelEuroAlis.TabIndex = 10;
            this.LabelEuroAlis.Text = "0";
            // 
            // LabelDolarSatis
            // 
            this.LabelDolarSatis.AutoSize = true;
            this.LabelDolarSatis.BackColor = System.Drawing.Color.Firebrick;
            this.LabelDolarSatis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelDolarSatis.Location = new System.Drawing.Point(298, 9);
            this.LabelDolarSatis.Name = "LabelDolarSatis";
            this.LabelDolarSatis.Size = new System.Drawing.Size(18, 20);
            this.LabelDolarSatis.TabIndex = 11;
            this.LabelDolarSatis.Text = "0";
            // 
            // LabelEuroSatis
            // 
            this.LabelEuroSatis.AutoSize = true;
            this.LabelEuroSatis.BackColor = System.Drawing.Color.Firebrick;
            this.LabelEuroSatis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelEuroSatis.Location = new System.Drawing.Point(298, 38);
            this.LabelEuroSatis.Name = "LabelEuroSatis";
            this.LabelEuroSatis.Size = new System.Drawing.Size(18, 20);
            this.LabelEuroSatis.TabIndex = 12;
            this.LabelEuroSatis.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(38, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kur :";
            // 
            // textBoxKur
            // 
            this.textBoxKur.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxKur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxKur.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxKur.Location = new System.Drawing.Point(85, 40);
            this.textBoxKur.Name = "textBoxKur";
            this.textBoxKur.ReadOnly = true;
            this.textBoxKur.Size = new System.Drawing.Size(218, 19);
            this.textBoxKur.TabIndex = 10;
            this.textBoxKur.TextChanged += new System.EventHandler(this.textBoxKur_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(19, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Miktar :";
            // 
            // textBoxMiktar
            // 
            this.textBoxMiktar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxMiktar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMiktar.Location = new System.Drawing.Point(85, 65);
            this.textBoxMiktar.Name = "textBoxMiktar";
            this.textBoxMiktar.Size = new System.Drawing.Size(218, 19);
            this.textBoxMiktar.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(10, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Toplam :";
            // 
            // textBoxToplam
            // 
            this.textBoxToplam.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxToplam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxToplam.Location = new System.Drawing.Point(85, 90);
            this.textBoxToplam.Name = "textBoxToplam";
            this.textBoxToplam.Size = new System.Drawing.Size(218, 19);
            this.textBoxToplam.TabIndex = 14;
            // 
            // ButtonDovizBoz
            // 
            this.ButtonDovizBoz.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ButtonDovizBoz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDovizBoz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonDovizBoz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ButtonDovizBoz.ForeColor = System.Drawing.SystemColors.Info;
            this.ButtonDovizBoz.Location = new System.Drawing.Point(85, 132);
            this.ButtonDovizBoz.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonDovizBoz.Name = "ButtonDovizBoz";
            this.ButtonDovizBoz.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonDovizBoz.Size = new System.Drawing.Size(218, 36);
            this.ButtonDovizBoz.TabIndex = 9;
            this.ButtonDovizBoz.Text = "Döviz Boz";
            this.ButtonDovizBoz.UseMnemonic = false;
            this.ButtonDovizBoz.UseVisualStyleBackColor = false;
            this.ButtonDovizBoz.Click += new System.EventHandler(this.ButtonDovizBoz_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.ButtonDovizBoz);
            this.groupBox1.Controls.Add(this.textBoxToplam);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxMiktar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxKur);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(213, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 185);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(616, 457);
            this.Controls.Add(this.LabelEuroSatis);
            this.Controls.Add(this.LabelDolarSatis);
            this.Controls.Add(this.LabelEuroAlis);
            this.Controls.Add(this.LabelDolarAlis);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ButtonEuroSatisKur);
            this.Controls.Add(this.ButtonEuroAlisKur);
            this.Controls.Add(this.ButtonDolarSatisKur);
            this.Controls.Add(this.ButtonDolarAlisKur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DÖVİZ UYGULAMASI";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Form1_HelpButtonClicked);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ButtonDolarAlisKur;
        private System.Windows.Forms.Button ButtonDolarSatisKur;
        private System.Windows.Forms.Button ButtonEuroAlisKur;
        private System.Windows.Forms.Button ButtonEuroSatisKur;
        private System.Windows.Forms.Label LabelDolarAlis;
        private System.Windows.Forms.Label LabelEuroAlis;
        private System.Windows.Forms.Label LabelDolarSatis;
        private System.Windows.Forms.Label LabelEuroSatis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxKur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxMiktar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxToplam;
        private System.Windows.Forms.Button ButtonDovizBoz;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}


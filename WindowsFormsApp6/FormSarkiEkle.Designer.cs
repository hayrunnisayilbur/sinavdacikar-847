namespace WindowsFormsApp6
{
    partial class FormSarkiEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSarki = new System.Windows.Forms.TextBox();
            this.txtSanatci = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSure = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.cbFavori = new System.Windows.Forms.CheckBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şarkı Adı:";
            // 
            // txtSarki
            // 
            this.txtSarki.Location = new System.Drawing.Point(114, 39);
            this.txtSarki.Name = "txtSarki";
            this.txtSarki.Size = new System.Drawing.Size(129, 20);
            this.txtSarki.TabIndex = 1;
            // 
            // txtSanatci
            // 
            this.txtSanatci.Location = new System.Drawing.Point(114, 83);
            this.txtSanatci.Name = "txtSanatci";
            this.txtSanatci.Size = new System.Drawing.Size(129, 20);
            this.txtSanatci.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sanatçı Adı:";
            // 
            // txtYil
            // 
            this.txtYil.Location = new System.Drawing.Point(114, 128);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(129, 20);
            this.txtYil.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yılı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Türü:";
            // 
            // txtSure
            // 
            this.txtSure.Location = new System.Drawing.Point(375, 94);
            this.txtSure.Name = "txtSure";
            this.txtSure.Size = new System.Drawing.Size(129, 20);
            this.txtSure.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Süresi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Eklenme Tarihi";
            // 
            // cmbTur
            // 
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Location = new System.Drawing.Point(375, 57);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(129, 21);
            this.cmbTur.TabIndex = 13;
            // 
            // dtTarih
            // 
            this.dtTarih.Location = new System.Drawing.Point(375, 130);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(129, 20);
            this.dtTarih.TabIndex = 14;
            // 
            // cbFavori
            // 
            this.cbFavori.AutoSize = true;
            this.cbFavori.Location = new System.Drawing.Point(114, 171);
            this.cbFavori.Name = "cbFavori";
            this.cbFavori.Size = new System.Drawing.Size(55, 17);
            this.cbFavori.TabIndex = 15;
            this.cbFavori.Text = "Favori";
            this.cbFavori.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Cornsilk;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Image = global::WindowsFormsApp6.Properties.Resources._003_song;
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.Location = new System.Drawing.Point(167, 203);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(220, 66);
            this.btnEkle.TabIndex = 16;
            this.btnEkle.Text = "Şarkı Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // FormSarkiEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 291);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cbFavori);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.cmbTur);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSure);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtYil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSanatci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSarki);
            this.Controls.Add(this.label1);
            this.Name = "FormSarkiEkle";
            this.Text = "FormSarkiEkle";
            this.Load += new System.EventHandler(this.FormSarkiEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSarki;
        private System.Windows.Forms.TextBox txtSanatci;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSure;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.CheckBox cbFavori;
        private System.Windows.Forms.Button btnEkle;
    }
}
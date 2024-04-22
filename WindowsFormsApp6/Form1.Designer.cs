namespace WindowsFormsApp6
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
            this.btnEkleForm = new System.Windows.Forms.Button();
            this.btnListeForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEkleForm
            // 
            this.btnEkleForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkleForm.Image = global::WindowsFormsApp6.Properties.Resources._003_song;
            this.btnEkleForm.Location = new System.Drawing.Point(77, 78);
            this.btnEkleForm.Name = "btnEkleForm";
            this.btnEkleForm.Size = new System.Drawing.Size(91, 84);
            this.btnEkleForm.TabIndex = 0;
            this.btnEkleForm.UseVisualStyleBackColor = true;
            this.btnEkleForm.Click += new System.EventHandler(this.btnEkleForm_Click);
            // 
            // btnListeForm
            // 
            this.btnListeForm.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnListeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListeForm.Image = global::WindowsFormsApp6.Properties.Resources._002_music;
            this.btnListeForm.Location = new System.Drawing.Point(174, 78);
            this.btnListeForm.Name = "btnListeForm";
            this.btnListeForm.Size = new System.Drawing.Size(108, 84);
            this.btnListeForm.TabIndex = 1;
            this.btnListeForm.UseVisualStyleBackColor = false;
            this.btnListeForm.Click += new System.EventHandler(this.btnListeForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 240);
            this.Controls.Add(this.btnListeForm);
            this.Controls.Add(this.btnEkleForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEkleForm;
        private System.Windows.Forms.Button btnListeForm;
    }
}


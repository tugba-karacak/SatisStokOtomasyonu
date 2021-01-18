namespace TugbaProjesi
{
    partial class PersonelArayuz
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
            this.pnlSayfalar = new System.Windows.Forms.Panel();
            this.pnlAna = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlAna.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSayfalar
            // 
            this.pnlSayfalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSayfalar.Location = new System.Drawing.Point(0, 103);
            this.pnlSayfalar.Name = "pnlSayfalar";
            this.pnlSayfalar.Size = new System.Drawing.Size(920, 509);
            this.pnlSayfalar.TabIndex = 3;
            // 
            // pnlAna
            // 
            this.pnlAna.Controls.Add(this.button5);
            this.pnlAna.Controls.Add(this.button4);
            this.pnlAna.Controls.Add(this.button3);
            this.pnlAna.Controls.Add(this.button2);
            this.pnlAna.Controls.Add(this.button1);
            this.pnlAna.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAna.Location = new System.Drawing.Point(0, 0);
            this.pnlAna.Name = "pnlAna";
            this.pnlAna.Size = new System.Drawing.Size(920, 103);
            this.pnlAna.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(736, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(175, 79);
            this.button5.TabIndex = 4;
            this.button5.Text = "Yapılan İşlemler";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(555, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 79);
            this.button4.TabIndex = 3;
            this.button4.Text = "Aylık Gelir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(374, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 79);
            this.button3.TabIndex = 2;
            this.button3.Text = "Ürün İşlemleri";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(193, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 79);
            this.button2.TabIndex = 1;
            this.button2.Text = "Kategori İşlemleri";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 79);
            this.button1.TabIndex = 0;
            this.button1.Text = "Personel Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PersonelArayuz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 612);
            this.Controls.Add(this.pnlSayfalar);
            this.Controls.Add(this.pnlAna);
            this.Name = "PersonelArayuz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Arayüzü";
            this.Load += new System.EventHandler(this.PersonelArayuz_Load);
            this.pnlAna.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSayfalar;
        private System.Windows.Forms.Panel pnlAna;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}
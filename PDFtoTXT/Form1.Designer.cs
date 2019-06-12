namespace PDFtoTXT
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Wykonaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Zamknij = new System.Windows.Forms.Button();
            this.Wczytaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Wykonaj
            // 
            this.Wykonaj.Location = new System.Drawing.Point(45, 144);
            this.Wykonaj.Name = "Wykonaj";
            this.Wykonaj.Size = new System.Drawing.Size(75, 23);
            this.Wykonaj.TabIndex = 0;
            this.Wykonaj.Text = "Wykonaj";
            this.Wykonaj.UseVisualStyleBackColor = true;
            this.Wykonaj.Click += new System.EventHandler(this.Wykonaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Plik PDF";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Zamknij
            // 
            this.Zamknij.Location = new System.Drawing.Point(144, 144);
            this.Zamknij.Name = "Zamknij";
            this.Zamknij.Size = new System.Drawing.Size(75, 23);
            this.Zamknij.TabIndex = 3;
            this.Zamknij.Text = "Zamknij";
            this.Zamknij.UseVisualStyleBackColor = true;
            this.Zamknij.Click += new System.EventHandler(this.Zamknij_Click);
            // 
            // Wczytaj
            // 
            this.Wczytaj.Location = new System.Drawing.Point(217, 53);
            this.Wczytaj.Name = "Wczytaj";
            this.Wczytaj.Size = new System.Drawing.Size(26, 23);
            this.Wczytaj.TabIndex = 4;
            this.Wczytaj.Text = "...";
            this.Wczytaj.UseVisualStyleBackColor = true;
            this.Wczytaj.Click += new System.EventHandler(this.Wczytaj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Wczytaj);
            this.Controls.Add(this.Zamknij);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Wykonaj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Wykonaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Zamknij;
        private System.Windows.Forms.Button Wczytaj;
    }
}


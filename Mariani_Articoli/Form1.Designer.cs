﻿namespace Mariani_Articoli
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.alimentare = new System.Windows.Forms.RadioButton();
            this.nonAlimentare = new System.Windows.Forms.RadioButton();
            this.alimentareFresco = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(125, 79);
            this.maskedTextBox1.Mask = ">LLLLLLLL";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(72, 20);
            this.maskedTextBox1.TabIndex = 3;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(231, 79);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 4;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(337, 79);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox3.TabIndex = 5;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(443, 79);
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox4.TabIndex = 6;
            // 
            // alimentare
            // 
            this.alimentare.AutoSize = true;
            this.alimentare.Location = new System.Drawing.Point(116, 204);
            this.alimentare.Name = "alimentare";
            this.alimentare.Size = new System.Drawing.Size(117, 17);
            this.alimentare.TabIndex = 7;
            this.alimentare.TabStop = true;
            this.alimentare.Text = "Prodotto Alimentare";
            this.alimentare.UseVisualStyleBackColor = true;
            this.alimentare.CheckedChanged += new System.EventHandler(this.alimentare_CheckedChanged);
            // 
            // nonAlimentare
            // 
            this.nonAlimentare.AutoSize = true;
            this.nonAlimentare.Location = new System.Drawing.Point(116, 227);
            this.nonAlimentare.Name = "nonAlimentare";
            this.nonAlimentare.Size = new System.Drawing.Size(140, 17);
            this.nonAlimentare.TabIndex = 8;
            this.nonAlimentare.TabStop = true;
            this.nonAlimentare.Text = "Prodotto Non Alimentare";
            this.nonAlimentare.UseVisualStyleBackColor = true;
            // 
            // alimentareFresco
            // 
            this.alimentareFresco.AutoSize = true;
            this.alimentareFresco.Location = new System.Drawing.Point(267, 204);
            this.alimentareFresco.Name = "alimentareFresco";
            this.alimentareFresco.Size = new System.Drawing.Size(152, 17);
            this.alimentareFresco.TabIndex = 9;
            this.alimentareFresco.TabStop = true;
            this.alimentareFresco.Text = "Prodotto Alimentare Fresco";
            this.alimentareFresco.UseVisualStyleBackColor = true;
            this.alimentareFresco.Visible = false;
            this.alimentareFresco.CheckedChanged += new System.EventHandler(this.alimentareFresco_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Codice";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 440);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.alimentareFresco);
            this.Controls.Add(this.nonAlimentare);
            this.Controls.Add(this.alimentare);
            this.Controls.Add(this.maskedTextBox4);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.RadioButton alimentare;
        private System.Windows.Forms.RadioButton nonAlimentare;
        private System.Windows.Forms.RadioButton alimentareFresco;
        private System.Windows.Forms.Label label1;
    }
}


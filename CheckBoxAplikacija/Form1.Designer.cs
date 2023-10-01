namespace CheckBoxAplikacija
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
            this.textBoxOdabraliSte = new System.Windows.Forms.TextBox();
            this.checkBoxDorucak = new System.Windows.Forms.CheckBox();
            this.checkBoxRucak = new System.Windows.Forms.CheckBox();
            this.checkBoxVecera = new System.Windows.Forms.CheckBox();
            this.buttonPosalji = new System.Windows.Forms.Button();
            this.checkBoxSakrijNarudzbu = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBoxOdabraliSte
            // 
            this.textBoxOdabraliSte.Location = new System.Drawing.Point(164, 36);
            this.textBoxOdabraliSte.Multiline = true;
            this.textBoxOdabraliSte.Name = "textBoxOdabraliSte";
            this.textBoxOdabraliSte.Size = new System.Drawing.Size(180, 84);
            this.textBoxOdabraliSte.TabIndex = 0;
            this.textBoxOdabraliSte.Text = " ";
            this.textBoxOdabraliSte.TextChanged += new System.EventHandler(this.textBoxOdabraliSte_TextChanged);
            // 
            // checkBoxDorucak
            // 
            this.checkBoxDorucak.AutoSize = true;
            this.checkBoxDorucak.Location = new System.Drawing.Point(22, 38);
            this.checkBoxDorucak.Name = "checkBoxDorucak";
            this.checkBoxDorucak.Size = new System.Drawing.Size(67, 17);
            this.checkBoxDorucak.TabIndex = 1;
            this.checkBoxDorucak.Text = "Dorucak";
            this.checkBoxDorucak.UseVisualStyleBackColor = true;
            this.checkBoxDorucak.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxRucak
            // 
            this.checkBoxRucak.AutoSize = true;
            this.checkBoxRucak.Location = new System.Drawing.Point(22, 76);
            this.checkBoxRucak.Name = "checkBoxRucak";
            this.checkBoxRucak.Size = new System.Drawing.Size(58, 17);
            this.checkBoxRucak.TabIndex = 2;
            this.checkBoxRucak.Text = "Rucak";
            this.checkBoxRucak.UseVisualStyleBackColor = true;
            this.checkBoxRucak.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBoxVecera
            // 
            this.checkBoxVecera.AutoSize = true;
            this.checkBoxVecera.Location = new System.Drawing.Point(22, 114);
            this.checkBoxVecera.Name = "checkBoxVecera";
            this.checkBoxVecera.Size = new System.Drawing.Size(60, 17);
            this.checkBoxVecera.TabIndex = 3;
            this.checkBoxVecera.Text = "Vecera";
            this.checkBoxVecera.UseVisualStyleBackColor = true;
            // 
            // buttonPosalji
            // 
            this.buttonPosalji.Location = new System.Drawing.Point(22, 155);
            this.buttonPosalji.Name = "buttonPosalji";
            this.buttonPosalji.Size = new System.Drawing.Size(122, 38);
            this.buttonPosalji.TabIndex = 4;
            this.buttonPosalji.Text = "Posalji";
            this.buttonPosalji.UseVisualStyleBackColor = true;
            this.buttonPosalji.Click += new System.EventHandler(this.buttonPosalji_Click);
            // 
            // checkBoxSakrijNarudzbu
            // 
            this.checkBoxSakrijNarudzbu.AutoSize = true;
            this.checkBoxSakrijNarudzbu.Location = new System.Drawing.Point(164, 126);
            this.checkBoxSakrijNarudzbu.Name = "checkBoxSakrijNarudzbu";
            this.checkBoxSakrijNarudzbu.Size = new System.Drawing.Size(101, 17);
            this.checkBoxSakrijNarudzbu.TabIndex = 5;
            this.checkBoxSakrijNarudzbu.Text = "Sakrij Narudzbu";
            this.checkBoxSakrijNarudzbu.UseVisualStyleBackColor = true;
            this.checkBoxSakrijNarudzbu.CheckedChanged += new System.EventHandler(this.checkBoxSakrijNarudzbu_CheckedChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 212);
            this.Controls.Add(this.checkBoxSakrijNarudzbu);
            this.Controls.Add(this.buttonPosalji);
            this.Controls.Add(this.checkBoxVecera);
            this.Controls.Add(this.checkBoxRucak);
            this.Controls.Add(this.checkBoxDorucak);
            this.Controls.Add(this.textBoxOdabraliSte);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOdabraliSte;
        private System.Windows.Forms.CheckBox checkBoxDorucak;
        private System.Windows.Forms.CheckBox checkBoxRucak;
        private System.Windows.Forms.CheckBox checkBoxVecera;
        private System.Windows.Forms.Button buttonPosalji;
        private System.Windows.Forms.CheckBox checkBoxSakrijNarudzbu;
    }
}


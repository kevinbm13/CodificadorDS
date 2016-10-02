namespace Proyecto01
{
    partial class Proyecto
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
            this.boton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Algoritmo = new System.Windows.Forms.CheckedListBox();
            this.tiraInicial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Modo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // boton
            // 
            this.boton.Location = new System.Drawing.Point(105, 214);
            this.boton.Name = "boton";
            this.boton.Size = new System.Drawing.Size(75, 23);
            this.boton.TabIndex = 0;
            this.boton.Text = "Iniciar";
            this.boton.UseVisualStyleBackColor = true;
            this.boton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CODIFICACION Y DECODIFICACION";
            // 
            // Algoritmo
            // 
            this.Algoritmo.FormattingEnabled = true;
            this.Algoritmo.Items.AddRange(new object[] {
            "Clave",
            "Vigenere",
            "Transposición",
            "Telefónico"});
            this.Algoritmo.Location = new System.Drawing.Point(12, 67);
            this.Algoritmo.Name = "Algoritmo";
            this.Algoritmo.Size = new System.Drawing.Size(113, 64);
            this.Algoritmo.TabIndex = 2;
            this.Algoritmo.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // tiraInicial
            // 
            this.tiraInicial.Location = new System.Drawing.Point(158, 111);
            this.tiraInicial.Name = "tiraInicial";
            this.tiraInicial.Size = new System.Drawing.Size(100, 20);
            this.tiraInicial.TabIndex = 4;
            this.tiraInicial.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingrese texto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Modo
            // 
            this.Modo.FormattingEnabled = true;
            this.Modo.Items.AddRange(new object[] {
            "Codificar",
            "Decodificar"});
            this.Modo.Location = new System.Drawing.Point(12, 148);
            this.Modo.Name = "Modo";
            this.Modo.Size = new System.Drawing.Size(121, 21);
            this.Modo.TabIndex = 6;
            this.Modo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Proyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Modo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tiraInicial);
            this.Controls.Add(this.Algoritmo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boton);
            this.Name = "Proyecto";
            this.Text = "PROYECTO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox Algoritmo;
        private System.Windows.Forms.TextBox tiraInicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Modo;
    }
}
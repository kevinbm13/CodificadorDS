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
            this.Algoritmos = new System.Windows.Forms.CheckedListBox();
            this.Archivos = new System.Windows.Forms.CheckedListBox();
            this.Modo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.oracion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Boton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.VigenereLabel = new System.Windows.Forms.Label();
            this.claveVigenere = new System.Windows.Forms.TextBox();
            this.ClaveClave = new System.Windows.Forms.TextBox();
            this.ClaveLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Algoritmos
            // 
            this.Algoritmos.CheckOnClick = true;
            this.Algoritmos.FormattingEnabled = true;
            this.Algoritmos.Items.AddRange(new object[] {
            "Clave",
            "Vigenere",
            "Transposición",
            "Telefónico"});
            this.Algoritmos.Location = new System.Drawing.Point(12, 175);
            this.Algoritmos.Name = "Algoritmos";
            this.Algoritmos.Size = new System.Drawing.Size(96, 64);
            this.Algoritmos.TabIndex = 0;
            this.Algoritmos.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // Archivos
            // 
            this.Archivos.CheckOnClick = true;
            this.Archivos.FormattingEnabled = true;
            this.Archivos.Items.AddRange(new object[] {
            "XML",
            "TXT",
            "EXCEL"});
            this.Archivos.Location = new System.Drawing.Point(135, 175);
            this.Archivos.Name = "Archivos";
            this.Archivos.Size = new System.Drawing.Size(96, 64);
            this.Archivos.TabIndex = 1;
            this.Archivos.SelectedIndexChanged += new System.EventHandler(this.checkedListBox2_SelectedIndexChanged);
            // 
            // Modo
            // 
            this.Modo.FormattingEnabled = true;
            this.Modo.Items.AddRange(new object[] {
            "Codificar",
            "Decodificar"});
            this.Modo.Location = new System.Drawing.Point(237, 196);
            this.Modo.Name = "Modo";
            this.Modo.Size = new System.Drawing.Size(96, 21);
            this.Modo.TabIndex = 2;
            this.Modo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Algoritmo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Archivo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // oracion
            // 
            this.oracion.Location = new System.Drawing.Point(113, 82);
            this.oracion.Name = "oracion";
            this.oracion.Size = new System.Drawing.Size(209, 20);
            this.oracion.TabIndex = 5;
            this.oracion.TextChanged += new System.EventHandler(this.oracion_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ingresar Oración";
            // 
            // Boton
            // 
            this.Boton.Location = new System.Drawing.Point(258, 282);
            this.Boton.Name = "Boton";
            this.Boton.Size = new System.Drawing.Size(75, 23);
            this.Boton.TabIndex = 7;
            this.Boton.Text = "Ejecutar";
            this.Boton.UseVisualStyleBackColor = true;
            this.Boton.Click += new System.EventHandler(this.Boton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(7, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(355, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sistema de Codificación/Decodificación";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // VigenereLabel
            // 
            this.VigenereLabel.AutoSize = true;
            this.VigenereLabel.Location = new System.Drawing.Point(15, 269);
            this.VigenereLabel.Name = "VigenereLabel";
            this.VigenereLabel.Size = new System.Drawing.Size(79, 13);
            this.VigenereLabel.TabIndex = 9;
            this.VigenereLabel.Text = "Clave Vigenere";
            this.VigenereLabel.Visible = false;
            // 
            // claveVigenere
            // 
            this.claveVigenere.Location = new System.Drawing.Point(8, 285);
            this.claveVigenere.Name = "claveVigenere";
            this.claveVigenere.Size = new System.Drawing.Size(100, 20);
            this.claveVigenere.TabIndex = 10;
            this.claveVigenere.Visible = false;
            // 
            // ClaveClave
            // 
            this.ClaveClave.Location = new System.Drawing.Point(131, 285);
            this.ClaveClave.Name = "ClaveClave";
            this.ClaveClave.Size = new System.Drawing.Size(100, 20);
            this.ClaveClave.TabIndex = 11;
            this.ClaveClave.Visible = false;
            // 
            // ClaveLabel
            // 
            this.ClaveLabel.AutoSize = true;
            this.ClaveLabel.Location = new System.Drawing.Point(128, 269);
            this.ClaveLabel.Name = "ClaveLabel";
            this.ClaveLabel.Size = new System.Drawing.Size(110, 13);
            this.ClaveLabel.TabIndex = 12;
            this.ClaveLabel.Text = "Clave Algoritmo Clave";
            this.ClaveLabel.Visible = false;
            // 
            // Proyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 317);
            this.Controls.Add(this.ClaveLabel);
            this.Controls.Add(this.ClaveClave);
            this.Controls.Add(this.claveVigenere);
            this.Controls.Add(this.VigenereLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Boton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.oracion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Modo);
            this.Controls.Add(this.Archivos);
            this.Controls.Add(this.Algoritmos);
            this.Name = "Proyecto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyecto";
            this.Load += new System.EventHandler(this.Proyecto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox Algoritmos;
        private System.Windows.Forms.CheckedListBox Archivos;
        private System.Windows.Forms.ComboBox Modo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox oracion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Boton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label VigenereLabel;
        private System.Windows.Forms.TextBox claveVigenere;
        private System.Windows.Forms.TextBox ClaveClave;
        private System.Windows.Forms.Label ClaveLabel;
    }
}
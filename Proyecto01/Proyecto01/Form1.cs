using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto01
{
    public partial class Proyecto : Form
    {
        ControladorGui cgui;
        public Proyecto()
        {
            InitializeComponent();
            cgui = new Proyecto01.ControladorGui();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String p = "";

            foreach (String item in Algoritmos.CheckedItems)
            {
                if (item.ToString().Equals("Vigenere"))
                {
                    claveVigenere.Visible = true;
                    VigenereLabel.Visible = true;
                    
                }

                if (item.ToString().Equals("Clave"))
                {
                    ClaveLabel.Visible = true;
                    ClaveClave.Visible = true;
                }

                p = p + item.ToString()+" ";

            }
            if(p.Length > 0)
            {
                string sub = p.Substring(0, p.Length - 1);
                cgui.obtenerAlgoritmos(sub);
                Console.WriteLine(sub);
            }
            

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String arch= "";
            foreach (String item in Archivos.CheckedItems)
            {
                arch = arch + item.ToString().ToLower() + " ";

            }
            if (arch.Length > 0)
            {
                string sub = arch.Substring(0, arch.Length - 1);
                cgui.obtenerArchivos(sub);
                Console.WriteLine(sub);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String modoSeleccionado = Modo.SelectedItem.ToString();
            cgui.obtenerModo(modoSeleccionado);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void oracion_TextChanged(object sender, EventArgs e)
        {
            cgui.obtenerOracion(oracion.Text);
        }

        private void Boton_Click(object sender, EventArgs e)
        {
            foreach (String itemChecked in Algoritmos.CheckedItems)
            {
                
                if (itemChecked.ToString() == "Vigenere")
                {
                    
                    cgui.obtenerClave(claveVigenere.Text);
                    
                }

                if (itemChecked.ToString() == "Clave")
                {
                    
                    cgui.obtenerClave(ClaveClave.Text);
                    
                }
                
                cgui.ejecutar(itemChecked.ToString());
            }

            cgui.archivar();


        }

        private void Proyecto_Load(object sender, EventArgs e)
        {

        }
    }
}

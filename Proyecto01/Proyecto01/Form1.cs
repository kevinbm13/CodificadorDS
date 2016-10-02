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

            
            foreach (String itemChecked in Algoritmos.CheckedItems)
            {
               
                if (itemChecked.ToString() == "Vigenere")
                {
                    claveVigenere.Visible = true;
                    VigenereLabel.Visible = true;


                }

                if (itemChecked.ToString() == "Clave")
                {
                    ClaveLabel.Visible = true;
                    ClaveClave.Visible = true;


                }



                cgui.obtenerAlgoritmos(itemChecked.ToString());


            }
          

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {


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
        }

        private void Proyecto_Load(object sender, EventArgs e)
        {

        }
    }
}

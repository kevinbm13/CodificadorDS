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
        Dto dto = new Dto();
        public Proyecto()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (object itemChecked in Algoritmo.CheckedItems)
            {
                String texto = itemChecked.ToString() + " ";
                String[] oraciones = texto.Split(' ');//En el controlador??
                dto.TipoAlgoritmo = oraciones;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        

        

      

       
        

       

   

       
    }
}

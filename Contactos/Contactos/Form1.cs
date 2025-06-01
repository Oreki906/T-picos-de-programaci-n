using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Contactos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            nombre.Text = "";
            CorreoElectronico.Text = "";
            telefono.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(nombre.Text)&&!string.IsNullOrEmpty(CorreoElectronico.Text)&&!string.IsNullOrEmpty(telefono.Text))
            {
                string resultado = $"Nombre: {nombre.Text}, Correo: {CorreoElectronico.Text}, Numero: {telefono.Text}";
                listcontactos.Items.Add(resultado);
                MessageBox.Show("Contacto agregado");
            }
            else
            {
                MessageBox.Show("llena todos los datos");
            }
        }
      

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (listcontactos.SelectedIndex != -1)
            {
                listcontactos.Items.RemoveAt(listcontactos.SelectedIndex);
               
            }
            else
            {
                MessageBox.Show("por favor selecciona un contacto");
            }
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En este programa podras agregar contactos para poder gestionarlos");
        }
    }
}

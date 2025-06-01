using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;//conector para tener acceso al manejador de bases de datos
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace accesoAbasesDeDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearBD_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("");
            SqlCommand cmd = new SqlCommand();//para ejecutar comnados de base de datos 
            cmd.CommandText = "CREATE DATABASE ESCOLAR"; //funcion de cadenas 
            cmd.ExecuteNonQuery();

        }
    }
}

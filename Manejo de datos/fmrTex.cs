using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Manejo_de_datos
{
    public partial class fmrTex : Form
    {
        public fmrTex()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //prueba de conexion a base de datos
            string connectionString = "";
            MySqlConnection conn;
            try
            {
                connectionString = @"server=localhost;Database:SMIS071121;uid=root;pwd=usbw;SSL Mode=None";
                conn = new MySqlConnection(connectionString);
                conn.Open();
                MetroFramework.MetroMessageBox.Show(this, "Se establecio conexion!","conexion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception Ex)
            {
                MetroFramework.MetroMessageBox.Show(this, Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

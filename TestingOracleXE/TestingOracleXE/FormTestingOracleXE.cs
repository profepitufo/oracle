using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.OracleClient;

namespace TestingOracleXE
{
    public partial class FormTestingOracleXE : Form
    {
        public FormTestingOracleXE()
        {
            InitializeComponent();
        }

        private void ConectarAOracle_Click(object sender, EventArgs e)
        {
            string proveedor = "OraOLEDB.Oracle";
            string dbq = ServidorTextBox.Text + ":" + PuertoTextBox.Text + "/XE";
            string usuario = UsuarioTextBox.Text;
            string password = PassWordTextBox.Text;

            string cadenaConexion = "Provider = " + proveedor + ";" +
                                    " dbq = " + dbq + ";" + 
                                    " User Id = " + UsuarioTextBox.Text + ";" +
                                    " Password = " + PassWordTextBox.Text + ";";

            OleDbConnection connection = new OleDbConnection(cadenaConexion);
            try
            {
                connection.Open();
                MessageBox.Show("Conectado a Oracle XE");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
            connection.Close();





        }
    }
}

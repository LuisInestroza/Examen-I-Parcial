using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Agregar el namespace para realizar la conexion a la base de datos SQL SERVER
using System.Data.SqlClient;

namespace ExamenPOO
{
    public partial class frmReseñaAnalisis : Form
    {
        // Crear la conexion a la base de datos 
        SqlConnection conn = new SqlConnection(@"server = (local)/sqlexpress; integrated security = true; database = AdventureWorks2014");

        public frmReseñaAnalisis()
        {
            InitializeComponent();
        }

        private void frmReseñaAnalisis_Load(object sender, EventArgs e)
        {
            // Crear el query de Select

            string sqlSel = @"SELECT Name, FinishedGoodsFlag  FROM Production.Product";

            // Crear el comando de ejecucion
            SqlCommand cmd = new SqlCommand(sqlSel, conn);

            try
            {
                // Abrir la conexion 
                conn.Open();

                // Realizar un SqlReader para mostrar los datos

                SqlDataReader rd = cmd.ExecuteReader();

                // Listar los productos
                while (rd.Read())
                {
                    lbxItems.Items.Add(rd[0] + "\t" + rd[1]);
                }
            }
            catch(SqlException exe)
            {
                MessageBox.Show(exe.Message + exe.StackTrace, "Detalles de la exepcion");
            }
            finally
            {
                // Cerrar la conexion
                conn.Close();
            }

        }
    }
}

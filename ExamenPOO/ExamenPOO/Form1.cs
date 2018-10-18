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
        SqlConnection conn = new SqlConnection(@"server = (local)\sqlexpress; integrated security = true; database = AdventureWorks2014");

        public frmReseñaAnalisis()
        {
            InitializeComponent();
        }

        private void frmReseñaAnalisis_Load(object sender, EventArgs e)
        {
            // Crear el query de Select
            // En el campo FinishedGoodsFlag solo se mostrara los valores de '1'
            string sqlSel = @"SELECT Name, FinishedGoodsFlag = '1' FROM Production.Product";

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
                    // Listar los campos Name y FinishedGoodsFlag
                    lbxProductos.Items.Add(rd[0] + "\t" + rd[1]);
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

        private void btnAceptarInsertarDatos_Click(object sender, EventArgs e)
        {
            // Crear el query de Insert
            string sqlIns = @"INSERT INTO Production.ProductReview(ProductID, ReviewerName, EmailAddress, Rating, Comments) VALUES(@IdProduct, @NameProduct, @Email, @rating, @comments)";

            // Crear el comando de ejecucion
            SqlCommand cmd = new SqlCommand(sqlIns, conn);

            try
            {
                // Abrir la conexion
                conn.Open();

                using (cmd)
                {
                    // Paramametros para la insercion
                    cmd.Parameters.Add("@IdProduct", SqlDbType.Int).Value = lbxProductos.SelectedItem.ToString();
                    cmd.Parameters.Add("@NameProduct", SqlDbType.NVarChar).Value = txtNombreCompleto.Text;
                    cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = txtCorreoElectronico.Text;
                    cmd.Parameters.Add("@rating", SqlDbType.Int).Value = Convert.ToInt16(txtValoracion.Text);
                    cmd.Parameters.Add("@comments", SqlDbType.NVarChar).Value = txtComantarios.Text;

                   
                 
                }
            }
            catch(SqlException exe)
            {
                MessageBox.Show(exe.Message + exe.StackTrace, "Detalles de exepcion");
            }
            finally
            {
                // Cerrar la conexion
                conn.Close();
            }
          

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario
            this.Close();
        }
    }
}

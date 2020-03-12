using capaDatos;
using System;
using System.Windows.Forms;

namespace Nuevo_InSiPo.Interfaces
{
    public partial class frBienvenida : Form
    {
        public frBienvenida()

        {
            InitializeComponent();
        }

        private void frBienvenida_Load(object sender, EventArgs e)
        {
            timer1.Start();
            txtPruebaConexion.Text = "Probando conexion a la base de datos...";
            try
            {
                conexionBD.mySqlConexion.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un problema al intentar conectar con la base de datos. " + ex + " // " + conexionBD.mySqlConexion.ConnectionString);
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            conexionBD.mySqlConexion.Close();
            txtPruebaConexion.Text = "Conexion exitosa.";
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            frPrincipal frPrincipal = new frPrincipal();
            frPrincipal.Show();
            this.Hide();
            timer2.Stop();
        }
    }
}

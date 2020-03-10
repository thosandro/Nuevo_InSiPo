using capaNegocio;
using System;
using System.Windows.Forms;

namespace Nuevo_InSiPo.Interfaces._02_Parte_Diario
{
    public partial class frNovedades : Form
    {
        public frNovedades()
        {
            InitializeComponent();
        }

        private void frNovedades_Load(object sender, EventArgs e)
        {
            N_Novedades objNegocio = new N_Novedades();
            dgNovedades.DataSource = objNegocio.listarNovedades("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbDesde.Text = dateDesde.Text;
            lbHasta.Text = dateHasta.Text;
        }

        /* FUNCIONES LOCALES */


    }
}

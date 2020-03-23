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

        N_Novedades objNegocio = new N_Novedades();
        private void frNovedades_Load(object sender, EventArgs e)
        {
            dgNovedades.DataSource = objNegocio.listarNovedadesEntreFechas(dateFechaInicial.Value,dateFechaFinal.Value);
        }

        private void btFiltroFecha_Click(object sender, EventArgs e)
        {
            dgNovedades.DataSource = "";
            dgNovedades.DataSource = objNegocio.listarNovedadesEntreFechas(dateFechaInicial.Value, dateFechaFinal.Value);
        }

        /* FUNCIONES LOCALES */


    }
}

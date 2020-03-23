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
            FXL_editarDataGrid();
        }

        private void btFiltroFecha_Click(object sender, EventArgs e)
        {
            dgNovedades.DataSource = "";
            dgNovedades.DataSource = objNegocio.listarNovedadesEntreFechas(dateFechaInicial.Value, dateFechaFinal.Value);
            FXL_editarDataGrid();
        }

        /* FUNCIONES LOCALES */
        private void FXL_editarDataGrid()
        {
            dgNovedades.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgNovedades.Columns[0].Visible = false;
            dgNovedades.Columns["id"].Visible = false;
            dgNovedades.Columns["idEquipo"].Visible = false;
            dgNovedades.Columns["idMotivo"].Visible = false;
            dgNovedades.Columns["idResponsable"].Visible = false;
            dgNovedades.Columns["ap"].Visible = false;
            dgNovedades.Columns["codificacionSistema"].Visible = false;
            dgNovedades.Columns["codificacionEquipo"].Visible = false;

            dgNovedades.Columns["fecha"].DisplayIndex = 1;
            dgNovedades.Columns["fecha"].Width = 110;
            dgNovedades.Columns["fecha"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgNovedades.Columns["codificacionET"].DisplayIndex = 2;
            dgNovedades.Columns["codificacionET"].HeaderText = "ET";
            dgNovedades.Columns["codificacionET"].Width = 40;

            dgNovedades.Columns["nivelTension"].DisplayIndex = 3;
            dgNovedades.Columns["nivelTension"].HeaderText = "Tensión";
            dgNovedades.Columns["nivelTension"].Width = 50;

            dgNovedades.Columns["nombreCampo"].DisplayIndex = 4;
            dgNovedades.Columns["nombreCampo"].HeaderText = "Campo";
            dgNovedades.Columns["nombreCampo"].Width = 190;

            dgNovedades.Columns["ens"].DisplayIndex = 5;
            dgNovedades.Columns["ens"].Width = 20;

            dgNovedades.Columns["descripcion"].DisplayIndex = 6;
            dgNovedades.Columns["descripcion"].HeaderText = "Descripción";
            dgNovedades.Columns["descripcion"].Width = 190;

            dgNovedades.Columns["actuaciones"].DisplayIndex = 7;
            dgNovedades.Columns["actuaciones"].Width = 190;

            dgNovedades.Columns["responsable"].DisplayIndex = 8;
            dgNovedades.Columns["responsable"].Width = 110;

            dgNovedades.Columns["motivo"].DisplayIndex = 9;
            dgNovedades.Columns["motivo"].Width = 140;

            dgNovedades.Columns["observaciones"].DisplayIndex = 10;
            dgNovedades.Columns["observaciones"].Width = 190;



        }
    }
}

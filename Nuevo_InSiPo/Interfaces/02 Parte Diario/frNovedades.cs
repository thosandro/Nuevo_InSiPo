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
        private void opcTurnoNoche_CheckedChanged(object sender, EventArgs e)
        {
            if (opcTurnoNoche.Checked == true)
            {
                DateTime ayer = new DateTime();
                DateTime hoy = new DateTime();

                //Fecha inicial
                ayer = DateTime.Now.AddDays(-1);
                string fechaInicio = ayer.Year.ToString() + "/" + ayer.Month.ToString() + "/" + ayer.Day.ToString() + " 23:00:00";

                ////Fecha final
                hoy = DateTime.Now;
                string fechaFinal = hoy.Year.ToString() + "/" + hoy.Month.ToString() + "/" + hoy.Day.ToString() + " 07:00:00";

                dgNovedades.DataSource = objNegocio.listarNovedadesEntreFechas(Convert.ToDateTime(fechaInicio), Convert.ToDateTime(fechaFinal));
            }
        }

        private void opcTurnoManiana_CheckedChanged(object sender, EventArgs e)
        {
            if (opcTurnoManiana.Checked == true)
            {
                DateTime hoy = new DateTime();
                hoy = DateTime.Now;

                //Fecha inicial
                string fechaInicio = hoy.Year.ToString() + "/" + hoy.Month.ToString() + "/" + hoy.Day.ToString() + " 07:00:00";

                ////Fecha final
                string fechaFinal = hoy.Year.ToString() + "/" + hoy.Month.ToString() + "/" + hoy.Day.ToString() + " 15:00:00";

                dgNovedades.DataSource = objNegocio.listarNovedadesEntreFechas(Convert.ToDateTime(fechaInicio), Convert.ToDateTime(fechaFinal));
            }
        }

        private void opcTurnoTarde_CheckedChanged(object sender, EventArgs e)
        {
            if (opcTurnoTarde.Checked == true)
            {
                DateTime hoy = new DateTime();
                hoy = DateTime.Now;

                //Fecha inicial
                string fechaInicio = hoy.Year.ToString() + "/" + hoy.Month.ToString() + "/" + hoy.Day.ToString() + " 15:00:00";

                ////Fecha final
                string fechaFinal = hoy.Year.ToString() + "/" + hoy.Month.ToString() + "/" + hoy.Day.ToString() + " 23:00:00";

                dgNovedades.DataSource = objNegocio.listarNovedadesEntreFechas(Convert.ToDateTime(fechaInicio), Convert.ToDateTime(fechaFinal));
            }
        }

        /* FUNCIONES PROPIAS */
        /*********************/
        private void FXL_editarDataGrid()
        {
            dgNovedades.DefaultCellStyle.WrapMode = DataGridViewTriState.True; //Ajuste de texto en las celdas

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
            dgNovedades.Columns["codificacionET"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgNovedades.Columns["nivelTension"].DisplayIndex = 3;
            dgNovedades.Columns["nivelTension"].HeaderText = "KV";
            dgNovedades.Columns["nivelTension"].Width = 40;
            dgNovedades.Columns["nivelTension"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgNovedades.Columns["nombreCampo"].DisplayIndex = 4;
            dgNovedades.Columns["nombreCampo"].HeaderText = "Campo";
            dgNovedades.Columns["nombreCampo"].Width = 190;

            dgNovedades.Columns["ens"].DisplayIndex = 5;
            dgNovedades.Columns["ens"].Width = 30;
            dgNovedades.Columns["ens"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

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
            dgNovedades.Columns["observaciones"].Width = 215;
        }

        private void frNovedades_Resize(object sender, EventArgs e)
        {
            opcDiaCompleto.Text = this.Width.ToString();
            dgNovedades.Size = new System.Drawing.Size(this.Width, this.Height - 220);
        }
    }
}

using capaEntidades;
using capaNegocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.Types;

namespace Nuevo_InSiPo.Interfaces
{
    public partial class frCargaNovedes : Form
    {
        public frCargaNovedes()
        {
            InitializeComponent();
        }

        //Posicion por defecto de groupFallas y groupGral
        Point posicion = new Point();

        private void frCargaNovedes_Load(object sender, EventArgs e)
        {
            posicion = new Point(groupGeneral.Location.X, groupGeneral.Location.Y);

            FXL_comboBoxEETT();
            cbET.SelectedIndex = -1;

            FXL_comboboxMotivos();
            cbMotivo.SelectedIndex = -1;

            FXL_comboboxResponsables();
            cbResponsable.SelectedIndex = -1;

            cbEquipo.SelectedIndex = -1;
        }

        #region CONTROLES ACTIVOS
        private void cbET_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbEquipo.SelectedIndex = -1;
        }

        private void cbET_TextChanged(object sender, EventArgs e)
        {
            if (cbET.Text == "")
                txtNombreET.Visible = false;
            else if (cbET.Text != "")
                txtNombreET.Visible = true;
        }

        private void cbET_Leave(object sender, EventArgs e)
        {
            cbET.Text = cbET.Text.ToUpper();

            //Generar el listado de los equipos asociados a la ET
            FXL_comboBoxEquipo();

            if (cbEquipo.Text == "")
            {
                txtDescripcionEquipo.Visible = false;
                cbEquipo.SelectedIndex = -1;
            }
            else if (cbEquipo.Text != "")
                txtDescripcionEquipo.Visible = true;
        }

        private void cbEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //FXL_comboBoxEquipo();

            if (cbEquipo.Text == "")
            {
                txtDescripcionEquipo.Visible = false;
                cbEquipo.SelectedIndex = -1;
            }
            else if (cbEquipo.Text != "")
                txtDescripcionEquipo.Visible = true;
        }

        private void txtTipoEquipo_TextChanged(object sender, EventArgs e)
        {
            txtDescripcionEquipo.Text = txtTipoEquipo.Text + " " + txtNivelTension.Text + " kV - " + txtNombreCampo.Text;
        }

        private void cbMotivo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbMotivo_TextChanged(object sender, EventArgs e)
        {
            switch (cbMotivo.Text)
            {
                case "":
                    txtMotivo.Visible = false;
                    FXL_ocultarTodo();
                    FXL_ocultarActuaciones();
                    break;
                case "FALLA":
                    txtMotivo.Visible = true;
                    FXL_descripcionFalla();
                    break;
                default:
                    txtMotivo.Visible = true;
                    FXL_descripcionGral();
                    FXL_ocultarActuaciones();
                    break;
            }
        }

        private void cbMotivo_Leave(object sender, EventArgs e)
        {

        }

        #endregion

        #region OPCIONES GRUPO DESCRIPCIÓN FALLAS
        private void opcDisparo_CheckedChanged(object sender, EventArgs e)
        {
            FXL_logicaDescripcionFalla();

            if (opcDisparo.Checked == true)
                FXL_mostrarActuaciones();
            else if (opcDisparo.Checked == false)
                FXL_ocultarActuaciones();
        }

        private void opcRecierrePositivo_CheckedChanged(object sender, EventArgs e)
        {
            FXL_logicaDescripcionFalla();

            if (opcRecierrePositivo.Checked == true)
                FXL_mostrarActuaciones();
            else if (opcRecierrePositivo.Checked == false)
                FXL_ocultarActuaciones();
        }

        private void opcRecierreNegativo_CheckedChanged(object sender, EventArgs e)
        {
            FXL_logicaDescripcionFalla();

            if (opcRecierreNegativo.Checked == true)
                FXL_mostrarActuaciones();
            else if (opcRecierreNegativo.Checked == false)
                FXL_ocultarActuaciones();
        }

        private void opcCierreFalla_CheckedChanged(object sender, EventArgs e)
        {
            FXL_logicaDescripcionFalla();

            FXL_ocultarActuaciones();
        }

        private void opcCierreNegativo_CheckedChanged(object sender, EventArgs e)
        {
            FXL_logicaDescripcionFalla();

            FXL_ocultarActuaciones();
        }

        private void opcApuFalla_CheckedChanged(object sender, EventArgs e)
        {
            FXL_logicaDescripcionFalla();
        }
        #endregion

        #region OPCIONES GRUPO DESCRIPCIÓN GENERAL
        private void opcApertura_CheckedChanged(object sender, EventArgs e)
        {
            FXL_logicaDescripcionGral();
        }

        private void opcCierre_CheckedChanged(object sender, EventArgs e)
        {
            FXL_logicaDescripcionGral();
        }

        private void opcApu_CheckedChanged(object sender, EventArgs e)
        {
            FXL_logicaDescripcionGral();
        }
        #endregion

        #region OPCIONES GRUPO ACTUACIONES
        private void opcIfase_CheckedChanged(object sender, EventArgs e)
        {
            FXL_logicaDeCorrientes();
        }

        private void opcItierra_CheckedChanged(object sender, EventArgs e)
        {
            FXL_logicaDeCorrientes();
        }

        private void opcTemporizada_CheckedChanged(object sender, EventArgs e)
        {
            FXL_logicaDeCorrientes();
        }

        private void opcImpedancia_CheckedChanged(object sender, EventArgs e)
        {
            if (opcImpedancia.Checked == true)
            {
                opcIfase.Enabled = false;
                opcItierra.Enabled = false;

                opcFaseR.Visible = true;
                opcFaseS.Visible = true;
                opcFaseT.Visible = true;
                opcFaseE.Visible = true;

                opcCuba.Enabled = false;
                opcBuchoolz.Enabled = false;
                FXL_logicaImpedancia();
            }
            if (opcImpedancia.Checked == false)
            {
                FXL_habilitarActuaciones();
                txtActuaciones.Text = "";
            }
        }

        private void opcFaseR_CheckedChanged(object sender, EventArgs e)
        {
            FXL_logicaImpedancia();
        }

        private void opcFaseS_CheckedChanged(object sender, EventArgs e)
        {
            FXL_logicaImpedancia();
        }

        private void opcFaseT_CheckedChanged(object sender, EventArgs e)
        {
            FXL_logicaImpedancia();
        }

        private void opcFaseE_CheckedChanged(object sender, EventArgs e)
        {
            FXL_logicaImpedancia();
        }

        private void opcCuba_CheckedChanged(object sender, EventArgs e)
        {
            FXL_logicaCubauchholz();
        }

        private void opcBuchoolz_CheckedChanged(object sender, EventArgs e)
        {
            FXL_logicaCubauchholz();
        }
        #endregion

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            E_Novedades objEntidad = new E_Novedades();

            //MySqlDateTime dateTime = new MySqlDateTime(txtFechaHora.Text);
            objEntidad.Fecha = Convert.ToDateTime(txtFechaHora.Text);
            objEntidad.IdEquipo = Convert.ToInt32(txtIdEquipo.Text.Trim());
            //objEntidad.ET = cbET.Text.Trim();
            //objEntidad.NombreCampo = txtNombreCampo.Text.Trim();
            //objEntidad.CodificacionEquipo = cbEquipo.Text.Trim();
            objEntidad.IdMotivo = Convert.ToInt32(txtIdMotivo.Text.Trim());
            objEntidad.IdResponsable = Convert.ToInt32(txtIdResponsable.Text.Trim());
            objEntidad.Ens = cbCorte.Text;
            objEntidad.Ap = Convert.ToInt32(txtAP.Text);
            objEntidad.Descripcion = txtDescripcion.Text.Trim();
            objEntidad.Actuaciones = txtActuaciones.Text.Trim();
            objEntidad.Observaciones = txtObservaciones.Text.Trim();

            try
            {
                N_Novedades objNegocio = new N_Novedades();
                objNegocio.agregarNovedad(objEntidad);

                DialogResult result = MessageBox.Show("¿Continuar con la misma ET?", "Continuar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                    FXL_limpiarCampos(true);
                else if (result == DialogResult.No)
                    FXL_limpiarCampos(false);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un problema al intentar guardar. \n \n" + ex);
            }
        }


        /* FUNCIONES PROPIAS */
        /*********************/

        private void FXL_limpiarCampos(bool continuaET)
        {
            if (opcMantenerFecha.Checked == false)
                txtFechaHora.Text = "";
            else
                txtFechaHora.Text = txtFechaHora.Text.Substring(0, 8);

            if (continuaET == false)
                cbET.SelectedIndex = -1;
    
            cbEquipo.SelectedIndex = -1;
            cbMotivo.SelectedIndex = -1;
            cbResponsable.SelectedIndex = -1;
            cbCorte.SelectedIndex = -1;
            txtObservaciones.Text = "";

            FXL_ocultarTodo();

            txtFechaHora.Focus();
        }
        private void FXL_comboBoxEETT()
        {
            N_EETT objNegocio = new N_EETT();
            List<E_EETT> listaEETT = new List<E_EETT>();
            listaEETT = objNegocio.listarEETT("");
            cbET.Items.Clear();

            cbET.DataSource = listaEETT;
            cbET.DisplayMember = "codificacion";

            txtNombreET.DataBindings.Clear();
            txtNombreET.DataBindings.Add("Text", listaEETT, "nombreCompleto");
            

            //Autocompletado
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (E_EETT ET in listaEETT)
                coleccion.Add(ET.Codificacion);
            cbET.AutoCompleteCustomSource = coleccion;
            cbET.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbET.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void FXL_comboBoxEquipo()
        {
            N_Equipos objNegocio = new N_Equipos();
            List<E_Equipos> listaEquipos = new List<E_Equipos>();
            listaEquipos = objNegocio.listarEquiposParaCargaNovedades(cbET.Text, "");

            cbEquipo.DataSource = listaEquipos;
            cbEquipo.DisplayMember = "codificacion";

            txtTipoEquipo.DataBindings.Clear();
            txtNivelTension.DataBindings.Clear();
            txtNombreCampo.DataBindings.Clear();
            txtIdEquipo.DataBindings.Clear();

            txtTipoEquipo.DataBindings.Add("Text", listaEquipos, "tipoDeEquipo");
            txtNivelTension.DataBindings.Add("Text", listaEquipos, "nivelTension");
            txtNombreCampo.DataBindings.Add("Text", listaEquipos, "nombreCampo");
            txtIdEquipo.DataBindings.Add("Text", listaEquipos, "id");
        }

        private void FXL_comboboxMotivos()
        {
            N_Motivos objNegocio = new N_Motivos();
            List<E_Motivos> listaMotivos = new List<E_Motivos>();
            listaMotivos = objNegocio.listarMotivos();// ("");
            cbMotivo.Items.Clear();

            cbMotivo.DataSource = listaMotivos;
            cbMotivo.DisplayMember = "codificacion";

            txtMotivo.DataBindings.Clear();
            txtIdMotivo.DataBindings.Clear();

            txtMotivo.DataBindings.Add("Text", listaMotivos, "motivo");
            txtIdMotivo.DataBindings.Add("Text", listaMotivos, "id");

            //Autocompletado
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (E_Motivos motivos in listaMotivos)
                coleccion.Add(motivos.Codificacion);
            cbMotivo.AutoCompleteCustomSource = coleccion;
            cbMotivo.AutoCompleteMode = AutoCompleteMode.Append;
            cbMotivo.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void FXL_comboboxResponsables()
        {
            N_Responsables objNegocio = new N_Responsables();
            List<E_Responsables> listaResponsables = new List<E_Responsables>();
            listaResponsables = objNegocio.listarResponsables();
            cbResponsable.Items.Clear();

            cbResponsable.DataSource = listaResponsables;
            cbResponsable.DisplayMember = "responsable";

            txtIdResponsable.DataBindings.Clear();
            txtIdResponsable.DataBindings.Add("Text", listaResponsables, "id");

            //Autocompletado
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (E_Responsables responsable in listaResponsables)
                coleccion.Add(responsable.Responsable);
            cbResponsable.AutoCompleteCustomSource = coleccion;
            cbResponsable.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbResponsable.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void FXL_descripcionFalla()
        {
            groupFalla.Visible = true;
            groupFalla.Location = posicion;
            groupGeneral.Visible = false;
            txtDescripcion.Visible = true;
            txtDescripcion.Text = "";

            txtMotivo.Visible = true;
        }

        private void FXL_descripcionGral()
        {
            groupFalla.Visible = false;
            groupGeneral.Visible = true;
            groupGeneral.Location = posicion;
            txtDescripcion.Visible = true;
            txtDescripcion.Text = "";

            txtMotivo.Visible = true;
        }

        private void FXL_ocultarActuaciones()
        {
            groupActuaciones.Visible = false;
            txtActuaciones.Visible = false;
            //this.Height = 468;
            //btnGuardar.Location = new Point(519, 380);
        }

        private void FXL_ocultarTodo()
        {
            groupFalla.Visible = false;
            groupGeneral.Visible = false;
            txtDescripcion.Visible = false;
        }

        private void FXL_mostrarActuaciones()
        {
            groupActuaciones.Visible = true;
            txtActuaciones.Visible = true;
        }

        private void FXL_habilitarActuaciones()
        {
            bool t = true;
            bool f = false;
            opcIfase.Enabled = t;
            opcIfase.Checked = f;

            opcItierra.Enabled = t;
            opcItierra.Checked = f;

            opcTemporizada.Visible = f;
            opcTemporizada.Checked = f;

            opcImpedancia.Enabled = t;
            opcImpedancia.Checked = f;
            opcFaseR.Visible = f;
            opcFaseR.Checked = f;
            opcFaseS.Visible = f;
            opcFaseS.Checked = f;
            opcFaseT.Visible = f;
            opcFaseT.Checked = f;
            opcFaseE.Visible = f;
            opcFaseE.Checked = f;

            opcCuba.Enabled = t;
            opcCuba.Checked = f;

            opcBuchoolz.Enabled = t;
            opcBuchoolz.Checked = f;
        }

        private void FXL_logicaDescripcionFalla()
        {
            if (opcDisparo.Checked == true)
            {
                txtDescripcion.Text = txtDescripcion.Text = "Disparo por protecciones.";
                txtAP.Text = "1";
                opcApuFalla.Enabled = false;
            }

            if (opcRecierreNegativo.Checked == true)
            {
                txtDescripcion.Text = "Disparo por protecciones. Opera recierre NEGATIVO.";
                txtAP.Text = "2";
                opcApuFalla.Enabled = false;
            }

            if (opcRecierrePositivo.Checked == true)
            {
                txtDescripcion.Text = "Disparo por protecciones. Opera recierre EXITOSO.";
                txtAP.Text = "1";
                opcApuFalla.Enabled = false;
            }

            if (opcCierreFalla.Checked == true)
            {
                txtDescripcion.Text = "Se cierra " + txtTipoEquipo.Text;
                txtAP.Text = "0";
                opcApuFalla.Enabled = true;

                if (opcApuFalla.Checked == true)
                    txtDescripcion.Text += " A pedido del usuario.";
                else if (opcApuFalla.Checked == false)
                    return;
            }

            if (opcCierreNegativo.Checked)
            {
                txtDescripcion.Text = "Intento de reposición negativo.";
                txtAP.Text = "1";
                opcApuFalla.Enabled = true;

                if (opcApuFalla.Checked == true)
                    txtDescripcion.Text += " A pedido del usuario.";
                else if (opcApuFalla.Checked == false)
                    return;
            }
        }

        private void FXL_logicaDescripcionGral()
        {
            if (opcApertura.Checked == true)
            {
                switch (cbMotivo.Text)
                {
                    case "CAAC":
                        txtDescripcion.Text = "Se abre " + txtTipoEquipo.Text + " para cambio de aceite.";
                        break;
                    case "ERROR":
                        txtDescripcion.Text = "Se abre " + txtTipoEquipo.Text + " por error operativo.";
                        break;
                    case "MANOP":
                        txtDescripcion.Text = "Se abre " + txtTipoEquipo.Text + " por maniobra operativa.";
                        break;
                    case "MAPRO":
                        txtDescripcion.Text = "Se abre " + txtTipoEquipo.Text + " por mantenimiento programado.";
                        break;
                    case "MINFR":
                        txtDescripcion.Text = "Disparo " + txtTipoEquipo.Text + " por mínima frecuencia.";
                        break;
                    case "RESCA":
                        txtDescripcion.Text = "Se abre " + txtTipoEquipo.Text + " por restricción de carga.";
                        break;
                    case "SVPF":
                        txtDescripcion.Text = "Sin tensión por falla. Se abre " + txtTipoEquipo.Text;
                        break;
                    default:
                        txtDescripcion.Text = "Se abre " + txtTipoEquipo.Text;
                        break;
                }

                txtAP.Text = "0";

                if (opcApu.Checked == true)
                    txtDescripcion.Text += " A pedido del usuario.";
                else if (opcApu.Checked == false)
                    return;
            }

            if (opcCierre.Checked == true)
            {
                switch (cbMotivo.Text)
                {
                    case "CAAC":
                        txtDescripcion.Text = "Se cierra " + txtTipoEquipo.Text + " por fin cambio de aceite.";
                        break;
                    case "MANOP":
                        txtDescripcion.Text = "Se cierra " + txtTipoEquipo.Text + " por maniobra operativa.";
                        break;
                    case "MAPRO":
                        txtDescripcion.Text = "Se cierra " + txtTipoEquipo.Text + " por fin mantenimiento programado.";
                        break;
                    case "MINFR":
                        txtDescripcion.Text = "Se cierra " + txtTipoEquipo.Text + " por fin mínima frecuencia.";
                        break;
                    case "RESCA":
                        txtDescripcion.Text = "Se abre " + txtTipoEquipo.Text + " por fin restricción de carga.";
                        break;
                    default:
                        txtDescripcion.Text = "Se cierra " + txtTipoEquipo.Text;
                        break;
                }

                txtAP.Text = "0";

                if (opcApu.Checked == true)
                    txtDescripcion.Text += " A pedido del usuario";
                else if (opcApu.Checked == false)
                    return;
            }
        }

        private void FXL_logicaDeCorrientes()
        {
            opcImpedancia.Enabled = false;
            opcImpedancia.Checked = false;
            opcCuba.Enabled = false;
            opcCuba.Checked = false;
            opcBuchoolz.Enabled = false;
            opcBuchoolz.Checked = false;

            if (opcIfase.Checked == true && opcItierra.Checked == true)
            {
                opcTemporizada.Visible = true;

                if (opcTemporizada.Checked == true)
                    txtActuaciones.Text = "Corriente máxima de fase y tierra temporizada.";
                else if (opcTemporizada.Checked == false)
                    txtActuaciones.Text = "Corriente máxima de fase y tierra.";
            }

            if (opcIfase.Checked == true && opcItierra.Checked == false)
            {
                opcTemporizada.Visible = true;

                if (opcTemporizada.Checked == true)
                    txtActuaciones.Text = "Corriente máxima de fase temporizada.";
                else if (opcTemporizada.Checked == false)
                    txtActuaciones.Text = "Corriente máxima de fase.";
            }

            if (opcIfase.Checked == false && opcItierra.Checked == true)
            {
                opcTemporizada.Visible = true;

                if (opcTemporizada.Checked == true)
                    txtActuaciones.Text = "Corriente máxima de tierra temporizada.";
                else if (opcTemporizada.Checked == false)
                    txtActuaciones.Text = "Corriente máxima de tierra.";
            }

            if (opcIfase.Checked == false && opcItierra.Checked == false)
            {
                opcTemporizada.Visible = false;
                txtActuaciones.Text = "";

                FXL_habilitarActuaciones();
            }
        }

        private void FXL_logicaImpedancia()
        {
            if (opcImpedancia.Checked == true)
                txtActuaciones.Text = "RZ.";

            string aux = "";

            if (opcFaseR.Checked == true)
                aux = "1";
            else if (opcFaseR.Checked == false)
                aux = "0";

            if (opcFaseS.Checked == true)
                aux = aux + "1";
            else if (opcFaseS.Checked == false)
                aux = aux + "0";

            if (opcFaseT.Checked == true)
                aux = aux + "1";
            else if (opcFaseT.Checked == false)
                aux = aux + "0";

            if (opcFaseE.Checked == true)
                aux = aux + "1";
            if (opcFaseE.Checked == false)
                aux = aux + "0";

            switch (aux)
            {
                case "0001":
                    txtActuaciones.Text = "RZ E.";
                    break;
                case "0010":
                    txtActuaciones.Text = "RZ T.";
                    break;
                case "0011":
                    txtActuaciones.Text = "RZ TE.";
                    break;
                case "0100":
                    txtActuaciones.Text = "RZ S.";
                    break;
                case "0101":
                    txtActuaciones.Text = "RZ SE.";
                    break;
                case "0110":
                    txtActuaciones.Text = "RZ ST.";
                    break;
                case "0111":
                    txtActuaciones.Text = "RZ STE.";
                    break;
                case "1000":
                    txtActuaciones.Text = "RZ R.";
                    break;
                case "1001":
                    txtActuaciones.Text = "RZ RE.";
                    break;
                case "1010":
                    txtActuaciones.Text = "RZ RT.";
                    break;
                case "1011":
                    txtActuaciones.Text = "RZ RTE.";
                    break;
                case "1100":
                    txtActuaciones.Text = "RZ RS.";
                    break;
                case "1101":
                    txtActuaciones.Text = "RZ RSE.";
                    break;
                case "1110":
                    txtActuaciones.Text = "RZ RST.";
                    break;
                case "1111":
                    txtActuaciones.Text = "RZ RSTE.";
                    break;
            }
        }

        private void FXL_logicaCubauchholz()
        {
            opcIfase.Enabled = false;
            opcIfase.Checked = false;
            opcItierra.Enabled = false;
            opcItierra.Checked = false;
            opcImpedancia.Enabled = false;
            opcImpedancia.Checked = false;

            if (opcCuba.Checked == true && opcBuchoolz.Checked == true)
                txtActuaciones.Text = "Disparo por cuba y Buchholz.";
            if (opcCuba.Checked == true && opcBuchoolz.Checked == false)
                txtActuaciones.Text = "Disparo por cuba.";
            if (opcCuba.Checked == false && opcBuchoolz.Checked == true)
                txtActuaciones.Text = "Disparo por Buchholz.";
            if (opcCuba.Checked == false && opcBuchoolz.Checked == false)
            {
                opcIfase.Enabled = true;
                opcItierra.Enabled = true;
                opcImpedancia.Enabled = true;
                txtActuaciones.Text = "";
            }
        }
    }
}
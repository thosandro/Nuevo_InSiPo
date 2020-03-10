using Nuevo_InSiPo.Interfaces._02_Parte_Diario;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Nuevo_InSiPo.Interfaces
{
    public partial class frPrincipal : Form
    {
        public frPrincipal()
        {
            InitializeComponent();
        }

        private void frPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #region MENU LATERAL
        private void btnAltoValle_Click(object sender, EventArgs e)
        {
            pnlAltoValle.Location = new Point(253, btnAltoValle.Location.Y);
            FXL_MenuSistemas(pnlAltoValle, imgAltoValle);
        }

        private void btnValleMedio_Click(object sender, EventArgs e)
        {
            pnlValleMedio.Location = new Point(253, btnValleMedio.Location.Y);
            FXL_MenuSistemas(pnlValleMedio, imgValleMedio);
        }

        private void btnAtlántico_Click(object sender, EventArgs e)
        {
            pnlAtlantico.Location = new Point(253, btnAtlántico.Location.Y);
            FXL_MenuSistemas(pnlAtlantico, imgAtlantico);
        }

        private void btnAndino_Click(object sender, EventArgs e)
        {
            pnlAndino.Location = new Point(253, btnAndino.Location.Y);
            FXL_MenuSistemas(pnlAndino, imgAndino);
        }
        #endregion

        #region BOTONES LATERALES
        private void btnCargaNovedades_Click(object sender, EventArgs e)
        {
            frCargaNovedes fr = new frCargaNovedes();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btnVerReporte_Click(object sender, EventArgs e)
        {
            frNovedades fr = new frNovedades();
            fr.MdiParent = this;
            fr.Show();
        }
        #endregion

        /* FUNCIONES LOCALES */
        /*********************/
        private void FXL_MenuSistemas(Control panel, PictureBox imagen)
        {
            if (panel.Visible == false)
            {
                FXL_OcultarFlechas();
                FXL_OcultarPanelesMenus();
                panel.Visible = true;
                imagen.Visible = true;
            }
            else if (panel.Visible == true)
            {
                panel.Visible = false;
                imagen.Visible = false;
            }
        }

        private void FXL_OcultarFlechas()
        {
            imgAltoValle.Visible = false;
            imgValleMedio.Visible = false;
            imgAtlantico.Visible = false;
            imgAndino.Visible = false;
        }

        private void FXL_OcultarPanelesMenus()
        {
            pnlAltoValle.Visible = false;
            pnlValleMedio.Visible = false;
            pnlAtlantico.Visible = false;
            pnlAndino.Visible = false;
        }
    }
}

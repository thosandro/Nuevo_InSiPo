﻿using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Nuevo_InSiPo.Interfaces
{
    public partial class frBienvenida : Form
    {
        private static OleDbConnection miConexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Maxi-eNova\\Qsync\\Programacion\\C#\\Nuevo_InSiPo_solucion\\Recursos\\REPORTE_pu.mdb");
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
                miConexion.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un problema al intentar conectar con la base de datos. " + ex + " // " + miConexion.ConnectionString);
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            miConexion.Close();
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
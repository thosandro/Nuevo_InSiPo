using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ConexionBD_CSharp.DTO
{
    class FX_SeleccionarDatos : ClsConexion
    {
        //VARIABLES:
        protected private static DataSet CopiaLocal_DataSet = new DataSet();
        private static OleDbDataAdapter Activo_DataAdapter = new OleDbDataAdapter();

        //MÉTODOS:
        public static void CrearTablasInternas()
        {
            CopiaLocal_DataSet.Tables.Add("spiderCampos");
            CopiaLocal_DataSet.Tables.Add("tasCampos");
            CopiaLocal_DataSet.Tables.Add("motivos");
        }

        public static void LlenarDataGrid(string NombreTabla, string InstruccionSQL, DataGridView NombreDataGridView)
        {
            MiConexion.Open();
            if (CopiaLocal_DataSet.Tables[NombreTabla].Rows.Count != 0)
            {
                CopiaLocal_DataSet.Tables[NombreTabla].Clear();
            }
            CopiaLocal_DataSet.Tables[NombreTabla].Clear();
            Activo_DataAdapter.SelectCommand = new OleDbCommand(InstruccionSQL, MiConexion);
            Activo_DataAdapter.Fill(CopiaLocal_DataSet.Tables[NombreTabla]);
            
            NombreDataGridView.DataSource = CopiaLocal_DataSet.Tables[NombreTabla];
            MiConexion.Close();
        }

        public static void LlenarComboBox(String NombreTabla, String InstruccionSQL, ComboBox NombreComboBox, String ColumnaParaMostrar)
        {
            MiConexion.Open();
            if (CopiaLocal_DataSet.Tables[NombreTabla].Rows.Count != 0)
            {
                CopiaLocal_DataSet.Tables[NombreTabla].Clear();
            }
            Activo_DataAdapter.SelectCommand = new OleDbCommand(InstruccionSQL, MiConexion);
            Activo_DataAdapter.Fill(CopiaLocal_DataSet.Tables[NombreTabla]);
            NombreComboBox.DataSource = CopiaLocal_DataSet.Tables[NombreTabla];
            NombreComboBox.DisplayMember = ColumnaParaMostrar;
            MiConexion.Close();


        }
    }
}

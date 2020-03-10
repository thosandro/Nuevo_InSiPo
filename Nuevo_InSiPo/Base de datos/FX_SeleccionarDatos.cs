using ConexionBD_CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace Nuevo_InSiPo.Base_de_datos
{
    public class FX_SeleccionarDatos : ClsConexion
    {
        protected static DataSet CopiaLocal_DataSet = new DataSet();
        
        public static void crearTablas()
        {
            CopiaLocal_DataSet.Tables.Add("EETT");
            CopiaLocal_DataSet.Tables.Add("auxEETT");
            CopiaLocal_DataSet.Tables.Add("motivos");
            CopiaLocal_DataSet.Tables.Add("campos");
            CopiaLocal_DataSet.Tables.Add("auxCampos");
            CopiaLocal_DataSet.Tables.Add("responsables");
        }
        
        public static DataTable Motivos (string sql)
        {
            OleDbDataAdapter da = new OleDbDataAdapter();

            if (CopiaLocal_DataSet.Tables["motivos"].Rows.Count != 0)
                CopiaLocal_DataSet.Tables["motivos"].Clear();

            da.SelectCommand = new OleDbCommand(sql, MiConexion);
            da.Fill(CopiaLocal_DataSet.Tables["motivos"]);

            return CopiaLocal_DataSet.Tables["motivos"];
        }

        public static DataTable EETT (string sql)
        {
            OleDbDataAdapter da = new OleDbDataAdapter();

            if (CopiaLocal_DataSet.Tables["EETT"].Rows.Count != 0)
                CopiaLocal_DataSet.Tables["EETT"].Clear();

            da.SelectCommand = new OleDbCommand(sql, MiConexion);
            da.Fill(CopiaLocal_DataSet.Tables["EETT"]);

            return CopiaLocal_DataSet.Tables["EETT"];
        }

        public static DataTable auxEETT(string sql)
        {
            OleDbDataAdapter da = new OleDbDataAdapter();

            if (CopiaLocal_DataSet.Tables["auxEETT"].Rows.Count != 0)
                CopiaLocal_DataSet.Tables["auxEETT"].Clear();

            da.SelectCommand = new OleDbCommand(sql, MiConexion);
            da.Fill(CopiaLocal_DataSet.Tables["auxEETT"]);

            return CopiaLocal_DataSet.Tables["auxEETT"];
        }

        public static DataTable Campos(string sql)
        {
            OleDbDataAdapter da = new OleDbDataAdapter();

            if (CopiaLocal_DataSet.Tables["campos"].Rows.Count != 0)
                CopiaLocal_DataSet.Tables["campos"].Clear();

            da.SelectCommand = new OleDbCommand(sql, MiConexion);
            da.Fill(CopiaLocal_DataSet.Tables["campos"]);

            return CopiaLocal_DataSet.Tables["campos"];
        }

        public static DataTable auxCampos(string sql)
        {
            OleDbDataAdapter da = new OleDbDataAdapter();

            if (CopiaLocal_DataSet.Tables["auxCampos"].Rows.Count != 0)
                CopiaLocal_DataSet.Tables["auxCampos"].Clear();

            da.SelectCommand = new OleDbCommand(sql, MiConexion);
            da.Fill(CopiaLocal_DataSet.Tables["auxCampos"]);

            return CopiaLocal_DataSet.Tables["auxCampos"];
        }

        public static DataTable Responsables (string sql)
        {
            OleDbDataAdapter da = new OleDbDataAdapter();

            if (CopiaLocal_DataSet.Tables["responsables"].Rows.Count != 0)
                CopiaLocal_DataSet.Tables["responsables"].Clear();

            da.SelectCommand = new OleDbCommand(sql, MiConexion);
            da.Fill(CopiaLocal_DataSet.Tables["responsables"]);

            return CopiaLocal_DataSet.Tables["responsables"];
        }

        public static void abrirConexion()
        {
            MiConexion.Open();
        }

        public static void cerrarConexion()
        {
            MiConexion.Close();
        }
    }
}
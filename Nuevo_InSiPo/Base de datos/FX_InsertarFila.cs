using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using ConexionBD_CSharp.DTO;

namespace Nuevo_InSiPo
{
    class FX_InsertarFila : FX_SeleccionarDatos

    {
        public static void spiderCampo()
        {
            OleDbCommand nuevoSpiderCampo = new OleDbCommand();
            nuevoSpiderCampo.CommandType = CommandType.Text;
            nuevoSpiderCampo.CommandText = "INSERT INTO Operadores (Operadores) VALUES ('Nuevo Operador')";
            
            nuevoSpiderCampo.Connection = MiConexion;

            MiConexion.Open();
            nuevoSpiderCampo.ExecuteNonQuery();
            MiConexion.Close();

       
        }
    }
}

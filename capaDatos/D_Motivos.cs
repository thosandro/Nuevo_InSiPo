using capaEntidades;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace capaDatos
{
    public class D_Motivos
    {
        public List<E_Motivos> listarMotivos()
        {
            SqlDataReader leerFilas;
            SqlCommand cmd = new SqlCommand("SP_listarMotivo", conexionBD.miConexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            conexionBD.miConexion.Open();

            leerFilas = cmd.ExecuteReader();

            List<E_Motivos> listar = new List<E_Motivos>();

            while (leerFilas.Read())
            {
                listar.Add(new E_Motivos
                {
                    Id = leerFilas.GetInt32(0),
                    Codificacion = leerFilas.GetString(1),
                    Motivo = leerFilas.GetString(2),
                    Ap = leerFilas.GetInt32(3)
                });
            }

            conexionBD.miConexion.Close();
            leerFilas.Close();

            return listar;
        }
    }
}

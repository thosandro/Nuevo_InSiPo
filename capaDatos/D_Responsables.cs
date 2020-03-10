using capaEntidades;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace capaDatos
{
    public class D_Responsables
    {
        public List<E_Responsables> listarResponsables()
        {
            SqlDataReader leerFilas;

            SqlCommand cmd = new SqlCommand("SP_listarResponsable", conexionBD.miConexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            conexionBD.miConexion.Open();

            leerFilas = cmd.ExecuteReader();

            List<E_Responsables> listar = new List<E_Responsables>();

            while (leerFilas.Read())
            {
                listar.Add(new E_Responsables
                {
                    Id = leerFilas.GetInt32(0),
                    Responsable = leerFilas.GetString(1)
                });
            }

            conexionBD.miConexion.Close();
            leerFilas.Close();

            return listar;
        }
    }
}

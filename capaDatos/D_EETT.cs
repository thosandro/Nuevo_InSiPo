using capaEntidades;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace capaDatos
{
    public class D_EETT
    {
        public List<E_EETT> listarEETT(string codificacionET)
        {
            SqlDataReader leerFilas;
            SqlCommand cmd = new SqlCommand("SP_listarEETT",conexionBD.miConexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            conexionBD.miConexion.Open();
            cmd.Parameters.AddWithValue("@buscar", codificacionET);

            leerFilas = cmd.ExecuteReader();

            List<E_EETT> listar = new List<E_EETT>();

            while (leerFilas.Read())
            {
                listar.Add(new E_EETT
                {
                    Id = leerFilas.GetInt32(0),
                    Codificacion = leerFilas.GetString(1),
                    NombreCompleto = leerFilas.GetString(2),
                    SistemaAsociado = leerFilas.GetString(3)
                });
            }

            conexionBD.miConexion.Close();
            leerFilas.Close();

            return listar;
        }
    }
}

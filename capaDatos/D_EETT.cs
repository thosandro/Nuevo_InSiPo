using capaEntidades;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace capaDatos
{
    public class D_EETT
    {
        public List<E_EETT> listarEETT(string codificacionET)
        {
            MySqlDataReader leerFilas;
            MySqlCommand cmd = new MySqlCommand("SP_listarEETT", conexionBD.mySqlConexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            conexionBD.mySqlConexion.Open();

            cmd.Parameters.AddWithValue("pCodificacionET", codificacionET);

            leerFilas = cmd.ExecuteReader();

            List<E_EETT> listar = new List<E_EETT>();

            while (leerFilas.Read())
            {
                listar.Add(new E_EETT
                {
                    Id = leerFilas.GetInt32(0),
                    Codificacion = leerFilas.GetString(1),
                    NombreCompleto = leerFilas.GetString(2),
                });
            }

            conexionBD.mySqlConexion.Close();
            leerFilas.Close();

            return listar;
        }
    }
}

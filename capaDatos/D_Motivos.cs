using capaEntidades;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace capaDatos
{
    public class D_Motivos
    {
        public List<E_Motivos> listarMotivos()
        {
            //SqlDataReader leerFilas;
            //SqlCommand cmd = new SqlCommand("SP_listarMotivo", conexionBD.miConexion);
            //cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //conexionBD.miConexion.Open();

            //leerFilas = cmd.ExecuteReader();

            MySqlDataReader leerFilas;
            MySqlCommand cmd = new MySqlCommand("SP_listarMotivo", conexionBD.mySqlConexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            conexionBD.mySqlConexion.Open();

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

            //conexionBD.miConexion.Close();
            conexionBD.mySqlConexion.Close();
            leerFilas.Close();

            return listar;
        }
    }
}

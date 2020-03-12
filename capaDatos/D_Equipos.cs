using capaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace capaDatos
{
    public class D_Equipos
    {
        public List<E_Equipos> listarEquipos_CargaNovedades(string codificacionET)
        {
            MySqlDataReader leerFilas;
            MySqlCommand cmd = new MySqlCommand("SP_listarEquiposParaCargaNovedades", conexionBD.mySqlConexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            conexionBD.mySqlConexion.Open();

            cmd.Parameters.AddWithValue("pCodificacionET", codificacionET);

            leerFilas = cmd.ExecuteReader();

            List<E_Equipos> listar = new List<E_Equipos>();

            while (leerFilas.Read())
            {
                listar.Add(new E_Equipos
                {
                    Id = leerFilas.GetInt32(0),
                    ETasociada = leerFilas.GetString(1),
                    NivelTension = leerFilas.GetString(2),
                    NombreCampo = leerFilas.GetString(3),
                    TipoDeEquipo = leerFilas.GetString(4),
                    Codificacion = leerFilas.GetString(5)
                });
            }

            conexionBD.mySqlConexion.Close();
            leerFilas.Close();

            return listar;
        }
    }
}

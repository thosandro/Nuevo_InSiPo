using capaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace capaDatos
{
    public class D_Equipos
    {
        public List<E_Equipos> listarEquiposParaCargaNovedades(string codificacionET, string nombreCampo)
        {
            SqlDataReader leerFilas;
            SqlCommand cmd = new SqlCommand("SP_listarEquipamientoParaCargaDeNovedades", conexionBD.miConexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            conexionBD.miConexion.Open();

            cmd.Parameters.AddWithValue("@buscar", nombreCampo);
            cmd.Parameters.AddWithValue("@ET", codificacionET);

            leerFilas = cmd.ExecuteReader();

            List<E_Equipos> listar = new List<E_Equipos>();

            while (leerFilas.Read())
            {
                listar.Add(new E_Equipos
                {
                    Id = leerFilas.GetInt32(0),
                    ETasociada = leerFilas.GetString(1),
                    NombreCampo = leerFilas.GetString(2),
                    TipoDeEquipo = leerFilas.GetString(3),
                    Codificacion = leerFilas.GetString(4),
                    NivelTension = leerFilas.GetString(5),
                    AccionOperativa = leerFilas.GetString(6)
                });
            }

            conexionBD.miConexion.Close();
            leerFilas.Close();

            return listar;
        }
    }
}

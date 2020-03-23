using capaEntidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace capaDatos
{
    public class D_Novedades
    {
        public void agregarNovedad(E_Novedades novedad)
        {
            MySqlCommand cmd = new MySqlCommand("SP_agregarOperacion", conexionBD.mySqlConexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            conexionBD.mySqlConexion.Open();

            cmd.Parameters.AddWithValue("pFecha", novedad.Fecha);
            cmd.Parameters.AddWithValue("pId_Equipamiento", novedad.IdEquipo);
            cmd.Parameters.AddWithValue("pId_Motivo", novedad.IdMotivo);
            cmd.Parameters.AddWithValue("pId_responsable", novedad.IdResponsable);
            cmd.Parameters.AddWithValue("pEns", novedad.Ens);
            cmd.Parameters.AddWithValue("pAp", novedad.Ap);
            cmd.Parameters.AddWithValue("pDescripcion", novedad.Descripcion);
            cmd.Parameters.AddWithValue("pObservaciones", novedad.Observaciones);
            cmd.Parameters.AddWithValue("pActuaciones", novedad.Actuaciones);

            cmd.ExecuteNonQuery();

            //conexionBD.miConexion.Close();
            conexionBD.mySqlConexion.Close();
        }

        public List<E_Novedades> listarNovedadesEntreFechas(DateTime fechaInicio, DateTime fechaFinal)
        {
            MySqlDataReader leerFilas;
            MySqlCommand cmd = new MySqlCommand("SP_listarOperacionesEntreFechas", conexionBD.mySqlConexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            conexionBD.mySqlConexion.Open();

            cmd.Parameters.AddWithValue("pFechaInicio", fechaInicio);
            cmd.Parameters.AddWithValue("pFechaFinal", fechaFinal);

            leerFilas = cmd.ExecuteReader();

            List<E_Novedades> listar = new List<E_Novedades>();

            while (leerFilas.Read())
            {
                listar.Add(new E_Novedades
                {
                    Id = leerFilas.GetInt64(0),
                    Fecha = leerFilas.GetDateTime(1),
                    CodificacionET = leerFilas.GetString(2),
                    NombreCampo = leerFilas.GetString(3),
                    NivelTension = leerFilas.GetString(4),
                    CodificacionSistema = leerFilas.GetString(5),
                    Motivo = leerFilas.GetString(6),
                    Responsable = leerFilas.GetString(7),
                    Ens = leerFilas.GetString(8),
                    Descripcion = leerFilas.GetString(9),
                    Actuaciones = leerFilas.GetString(10),
                    Observaciones = leerFilas.GetString(11)
                });
            }

            conexionBD.mySqlConexion.Close();
            leerFilas.Close();

            return listar;
        }
    }
}

using capaEntidades;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using MySql.Data.Types;

namespace capaDatos
{
    public class D_Novedades
    {
        public void agregarNovedad(E_Novedades novedad)
        {
            //SqlCommand cmd = new SqlCommand("SP_agregarOperacion", conexionBD.miConexion);
            //cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //conexionBD.miConexion.Open();

            //cmd.Parameters.AddWithValue("@id_Equipamiento", novedad.EquipoAsociado);
            //cmd.Parameters.AddWithValue("@ET", novedad.ET);
            //cmd.Parameters.AddWithValue("@nombreCampo", novedad.NombreCampo);
            //cmd.Parameters.AddWithValue("@codificacionEquipo", novedad.CodificacionEquipo);
            //cmd.Parameters.AddWithValue("@fecha", novedad.Fecha);
            //cmd.Parameters.AddWithValue("@id_Motivo", novedad.Id_Motivo);
            //cmd.Parameters.AddWithValue("@id_responsable", novedad.Id_Responsable);
            //cmd.Parameters.AddWithValue("@ens", novedad.Ens);
            //cmd.Parameters.AddWithValue("@ap", novedad.Ap);
            //cmd.Parameters.AddWithValue("@descripcion", novedad.Descripcion);
            //cmd.Parameters.AddWithValue("@observaciones", novedad.Observaciones);
            //cmd.Parameters.AddWithValue("@actuaciones", novedad.Actuaciones);

            MySqlCommand cmd = new MySqlCommand("SP_agregarOperacion", conexionBD.mySqlConexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            conexionBD.mySqlConexion.Open();

            cmd.Parameters.AddWithValue("pId_Equipamiento", novedad.EquipoAsociado);
            cmd.Parameters.AddWithValue("pET", novedad.ET);
            cmd.Parameters.AddWithValue("pNombreCampo", novedad.NombreCampo);
            cmd.Parameters.AddWithValue("pCodificacionEquipo", novedad.CodificacionEquipo);
            cmd.Parameters.AddWithValue("pFecha", novedad.Fecha);
            cmd.Parameters.AddWithValue("pId_Motivo", novedad.Id_Motivo);
            cmd.Parameters.AddWithValue("pId_responsable", novedad.Id_Responsable);
            cmd.Parameters.AddWithValue("pEns", novedad.Ens);
            cmd.Parameters.AddWithValue("pAp", novedad.Ap);
            cmd.Parameters.AddWithValue("pDescripcion", novedad.Descripcion);
            cmd.Parameters.AddWithValue("pObservaciones", novedad.Observaciones);
            cmd.Parameters.AddWithValue("pActuaciones", novedad.Actuaciones);

            cmd.ExecuteNonQuery();

            //conexionBD.miConexion.Close();
            conexionBD.mySqlConexion.Close();
        }

        public List<E_Novedades> listarNovedades(string ET)
        {
            //SqlDataReader leerFilas;
            //SqlCommand cmd = new SqlCommand("SP_listarOperacion", conexionBD.miConexion);
            //cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //conexionBD.miConexion.Open();

            //cmd.Parameters.AddWithValue("@buscar", ET);

            MySqlDataReader leerFilas;
            MySqlCommand cmd = new MySqlCommand("SP_listarOperacion", conexionBD.mySqlConexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            conexionBD.mySqlConexion.Open();

            cmd.Parameters.AddWithValue("pBuscar", ET);

            leerFilas = cmd.ExecuteReader();

            List<E_Novedades> listar = new List<E_Novedades>();

            while (leerFilas.Read())
            {
                listar.Add(new E_Novedades
                {
                    Id = leerFilas.GetInt64(0),
                    Fecha = leerFilas.GetDateTime(1),
                    ET = leerFilas.GetString(2),
                    NombreCampo = leerFilas.GetString(3),
                    CodificacionEquipo = leerFilas.GetString(4),
                    ResponsableAsociado = leerFilas.GetString(5),
                    MotivoAsociado = leerFilas.GetString(6),
                    Ens = leerFilas.GetString(7),
                    Ap = leerFilas.GetInt32(8),
                    Descripcion = leerFilas.GetString(9),
                    Actuaciones = leerFilas.GetString(10),
                    EquipoAsociado = leerFilas.GetInt32(11),
                    Observaciones = leerFilas.GetString(12)
                });
            }

            //conexionBD.miConexion.Close();
            conexionBD.mySqlConexion.Close();
            leerFilas.Close();

            return listar;
        }
    }
}

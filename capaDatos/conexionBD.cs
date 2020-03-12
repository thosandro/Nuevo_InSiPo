using MySql.Data.MySqlClient;

namespace capaDatos
{
    public class conexionBD
    {
        public static MySqlConnection mySqlConexion = new MySqlConnection("server = maxirucci.dyndns.info; port=3306; user id = codEdersa; password=newInsipo;database=codEdersa;");
    }
}

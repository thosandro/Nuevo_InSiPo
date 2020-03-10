using MySql.Data.MySqlClient;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace capaDatos
{
    public class conexionBD
    {
        //public static SqlConnection miConexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Maxi-eNova\\Qsync\\Programacion\\C#\\Nuevo_InSiPo_solucion\\Recursos\\REPORTE_pu.mdb");
        public static SqlConnection miConexion = new SqlConnection("Data Source=NOTEBOOK-ENOVA\\ENOVASERVER;Initial Catalog=nuevoInsipo;Integrated Security=True");

        public static MySqlConnection mySqlConexion = new MySqlConnection("server = maxirucci.dyndns.info; port=3306; user id = codEdersa; password=newInsipo;database=codEdersa;");

    }
}

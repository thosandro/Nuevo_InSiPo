using System.Data.OleDb;
using System.Data.SqlClient;

namespace capaDatos
{
    public class conexionBD
    {
        //public static SqlConnection miConexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Maxi-eNova\\Qsync\\Programacion\\C#\\Nuevo_InSiPo_solucion\\Recursos\\REPORTE_pu.mdb");
        public static SqlConnection miConexion = new SqlConnection("Data Source=NOTEBOOK-ENOVA\\ENOVASERVER;Initial Catalog=nuevoInsipo;Integrated Security=True");
        //Esto es una prueba de sincronización con GitHub para poder trabajar en conjunto con Thomas.
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;


namespace ConexionBD_CSharp
{
    public class ClsConexion
    {
        //GFast:
        public static OleDbConnection MiConexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Maxi-eNova\\Qsync\\Programacion\\C#\\Nuevo_InSiPo_solucion\\Recursos\\REPORTE_pu.mdb");
        //ASUS:
        //public OleDbConnection MiConexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=L:\\Programacion\\ErroresSOTR.mdb");
        //protected static OleDbConnection MiConexion = new OleDbConnection("Server=tcp:server-inicio.database.windows.net,1433;Initial Catalog=bdNumeroFormulario;Persist Security Info=False;User ID=server-inicio;Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
    }
}

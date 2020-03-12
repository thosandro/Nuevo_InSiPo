using System;

namespace capaEntidades
{
    public class E_Novedades
    {
        //Entidades para guardar
        private long _id;
        private DateTime _fecha;
        private int _idEquipo;
        private int _idMotivo;
        private int _idResponsable;
        private string _ens;
        private int _ap;
        private string _descripcion;
        private string _actuaciones;
        private string _observaciones;

        //Para mostrar la informacion de las novedades se necesitan más columnas,
        //entonces se agregran las entidades necesarias
        private string _motivo;
        private string _responsable;
        private string _codificacionET;
        private string _codificacionSistema;
        private string _nombreCampo;
        private string _codificacionEquipo;

        public long Id { get => _id; set => _id = value; }
        public DateTime Fecha { get => _fecha; set => _fecha = value; }
        public int IdEquipo { get => _idEquipo; set => _idEquipo = value; }
        public int IdMotivo { get => _idMotivo; set => _idMotivo = value; }
        public int IdResponsable { get => _idResponsable; set => _idResponsable = value; }
        public string Ens { get => _ens; set => _ens = value; }
        public int Ap { get => _ap; set => _ap = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string Actuaciones { get => _actuaciones; set => _actuaciones = value; }
        public string Observaciones { get => _observaciones; set => _observaciones = value; }

        //
        public string Motivo { get => _motivo; set => _motivo = value; }
        public string Responsable { get => _responsable; set => _responsable = value; }

        public string CodificacionET { get => _codificacionET; set => _codificacionET = value; }
        public string CodificacionSistema { get => _codificacionSistema; set => _codificacionSistema = value; }
        public string NombreCampo { get => _nombreCampo; set => _nombreCampo = value; }
        public string CodificacionEquipo { get => _codificacionEquipo; set => _codificacionEquipo = value; }
    }
}

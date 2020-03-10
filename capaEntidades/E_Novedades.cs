using System;
using MySql.Data.Types;

namespace capaEntidades
{
    public class E_Novedades
    {
        private long _id;
        private int _equipoAsociado;
        private string _ET;
        private string _nombreCampo;
        private string _codificacionEquipo;
        private DateTime _fecha;
        private string _motivoAsociado;
        private string _responsableAsociado;
        private string _ens;
        private int _ap;
        private string _descripcion;
        private string _actuaciones;
        private string _observaciones;

        //Propiedades para guardar/actualizar datos
        private int _id_Motivo;
        private int _id_Responsable;

        public long Id { get => _id; set => _id = value; }
        public int EquipoAsociado { get => _equipoAsociado; set => _equipoAsociado = value; }
        public string ET { get => _ET; set => _ET = value; }
        public string NombreCampo { get => _nombreCampo; set => _nombreCampo = value; }
        public string CodificacionEquipo { get => _codificacionEquipo; set => _codificacionEquipo = value; }
        public DateTime Fecha { get => _fecha; set => _fecha = value; }
        public string MotivoAsociado { get => _motivoAsociado; set => _motivoAsociado = value; }
        public string ResponsableAsociado { get => _responsableAsociado; set => _responsableAsociado = value; }
        public string Ens { get => _ens; set => _ens = value; }
        public int Ap { get => _ap; set => _ap = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string Actuaciones { get => _actuaciones; set => _actuaciones = value; }
        public string Observaciones { get => _observaciones; set => _observaciones = value; }

        //
        public int Id_Motivo { get => _id_Motivo; set => _id_Motivo = value; }
        public int Id_Responsable { get => _id_Responsable; set => _id_Responsable = value; }
    }
}

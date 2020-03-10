using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capaEntidades
{
    public class E_Equipos
    {
        private int _id;
        private string _ETasociada;
        private string _sistemaAsociado;
        private string _nivelTension;
        private string _nombreCampo;
        private string _tipoDeEquipo;
        private string _codificacion;
        private string _accionOperativa;
        private string _ultimaModificacion;
        private string _marcaModelo;
        private string _anioFabricacion;
        private string _nroSerie;
        private string _sNominal;
        private string _iNominal;
        private string _uNominal;
        private string _uccPorcentual;
        private string _grupoConexion;
        private string _rbc;
        private string _tipo;
        private string _poderDeCorte;
        private string _accionamiento;
        private string _camara;
        private string _relacionTiTV;
        private string _clase;
        private string _observaciones;

        public int Id { get => _id; set => _id = value; }
        public string ETasociada { get => _ETasociada; set => _ETasociada = value; }
        public string SistemaAsociado { get => _sistemaAsociado; set => _sistemaAsociado = value; }
        public string NivelTension { get => _nivelTension; set => _nivelTension = value; }
        public string NombreCampo { get => _nombreCampo; set => _nombreCampo = value; }
        public string TipoDeEquipo { get => _tipoDeEquipo; set => _tipoDeEquipo = value; }
        public string Codificacion { get => _codificacion; set => _codificacion = value; }
        public string AccionOperativa { get => _accionOperativa; set => _accionOperativa = value; }
        public string UltimaModificacion { get => _ultimaModificacion; set => _ultimaModificacion = value; }
        public string MarcaModelo { get => _marcaModelo; set => _marcaModelo = value; }
        public string AnioFabricacion { get => _anioFabricacion; set => _anioFabricacion = value; }
        public string NroSerie { get => _nroSerie; set => _nroSerie = value; }
        public string SNominal { get => _sNominal; set => _sNominal = value; }
        public string INominal { get => _iNominal; set => _iNominal = value; }
        public string UNominal { get => _uNominal; set => _uNominal = value; }
        public string UccPorcentual { get => _uccPorcentual; set => _uccPorcentual = value; }
        public string GrupoConexion { get => _grupoConexion; set => _grupoConexion = value; }
        public string Rbc { get => _rbc; set => _rbc = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }
        public string PoderDeCorte { get => _poderDeCorte; set => _poderDeCorte = value; }
        public string Accionamiento { get => _accionamiento; set => _accionamiento = value; }
        public string Camara { get => _camara; set => _camara = value; }
        public string RelacionTiTV { get => _relacionTiTV; set => _relacionTiTV = value; }
        public string Clase { get => _clase; set => _clase = value; }
        public string Observaciones { get => _observaciones; set => _observaciones = value; }
    }
}

using capaDatos;
using capaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capaNegocio
{
    public class N_Equipos
    {
        D_Equipos objDato = new D_Equipos();

        public List<E_Equipos> listarEquiposParaCargaNovedades(string codificacionET, string nombreCampo)
        {
            return objDato.listarEquiposParaCargaNovedades(codificacionET, nombreCampo);
        }
    }
}

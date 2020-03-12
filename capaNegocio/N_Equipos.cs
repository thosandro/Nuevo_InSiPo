using capaDatos;
using capaEntidades;
using System.Collections.Generic;

namespace capaNegocio
{
    public class N_Equipos
    {
        D_Equipos objDato = new D_Equipos();

        public List<E_Equipos> listarEquipos_CargaNovedades(string codificacionET)
        {
            return objDato.listarEquipos_CargaNovedades(codificacionET);
        }
    }
}

using capaDatos;
using capaEntidades;
using System.Collections.Generic;

namespace capaNegocio
{
    public class N_Novedades
    {
        D_Novedades objDato = new D_Novedades();

        public void agregarNovedad(E_Novedades novedad)
        {
            objDato.agregarNovedad(novedad);
        }

        public List<E_Novedades> listarNovedades(string ET)
        {
            return objDato.listarNovedades(ET);
        }
    }
}

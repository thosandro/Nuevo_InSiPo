using capaDatos;
using capaEntidades;
using System.Collections.Generic;

namespace capaNegocio
{
    public class N_Responsables
    {
        D_Responsables objDato = new D_Responsables();

        public List<E_Responsables> listarResponsables()
        {
            return objDato.listarResponsables();
        }
    }
}

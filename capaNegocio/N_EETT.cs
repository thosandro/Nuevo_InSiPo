using capaDatos;
using capaEntidades;
using System.Collections.Generic;

namespace capaNegocio
{
    public class N_EETT
    {
        D_EETT objDato = new D_EETT();

        public List<E_EETT> listarEETT(string codificacionET)
        {
            return objDato.listarEETT(codificacionET);
        }
    }
}

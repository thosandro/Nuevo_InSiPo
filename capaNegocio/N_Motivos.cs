using capaDatos;
using capaEntidades;
using System.Collections.Generic;

namespace capaNegocio
{
    public class N_Motivos
    {
        D_Motivos objDato = new D_Motivos();

        public List<E_Motivos> listarMotivos()
        {
            return objDato.listarMotivos();
        }
    }
}

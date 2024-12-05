using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasLin
{
    class Pilas
    {

        NodoCuatro arriba;

        public NodoCuatro Arriba()
        {
            return arriba;
        }

        public void Apilar(NodoCuatro nodoC)
        {
            if (arriba == null)
            {
                arriba = nodoC;
            }
            else
            {
                NodoCuatro auxiliar = arriba;
                arriba = nodoC;
                arriba.Siguiente = auxiliar;
            }

        }

        public void Desapilar()
        {

            if (arriba != null)
            {
                arriba = arriba.Siguiente;
            }

        }

    }
}


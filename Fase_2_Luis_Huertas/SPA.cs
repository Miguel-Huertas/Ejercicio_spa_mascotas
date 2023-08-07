using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase_2_Luis_Huertas
{
    class SPA
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Nombre_Mascota { get; set; }
        public int Estrato { get; set; }
        public string Opcion { get; set; }
        public int Servicio { get; set; }

        public float Calcular()
        {
            float Costo;
            if (Servicio == 1)
            {
                Servicio = 45000;
            }
            else if (Servicio == 2)
            {
                Servicio = 80000;
            }
            else if (Servicio == 3)
            {
                Servicio = 100000;
            }
            Costo = Servicio;
            if (Estrato <= 2)
            {
                Costo = (float)(Costo * 0.85);
            }
            else if ((Estrato > 2) && (Estrato <= 4))
            {
                Costo = (float)(Costo * 0.90);
            }
            else if (Estrato >= 5)
            {
                Costo = (float)(Costo * 0.95);
            }
            return Costo;


        }
    }
}

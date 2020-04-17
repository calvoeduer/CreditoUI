using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class Credito
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public float CapitalInicial { get; set; }
        public float TasaInteres { get; set; }
        public float TiempoTranscurrido { get; set; }
        public float TotalPagar { get; set; }

        public string TipoCredito { get; set; }

        public abstract void CalcularValorPagar();

    }
}

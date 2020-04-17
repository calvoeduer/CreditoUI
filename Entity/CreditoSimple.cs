using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CreditoSimple : Credito
    {

        public CreditoSimple(string identificacion, string nombre, float capitalInicial, float tasaInteres, float totalPagar, string tipoCredito)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            CapitalInicial = capitalInicial;
            TasaInteres = tasaInteres;
            TotalPagar = totalPagar;
            TipoCredito = tipoCredito;

        }

        public override void CalcularValorPagar()
        {
            TotalPagar = CapitalInicial * (1 + TasaInteres * TiempoTranscurrido);
        }
    }
}

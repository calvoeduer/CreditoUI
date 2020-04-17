using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class CreditoService
    {
        public static CreditoRepository creditoRepository;

        public string Guardar(Credito credito)
        {
            if (credito.TipoCredito.Equals("simple"))
            {
                creditoRepository = new CreditoRepositorySimple();
                creditoRepository.Guardar(credito);
                return $"Credito Simple guardado de manera correcta";
            }
            else if (credito.Equals("compuesto"))
            {
                creditoRepository = new CreditoRepositoryCompuesto();
                creditoRepository.Guardar(credito);

                return $"Credito Compuesto guardado de manera correcta";


            }
            return $"Tipo de credito no valido";
        
        }
    }
}

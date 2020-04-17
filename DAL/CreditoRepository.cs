using System;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class CreditoRepository
    {
        public string ruta = @"credito.txt";

        public List<Credito> creditos = new List<Credito>();


        public void Guardar(Credito credito)
        {
            FileStream origenFlujo = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(origenFlujo);
           escritor.WriteLine($"{credito.Identificacion};{credito.Nombre};{credito.CapitalInicial};{credito.TasaInteres};{credito.TiempoTranscurrido};{credito.TotalPagar}");
            escritor.Close();
            origenFlujo.Close();
        }
       




    }
}

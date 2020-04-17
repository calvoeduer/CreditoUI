using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
   public class CreditoRepositorySimple : CreditoRepository
    {

        public List<Credito> Consultar()
        {
            List<Credito> Creditos = new List<Credito>();
            FileStream origen = new FileStream(ruta, FileMode.OpenOrCreate);
            StreamReader reader = new StreamReader(origen);
            string linea = string.Empty;
            while ((linea = reader.ReadLine()) != null)
            {
                Credito Credito = Mapear(linea);
                Creditos.Add(Credito);
            }
            reader.Close();
            origen.Close();
            return Creditos;

        }



        private Credito Mapear(string linea)
        {
            string[] datos = linea.Split(';');
            Credito recaudo = new CreditoSimple(datos[0], datos[1], float.Parse(datos[2]), float.Parse(datos[3]), float.Parse(datos[4]), datos[5]);

            return recaudo;
        }
    }
}

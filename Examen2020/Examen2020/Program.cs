using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen2020;

namespace Examen2020
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Furgoneta furgoneta;
            List<Furgoneta> list = new List<Furgoneta>();
            list.Add(new Furgoneta(2,200,45));*/

            List<Vehiculo> lista = new List<Vehiculo>();
            lista.Add(new Vehiculo("Honda", "Arx2011", "2012"));
            lista.Add(new Vehiculo("Honda", "Arx2011", "2012"));
            lista.Add(new Vehiculo("Honda", "Arx2011", "2012"));
            lista.Add(new Vehiculo("Honda", "Arx2011", "2012"));

            foreach (var vehiculo in lista)
            {
                Console.WriteLine(""+lista);
            }
        }
    }
}

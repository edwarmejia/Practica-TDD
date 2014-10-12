using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDPractica
{
   public class Divisores
    {
       public string Score(int numero)
       {
           string Salida = null;

           if (numero % 3 == 0 || numero.ToString().Contains("3"))
               Salida = "Fizz";
           if (numero % 5 == 0 || numero.ToString().Contains("5"))
               Salida += "Buzz";

           return Salida != null ? Salida : numero.ToString();
       }
    }
}



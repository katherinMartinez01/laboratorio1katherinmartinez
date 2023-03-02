using laboratorio1KatherinMartinez.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio1KatherinMartinez.Negocio
{

    public class clspersona {
        public void calcularIMC(persona info)
        {
            double pro = info.Peso / Math.Pow(info.Altura, 2);
            if (pro < 24)
            {
                Console.WriteLine("Peso ideal!");
            }
            else
            {

                Console.WriteLine("Tiene sobre peso");
            }



        }
        public void esMayorDeEdad(persona info)
        {
            int edad = info.Edad;
            if (edad > 18)
            {
                Console.WriteLine("Es mayor de edad");
            }
            else
            {
                Console.WriteLine("Es menor de edad");
            }
        }

    }
}
    
    


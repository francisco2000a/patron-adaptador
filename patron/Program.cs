using System;

namespace patron
{
    class Program
    {
        static void Main(string[] args)
        {
            // este es el cliente
            int resultado = 0;

            Interface1 calcu = new Calculo();

            resultado = calcu.Sumar(4, 3);
            Console.WriteLine("el resultadoes {0}", resultado);

            Console.WriteLine("-------");

            //hacemos uso del adaptador
            calcu = new Adaptador();
            //usamos el adaptador para hacer la operacion
            resultado = calcu.Sumar(5, 6);
            Console.WriteLine("el resultado es {0}", resultado);












        } 

      
    }
}

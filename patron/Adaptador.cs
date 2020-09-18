using System;
using System.Collections.Generic;
using System.Text;

namespace patron
{
    //esta clase es el adaptador usa la interfaz interface1 la cual es conocida po
    // el cliente
    // el adaptador comunica al cliente con la clase adaptada




    class Adaptador :Interface1
    {
        calculadoraArray adaptado = new calculadoraArray();

        //aqui hacemos la adaptacion de una operacion

        public int Sumar(int pA, int pB)
        {
            double B = 0;

            // creamos el array que necesitamos el adaptado
            // adaptamos los datos que se envia
            int[] operadores = { pA, pB };

            //realizamos la operacion en al adaptado
            B = adaptado.sumar(operadores);
//Adaptamos el resultado
            return (int)B;
        }



    }
}

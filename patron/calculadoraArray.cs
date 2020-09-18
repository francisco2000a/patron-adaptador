using System;
using System.Collections.Generic;
using System.Text;

namespace patron
{

    //esta es la clase que deseamos adaptary el cliente no la puede usar directamente
    //pues su interfaz es muy diferente
    class calculadoraArray
    {
        public double sumar (int[] operandos)
        {
            int A = 0;
            double B = 0;

            for (A = 0; A < operandos.Length; A++)
                B += operandos[A];
            return B;

        }


    }
}

using System;

namespace Taboada2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=1;
            int b=1;
            int resultado;
            int cont = 0;


            for (int x = 1; x <= 101; x++)
            {
                resultado = a * b;

                Console.WriteLine(a + "x" + b + "=" + resultado);

                b = b+1;

                cont = cont + 1;

                if (cont == 11)
                {

                    Console.WriteLine();
                    a = a+1;
                    b = 1;
                    cont = 1;
                }
               

            }
        }
    }
}

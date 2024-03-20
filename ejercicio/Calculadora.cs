using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio
{
    internal class Calculadora
    {
        public void Start()
        {
            calculadora();
        }
        bool continueflag = true;
        
        public void calculadora()
        {
            while(continueflag)
            {
                Console.WriteLine("Que operación deseas realizar?");

                Console.WriteLine("+");
                Console.WriteLine("-");
                Console.WriteLine("x");
                Console.WriteLine("/");
                Console.WriteLine("%");

                String options = Console.ReadLine();

                switch(options)
                {
                    case "+":
                        float variable1, variable2;

                        Console.WriteLine("Ingrese la primera variable");
                        variable1= float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la segunda variable");
                        variable2= float.Parse(Console.ReadLine());
                        suma suma = new suma(variable1, variable2);
                        Console.WriteLine($"El resultado de la suma es {suma.Solucion()}");
                        break;
                    
                    case "-":
                        float A, B;

                        Console.WriteLine("Ingrese la primera variable");
                        A = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la segunda variable");
                        B = float.Parse(Console.ReadLine());
                        Resta resta= new Resta(A, B);
                        Console.WriteLine($"El resultado de la resta es {resta.Solucion()}");
                        break;

                    case "/":
                        float C, D;

                        Console.WriteLine("Ingrese la primera variable");
                        C = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la segunda variable");
                        D = float.Parse(Console.ReadLine());
                        Dividir dividir= new Dividir(C, D);
                        Console.WriteLine($"El resultado de la division es {dividir.Solucion()}");
                        break;
                    case "%":
                        float E, F;

                        Console.WriteLine("Ingrese la primera variable");
                        E = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la segunda variable");
                        F = float.Parse(Console.ReadLine());
                        Modulo modulo = new Modulo(E, F);
                        Console.WriteLine($"El resultado del modulo es {modulo.Solucion()}");
                        break;

                }

                Console.WriteLine("Desea continuar? Escriba SI o NO");
                if (Console.ReadLine() == "NO")
                {
                    continueflag = false;
                }

            }
        }

    }
}

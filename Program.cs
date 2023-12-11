using System;

namespace U3_programa5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,n2,n3,n4;

            Console.WriteLine("ingrese un numero por favor");
            n1=int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un numero por favor");
            n2=int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un numero por favor");
            n3=int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un numero por favor");
            n4=int.Parse(Console.ReadLine());

            if (n1>100){
                Console.WriteLine(n1 + " es mayor a 100");
            }else {
                Console.WriteLine(n1 + " no es mayor a 100");
                }
             if (n2>100){
                Console.WriteLine(n2 + " es mayor a 100");
            }else {
                Console.WriteLine(n2 + " no es mayor a 100");
                }
             if (n3>100){
                Console.WriteLine(n3 + " es mayor a 100");
            }else {
                Console.WriteLine(n3 + " no es mayor a 100");
                }
             if (n4>100){
                Console.WriteLine(n4+ " es mayor a 100");
            }else {
                Console.WriteLine(n4 + " no es mayor a 100");
                }
        }
    }
}

//Compare two values and return the highest
using System;

namespace ListaExercicios{
public class ComparaNumero{
        public static void Compara(){
            Console.WriteLine("This program will read two values and return the highest one\n");
            Console.WriteLine("Inform the first number\n");
            double v1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Now, Inform the second number\n");
            double v2 = Convert.ToDouble(Console.ReadLine());


            if(v1>v2){
                Console.WriteLine($"o PRIMEIRO valor informado ({v1}) é o maior.");

            }else if(v1==v2){
                Console.WriteLine("Os valores informados são iguais");

            }else{
                Console.WriteLine($"o Segundo valor informado ({v2}) é o maior.");
            }            
        }
    }
}
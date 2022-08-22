using System;
using System.Collections;

namespace ListaExercicios
{
    class Program
    {
        static Boolean Validate(ArrayList array, int limit){
            int valida = 0;
            int valor2 = 0;
            for(int i=0; i<=limit; i++){
                int proximo = i+1;

                int valor1= Convert.ToInt32(array[i]);
             if(proximo<=limit){
                 valor2 = Convert.ToInt32(array[proximo]);

            }
            if(valor1<=valor2){
                valida++;
            }
            
            }
            if(valida >= limit+1){
                return true;
            } else{
            return false;
            }
        }
        static void Main(string[] args)
        {
            int summary = 1;
            //Customer/User reception
            Console.WriteLine("Hi dear! Welcome to Bruno Groth C# exercices repository.\nHere you can find all my C# logic/algorythms Exercices.\n");
            Console.WriteLine("######## SUMMARY ########");
            Console.WriteLine($"Press {summary} to run Rectangle Area Calculator"); 
            summary++; 
            Console.WriteLine($"Press {summary} to run Currency Converter");
            summary++;
            Console.WriteLine($"Press {summary} to run Fibonacci");
            summary++;
            Console.WriteLine($"Press {summary} to run Age Validator");
            summary++;
            Console.WriteLine($"Press {summary} to run Number Comparator");
            summary++;
            Console.WriteLine($"Press {summary} to run Number Raffle and Ordenator*");
            summary++;
            Console.WriteLine($"*This one was a self-challenge that I made by hand.");
            int decision = Convert.ToInt32(Console.ReadLine());

            switch (decision){

                case 1:
                    CalculaArea.Calcula();
                break;
                case 2:
                    CurrencyConverter.Calcula();
                break;
                case 3:
                    Fibonacci.Calcula();
                break;
                case 4:
                    YourAge.CalculateAge();
                break;
                case 5:
                    ComparaNumero.Compara();
                break;
                case 6:
                    Console.WriteLine("Inform how many numbers will be drawn for raffle and ordenate.");
                    int limit = Convert.ToInt32(Console.ReadLine());
                    int repeatCounter=0;
                    Random random = new Random();
                    ArrayList array = new ArrayList();
            
                    for(int i=0;i<=limit;i++){
                        array.Add(random.Next(1000));
                    }
            
                    for(int i=0;i<=limit;i++){
                    Console.WriteLine($"Valor {i}:{array[i]}");
                    }
            
                    do{
                        OrdenarValores.Ordenar(array, limit);
                        repeatCounter++;
                    } while(Validate(array, limit) == false);

                    Console.WriteLine($"Posição Corrigida:");
                    
                    for(int p=0;p<=limit;p++){
                        Console.WriteLine($"Valor {p}: {array[p]}");
                    }
                    Console.WriteLine($"Ordenator algorithm run {repeatCounter} times to order {limit} values.");
                break;
                default:
                    Console.WriteLine("Invalid value. Please try again.");
                break;       
            }
    }
}
}

using System;
using System.Collections;

namespace ListaExercicios
{
    class Program
    {
        static Boolean Validate(ArrayList array){
            int valida = 0;
            int valor2 = 0;
            for(int i=0; i<=10; i++){
                int proximo = i+1;

                int valor1= Convert.ToInt32(array[i]);
             if(proximo<=10){
                 valor2 = Convert.ToInt32(array[proximo]);

            }
            if(valor1<=valor2){
                valida++;
            }
            
            }
            if(valida >= 11){
                return true;
            } else{
            return false;
            }
        }
        static void Main(string[] args)
        {

            // YourAge.CalculateAge();
            // CalculaArea.Calcula();
            // sConversaoMonetaria.Calcula();
            // ComparaNumero.Compara();
            // Fibonacci.Calcula();

            Random random = new Random();
            ArrayList array = new ArrayList();
            int limite = 1000;

            for(int i=0;i<=10;i++){
                array.Add(random.Next(limite));
            }

            for(int i=0;i<=10;i++){
            Console.WriteLine($"Valor {i}:{array[i]}");
            }

            do{
                OrdenarValores.Ordenar(array);
            } while(Validate(array) == false);

        Console.WriteLine($"Posição Corrigida:");
        
        for(int p=0;p<=10;p++){
            Console.WriteLine($"Valor {p}: {array[p]}");
        }
    }
}
}

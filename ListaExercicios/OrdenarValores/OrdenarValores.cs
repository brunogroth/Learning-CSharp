using System;
using System.Collections;

namespace ListaExercicios{

    public class OrdenarValores{
        public static void Ordenar(ArrayList array){
            // Dear Code Reviewer,
            // I know that it's a lot of commented lines.
            // I let them there so I can review it anytime I need to debug any other code manually.

            int limite = 1000;
            
                for(int i=9;i>=0;i--){
                //Collecting positions
                int proximo = i+1; // Next
                int anterior = i-1; //Previous

                //Collecting values and inserting into variables 
                int value1 = Convert.ToInt32(array[i]);
                int value2 = Convert.ToInt32(array[proximo]);
                int value3 = limite;

                if(i>=2){
                    value3 = Convert.ToInt32(array[anterior]);
                }

                // Console.WriteLine($"--------DEBUG--------");
                // Console.WriteLine("BEFORE CHANGING VALUES");
                // Console.WriteLine($"value 1: {value1}");
                // Console.WriteLine($"value 2: {value2} (proximo)");
                // Console.WriteLine($"value 3: {value3} (anterior)");

                // if the actual value is bigger than the next one
                if(value2<=value1){
                    array[i] = value2;
                    array[proximo] = value1;
                    // Console.WriteLine("changed");
                }
                if(value3 != limite){

                    // Console.WriteLine($"rodada {i}");
                    //Console.WriteLine($"aaaaa value 3 = {value3} e value1: {value1}");

                    //if the previous value is bigger than the actual
                    if(value3>=value1){
                    array[anterior] = value1;
                    array[i] = value3;
                    // Console.WriteLine("changed previous");
                    }
                } 
                // Console.WriteLine($"AFTER CHANGES {i}");
                // Console.WriteLine($"value 1: {value1}");
                // Console.WriteLine($"value 2: {value2} (proximo)");
                // Console.WriteLine($"value 3: {value3} (anterior)");
            }            
        }
    }
}
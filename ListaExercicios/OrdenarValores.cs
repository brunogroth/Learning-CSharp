using System;
using System.Collections;

namespace ListaExercicios{

    public class OrdenarValores{
        public static void Ordenar(){
            Random random = new Random();
            ArrayList array = new ArrayList();
            int limite = 1000;
            for(int i=0;i<=10;i++){
                array.Add(random.Next(limite));
            }
            for(int i=0;i<=10;i++){
            Console.WriteLine($"Valor {i}:{array[i]}");
            }
            Console.WriteLine($"Posição Corrigida:");
            
            for(int i=0;i<=9;i++){

                int proximo = i+1; //posicao, não valor
                int anterior = i-1;

                int valor1 = Convert.ToInt32(array[i]);
                int valor2 = Convert.ToInt32(array[proximo]);
                int valor3 = limite;
                if(i>0){;
                    valor3 = Convert.ToInt32(array[anterior]);
                }
                // se for maior, passa para baixo
                if(valor2<=valor1){
                    array[i] = valor2;
                    array[proximo] = valor1;
                    Console.WriteLine("trocou");
                }
                if(valor3 != limite){
                    Console.WriteLine($"aaaaa Valor 3 = {valor3} e valor1: {valor1}");

                    if(valor3>=valor1){
                    array[anterior] = valor1;
                    array[i] = valor3;
                    Console.WriteLine("trocou anterior");
                    }
                }
            }
            
            for(int p=0;p<=10;p++){
                Console.WriteLine($"Valor {p}: {array[p]}");
            }
        }
    }
}
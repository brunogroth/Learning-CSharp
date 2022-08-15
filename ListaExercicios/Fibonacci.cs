using System;

namespace ListaExercicios{
    public class Fibonacci{
        public static void Calcula(){
            Console.WriteLine("Informe um valor para calcular a Sequência de Fibonatti até esse número.");
            int valor = Convert.ToInt32(Console.ReadLine());

            int fibon= 0;
            int fibonSegundo = 0;
            int fibonTerceiro = 1;
            if (valor > 0){
            Console.WriteLine("0\n1\n1");
            }
            for(int i = 3; valor>fibon; i++){
                fibon = fibonSegundo + fibonTerceiro;
                fibonSegundo = fibonTerceiro;
                fibonTerceiro = fibon;
                
                // debug
                // Console.WriteLine("fibon: "+fibon);
                // Console.WriteLine("Segundo:"+fibonSegundo);
                
                if(valor>fibon){
                Console.WriteLine(fibon);


                }
            }
        }
    }
}
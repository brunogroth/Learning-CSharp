using System;

namespace ListaExercicios
{
    public class ConversaoMonetaria
    {
    public static void Calcula(){
            Console.WriteLine("CONVERSOR DE MOEDAS");
            Console.WriteLine("Digite o valor em R$:");
            double real = Convert.ToDouble(Console.ReadLine());

            double dolar = real * 5.18;
            double euro = real * 5.31;
            double peso = real * 0.04;
            String result = ($"\nValor R$: {real}\nValor USD$:{dolar}\nValor EURЄ:{euro}\nValor Peso Argentino ARS${peso}");
            Console.WriteLine(result);
        }
    }
}

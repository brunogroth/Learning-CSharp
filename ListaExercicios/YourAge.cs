using System;

namespace ListaExercicios{
    public class YourAge{
        public static void CalculateAge(){
            // This program calculates your age and define if you are a kid, young, adult or elderly
            Console.WriteLine("Inform your age: ");
            int age = Convert.ToInt32((Console.ReadLine()));

            Console.WriteLine($"Your Age is {age}");

            if(age <= 13){
                Console.WriteLine("\nKid");
            }else if (age <=18){
                Console.WriteLine("\nYoung");
            }else if (age <=60){
                Console.WriteLine("\nAdult");
            }else{
                Console.WriteLine("\nElderly");
            }
        }
    }
}
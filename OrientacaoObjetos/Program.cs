using System;

namespace OrientacaoObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            User usuario = new User();
            usuario.setNome("Brunera 8)");
            Console.WriteLine($"User Name: {usuario.getNome()}");
        
            //Way 1 to create an Object
            Product product1 = new Product();
            product1.Name = "Water";
            product1.Price = 3.5;
            Console.WriteLine($"Product Name: {product1.Name} | Price: {product1.Price}");

            //Way 2 to create an Object
            Product product2 = new Product{
                Name = "Coke",
                Price = 5
            };
            Console.WriteLine($"Product Name: {product2.Name} | Price: {product2.Price}");
        }
    }
}

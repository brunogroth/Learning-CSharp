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
            Console.WriteLine("Stock:\n");
            Console.WriteLine($"Product Name: {product1.Name} | Price: {product1.Price}");
            //Way 2 to create an Object
            Product product2 = new Product{
                Name = "Coke",
                Price = 5
            };
            Console.WriteLine($"Product Name: {product2.Name} | Price: {product2.Price}");
            Console.WriteLine("\n");
            Console.WriteLine("Press 1 to create a new user or 2 to create a new product");
            int n = Convert.ToInt32(Console.ReadLine()); 
            if( n==1){
                User user2 = new User();
                Console.WriteLine("-------------");
                Console.WriteLine("Inform the Username: ");
                user2.setNome(Console.ReadLine());
                Console.WriteLine("Inform the Password: ");
                user2.setSenha(Console.ReadLine());
                Console.WriteLine($"Name: {user2.getNome()}");
                Console.WriteLine($"Password: {user2.getSenha()}");
            }else if(n==2){
                Product product3 = new Product();
                Console.WriteLine("Inform the product Name:");
                //product3.Name(Console.ReadLine());

            }
        }
    }
}

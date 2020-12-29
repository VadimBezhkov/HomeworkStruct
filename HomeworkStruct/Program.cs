using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Product apple = new Product(1,54m,44,"apple");
            Product orange = new Product(56m, 44, "orange");

            Product grapefruit = new Product(3, 57m, 44, "grapefruit");
            Product pineapple = new Product(4, 51m, 44, "pineapple");

            Product potato = new Product(5, 53m, 44, "potato");
            Product cucumber = new Product(6, 55m, 44, "cucumber");
            Product tomato = new Product(7, 44m, 44, "tomato");

            Product sugar = new Product(8,44m, "sugar");
            Product noname = new Product(9, 44m,55);

            Product noname1 = new Product(10, 44m,99);
            Product noname2 = new Product(11,48m);


            Struct_Sklad sklad = new Struct_Sklad();
            sklad.Sklad();

            sklad.AddProducts(apple);
            sklad.AddProducts(orange);
            sklad.AddProducts(grapefruit);

            sklad.AddProducts(pineapple);
            sklad.AddProducts(potato);

            sklad.AddProducts(cucumber);
            sklad.AddProducts(tomato);

            sklad.AddProducts(sugar);
            sklad.AddProducts(noname);

            sklad.AddProducts(noname1);
            sklad.AddProducts(noname2);

            sklad.GetProductsInfo();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Summ total product: {sklad.GetSummInfo()}");
            Console.ResetColor();
            
            Console.ReadKey();
        }
    }
}

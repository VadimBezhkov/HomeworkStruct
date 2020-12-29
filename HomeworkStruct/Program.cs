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
            Product apple2 = new Product(2, 56m, 44, "apple2");
            Product apple3 = new Product(3, 57m, 44, "apple3");
            Product apple4 = new Product(4, 51m, 44, "apple4");
            Product apple5 = new Product(5, 53m, 44, "apple5");
            Product apple6 = new Product(6, 55m, 44, "apple6");
            Product apple7 = new Product(7, 44m, 44, "apple7");

            Product bananas = new Product(8,44,"banan");
            Product bananas2 = new Product(8, 44,55);
            Product bananas3 = new Product(8, 44,99);
            Product bananas4 = new Product(8, 44);


            Struct_Sklad sklad = new Struct_Sklad();
            sklad.Sklad();

            sklad.AddProducts(apple);
            sklad.AddProducts(apple2);
            sklad.AddProducts(apple3);
            sklad.AddProducts(apple4);
            sklad.AddProducts(apple5);
            sklad.AddProducts(apple6);
            sklad.AddProducts(apple7);

            sklad.AddProducts(bananas);
            sklad.AddProducts(bananas2);
            sklad.AddProducts(bananas3);
            sklad.AddProducts(bananas4);

            sklad.GetProductsInfo();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Summ total product: {sklad.GetSummInfo()}");
            Console.ResetColor();
            
            Console.ReadKey();
        }
    }
}

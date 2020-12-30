using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkStruct
{
    struct Struct_Sklad
    {

        Product[] products;

        public int productsCount;
        public int warehouseSize;

        public void Sklad()
        {
            warehouseSize = 5000;
            productsCount = 0;
            products = new Product[warehouseSize];
        }

        public void AddProducts(Product product)
        {
            if (warehouseSize<= productsCount)
            {
                Console.WriteLine($"Out of stock. Product {product.Name} does not fit.");
                return;
            }
            products[productsCount++] = product;
        }

        public void GetProductsInfo()
        {
            for (int i = 0; i < productsCount; i++)
            {
                GetPrint(products[i]);
            }
        }

        public decimal GetSummInfo()
        {
            decimal summProducts = 0;

            if (productsCount>0&&products!=null)
            {
                foreach (var item in products)
                {

                    if(item.Price!=0&&item.Count!=0)
                        summProducts =  item.Count* item.Price+ summProducts;
                    else
                    {
                        return summProducts;
                    }

                }
                return summProducts;
            }
            return 0;
        }
        public void GetPrint(Product product)
        {
            Console.WriteLine($"ID: {product.ID} Name: {product.Name} " +
                $"Price: {product.Price} Count: {product.Count}");
        }
    }
}

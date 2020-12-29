using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkStruct
{
   struct Product
    {

        private int _count;
        private decimal _price;
        private string _name;
        private int _iD;

        public string Name
        {
            get { return _name; }
        }

        public decimal Price
        {
            get { return _price; }
        }

        public int Count
        {
            get { return _count; }
        }

        public int ID
        {
            get { return _iD; }
        }
       
        public Product(int ID,decimal price,int count,string name)
        {
            _iD = ID;
            _price = price;
            _count = count;
            _name = name;
        }

         public Product(int ID, decimal price, string name) 
            : this (ID, price, 0,name)
        {
            
        }
        public Product(int ID, string name)
           : this(ID, 0, 0, name)
        {

        }
        public Product( string name)
           : this(0, 0, 0, name)
        {

        }
        public Product(int ID, decimal price)
           : this(ID, price, null)
        {

        }
        public Product( decimal price,int count, string name)
           : this(0, price,count, name)
        {

        }
        public Product(int ID,int count, string name)
           : this(ID, 0, 0, name)
        {

        }
        public Product(int ID, decimal price,int count)
           : this(ID, price, count, null)
        {

        }
        public void GetPrint()
        {
            Console.WriteLine($"ID: {_iD} Name: {_name} Price: {_price} Count: {_count}");
        }
    }
}
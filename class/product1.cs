using System;

namespace product1
{
    interface product
    {
         void doing();
          int ID{get;set;}
    }
    class productdoor : product
    {
        public int ID{get;set;}
        public productdoor(int id)
        {
            ID=id;
        }
        public void doing()
        {
            Console.WriteLine("Сделал дверь");
        }
    }
    class productwindow : product
    {
        public int ID{get;set;}
        public productwindow(int id)
        {
            ID=id;
        }
        public void doing()
        {
            Console.WriteLine("Сделал окно");
        }
    }
    
}
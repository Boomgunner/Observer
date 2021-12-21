using System;
using facktory;
using product1;


namespace Наблюдатель
{
    class Program
    {
        static void Main(string[] args)
        {
            facktories doing1 = new facktories();
            doing1.Addfacktory (new Facktory("Большевичка",1));
            doing1.Addfacktory (new Facktory("Росатом",2));
            doing1.Addfacktory (new Facktory("Синергия",1));
            doing1.Addfacktory (new Facktory("Минкульт",2));
            productwindow window = new productwindow(1);
            productdoor door = new productdoor(2);

            
            while(true)
            {
                Console.WriteLine("Вы хотите что-то производить?\n1-Окна\n2-Двери");
                string inter = Console.ReadLine();
                if(inter=="")
                {
                    break;
                }
                switch (inter)
                {
                case "1":
                doing1.update(window);
                break;
                case "2":
                doing1.update(door);
                break;
                default:
                Console.WriteLine("Не верно введены значения");
                break;
                }
                
                
            }
            
            Console.ReadKey(true);
        }
       
    }
}

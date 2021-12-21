using System;
using product1;
using System.Collections.Generic;
namespace facktory
{
    class Facktory:Iwork
    {
        public int ID{get;private set;}
        public string name{get;private set;}
        public Facktory(string name,int ID)
        {
            this.name=name;
            this.ID=ID;
        }
        public void work(product k)
        {
            Console.WriteLine($"Завод {name}, работаю");
            if(this.ID==k.ID)
            {
                k.doing();
            }
            else
            {
                stop();
            }
            
        }
        public void stop()
        {
            Console.WriteLine($"Завод {name}, не могу произвести");
        }
    }

    interface Iwork
    {
        void work(product k);
        void stop();
    }
    class facktories:Imassegae
    {
         private List<Iwork> plant;
        
        public void Addfacktory(Iwork o)
        {
            plant.Add(o);
        }
        public facktories()
        {
            plant = new List<Iwork>();
        }
        public void update(product i)
        {
            Console.WriteLine("Оповещаю заводы");
            foreach(Iwork fac in plant)
            {
                fac.work(i);
            }
        }
    }
    interface Imassegae
    {
        void update(product i);

    }
    
}
using System;

namespace InheritancePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef();///superclass
            chef.MakeSpecialDish();



           // ItalianChef italianChef = new ItalianChef();//subclass
           // italianChef.MakeChicken();

            ItalianChef italianChef = new ItalianChef();//subclass (Pasta only made in subclass not super)
            italianChef.MakeSpecialDish();





        }
    }
}

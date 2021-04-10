using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    class ItalianChef: Chef
    {
        public override void MakeSpecialDish() /// virtual means method can be overridden in subclasses--- change to override
        {
            Console.WriteLine("The Chef makes chicken parm");
        }


        public void MakePasta()
        {
            Console.WriteLine("The Chef makes pasta");
        }
    }
}

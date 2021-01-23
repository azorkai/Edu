using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> Name = new MyDictionary<string>();
            Name.Add("Emirhan");
            Name.Add("Cansın");
            Name.Add("Sude");
            Name.Add("Bryan Adams");
            Name.Add("LeBron James");
            Name.Add("Stephen Curry");
            Name.Add("Erich von Däniken");
            Name.Add("Elon Musk");

            Name.List();
            Console.ReadLine();
        }
    }
}

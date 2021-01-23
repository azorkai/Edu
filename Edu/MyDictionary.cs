using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu
{
    class MyDictionary<T>
    {
        T[] names;

        public MyDictionary()
        {
            names = new T[0];
        }

        public void Add(T name)
        {
            T[] tempNames = names;
            names = new T[names.Length + 1];

            for (int i = 0; i < tempNames.Length; i++)
            {
                names[i] = tempNames[i];
            }

            names[names.Length - 1] = name;
        }

        public void List()
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}

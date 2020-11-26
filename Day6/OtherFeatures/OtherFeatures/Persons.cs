using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherFeatures
{

    
    class Persons : IEnumerable
    {
        string[] names;
        public Persons(params string[] nameParam)
        {
            names = new string[nameParam.Length];
            nameParam.CopyTo(names, 0);
        }

        public IEnumerator GetEnumerator()
        {
            foreach(string str in names)
            {
                yield return str;
            }
        }
    }
}

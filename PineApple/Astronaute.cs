using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PineApple
{
    class Astronaute
    {
        string _name;
        private static int _referenceNumber = 0;
        private int _number;
        public Astronaute(string name)
        {
            _number = _referenceNumber;
            _referenceNumber++;
            _name = name;
        }
        public string getName()
        {
            return _name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PineApple
{
    class Location
    {
        private static int _referenceNumber = 0;
        private int _number;
        private string _name;
        private int _posx;
        private int _posy;
        private const int _width = 1095;
        private const int _height=2053;
        private const int _abZero = 700;
        private const int _ordZero = 1000;
        private const int _metrePixel = 5;//5m par pixels

        public Location(string name, int posx, int posy)
        {
            _referenceNumber++;
            _number = _referenceNumber;
            _name = name;
            _posx = posx;
            _posy = posy;
        }
        /// <summary>
        /// Return (array) the location in pixels/the origin 
        /// </summary>
        /// <returns></returns>
        public int[] getLocation()
        {
            int[] tab={_posx,_posy};
            return tab;
        }
        public void setLocation(int posx, int posy)
        {
            _posx = posx;
            _posy = posy;
        }
    }
}

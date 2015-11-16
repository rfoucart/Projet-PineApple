using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PineApple
{
    class Activity
    {
        private static int _referenceNumber=0;
        private int _number;
        private string _name;
        private string _description;
        private GenericType _genericType;
        private string _type;
        private List<Astronaute> _astronautes;
        private Location _location;
        private bool _externMission;
        private bool _spaceVehicle;
        private MDate _startDate;
        private MDate _endDate;

        /// <summary>
        /// 
        /// </summary>
        public Activity(string name, string description, GenericType genericType ,string type, Location location, List<Astronaute> astronautes, bool externMission, bool spaceVehicle, MDate startDate, MDate endDate)
        {
            _number = _referenceNumber;
            _referenceNumber++;
            _name = name;
            _description = description;
            _genericType = genericType;
            _type = type;
            _location = location;
            _externMission = externMission;
            _spaceVehicle = spaceVehicle;
            _astronautes = astronautes;
            _startDate = startDate;
            _endDate = endDate;
        }
        public int getNumber()
        {
            return _number;
        }
        public string getName()
        {
            return _name;
        }
        public string getDescription()
        {
            return _description;
        }
        public  Location getLocation()
        {
            return _location;
        }
        public List<Astronaute> getAstronautes()
        {
            return _astronautes;
        }
        public MDate getStartDate()
        {
            return _startDate;
        }
        public MDate getEndDate()
        {
            return _endDate;
        }
        public GenericType getGenericType()
        {
            return _genericType;
        }
        public string getType()
        {
            return _type;
        }

    }
}

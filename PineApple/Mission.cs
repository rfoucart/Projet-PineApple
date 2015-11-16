using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PineApple
{
    class Mission
    {
        private List<Activity> _activies;
        private List<Day> _days;
        private List<Astronaute> _astronautes;
        private int _numberOfDays;
        private string _name;
        private List<GenericType> _genericTypes;
        private int _currentDay;
        

        /// <summary>
        /// 
        /// </summary>
        public Mission(string name, int numberOfDays)
        {

            _numberOfDays = numberOfDays;
            _activies = new List<Activity>(0);
            _astronautes = new List<Astronaute>(0);
            _days = new List<Day>(_numberOfDays);
            _genericTypes = new List<GenericType>(0);
            _name = name;
            string[] Living = {"Eating","Sleeping","Entertainment","Private","Health control","Medical Act"};
            string[] Science = {"Exploration","Briefing","Debriefing","Inside Experiment","Outside Experiment"};
            string[] Maintenance = {"Cleaning","LSS air system","LSS water system","LSS food system","Power systems","Space suit","Other"};
            string[] Communication = {"Sending message","Receiving message"};
            string[] Repair = { "LSS", "Power systems", "Communication systems","Propulsion systems","Habitat","Space suit","Vehicle"};
            string[] Emergency = {"None"};
            _genericTypes.Add(new GenericType("Living",Living));
            _genericTypes.Add(new GenericType("Science", Science));
            _genericTypes.Add(new GenericType("Maintenance", Maintenance));
            _genericTypes.Add(new GenericType("Communication", Communication));
            _genericTypes.Add(new GenericType("Repair", Repair));
            _genericTypes.Add(new GenericType("Emergency", Emergency));

        }

        /// <summary>
        /// Add an activity
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="genericType"></param>
        /// <param name="type"></param>
        /// <param name="location"></param>
        /// <param name="astronautes"></param>
        /// <param name="externMission"></param>
        /// <param name="spaceVehicle"></param>
        public void newActivity(string name, string description,GenericType genericType, string type, Location location, List<Astronaute> astronautes, bool externMission, bool spaceVehicle, MDate startDate, MDate endDate)
        {
            _activies.Add(new Activity(name, description, genericType, type, location, astronautes, externMission, spaceVehicle, startDate, endDate));
        }

        /// <summary>
        /// Delete an activity
        /// </summary>
        /// <param name="number"></param>
        public void deleteActivity(int number)
        {
            _activies.RemoveAll(x => x.getNumber() == number);
        }
        public void newLocation()
        {

        }
        public void newAstronaute(string name)
        {
            _astronautes.Add(new Astronaute(name));
        }
        /// <summary>
        /// fill the days and time unites from the activities list
        /// </summary>
        public void fillTimeUnites()
        {

        }
        /// <summary>
        /// fill activities from the XML file
        /// </summary>
        public void fillActivities()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="searchDates"></param>
        /// <returns></returns>
        public List<Activity> searchByPeriod(MDate[] searchDates)
        {
            return new List<Activity>(0);
        }

        /// <summary>
        /// search method by day
        /// </summary>
        /// <param name="searchDate"></param>
        /// <returns></returns>
        public List<Activity> searchByDate(MDate searchDate)
        {
            return new List<Activity>(0);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public List<Activity> searchByType(string type)
        {
            return new List<Activity>(0);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="genericType"></param>
        /// <returns></returns>
        public List<Activity> searchByGenericType(string genericType)
        {
            return new List<Activity>(0);
        }
        
    }
}

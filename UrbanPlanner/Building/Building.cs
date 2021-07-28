using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrbanPlanner
{
    class Building
    {
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public int Volume { get; private set; }

        private string _designer;
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;

        public Building(string address, int stories, double width, double depth)
        {
            _address = address;
            _designer = "Honey-Rae";
            Stories = stories;
            Width = width;
            Depth = depth;
            Volume = (int)(Width * Depth * (3 * Stories));
        }
        
        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string name)
        {
            _owner = name;
            Console.WriteLine($"The building at {_address} is {Volume} cubic meters and was constructed on" +
                $"{_dateConstructed}. The building was designed by {_designer} and is owned by {_owner}");
        }
    }
}

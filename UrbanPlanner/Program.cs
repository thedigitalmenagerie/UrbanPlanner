using System;

namespace UrbanPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            var Home = new Building("106 E Oak St", 1, 300, 300);
            var NewHome = new Building("35 Parker Rd", 2, 600, 600);

            Home.Construct();
            NewHome.Construct();
            NewHome.Purchase("Honey-Rae");
        }
    }
}

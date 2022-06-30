using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Dixit_Hihoriya
{
    class City
    {
        public string Name { get; private set; }
        public string Country { get; private set; }
        public string Description { get; private set; }
        public string Image { get; private set; }
        public City(string name, string country, string description, string image)
        {
            Name = name;
            Country = country;
            Description = description;
            Image = image;
        }
        public static List<City> GetCities()
        => new List<City>
        {
            new City("Toronto","Canada","Captial City of Ontario Province","images\\toronto.jpg"),
            new City("New york","US","Captial City of New York State","images\\newyork.jpg"),
            new City("Tokyo","Japan","Captial City of Japan","images\\tokyo.jpg"),
            new City("Montreal","Canada","City in Quebec Province","images\\montreal.jpg"),
        };
    }
}

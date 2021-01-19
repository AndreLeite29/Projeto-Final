using System;
using System.Collections.Generic;
using System.Text;

namespace Stand_v2
{
    class Carros                                //Propriedades
    {
        public Carros(string name, int miles_per_Gallon, int cylinders, int kilometers, int horsepower, int weight_in_lbs, float acceleration, string year, string origin, int price)
        {
            Name = name;
            Miles_per_Gallon = miles_per_Gallon;
            Cylinders = cylinders;
            Kilometers = kilometers;
            Horsepower = horsepower;
            Weight_in_lbs = weight_in_lbs;
            Acceleration = acceleration;
            Year = year;
            Origin = origin;
            Price = price;
        }

        public string Name { get; set; }

        public int Miles_per_Gallon { get; set; }

        public int Cylinders { get; set; }

        public int Kilometers { get; set; }

        public int Horsepower { get; set; }

        public int Weight_in_lbs { get; set; }

        public float Acceleration { get; set; }

        public string Year { get; set; }

        public string Origin { get; set; }

        public int Price { get; set; }
    }
}

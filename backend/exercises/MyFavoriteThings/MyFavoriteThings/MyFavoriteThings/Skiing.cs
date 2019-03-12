using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings
{
    class Skiing
    {
        // ------------ PROPERTIES ------------
        public string Name { get; }
        public string City { get; }
        public SkiingState State { get; }
        public SkiType Type { get; }

        // ------------ CONSTRUCTOR ------------
        public Skiing(string name, string city, SkiingState state, SkiType type)
        {
            Name = name;
            City = city;
            State = state;
            Type = type;
        }

        // ------------ METHODS ------------
        public void skiOrBoard()
        {
            if (Type == SkiType.Ski)
            {
                Console.WriteLine("Yes! Skiing is the best");
            }
            else
            {
                Console.WriteLine("Why don't you ski?");
            }
        }

        public void powder()
        {
            Console.WriteLine("Nothing beats fresh powder!");
        }
    }

    enum SkiingState
    {
        Colorado,
        Utah,
        California,
        Canada,
        Switzerland,
        Austria,
        France,
        Oregon,
        Wyoming,
        Montana,
        Vermont
    }

    enum SkiType{ Ski, Snowboard }
}

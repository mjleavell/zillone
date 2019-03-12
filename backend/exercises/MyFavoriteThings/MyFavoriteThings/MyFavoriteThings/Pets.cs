using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings
{
    class Pets
    {
        // ------------ PROPERTIES ------------
        public string Name { get; }
        public int Age { get; }
        public string Color { get; }
        public PetType Type { get; }

        // ------------ CONSTRUCTOR ------------
        public Pets(string name, int age, string color, PetType type)
        {
            Name = name;
            Age = age;
            Color = color;
            Type = type;
        }

        // ------------ METHODS ------------
        public void fetch()
        {
            Console.WriteLine("Chasing after a yellow tennis ball is my favorite thing!");
        }

        public void tricks()
        {
            Console.WriteLine("Sit, stay, lay down, roll over are the best tricks");
        }
    }

    enum PetType
    {
        Labrador,
        Corgi,
        Poodle,
        Retriever
    }
}

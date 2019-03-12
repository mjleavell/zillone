using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings
{
    class Books
    {
        // ------------ PROPERTIES ------------
        public string Name { get; }
        public string Author { get; }
        public BookGenre Genre { get; }

        // ------------ CONSTRUCTOR ------------
        public Books(string name, string author, BookGenre genre)
        {
            Name = name;
            Author = author;
            Genre = genre;
        }

        // ------------ METHODS ------------
        public void bestBook()
        {
            if (Genre == BookGenre.Fiction)
            {
                Console.WriteLine("Yes! Fiction is the best");
            }
            else
            {
                Console.WriteLine("Why don't you like Fiction?");
            }
        }

        public void place()
        {
            Console.WriteLine("I love reading at the beach");
        }
    }

    enum BookGenre
    {
        Biography,
        Fiction,
        History,
        Kids,
        Mystery,
        Religion,
        SciFi
    }
}

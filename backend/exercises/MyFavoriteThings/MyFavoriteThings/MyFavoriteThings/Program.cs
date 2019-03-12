using System;

namespace MyFavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var book1 = new Books("Pride and Prejudice", "Jane Austen", BookGenre.Fiction);

            book1.bestBook();
            book1.place();

            var pet1 = new Pets("Hank", 4, "Black", PetType.Labrador);

            pet1.fetch();
            pet1.tricks();

            var skiResort1 = new Skiing("Deer Valley", "Salt Lake", SkiingState.Utah, SkiType.Ski);

            skiResort1.skiOrBoard();
            skiResort1.powder();

            var show1 = new TV("Grey's Anatomy", "Ellen Pompeo", TVNetwork.ABC);

            show1.bestNetwork();
            show1.bestShow();

            Console.ReadLine();
        }
    }
}

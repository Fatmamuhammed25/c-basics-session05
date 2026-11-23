using System;

namespace BookAssignment
{
    // Task 4: the Genre enum
    enum Genre
    {
        Fiction,     // 0
        NonFiction,  // 1
        Science      // 2
    }

    class Book
    {
        // Task 1: private field -> can only be used inside the Book class
        private string password = "secret";

        // Task 2: internal field -> can be used anywhere inside the same project
        internal int copiesInStock = 5;

        // Task 3: public field -> can be used from anywhere
        public string Title;

        // Task 4: a property of type Genre
        public Genre Genre { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();

            #region Task 1: private field
            // Console.WriteLine(book.password);
            // The line above gives a compile error (CS0122):
            // 'Book.password' is inaccessible due to its protection level.
            // Why? Because "private" means the field can only be accessed
            // inside the Book class itself, and Main is outside it.
            Console.WriteLine("Task 1: see the comment above (compile error if uncommented)");
            #endregion

            #region Task 2: internal field
            Console.WriteLine("Task 2: copiesInStock = " + book.copiesInStock);
            // It compiles, because "internal" means the field can be accessed
            // from anywhere inside the same project (assembly), and Main
            // and Book are in the same project.
            #endregion

            #region Task 3: public field
            book.Title = "C# for Beginners";
            Console.WriteLine("Task 3: Title = " + book.Title);
            #endregion

            #region Task 4: enum property
            book.Genre = Genre.Science;
            Console.WriteLine("Task 4: Genre = " + book.Genre);
            #endregion

            #region Task 5: enum to int (casting)
            Console.WriteLine("Task 5:");
            Console.WriteLine("Fiction    = " + (int)Genre.Fiction);
            Console.WriteLine("NonFiction = " + (int)Genre.NonFiction);
            Console.WriteLine("Science    = " + (int)Genre.Science);
            #endregion

            #region Task 6: int to enum (casting)
            int genreNumber = 1;
            Genre genreFromNumber = (Genre)genreNumber;
            Console.WriteLine("Task 6: " + genreFromNumber);
            #endregion

            #region Task 7: enum to string using ToString()
            Genre genre = Genre.Fiction;
            string genreString = genre.ToString();
            Console.WriteLine("Task 7: " + genreString);
            #endregion

            #region Task 8: string to enum using Enum.Parse()
            string genreText = "Science";
            Genre parsedGenre = (Genre)Enum.Parse(typeof(Genre), genreText);
            Console.WriteLine("Task 8: " + parsedGenre);
            #endregion

            #region Task 9: Enum.TryParse() with an invalid value
            string wrongText = "Mystery";
            Genre result;
            bool success = Enum.TryParse(wrongText, out result);

            if (success)
            {
                Console.WriteLine("Task 9: " + result);
            }
            else
            {
                Console.WriteLine("Task 9: Unknown genre");
            }
            #endregion
        }
    }
}
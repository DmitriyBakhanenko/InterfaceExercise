//Exercise:

// Write a program where the user enters the names of creative works and their writers, and then the program outputs that information.

// Requirements:

// Create an interface called IWritable that can be used with classes that represent creative works.The interface should define two methods - GetNameOfWork() and GetWriter().

// In the Program class, write a method called PrintWriter() that accepts an IWritable object as input and prints out the name of the work and the writer.

// Now, create three classes - Novel, which contains the fields name and author; Movie which contains the fields name and screenwriter; and Song, which contains the fields name and songwriter.Have each class implement the IWritable interface.

// In the Main() method, prompt the user to enter the data for a novel, movie, and song, and store the data in those types of objects.Then use the PrintWriter method to print the writer info for each of the objects.

// Output should match the following example:
// Enter name of novel: Pride and Prejudice
// Enter name of author: Jane Austen

// Enter name of movie: La La Land
// Enter name of screenwriter: Damien Chazelle

// Enter name of song: Fallin
// Enter name of songwriter: Alicia Keys

using System;

namespace CourseWork_ex15
{
    internal class Program
    {
        private static string Name { get; set; }
        private static string Author { get; set; }

        private static void Main()
        {
            Console.Write("Enter name of novel: ");
            Name = Console.ReadLine();
            Console.Write("Enter name of author: ");
            Author = Console.ReadLine();
            Console.WriteLine();

            var novel = new Novel(Name, Author);

            Console.Write("Enter name of movie: ");
            Name = Console.ReadLine();
            Console.Write("Enter name of screenwriter: ");
            Author = Console.ReadLine();
            Console.WriteLine();

            var movie = new Movie(Name, Author);

            Console.Write("Enter name of song: ");
            Name = Console.ReadLine();
            Console.Write("Enter name of songwriter: ");
            Author = Console.ReadLine();
            Console.WriteLine();

            var song = new Song(Name, Author);

            PrintWriter(novel);
            PrintWriter(movie);
            PrintWriter(song);
            Console.Read();
        }

        private static void PrintWriter(IWritable displayObject)
        {
            Console.WriteLine($"Name of work: {displayObject.GetNameOfWork()}");
            Console.WriteLine($"Written by: {displayObject.GetWriter()}");
            Console.WriteLine();
        }
    }


    internal interface IWritable
    {
        string GetNameOfWork();
        string GetWriter();
    }

    internal class Novel : IWritable
    {
        private string Name { get; }
        private string Author { get; }

        public Novel(string name, string author)
        {
            Name = name;
            Author = author;
        }

        public string GetNameOfWork()
        {
            return Name;
        }

        public string GetWriter()
        {
            return Author;
        }
    }

    internal class Movie : IWritable
    {
        private string Name { get; }
        private string Screanwriter { get; }

        public Movie(string name, string screenwriter)
        {
            Name = name;
            Screanwriter = screenwriter;
        }

        public string GetNameOfWork()
        {
            return Name;
        }

        public string GetWriter()
        {
            return Screanwriter;
        }
    }

    internal class Song : IWritable
    {
        private string Name { get; }
        private string Songwriter { get; }

        public Song(string name, string songwriter)
        {
            Name = name;
            Songwriter = songwriter;
        }

        public string GetNameOfWork()
        {
            return Name;
        }

        public string GetWriter()
        {
            return Songwriter;
        }
    }
}

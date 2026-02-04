namespace Part_1_Basics___Topic_1_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // #1 a,b,c,d Below
            string firstName = "Linkin";
            string favMovie = "The Matrix";
            favMovie = favMovie.ToUpper();

            Console.WriteLine($"hello {firstName}, welcome to the program. based on what your doing here i am going to assume you like the movie {favMovie}");
            Console.WriteLine();

            Console.WriteLine(favMovie.Contains("THE"));
            Console.WriteLine();

            favMovie = favMovie.Replace('A', '@');
            favMovie = favMovie.Replace('E', '3');
            Console.WriteLine(favMovie);
            Console.WriteLine();

            //#2 Below
            string musicQuote = "Don't you know that I'm still standing better than I ever did";

            musicQuote = musicQuote.Replace('a', ' ');
            musicQuote = musicQuote.Replace('e', ' ');
            musicQuote = musicQuote.Replace('i', ' ');
            musicQuote = musicQuote.Replace('o', ' ');
            musicQuote = musicQuote.Replace('u', ' ');

            Console.WriteLine(musicQuote);
            Console.WriteLine();

            //#3 Below
            Console.WriteLine(".==========.         ,*-.");
            Console.WriteLine("|      |   |         |  |");
            Console.WriteLine("| ===. .=. |     ,.  |  |");
            Console.WriteLine("|    |   | |     | |_|  | ,.");
            Console.WriteLine("|  | .== | |     `___.  |_| |");
            Console.WriteLine("|  |     | |         |  .--`");
            Console.WriteLine(".==========.         |  |");
            Console.WriteLine("                     |  |");

        }
    }
}

namespace Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FavBook favbok = new FavBook();

           

            Console.WriteLine(favbok[0, "C#", "Joe"]);
            Console.WriteLine(favbok[1, "C++", "Jhon"]);
        }
    }
}
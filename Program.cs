using System;

namespace Demo_LatestLangFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Person CFO = new Person();
            //CFO.Fname = "Minny";
            //CFO.LName = "Scot";

            NewPerson CEO = new NewPerson();
            CEO.Firstname = "Anusha";
            CEO.LastName = "Sana";

            Coordinates India = new Coordinates(120, 220);
            Console.WriteLine("Indian Coordinates are "+India.X+India.Y);
            Console.WriteLine(MyEnum.Blue + "is my fav color");

        }
    }
    public record Person(string Fname, string Lname); 

    public record Person1
    {
        public string Firstname { get; init; } = default!;

        public string LastName { get; init; } = default!;
    }


    public record NewPerson
    {
        public string Firstname { get; set; } = default!;

        public string LastName { get; set; } = default!;
    }
}

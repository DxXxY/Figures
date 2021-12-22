using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(2, 6);
            Romb romb = new Romb(2, 2);
            Squre squre = new Squre(4);
            TeamSolyanka ts=new TeamSolyanka();
            ts.Add(romb);
            ts.Add(rectangle);
            ts.Add(squre);
            Console.WriteLine(ts.GiveArea());

            
        }
    }
}

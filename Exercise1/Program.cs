using System;
using System.Threading;

namespace Exercise1
{
    class Program
    {
        static void Main( string[] args )
        {
            FuelTank fuel = new FuelTank(5);
            Console.Out.WriteLine("оого" + fuel.GetAmount());
            fuel.Fill(5);

            Engine eng = new();
            Console.Out.WriteLine( "State: " + eng.GetState() );
            Console.Out.WriteLine();

            eng.Start();
            Console.Out.WriteLine( "State: " + eng.GetState() );
            Thread.Sleep( 2000 );
            Console.Out.WriteLine();

            eng.Stop();
            Console.Out.WriteLine( "State: " + eng.GetState() );

            Console.ReadKey();
        }
    }
}

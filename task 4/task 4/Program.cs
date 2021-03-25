using System;
using System.Threading;

namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // minimum terminal window height = 6
            // DO NOT resize after launching
            // kill with ^C
            new RunChains(-1).Run();
            // the argument has to be a positive integer
            // -1 means occupy every column
        }

    }
}

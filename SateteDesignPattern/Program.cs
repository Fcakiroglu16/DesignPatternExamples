using System;

namespace SateteDesignPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            WriteContext context = new WriteContext();

            context.TranstionTo(new DebugState());

            context.Write("merhaba debug state");

            //Otomadik olarak  DebugState çalıştığında DebuState'den ConsoleState'e geçiş var
            // istnirse iptal edilebilir
            //context.TranstionTo(new ConsoleState());

            context.Write("merhaba console state");

            Console.WriteLine("######################################################");

            //Kötü olan yol

            WriteContextBad writeContextBad = new WriteContextBad();

            writeContextBad.state = State2.Console;

            writeContextBad.Write("Merhaba  console state");
        }
    }
}
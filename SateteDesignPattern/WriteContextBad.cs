using System;
using System.Collections.Generic;
using System.Text;

namespace SateteDesignPattern
{
    internal enum State2
    {
        Debug,
        Console
    }

    internal class WriteContextBad
    {
        public State2 state { get; set; }

        public void Write(string text)
        {
            switch (state)
            {
                case State2.Debug:

                    Console.WriteLine("Debug has writed :" + text);
                    break;

                case State2.Console:

                    Console.WriteLine("Console has writed :" + text);
                    break;

                default:
                    break;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace SateteDesignPattern
{
    internal class ConsoleState : State
    {
        internal override void Write(string text)
        {
            Console.WriteLine("Console has writed :" + text);
        }
    }
}
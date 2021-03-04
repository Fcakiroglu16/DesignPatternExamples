using System;
using System.Collections.Generic;
using System.Text;

namespace SateteDesignPattern
{
    internal class DebugState : State
    {
        internal override void Write(string text)
        {
            Console.WriteLine("Debug has writed :" + text);

            //İstenirse diğer state'e geçilebilir

            _context.TranstionTo(new ConsoleState());
        }
    }
}
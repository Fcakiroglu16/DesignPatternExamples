using System;
using System.Collections.Generic;
using System.Text;

namespace SateteDesignPattern
{
    internal class WriteContext
    {
        public State _currentState { get; set; } = null;

        public void TranstionTo(State state)
        {
            _currentState = state;
            _currentState.SetContext(this);
        }

        public void Write(string text)
        {
            _currentState.Write(text);
        }
    }
}
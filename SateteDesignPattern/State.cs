using System;
using System.Collections.Generic;
using System.Text;

namespace SateteDesignPattern
{
    internal abstract class State
    {
        //Somut State'ler arasında state değiştirebilmek için
        protected WriteContext _context;

        public void SetContext(WriteContext context)
        {
            _context = context;
        }

        internal abstract void Write(string text);
    }
}
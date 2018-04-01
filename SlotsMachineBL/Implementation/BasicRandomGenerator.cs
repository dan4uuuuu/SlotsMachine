using SlotsMachineBL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlotsMachineBL
{
    public class BasicRandomGenerator : IRandomGenerator
    {
        private Random generator { get; set; }
        public BasicRandomGenerator()
        {
            generator = new Random();
        }

        public int GetNext(int maxValue)
        {
            return generator.Next(maxValue);
        }
    }
}

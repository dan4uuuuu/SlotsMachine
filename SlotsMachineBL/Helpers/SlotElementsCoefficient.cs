using System;
using System.Collections.Generic;
using System.Text;

namespace SlotsMachineBL.Helpers
{
    public class SlotElementsCoefficient
    {
        public SlotElementsCoefficient()
        {
            this.SlotsCoefficient = new List<KeyValuePair<int, double>>()
            {
                new KeyValuePair<int, double>(1, 0.4),
                new KeyValuePair<int, double>(2, 0.6),
                new KeyValuePair<int, double>(3, 0.8),
                new KeyValuePair<int, double>(4, 0.0)
            };
        }
        public List<KeyValuePair<int, double>> SlotsCoefficient { get; set; }
    }
}

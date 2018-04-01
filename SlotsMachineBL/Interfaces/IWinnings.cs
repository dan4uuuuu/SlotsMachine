using System;
using System.Collections.Generic;
using System.Text;

namespace SlotsMachineBL.Interfaces
{
    public interface IWinnings
    {
        void Calculate(List<List<ISlotElement>> spinResult, int deposit, int stake);
    }
}

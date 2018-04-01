using System.Collections.Generic;

namespace SlotsMachineBL.Interfaces
{
    public interface ISlotMachine
    {
        List<List<ISlotElement>> Spin();
    }
}
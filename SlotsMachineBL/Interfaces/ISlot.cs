using System;
using System.Collections.Generic;
using System.Text;

namespace SlotsMachineBL.Interfaces
{
  

    public interface ISlot
    {
        List<ISlotElement> Spin();
    }

}

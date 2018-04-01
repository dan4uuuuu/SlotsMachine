using SlotsMachineBL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlotsMachineBL
{
    public class SlotMachine : ISlotMachine
    {
        List<ISlot> Slots { get; set; }

        public SlotMachine()
        {
            Slots = new List<ISlot>();
        }

        public SlotMachine(List<ISlot> slots)
        {
            Slots = new List<ISlot>();
            Slots.AddRange(slots);
        }


        public void AddSlot(ISlot slot)
        {
            Slots.Add(slot);
        }

        public List<List<ISlotElement>> Spin()
        {
            var result = new List<List<ISlotElement>>();
            foreach(var slot in Slots)
            {
                var spinResult = slot.Spin();
                result.Add(spinResult);
            }

            return result;
        }
    }
}

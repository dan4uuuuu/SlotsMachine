using SlotsMachineBL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlotsMachineBL
{
    public class BedeSlotMachine : SlotMachine
    {
        private readonly int SLOT_COUNT = 3;
        private readonly int ROWS_COUNT = 4;

        public BedeSlotMachine() : base()
        {
            List<ISlotElement> elements;
            SlotElement apple = new SlotElement(1, "Apple");
            SlotElement banana = new SlotElement(2, "Banana");
            SlotElement pineaple = new SlotElement(3, "Pineaple");
            SlotElement wildcard = new SlotElement(4, "*");

            for (int i = 0; i < SLOT_COUNT; i++)
            {
                elements = new List<ISlotElement>();
                AddRepeatebleSlotElements(elements, apple, 9);
                AddRepeatebleSlotElements(elements, pineaple, 7);
                AddRepeatebleSlotElements(elements, banana, 3);
                AddRepeatebleSlotElements(elements, wildcard, 1);
                var slot = new Slot(new BasicRandomGenerator(), elements, ROWS_COUNT);
                AddSlot(slot);
            }
        }

        public Winnings CalculateWinnings(List<List<ISlotElement>> result, int deposit, int stake)
        {
            return new Winnings(result, deposit, stake);
        }

        public List<List<ISlotElement>> SpinBedeSlotMachine()
        {
            return Spin();
        }



        private  void AddRepeatebleSlotElements(List<ISlotElement> elements, SlotElement element, int max)
        {
            for (int i = 1; i <= max; i++)
            {
                elements.Add(element);
            }
        }
    }
}

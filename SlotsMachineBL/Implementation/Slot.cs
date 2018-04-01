using SlotsMachineBL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlotsMachineBL
{
    public class SlotElement : ISlotElement
    {
        public int Id { get; set; }
        public string Name { get; set;}

        public SlotElement(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    public class Slot : ISlot
    {
        private IList<ISlotElement> Elements { get; set; }
        private IRandomGenerator Generator { get; set; }
        private int VisibleRows { get; set; }

        public Slot(IRandomGenerator generator, IList<ISlotElement> elements, int visibleRows)
        {
            Generator = generator;
            Elements = elements;
            VisibleRows = visibleRows;
        }

        public List<ISlotElement> Spin()
        {
            var result = new List<ISlotElement>();
            int randomPosition = Generator.GetNext(Elements.Count);
            int count = VisibleRows;
            for(int i=randomPosition; count!=0; count--)
            {
                result.Add(Elements[i]);
                if (i++ > Elements.Count) i = 0;
            }
            return result;
        }
    }

}

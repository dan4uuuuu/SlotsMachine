using SlotsMachineBL.Helpers;
using SlotsMachineBL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SlotsMachineBL
{
    public class Winnings : IWinnings
    {
        public Winnings(List<List<ISlotElement>> spinResult, int deposit, int stake)
        {
            AmountWon = 0.0;
            CurrentBalance = 0.0;
            Coefficient = 0.0; 
            Calculate(spinResult, deposit, stake);
        }

        public double AmountWon { get; set; }

        public double CurrentBalance { get; set; }

        public double Coefficient { get; set; }

        public void Calculate(List<List<ISlotElement>> spinResult, int deposit, int stake)
        {
            int rowCount = spinResult.Count;

            SlotElementsCoefficient coefficients = new SlotElementsCoefficient();

            int columnCount = spinResult.First().Count;
            
            for (int i = 0; i < columnCount; i++)
            {
                bool isWin = false;
                Coefficient = 0.0;
                for (int j = 0; j < rowCount; j++)
                {
                    var firstElement = spinResult[0][i].Id;
                    
                    var currentElement = spinResult[j][i].Id;

                    if ( j > 0 )
                    {
                        if (firstElement != currentElement && currentElement != 4)
                        {
                            isWin = false;
                            break;
                        }
                        else
                        {
                            if (Coefficient == 0.0)
                            {
                                Coefficient += coefficients.SlotsCoefficient.Find(x => x.Key == firstElement).Value;
                            }
                            Coefficient += coefficients.SlotsCoefficient.Find(x => x.Key == currentElement).Value;
                        }
                    }

                }
                if (isWin)
                {
                    AmountWon += Coefficient * stake;
                }
                
            }
            CurrentBalance += (deposit - stake) + AmountWon;
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using SlotsMachineBL;
using NUnit.Framework;

namespace SlotsMachineBLTests
{
    [TestClass]
    public class IWinningsTests
    {
        BedeSlotMachine _Bede;
        public IWinningsTests()
        {
           _Bede  = new BedeSlotMachine();
        }

        [TestMethod]
        public void CalculateHasCorrectRowsInData()
        {
            //Arrange
            var spinResult = _Bede.SpinBedeSlotMachine();
            var stake = 5;
            var deposit = 1000;
            var rows = 4;

            //Act
            var result = _Bede.CalculateWinnings(spinResult, deposit, stake);

            //Assert
            NUnit.Framework.Assert.That(spinResult.Count, Is.EqualTo(rows));
        }
    }
}

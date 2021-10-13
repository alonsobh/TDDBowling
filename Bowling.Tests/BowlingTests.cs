using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bowling.Tests
{
    [TestClass]
    public class BowlingTests
    {
        Game g;

        [TestInitialize]
        public void TestInitialize()
        {
            g = new Game();
        }

        [TestMethod]
        public void Roll()
        {
            g.Roll(0);
        }

        [TestMethod]
        public void GutterGame()
        {
            for (int i = 0; i < 20; i++)
                g.Roll(0);

            Assert.AreEqual(0, g.Score());
        }

        [TestMethod]
        public void AllOnes()
        {
            for (int i = 0; i < 20; i++)
                g.Roll(1);

            Assert.AreEqual(20, g.Score());
        }


        /*
        Rules
            Game has 10 frames
            Frames 1-9 have 2 rolls that can addup to 10
            Frame 10 has up to 3 Rolls if 2nd roll is Spare or Strike
            Spare: Frame adds to 10 in the 2 attemps
            Strike: First shot in Frame is 10
        Points
            Frame: Sum of pins in the 2 rolls
            Spare: 10 + next roll
            Strike: 10 + next 2 rolls
        */
    }
}

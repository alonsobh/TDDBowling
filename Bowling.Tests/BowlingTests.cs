using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bowling.Tests
{
    [TestClass]
    public class BowlingTests
    {
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

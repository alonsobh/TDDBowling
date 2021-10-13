﻿namespace Bowling.Tests
{
    internal class Game
    {
        int[] rolls = new int[21];
        int currentRoll = 0;
        internal void Roll(int pins)
        {
            rolls[currentRoll++] = pins;
        }

        internal int Score()
        {
            var score = 0;
            var i = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                score += rolls[i] + rolls[i + 1];
                i += 2;
            }
            return score;
        }
    }
}

using System;

namespace TddTutorialBowling
{
    public class Bowling
    {
        public int CalculateScore(int[][] shots)
        {
            int score = 0;

            for (int i = 0; i < shots.Length; i++)
            {
                score += GetScore(shots, i);
            }

            return score;
        }

        public int GetScore(int[][] shots, int index, bool spare = false, bool strike = false)
        {
            int score = 0;

            for (int i = 0; i < shots[index].Length; i++)
            {
                score += shots[index][i];

                if (spare)
                    return score;

                if (strike && i == 1)
                {
                    return score;
                }
            }

            if (strike)
            { 
                if (shots[index].Length == 1)
                    return score + GetScore(shots, index + 1, true);
            }
                
            if (score == 10)
            {
                // Spare
                if (shots[index].Length == 2)
                    score += GetScore(shots, index + 1, true);

                // Strike
                if (shots[index].Length == 1)
                    score += GetScore(shots, index + 1, false, true);
            }

            return score;
        }
    }
}

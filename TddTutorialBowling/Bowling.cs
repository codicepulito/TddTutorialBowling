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

            foreach (int item in shots[index])
            {
                score += item;

                if (spare)
                {
                    return score;
                }

                if (strike)
                {
                    if (index == 9)
                    {
                        return score + shots[index][1];
                    }
                    else 
                    {
                        if (shots[index].Length == 1)
                        {
                            return score + GetScore(shots, index + 1, false, true);
                        }
                        else 
                        {
                            return score + GetScore(shots, index + 1, true);
                        }
                    }
                }
            }

            if (score == 10)
            {
                // spare
                if (shots[index].Length == 2)
                {
                    score += GetScore(shots, index + 1, true);
                }

                // strike
                //if (shots[index].Length == 1)
                //{
                //    score += GetScore(shots, index + 1, false, true);
                //}
            }

            return score;
        }
    }
}

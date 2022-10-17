using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestTddTutorialBowling
{
    [TestClass]
    public class TestBowling
    {
        TddTutorialBowling.Bowling Bowling;
        int[][] Shots = new int[10][];

        [TestInitialize]
        public void Initialize()
        {
            Bowling = new TddTutorialBowling.Bowling();
        }

        [TestMethod]
        public void Test1AllEmptyShots()
        {
            Shots[0] = new int[] { 0, 0 };
            Shots[1] = new int[] { 0, 0 };
            Shots[2] = new int[] { 0, 0 };
            Shots[3] = new int[] { 0, 0 };
            Shots[4] = new int[] { 0, 0 };
            Shots[5] = new int[] { 0, 0 };
            Shots[6] = new int[] { 0, 0 };
            Shots[7] = new int[] { 0, 0 };
            Shots[8] = new int[] { 0, 0 };
            Shots[9] = new int[] { 0, 0 };
            int expected = 0;
            
            int actual = Bowling.CalculateScore(Shots);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test2AllShotsHitsAPin()
        {
            Shots[0] = new int[] { 1, 1 };
            Shots[1] = new int[] { 1, 1 };
            Shots[2] = new int[] { 1, 1 };
            Shots[3] = new int[] { 1, 1 };
            Shots[4] = new int[] { 1, 1 };
            Shots[5] = new int[] { 1, 1 };
            Shots[6] = new int[] { 1, 1 };
            Shots[7] = new int[] { 1, 1 };
            Shots[8] = new int[] { 1, 1 };
            Shots[9] = new int[] { 1, 1 };
            int expected = 20;

            int actual = Bowling.CalculateScore(Shots);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test3FirstFrameClosedSpareAndAllTheOthersHitsAPin()
        {
            Shots[0] = new int[] { 9, 1 };
            Shots[1] = new int[] { 1, 1 };
            Shots[2] = new int[] { 1, 1 };
            Shots[3] = new int[] { 1, 1 };
            Shots[4] = new int[] { 1, 1 };
            Shots[5] = new int[] { 1, 1 };
            Shots[6] = new int[] { 1, 1 };
            Shots[7] = new int[] { 1, 1 };
            Shots[8] = new int[] { 1, 1 };
            Shots[9] = new int[] { 1, 1 };
            int expected = 29;

            int actual = Bowling.CalculateScore(Shots);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test4FirstFrameStrikeAndAllTheOthersHitsAPin()
        {
            Shots[0] = new int[] { 10 };
            Shots[1] = new int[] { 1, 1 };
            Shots[2] = new int[] { 1, 1 };
            Shots[3] = new int[] { 1, 1 };
            Shots[4] = new int[] { 1, 1 };
            Shots[5] = new int[] { 1, 1 };
            Shots[6] = new int[] { 1, 1 };
            Shots[7] = new int[] { 1, 1 };
            Shots[8] = new int[] { 1, 1 };
            Shots[9] = new int[] { 1, 1 };
            int expected = 30;

            int actual = Bowling.CalculateScore(Shots);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test5FirstTwoFrameStrikeAndAllTheOthersHitsAPin()
        {
            Shots[0] = new int[] { 10 };
            Shots[1] = new int[] { 10 };
            Shots[2] = new int[] { 1, 1 };
            Shots[3] = new int[] { 1, 1 };
            Shots[4] = new int[] { 1, 1 };
            Shots[5] = new int[] { 1, 1 };
            Shots[6] = new int[] { 1, 1 };
            Shots[7] = new int[] { 1, 1 };
            Shots[8] = new int[] { 1, 1 };
            Shots[9] = new int[] { 1, 1 };
            int expected = 49;

            int actual = Bowling.CalculateScore(Shots);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test6AllFramesSpareAndTheFinalHitsAPin()
        {
            Shots[0] = new int[] { 9, 1 };
            Shots[1] = new int[] { 9, 1 };
            Shots[2] = new int[] { 9, 1 };
            Shots[3] = new int[] { 9, 1 };
            Shots[4] = new int[] { 9, 1 };
            Shots[5] = new int[] { 9, 1 };
            Shots[6] = new int[] { 9, 1 };
            Shots[7] = new int[] { 9, 1 };
            Shots[8] = new int[] { 9, 1 };
            Shots[9] = new int[] { 9, 1, 1 };
            int expected = 182;

            int actual = Bowling.CalculateScore(Shots);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test7AllFramesStrike()
        {
            Shots[0] = new int[] { 10 };
            Shots[1] = new int[] { 10 };
            Shots[2] = new int[] { 10 };
            Shots[3] = new int[] { 10 };
            Shots[4] = new int[] { 10 };
            Shots[5] = new int[] { 10 };
            Shots[6] = new int[] { 10 };
            Shots[7] = new int[] { 10 };
            Shots[8] = new int[] { 10 };
            Shots[9] = new int[] { 10, 10, 10 };
            int expected = 300;

            int actual = Bowling.CalculateScore(Shots);

            Assert.AreEqual(expected, actual);
        }
    }
}

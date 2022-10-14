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
            Shots[0] = new int[] { 7, 0 };
            Shots[1] = new int[] { 0, 0 };
            Shots[2] = new int[] { 0, 0 };
            Shots[3] = new int[] { 0, 0 };
            Shots[4] = new int[] { 0, 0 };
            Shots[5] = new int[] { 0, 0 };
            Shots[6] = new int[] { 0, 0 };
            Shots[7] = new int[] { 0, 0 };
            Shots[8] = new int[] { 0, 0 };
            Shots[9] = new int[] { 0, 0 };
            int expected = 7;

            int actual = Bowling.CalculateScore(Shots);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test2BisAllShotsHitsAPin()
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
            Shots[0] = new int[] { 9, 1 }; // 9 + 1 + 4 = 14
            Shots[1] = new int[] { 4, 1 }; // 19
            Shots[2] = new int[] { 1, 1 }; // 21
            Shots[3] = new int[] { 1, 1 }; // 23
            Shots[4] = new int[] { 1, 1 }; // 25
            Shots[5] = new int[] { 1, 1 }; // 27
            Shots[6] = new int[] { 1, 1 }; // 29
            Shots[7] = new int[] { 1, 1 }; // 31
            Shots[8] = new int[] { 1, 1 }; // 33
            Shots[9] = new int[] { 1, 1 }; // 35
            int expected = 35;

            int actual = Bowling.CalculateScore(Shots);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test4FirstFrameStrikeAndAllTheOthersHitsAPin()
        {
            Shots[0] = new int[] { 10 };   // 10 + 1 + 1 = 12
            Shots[1] = new int[] { 1, 1 }; // 14
            Shots[2] = new int[] { 1, 1 }; // 16
            Shots[3] = new int[] { 1, 1 }; // 18
            Shots[4] = new int[] { 1, 1 }; // 20
            Shots[5] = new int[] { 1, 1 }; // 22
            Shots[6] = new int[] { 1, 1 }; // 24
            Shots[7] = new int[] { 1, 1 }; // 26
            Shots[8] = new int[] { 1, 1 }; // 28
            Shots[9] = new int[] { 1, 1 }; // 30
            int expected = 30;

            int actual = Bowling.CalculateScore(Shots);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test5FirstTwoFrameStrikeAndAllTheOthersHitsAPin()
        {
            Shots[0] = new int[] { 10 };   // 10 + 10 + 1 = 21
            Shots[1] = new int[] { 10 };   // 21 + 10 + 1 + 1 = 33
            Shots[2] = new int[] { 1, 1 }; // 35
            Shots[3] = new int[] { 1, 1 }; // 37
            Shots[4] = new int[] { 1, 1 }; // 39
            Shots[5] = new int[] { 1, 1 }; // 41
            Shots[6] = new int[] { 1, 1 }; // 43
            Shots[7] = new int[] { 1, 1 }; // 45
            Shots[8] = new int[] { 1, 1 }; // 47
            Shots[9] = new int[] { 1, 1 }; // 49
            int expected = 49;

            int actual = Bowling.CalculateScore(Shots);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test6AllFramesSpareAndTheFinalHitsAPin()
        {
            Shots[0] = new int[] { 9, 1 };    // 9 + 1 + 9 = 19
            Shots[1] = new int[] { 9, 1 };    // 19 + 9 + 1 + 9 = 38
            Shots[2] = new int[] { 9, 1 };    // 38 + 9 + 1 + 9 = 57
            Shots[3] = new int[] { 9, 1 };    // 57 + 9 + 1 + 9 = 76
            Shots[4] = new int[] { 9, 1 };    // 76 + 9 + 1 + 9 = 95
            Shots[5] = new int[] { 9, 1 };    // 95 + 9 + 1 + 9 = 114
            Shots[6] = new int[] { 9, 1 };    // 114 + 9 + 1 + 9 = 133
            Shots[7] = new int[] { 9, 1 };    // 133 + 9 + 1 + 9 = 152
            Shots[8] = new int[] { 9, 1 };    // 152 + 9 + 1 + 9 = 171
            Shots[9] = new int[] { 9, 1, 1 }; // 171 + 9 + 1 + 1 = 182
            int expected = 182;

            int actual = Bowling.CalculateScore(Shots);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test7AllFramesStrike()
        {
            Shots[0] = new int[] { 10 }; // 10 + 10 + 10 = 30
            Shots[1] = new int[] { 10 }; // 30 + 10 + 10 + 10 = 60
            Shots[2] = new int[] { 10 }; // 50 + 10 + 10 + 10 = 90
            Shots[3] = new int[] { 10 }; // 30 + 10 + 10 + 10 = 120
            Shots[4] = new int[] { 10 }; // 30 + 10 + 10 + 10 = 150
            Shots[5] = new int[] { 10 }; // 30 + 10 + 10 + 10 = 180
            Shots[6] = new int[] { 10 }; // 30 + 10 + 10 + 10 = 210
            Shots[7] = new int[] { 10 }; // 30 + 10 + 10 + 10 = 240
            Shots[8] = new int[] { 10 }; // 30 + 10 + 10 + 10 = 270
            Shots[9] = new int[] { 10, 10, 10 }; // 270 + 10 + 10 + 10 = 300
            int expected = 300;

            int actual = Bowling.CalculateScore(Shots);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test8Score295()
        {
            Shots[0] = new int[] { 10 }; // 10 + 10 + 10 = 30
            Shots[1] = new int[] { 10 }; // 30 + 10 + 10 + 10 = 60
            Shots[2] = new int[] { 10 }; // 50 + 10 + 10 + 10 = 90
            Shots[3] = new int[] { 10 }; // 30 + 10 + 10 + 10 = 120
            Shots[4] = new int[] { 10 }; // 30 + 10 + 10 + 10 = 150
            Shots[5] = new int[] { 10 }; // 30 + 10 + 10 + 10 = 180
            Shots[6] = new int[] { 10 }; // 30 + 10 + 10 + 10 = 210
            Shots[7] = new int[] { 10 }; // 30 + 10 + 10 + 10 = 240
            Shots[8] = new int[] { 10 }; // 30 + 10 + 10 + 10 = 270
            Shots[9] = new int[] { 10, 10, 5 }; // 270 + 10 + 10 + 5 = 295
            int expected = 295;

            int actual = Bowling.CalculateScore(Shots);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test8Score296()
        {
            Shots[0] = new int[] { 10 }; // 10 + 10 + 10 = 30
            Shots[1] = new int[] { 10 }; // 30 + 10 + 10 + 10 = 60
            Shots[2] = new int[] { 10 }; // 50 + 10 + 10 + 10 = 90
            Shots[3] = new int[] { 10 }; // 30 + 10 + 10 + 10 = 120
            Shots[4] = new int[] { 10 }; // 30 + 10 + 10 + 10 = 150
            Shots[5] = new int[] { 10 }; // 30 + 10 + 10 + 10 = 180
            Shots[6] = new int[] { 10 }; // 30 + 10 + 10 + 10 = 210
            Shots[7] = new int[] { 10 }; // 30 + 10 + 10 + 10 = 240
            Shots[8] = new int[] { 10 }; // 30 + 10 + 10 + 10 = 270
            Shots[9] = new int[] { 10, 10, 6 }; // 270 + 10 + 10 + 6 = 296
            int expected = 296;

            int actual = Bowling.CalculateScore(Shots);

            Assert.AreEqual(expected, actual);
        }
    }
}

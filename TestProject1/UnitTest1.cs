using MoodAnalyzaer;
using static MoodAnalyzaer.MoodAnalyser;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void Given_Mood_Sad_Should_Return_Sad()   //testCase1-Reurn Sad
        {
            string input = "I am in Sad Mood";
            string expected = "SAD";


            Mood moodAnalyzer = new Mood();

            string actual = moodAnalyzer.analyseMood(input);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Given_Mood_Happy_Should_Return_Happy() //testcase2-Return Happy
        {
            string input = "I am in Any Mood";
            string expected = "HAPPY";


            Mood moodAnalyzer = new Mood();

            string actual = moodAnalyzer.analyseMood(input);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Refactor1() //Refactor-Testcase1
        {
            string input = "I am in Sad Mood";
            string expected = "SAD";


            MoodAnalyser moodAnalyser = new MoodAnalyser();

            string actual = moodAnalyser.msg;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Refactor2()  //Refactor-TestCase2
        {
            string input = "I am in Happy Mood";
            string expected = "SAD";


            MoodAnalyser moodAnalyser = new MoodAnalyser();

            string actual = moodAnalyser.msg;

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        
         public void Refactor3()

        {//Arrange

            
            object expected = new moodanalyze();
            

            //Act

            object result = moodanalyze.createmoodanalyzer("moodanalyze.moodanalyze");


            //Assert

           // Assert.AreEqual(expected.Equals);
             expected.Equals(result);
            

        }
        public void TestMethodForCustomizedNullException()

        {

            try
            {
                string input = null;
                var analyze = new UC3(input);
            }
            catch (NullReferenceException Exception)
            {
                Assert.AreEqual("Mood can not be Null.", Exception.Message);
            }
        }
        [TestMethod]
        public void TestMethodForCustomizedEmptyException()

        {
            string expected = "Mood should not be empty";
            try
            {

                UC3 moodAnalyser = new UC3(string.Empty);
                moodAnalyser.AnalyzeMood();
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }

        }




    }

}


            

        
   

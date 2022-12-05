using MoodAnalyzerProblem;
using MoodAnalyzerProblem;

namespace MoodAnalyzerProblemTest
{
    public class MoodAnalyzerTest
    {
       
        [Test]
        public void GivenSadMood_WhenAnalyzed_ShouldReturnSad()
        {
            //Arrange
            MoodAnalyzer analyse = new MoodAnalyzer("I am in Sad Mood");
            //Act
            string result = analyse.AnalyzeMood();
            Assert.AreEqual(result,"Sad");
        }
        [Test]
        public void GivenAnyMood_WhenAnalyzed_ShouldReturnHappy()
        {
            //Arrange
            MoodAnalyzer analyse = new MoodAnalyzer("I am in Any Mood");
            //Act
            string result = analyse.AnalyzeMood();
            Assert.AreEqual(result, "Happy");
        }
    }
}
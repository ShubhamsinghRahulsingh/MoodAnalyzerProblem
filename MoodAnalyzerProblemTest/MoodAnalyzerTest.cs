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
            MoodAnalyzer analyse = new MoodAnalyzer();
            string result = analyse.AnalyzeMood("I am in Sad Mood");
            Assert.AreEqual(result,"Sad");
        }
        [Test]
        public void GivenAnyMood_WhenAnalyzed_ShouldReturnHappy()
        {
            //Arrange
            MoodAnalyzer analyse = new MoodAnalyzer();
            string result = analyse.AnalyzeMood("I am in Any Mood");
            Assert.AreEqual(result, "Happy");
        }
    }
}
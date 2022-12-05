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
        [Test]
        public void GivenNullMessage_ThrowsMoodAnalysisExceptionNullMessage()
        {
            try
            {
                //Arrange
                MoodAnalyzer analyse = new MoodAnalyzer(null);
                //Act
                string result = analyse.AnalyzeMood();
            }
            catch (MoodAnalysisException ex)
            {
                Assert.AreEqual("Message should not be null", ex.Message);
            }
        }
        [Test]
        public void GivenEmptyMessage_ThrowsMoodAnalysisExceptionEmptyMessage()
        {
            try
            {
                //Arrange
                MoodAnalyzer analyse = new MoodAnalyzer(String.Empty);
                //Act
                string result = analyse.AnalyzeMood();
            }
            catch (MoodAnalysisException ex)
            {
                Assert.AreEqual("Message should not be Empty", ex.Message);
            }
        }
    }
}
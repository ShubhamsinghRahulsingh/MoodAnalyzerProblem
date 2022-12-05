using static MoodAnalyzerProblem.MoodAnalysisException;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzer
    {
        string message;
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }
        public string AnalyzeMood()
        {
            try
            {
                if (message.Equals(string.Empty))
                {
                    throw new MoodAnalysisException(MoodAnalysisExceptionType.EMPTY_MOOD, "Message should not be Empty");
                }
                if (message.Contains("Sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalysisException(MoodAnalysisExceptionType.NULL_MOOD, "Message should not be null");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalysisException:Exception
    {
        public enum MoodAnalysisExceptionType
        {
            NULL_MOOD, EMPTY_MOOD
        }
        public MoodAnalysisExceptionType type;
        public MoodAnalysisException(MoodAnalysisExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}

using System.Collections.Generic;

namespace KerkyLearn
{
    internal class Question
    {
        public int Id { get; internal set; }
        public string Text { get; internal set; }
        public List<string> Answers { get; internal set; }
        public int CorrectAnswerIndex { get; internal set; }
    }

}
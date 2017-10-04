using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorksheetBuilder
{
    class Question
    {
        private string _questionText;

        public string QuestionText
        {
            get { return _questionText; }
            set { _questionText = value; }
        }

        private int _questionLevel;

        public int QuestionLevel
        {
            get { return _questionLevel; }
            set { _questionLevel = value; }
        }

        private string _questionType;

        public string QuestionType
        {
            get { return _questionType; }
            set { _questionType = value; }
        }

        private OptionList _options;

        public OptionList Options
        {
            get { return _options; }
            set { _options = value; }
        }

        private bool _photoRequired;

        public bool PhotoRequired
        {
            get { return _photoRequired; }
            set { _photoRequired = value; }
        }

        public Question(string questionText, string questionType, int questionLevel, OptionList options, bool photoRequired)
        {
            this.QuestionText = questionText;
            this.QuestionType = questionType;
            this.QuestionLevel = questionLevel;
            this.Options = options;
            this.PhotoRequired = photoRequired;
        }
    }
}

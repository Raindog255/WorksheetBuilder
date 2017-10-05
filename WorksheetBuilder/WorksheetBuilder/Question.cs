using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorksheetBuilder
{
    class Question
    {
        #region Properties
        public string QuestionText { get; set; }
        public int QuestionLevel { get; set; }
        public string QuestionType { get; set; }
        public OptionList Options { get; set; }
        public bool PhotoRequired { get; set; }
        #endregion

        #region Constructor
        public Question(string questionText, string questionType, int questionLevel, OptionList options, bool photoRequired)
        {
            this.QuestionText = questionText;
            this.QuestionType = questionType;
            this.QuestionLevel = questionLevel;
            this.Options = options;
            this.PhotoRequired = photoRequired;
        }
        #endregion
    }
}

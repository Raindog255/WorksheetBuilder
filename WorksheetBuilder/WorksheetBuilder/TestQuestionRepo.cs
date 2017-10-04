using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorksheetBuilder
{
    class TestQuestionRepo
    {
        private List<Question> _testQuestions;

        public List<Question> TestQuestions
        {
            get { return _testQuestions; }
            set { _testQuestions = value; }
        }

        public TestQuestionRepo()
        {
            this.TestQuestions = new List<Question>
            {
               new Question("Saywuh?", "Dropdown", 0, new OptionList(new List<string> { "1", "2", "3" }), true), 
               new Question("Saywuuuuuh?!", "Dropdown", 0, new OptionList(new List<string> { "1", "2", "3" }), true),
               new Question("Whachootalkinbout?!", "Dropdown", 0, new OptionList(new List<string> { "This", "That" }), true)
            };
        }

    }
}
 
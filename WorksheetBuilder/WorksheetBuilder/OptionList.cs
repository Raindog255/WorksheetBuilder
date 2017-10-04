using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorksheetBuilder
{
    class OptionList
    {
        private List<string> _optionList;

        public List<string> Options
        {
            get { return _optionList; }
            set { _optionList = value; }
        }

        public OptionList(List<string> optionList)
        {
            Options = optionList;
        }

        public override string ToString()
        {
            return String.Join("|", Options.ToArray());
        }

        public void Add(string str)
        {
            Options.Add(str);
        }
    }
}

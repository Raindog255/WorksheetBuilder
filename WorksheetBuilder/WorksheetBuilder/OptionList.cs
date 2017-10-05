using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorksheetBuilder
{
    public class OptionList
    {
        #region Properties
        public List<string> Options { get; set; }
        #endregion

        #region Constructor
        public OptionList(List<string> optionList)
        {
            Options = optionList;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Returns the options seperated by "|"
        /// </summary>
        public override string ToString() => String.Join("|", Options.ToArray());

        /// <summary>
        /// Adds a value to the options list
        /// </summary>
        /// <param name="str">New string to add to the options list.</param>
        public void Add(string str) => Options.Add(str);

        /// <summary>
        /// Appends an 'Other' option to the options list
        /// </summary>
        public void AddOther() => Options.Add("Other");

        /// <summary>
        /// Sorts the options alphabetically, with 'Other' always being the last option
        /// </summary>
        public void Sort()
        {
            bool otherPresent;

            if (Options.Contains("Other"))
            {
                otherPresent = true;
                Options.Remove("Other");
            }
            else otherPresent = false;

            Options.Sort();
            if (otherPresent == true) Options.Add("Other");
        }
        #endregion
    }
}

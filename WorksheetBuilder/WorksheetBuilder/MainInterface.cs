using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorksheetBuilder
{
    public partial class MainInterface : Form
    {
        public MainInterface()
        {
            InitializeComponent();
        }

        private void AddTestData_Click(object sender, EventArgs e)
        {
            var questions = new TestQuestionRepo();

            foreach (var question in questions.TestQuestions)
            {
                QuestionGridView.Rows.Add();
            }

            for (var i = 0;  i < questions.TestQuestions.Count; i++)
            {
                QuestionGridView.Rows[i].Cells[0].Value = questions.TestQuestions[i].QuestionText;
                QuestionGridView.Rows[i].Cells[1].Value = questions.TestQuestions[i].QuestionType;
                QuestionGridView.Rows[i].Cells[2].Value = questions.TestQuestions[i].QuestionLevel.ToString();
                QuestionGridView.Rows[i].Cells[3].Value = questions.TestQuestions[i].Options.ToString();
                QuestionGridView.Rows[i].Cells[4].Value = questions.TestQuestions[i].PhotoRequired.ToString();
            }
        }
    }
}
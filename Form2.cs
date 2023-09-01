using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remembering_Numbers
{
    public partial class StatsForm : Form
    {
        public StatsForm()
        {
            InitializeComponent();
        }

        private void StatsForm_Load(object sender, EventArgs e)
        {
            lbNumOfQues.Text  = Form1.GameInfo.NumberOfQusetion.ToString();
            lbNumOfRightQues.Text = Form1.GameInfo.NumberOfRightQuestions.ToString();
            lbNumOfWrongQues.Text = Form1.GameInfo.NumberOfWrongQuestion.ToString();
        }
    }
}

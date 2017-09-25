using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmPaperTestByTxt
{
    [Serializable]
    public class Answer
    {
        public string RightAnswer { get; set; } = string.Empty;//标准的正确答案
        public string SelectAnswer { get; set; } = string.Empty;//用户选择的答案
        public string AnswerAnalysis { get; set; } = string.Empty;//答案分析
    }
}

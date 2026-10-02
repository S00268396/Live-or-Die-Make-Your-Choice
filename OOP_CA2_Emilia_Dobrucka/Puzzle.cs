using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CA2_Emilia_Dobrucka
{
    public class Puzzle
    {
        public string Question { get; set; }

        public string Answer { get; set; }
        public int chances { get; set; }

        //Scales
        public string LeftScale {  get; set; }
        public string LeftAnswerF {  get; set; }
        public string LeftAnswerS { get; set; }
        public string RightScale { get; set; }
        public string RightAnswerF { get; set; }
        public string RightAnswerS {  set; get; }

    }
}

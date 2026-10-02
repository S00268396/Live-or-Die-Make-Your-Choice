using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CA2_Emilia_Dobrucka
{
    public class Room
    {
        public Puzzle RoomPuzzle { get; set; }

        //Descroptions        
        public Description Begin {  get; set; }
        public Description FirstDescription { get; set; }
        public Description SecondDescription { get; set; }
        public Description ThirdDescription { get; set; }
       

        //VoiceTalkings
        public VoiceTalking Voices { get; set; }      
        
        //Decisions        
        public Decision FirstDecision { get; set; }                      
        public Decision SecondDecision { get; set; }
        public Decision ThirdDecision { get; set; }
    }
}

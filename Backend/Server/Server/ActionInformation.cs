using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class ActionInformation
    {
        public string nameAction { get; set; }
        public Note note { get; set; }

        public ActionInformation() { }
        public ActionInformation(string nameAction, Note note)
        {
            this.nameAction = nameAction;
            this.note = note;
        }
    }
}

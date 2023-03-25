using System;
using System.Collections.Generic;
using System.Text;

namespace ControlTask
{
    class Soccer
    {
        Sport sportObject;
        string name;
        string sportName = "футбол";
        public Soccer(string name)
        {
            this.name = name;
        }
        public string PersonName()
        {
            return name;
        }
        public string KindOfActivity()
        {
            return sportObject.Activity();
        }

        public string SportName()
        {
            return sportName;
        }

        public int SportRank()
        {
            return sportObject.Rank();
        }
    }
}

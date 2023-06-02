using System;
using System.Collections.Generic;
using System.Text;

namespace ControlTask
{
    class Sport : Hobby
    {

        public Sport(string name) : base(name)
        {
            this.name = name;
            activity = "спорт";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ControlTask
{
    class Sport : Hobby
    {
        protected string sportName;
        public Sport(string name) : base(name)
        {
            this.name = name;
            activity = "спорт";
        }
        public void Rechevka()
        {
            Console.WriteLine("СПОРТ ЭТО ЗЫЗНЬ - {0} ЭТО ЗЫЗНЬ!.!", sportName);
        }
    }
}

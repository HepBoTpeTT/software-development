using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ControlTask
{
    class Music : Hobby
    {
        public Music(string name, string vocal, int experience) : base(name)
        {
            activity = "музыка";
            this.name = name;
            details = details = "\n  Ноты: " + vocal + "\n  Опыт: " + Convert.ToString(experience) + "\n";
        }
        public void SingSong()
        {
            Console.WriteLine("Ла-ла-ла-ла-ла-лааааа...");
        }
    }
}

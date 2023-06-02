using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Sport
    {
        Hobby outHobby;
        string hobby = "Футбол";
        string name;
        public Sport(string name)
        {
            this.name = name;
            outHobby = new Hobby(name, hobby);
        }
        public void ShowHobby()
        {
            Console.WriteLine("Меня зовут {0}. \nМоё хобби {1}", name, hobby);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Hobby
    {
        string name;
        string hobby;

        
        public Hobby(string name, string hobby)
        {
            this.name = name;
            this.hobby = hobby;
        }

        public void ShowHobby()
        {
            Console.WriteLine("Меня зовут {0}. \nМоё хобби {1}",name,hobby);
        }
    }
}

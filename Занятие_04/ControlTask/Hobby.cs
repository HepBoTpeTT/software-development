using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ControlTask
{
    internal class Hobby
    {
        protected string name;
        protected string details;
        protected string activity;
        public Hobby(string name)
        {
            this.name = name;
        }
        public void ShowDetails()
        {
            Console.WriteLine("\nИмя: {0}\n Увлечение: {1}\n Подробности: {2}", name, activity,
                details);

        }
        public void PersonSpecific()
        {
            Console.WriteLine("Спецификация для пользователя {0}: {1}", name, details);
        }
    }
}

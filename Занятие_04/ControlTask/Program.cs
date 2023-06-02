using System;

namespace ControlTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Soccer p1 = new Soccer("Данил");
            p1.ShowDetails();
            p1.PersonSpecific();

            Music p2 = new Music("Олег", "Верхние", 5);
            p2.ShowDetails();
            p2.PersonSpecific();
        }
    }
}

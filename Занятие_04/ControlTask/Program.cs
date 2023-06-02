using System;

namespace ControlTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Soccer p1 = new Soccer("Данил");
            p1.ShowDetails();
            p1.Rechevka();
            p1.HitGoal();
            p1.PersonSpecific();
            p1.ShowDetails();

            Music p2 = new Music("Олег", "Верхние", 5);
            p2.ShowDetails();
            p2.PersonSpecific();
            p2.SingSong();
        }
    }
}

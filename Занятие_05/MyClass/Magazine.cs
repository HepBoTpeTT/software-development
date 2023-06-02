using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    class Magazine : Item
    {
        private string volume;
        private int number;
        private string title;
        private int year;

        public Magazine() {}
        public Magazine(string volume, int number, string title, int year, long InvNumber, bool taken) : base(InvNumber, taken)
        {
            this.volume = volume;
            this.number = number;
            this.title = title;
            this.year = year;
        }

        public override void Show()
        {
            Console.WriteLine("\nЖурнал:\n Том: {0}\n Номер: {1}\n Название: {2}\n Год выпуска: {3}", volume, number, title, year);
            base.Show();
        }
        public override void Return()
        {
            taken = true;
        }
    }
}

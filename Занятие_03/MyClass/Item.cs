using System;

namespace MyClass
{
    abstract class Item: IComparable
    {
        protected long InvNumber;
        protected bool taken;

        public Item(long InvNumber, bool taken)
        {
            this.InvNumber = InvNumber;
            this.taken = taken;
        }
        public Item()
        {
            this.taken = true;
        }
        public bool IsAvailable()
        {
            if (taken == true) return true; else return false;
        }

        public long GetInvNumber()
        {
            return InvNumber;
        }

        private void Take()
        {
            taken = false;
        }

        abstract public void Return();
        public virtual void Show()
        {
            Console.WriteLine("Состояние единицы хранения:\n Инвертарный номер: {0}\n Наличие: {1}", InvNumber, taken);
        }
        public void TakeItem()
        {
            if (this.IsAvailable()) this.Take();
        }
        int IComparable.CompareTo(object obj)
        {
            Item it = (Item)obj;
            if (this.InvNumber == it.InvNumber) return 0;
            else if (this.InvNumber > it.InvNumber) return 1;
            else return -1;
        }
    }
}

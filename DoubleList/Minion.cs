using System;
using System.Collections.Generic;
using System.Text;

namespace Garbage
{
    class Minion : IComparable
    {
        private static int ID = 1;
        public int id { get; private set; }

        public String name { get; set; }
        public int age { get; set; }
        public Minion()
        {
            id = ID;
            ID++;
        }

        public int CompareTo(object obj)
        {
            Minion m = obj as Minion;

            if (m != null)
            {
                if (this.age < m.age)
                {
                    return -1;
                }
                else if (this.age > m.age)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                throw new Exception("Хуита!");
            }
        }
    }
}

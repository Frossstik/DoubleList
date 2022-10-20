using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleList
{
    class Minions : IComparable
    {
        private static int ID = 1;
        public int id { get; private set; }

        public String name { get; set; }
        public int age { get; set; }
        public Minions()
        {
            id = ID;
            ID++;
        }

        public int CompareTo(object obj)
        {
            Minions m = obj as Minions;

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
                throw new Exception("Не судьба!");
            }
        }


    }
}

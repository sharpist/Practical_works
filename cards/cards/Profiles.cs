using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cards
{
    class Profiles<T>
    {
        private T match;
        private T[] arr { get; set; }
        public Profiles(params T[] p) {
            this.arr = new T[p.Length];

            for (int i = 0; i < p.Length; i++)
            { this.arr[i] = p[i]; }
        }

        public T Find(Func<T, bool> op)
        {
            foreach (var value in this.arr)
            {
                bool checkValue = op(value);

                if (checkValue == true)
                {
                    this.match = value;
                    break;
                }
            }
            return this.match;
        }
    }
}

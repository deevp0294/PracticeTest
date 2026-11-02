using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTest
{
    internal class Question9
    {
        public void Adjustment(ref int stock,int change)
        {
            int st = stock;
            int ch = change;

            if (Validation(st, ch)) st -= ch;

            stock = st;
        }
        public bool Validation(int st, int ch)
        {
            return st > ch;
        }
    }
}

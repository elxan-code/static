using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    static class Extention
    {

        public static int info(this  int c)
        {
            int i;
            int a;
            for (i = 0; i < c; i++)
            {
                a = i * i * i;
                if (a == c)
                {
                    break;
                }
            }

            return i;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4_enum
{
    class Distance
    {
        public int dist1;

        public Distance(int d)
        {
            dist1 = d;
        }
        public static Distance operator ++(Distance dis1)
        {
            Distance temp = new Distance(1);
            temp.dist1 = dis1.dist1 + 1;
            //dis1.dist1++;
            return temp;

        }
        class OperatorOverloading
        {
            static void Main()
            {
                Distance d1 = new Distance(50);
                d1++;

                Console.WriteLine(d1.dist1);
                Console.Read();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Scholarship

    {
        public double stud(int marks, double fees)
        {
            double scholarshipAmount = 0;

            if (marks >= 70 && marks <= 80)
            {
            }
            else if (marks > 80 && marks <= 90)
            {
                scholarshipAmount = 0.3 * fees;
            }
            else if (marks > 90)
            {
                scholarshipAmount = 0.5 * fees;
            }
           return scholarshipAmount;
        }
    }
}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice8_Zadanie1
{
    class Student
    {
        public string name;
        public double rost;
        double ves = 60.0;
        
        
        public void SetEat(double eat)
        {
            if(eat <= 5)
            {
                ves += ((eat * 1000 - 1400) / 1000) * 0.8;
            }
            if(eat > 5 && eat <= 10)
            {
                rost -= 1;
                ves += ((eat * 1000 - 1600) / 1000) * 0.7;
            }
            else if(eat > 10)
            {
                rost -= 2;
                ves += ((eat * 1000 - 1800) / 1000) * 0.5;
            }
        }
        public double GetEat()
        {
            return Math.Round(ves,2);
        }
        
        
        
    }
}

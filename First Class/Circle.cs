using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Class
{
    public class Circle : Shape
    {
        public int radius;

        public Circle(int radius,string color):base (color)
        {
            this.radius = radius;
            this.area = 3.14 * radius * radius;
        }

    }

}

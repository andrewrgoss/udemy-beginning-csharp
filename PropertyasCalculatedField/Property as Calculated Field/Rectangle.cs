using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property_as_Calculated_Field
{
    class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int Area
        {
            get
            {
                return Width * Height;
            }
        }
    }
}

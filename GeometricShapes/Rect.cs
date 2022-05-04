using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes {
    internal class Rect {
        public string Name { get; set; } = string.Empty;
        public int SideL { get; set; } = 0;
        public int SideS { get; set; } = 0;


        public int Perimeter() {
            return (SideL * 2) + (SideS * 2);
            }
        public int Area() {
                return SideL * SideS;
            }
            
    }
}

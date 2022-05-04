using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes {
    internal class Quad {
        public string Name { get; set; } = string.Empty;
        public int Side1 { get; set; } = 0;
        public int Side2 { get; set; } = 0;
        public int Side3 { get; set; } = 0;
        public int Side4 { get; set; } = 0;

        public int Perimeter() {
            return Side1 + Side2 + Side3 + Side4;
            }

        }
    }

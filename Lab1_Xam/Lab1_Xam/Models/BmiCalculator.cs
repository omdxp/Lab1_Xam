using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_Xam.Models
{
    class BmiCalculator
    {
        public float Height { get; set; }
        public float Weight { get; set; }

        public float CalculateBmi()
        {
            return Weight / (Weight * Height);
        }
    }
}

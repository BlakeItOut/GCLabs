using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Circle
    {
        private double _radius;

        public Circle (double radius)
        {
            _radius = radius;
        }

        public double CalculateCircumference() => 2 * Math.PI * _radius;

        public string CalculateFormattedCircumference() => FormatNumber(CalculateCircumference());

        public double CalculateArea() => Math.PI * Math.Pow(_radius, 2);

        public string CalculateFormattedArea() => FormatNumber(CalculateArea());

        private string FormatNumber(double x) => $"{x:0.00}";
    }
}

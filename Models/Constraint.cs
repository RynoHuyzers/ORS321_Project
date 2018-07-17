using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Models.Enums;

namespace Models
{
    public class Constraint
    {
        private double[] coefficients;
        private Sign sign;
        private double rhs;

        public double[] Coefficients
        {
            get { return coefficients; }
            set { coefficients = value; }
        }

        public Sign Sign
        {
            get { return sign; }
            set { sign = value; }
        }

        public double RHS
        {
            get { return rhs; }
            set { rhs = value; }
        }

        public Constraint()
        {

        }

        public Constraint(double[] coefficients, Sign sign, double rhs)
        {
            this.Coefficients = coefficients;
            this.Sign = sign;
            this.RHS = rhs;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

using System;

namespace CalcSqr
{
    class krug
    {
        double r { get; set; }
        public krug(double r)
        {
            if (r <= 0)
                throw new Exception("r должен быть больше 0");
            this.r = r;
        }
        public double Skrug()
        {

            return r * r * Math.PI;
        }

    }
}

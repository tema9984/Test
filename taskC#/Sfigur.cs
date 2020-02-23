using System;
using System.Collections.Generic;
using System.Text;

namespace CalcSqr
{
            class Sfigur//Допуситм пользователь не знает что у него за фигура, но знает параметры
        {
            double SNfigur(double r)
            {

                krug krug = new krug(r);
                return krug.Skrug();
            }
            double SNfigeur(double a, double b, double c)
            {
                trig trig = new trig(a, b, c);
                return trig.SurTr();
            }
        }
    
}

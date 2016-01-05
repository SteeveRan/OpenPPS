using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenPPS
{
    class UoM
    {
        // Базовый класс всех едениц измерений
        private Double value;

        public virtual void Set(double _t)
        {
            value = _t;
        }

        public virtual Double Get()
        {
            return value;
        } 
    }

    // Давление
    class Units_Pressure : UoM
    {
        double atm = 101325;

        //Стандартно измеряется в паскалях
        public override double Get()
        {
            return base.Get();
        }

        public double Get_Pa()
        {
            return base.Get();
        }

        public double Get_kPa()
        {
            return base.Get()/1000;
        }

        public double Get_MPa()
        {
            return base.Get()/1000000;
        }

        public double Get_mm_Hg()
        {
            return base.Get()/(atm/760);
        }

        public double Get_m_H20()
        {
            return base.Get() / 9806.65;
        }

        public double Get_kgs_m2()
        {
            return base.Get()/9.80665;
        }

        public double Get_kgs_cm2()
        {
            return base.Get()/98066.5;
        }

        public double Get_bar()
        {
            return base.Get()/100000;
        }

        public double Get_N_m2()
        {
            return base.Get();
        }

        public double Get_N_mm2()
        {
            return base.Get()/1000000;
        }

    }

    class Units_Length : UoM
    {

    }

    class Units_Mass : UoM
    {

    }

    class Units_Temperature : UoM
    {

    }

    class Units_DinamicViscosity : UoM
    {

    }

    class Units_KinematicViscositi : UoM
    {

    }
    class Units_Density : UoM
    {

    }

    class Units_Velocity : UoM
    {

    }

    class Units_Time : UoM
    {

    }

    class Units_Force : UoM
    {

    }

    class Units_Energy : UoM
    {

    }

    //class Units_Temperature : UoM
    //{

    //}
    //class Units_Temperature : UoM
    //{

    //}

    //class Units_Temperature : UoM
    //{

    //}

    //class Units_Temperature : UoM
    //{

    //}
}
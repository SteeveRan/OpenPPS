using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenPPS
{
    public enum Units : int
    {
        pressure,
        dynamic_viscosity,
        kinematic_viscosity,
        flowrate,
        length,
        square,
        volume,
        time,
        velocity,
        acceleration,
        mass,
        density,
        force,
        temperature,
        energy
    };

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

    //Гидромеханика
    
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
    // Динамическая вязкость
    class Units_DinamicViscosity : UoM
    {

    }
    // Кинематическая вязкость
    class Units_KinematicViscositi : UoM
    {

    }
    // Расход
    class Units_Flowrate : UoM
    {

    }

    // Геометрия
    // Длина
    class Units_Length : UoM
    {

    }
    // Площадь
    class Units_Square : UoM
    {

    }    
    // Объем
    class Units_Volume : UoM
    {

    }

    //Механика

    // Время
    class Units_Time : UoM
    {

    }
    // Скорость
    class Units_Velocity : UoM
    {

    }
    // Ускорение
    class Units_Acceleration : UoM
    {

    }
    // Масса
    class Units_Mass : UoM
    {

    }
    // Плотность
    class Units_Density : UoM
    {

    }
    // Сила
    class Units_Force : UoM
    {

    }

    //Термодинамика

    // Температура
    class Units_Temperature : UoM
    {

    } 
    





    // Энергия
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
}
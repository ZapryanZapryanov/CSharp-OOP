﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
   public class SportCar : Car
    {
        private const double defaultConsumption = 10;

        public SportCar(int horsePower, double fuel) : base(horsePower, fuel)
        {
            base.FuelConsumption = defaultConsumption;
        }
    }
}

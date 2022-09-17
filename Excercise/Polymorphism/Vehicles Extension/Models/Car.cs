﻿namespace P01.Vehicles.Models
{
    public class Car : Vehicle
    {
        private const double CarFuelConsumptionIncrement = 0.9;

        public Car(double fuelQuantity, double fuelConsumption, double capacity) 
            : base(fuelQuantity, fuelConsumption, capacity)
        {

        }

        protected override double FuelConsumptionModifier
            => CarFuelConsumptionIncrement;
    }
}
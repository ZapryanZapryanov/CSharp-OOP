// ReSharper disable ConvertToAutoProperty
namespace P01.Vehicles.Models
{
    using Interfaces;
    using System;

    public abstract class Vehicle : IVehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
       

        private Vehicle()
        {
            this.FuelConsumptionModifier = 0;
        }

        protected Vehicle(double fuelQuantity, double fuelConsumption, double capacity)
            : this()
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.Capacity = capacity;
        }

        //Full property -> Open to extension, easy can add validation
        public double FuelQuantity
        {
            get
            {
                return this.fuelQuantity;
            }
            private set
            {
                this.fuelQuantity = value;
            }
        }

        public double FuelConsumption
        {
            get
            {
                return this.fuelConsumption;
            }
            protected set
            {
                this.fuelConsumption = value + this.FuelConsumptionModifier;
            }
        }
        public double Capacity { get; private set; }

        protected virtual double FuelConsumptionModifier { get; }

        public string Drive(double distance)
        {
            double fuelNeeded = distance * this.FuelConsumption;
            if (fuelNeeded > this.FuelQuantity)
            {
                //Not Enough fuel
                return $"{this.GetType().Name} needs refueling";
            }

            this.FuelQuantity -= fuelNeeded;
            return $"{this.GetType().Name} travelled {distance} km";
        }

        public virtual void Refuel(double liters)
        {
           double sum = this.FuelQuantity + liters;
            if (sum > Capacity)
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }
            else
            {
                this.FuelQuantity += liters;
            }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}

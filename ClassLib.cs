using System;


namespace Lab2Lib
{
    public class Car
    {
        public string ModelName;
        public string Manufacturer;
        public int YearOfProduction;
        public double EngineCapacity;
        public int SeatCount;
        public bool IsElectric;
        public double AverageFuelConsumption;

        public double GetFuelConsumptionPer100Km()
        {
            return AverageFuelConsumption;
        }

        public int GetCarAge()
        {
            return DateTime.Now.Year - YearOfProduction;
        }
    }
}
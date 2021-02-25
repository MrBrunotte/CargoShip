using System;
using System.Collections.Generic;
using System.Text;

namespace CargoShipForm
{
    class Ship
    {
        // Constant values 
        const int CYCLE_WEIGHT = 3;
        const int CAR_WEIGHT = 5;
        const int TRUCK_WEIGHT = 11;
        const int TRAIN_WEIGHT = 17;

        const int MAX_WEIGHT = 10;
        // Properties for the class
        public int Capacity { get; set; }
        public int CycleCount { get; set; }
        public int CarCount { get; set; }
        public int TruckCount { get; set; }
        public int TrainCarCount { get; set; }

        // New random method
        Random random = new Random();

        // Constructor
        public Ship()
        {
            CycleCount = 0;
            CarCount = 0;
            TruckCount = 0;
            TrainCarCount = 0;

            // create a random number for capacity
            Capacity = random.Next(MAX_WEIGHT) *
                       CYCLE_WEIGHT + random.Next(MAX_WEIGHT) *
                       CAR_WEIGHT + random.Next(MAX_WEIGHT) *
                       TRUCK_WEIGHT + random.Next(MAX_WEIGHT) *
                       TRAIN_WEIGHT;

        }

        public int OverUnder()
        {
            // returns a value how loaded the ship is
            return Capacity - GetShipLoad();
        }

        public override string ToString()
        {
            return $"Capacity = {Capacity}, CurrentLoad = {GetShipLoad()}";
        }

        // Method
        public int GetShipLoad()
        {
            // calculate the total weight of the cargo of the ship.
            return CycleCount * CYCLE_WEIGHT +
                   CarCount * CAR_WEIGHT +
                   TruckCount * TRUCK_WEIGHT +
                   TrainCarCount * TRAIN_WEIGHT;
        }
    }
}

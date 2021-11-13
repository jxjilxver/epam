using System.Collections.Generic;

namespace Aircompany.Planes
{
    public abstract class Plane
    {
        public string Model;
        public int MaxSpeed;
        public int MaxFlightDistance;
        public int MaxLoadCapacity;

        public Plane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity)
        {
            Model = model;
            MaxSpeed = maxSpeed;
            MaxFlightDistance = maxFlightDistance;
            MaxLoadCapacity = maxLoadCapacity;
        }

        public string GetModel()
        {
            return Model;
        }

        public int GetMS()
        {
            return MaxSpeed;
        }

        public int MAXFlightDistance()
        {
            return MaxFlightDistance;
        }

        public int MAXLoadCapacity()
        {
            return MaxLoadCapacity;
        }

        public override string ToString()
        {
            return $"Plane( Model = {Model}, MaxSpeed = {MaxSpeed}, MaxFlightDistance = {MaxFlightDistance}, MaxLoadCapacity = {MaxLoadCapacity})";
        }

        public override bool Equals(object obj)
        {
            var plane = obj as Plane;
            return plane != null &&
                   Model == plane.Model &&
                   MaxSpeed == plane.MaxSpeed &&
                   MaxFlightDistance == plane.MaxFlightDistance &&
                   MaxLoadCapacity == plane.MaxLoadCapacity;
        }

        public override int GetHashCode()
        {
            var hashCode = -1043886837;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Model);
            hashCode = hashCode * -1521134295 + MaxSpeed.GetHashCode();
            hashCode = hashCode * -1521134295 + MaxFlightDistance.GetHashCode();
            hashCode = hashCode * -1521134295 + MaxLoadCapacity.GetHashCode();
            return hashCode;
        }

    }
}

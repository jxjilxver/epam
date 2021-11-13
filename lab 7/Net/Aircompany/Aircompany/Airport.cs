using Aircompany.Models;
using Aircompany.Planes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aircompany
{
    public class Airport
    {
        public List<Plane> Planes;

        public Airport(IEnumerable<Plane> planes)
        {
            Planes = planes.ToList();

        }

        public List<PassengerPlane> GetPassengersPlanes => Planes.OfType<PassengerPlane>().ToList();
        public List<MilitaryPlane> GetMilitaryPlanes => Planes.OfType<MilitaryPlane>().ToList();
        public PassengerPlane GetPassengerPlaneWithMaxPassengersCapacity => GetPassengersPlanes.First(p => p.PassengersCapacity == GetPassengersPlanes.Max(x => x.PassengersCapacity));
        public List<MilitaryPlane> GetTransportMilitaryPlanes => Planes.OfType<MilitaryPlane>().Where(p => p.Type == MilitaryType.TRANSPORT).ToList();


        public Airport SortByMaxDistance()
        {
            return new Airport(Planes.OrderBy(w => w.MAXFlightDistance()));
        }

        public Airport SortByMaxSpeed()
        {
            return new Airport(Planes.OrderBy(w => w.GetMS()));
        }

        public Airport SortByMaxLoadCapacity()
        {
            return new Airport(Planes.OrderBy(w => w.MAXLoadCapacity()));
        }


        public IEnumerable<Plane> GetPlanes()
        {
            return Planes;
        }

        public override string ToString()
        {
            return "Airport{" +
                    "planes=" + string.Join(", ", Planes.Select(x => x.GetModel())) +
                    '}';
        }
    }
}

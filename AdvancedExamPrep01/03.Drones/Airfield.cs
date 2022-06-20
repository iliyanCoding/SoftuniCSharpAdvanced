using System.Collections.Generic;
using System.Text;

namespace Drones
{
    public class Airfield
    {
        public Airfield(string name, int capacity, double landingStrip)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.LandingStrip = landingStrip;
            this.Drones = new List<Drone>();
        }

        private List<Drone> drones = new List<Drone>();

        public List<Drone> Drones
        {
            get { return drones; }
            set { drones = value; }
        }


        public string Name { get; set; }

        public int Capacity { get; set; }

        public double LandingStrip { get; set; }

        public int Count => this.Drones.Count;

        public string AddDrone(Drone drone)
        {

            if (string.IsNullOrEmpty(drone.Name) ||
                string.IsNullOrEmpty(drone.Brand) ||
                drone.Range < 5 || drone.Range > 15)
            {
                return "Invalid drone.";
            }

            if (this.Drones.Count >= this.Capacity)
            {
                return "Airfield is full.";
            }

            this.Drones.Add(drone);
            return $"Successfully added {drone.Name} to the airfield.";
        }

        public bool RemoveDrone(string name)
        {
            if (Drones.Contains(Drones.Find(x => x.Name == name)))
            {
                Drones.Remove(Drones.Find(x => x.Name == name));
                return true;
            }
            else
            {
                return false;
            }
        }

        public int RemoveDroneByBrand(string brand)
        {
            int count = Drones.FindAll(x => x.Brand == brand).Count;
            if (count != 0)
            {
                Drones.RemoveAll(x => x.Brand == brand);

            }
            return count;

        }

        public Drone FlyDrone(string name)
        {
            if (Drones.Contains(Drones.Find(x => x.Name == name)))
            {

                Drone drone = Drones.Find(x => x.Name == name);
                drone.Available = false;
                return drone;
            }
            else
            {
                return null;
            }
        }

        public List<Drone> FlyDronesByRange(int range)
        {
            List<Drone> drones = Drones.FindAll(x => x.Range >= range);
            return drones;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Drones available at {Name}:");
            foreach (var drone in Drones)
            {
                if (drone.Available)
                {
                    sb.AppendLine(drone.Name);
                }
            }

            return sb.ToString();
        }
    }


}

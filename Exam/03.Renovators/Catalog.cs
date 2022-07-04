using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Catalog
    {
        public List<Renovator> renovators = new List<Renovator>();

        public string Name { get; set; }

        public int NeededRenovators { get; set; }

        public string Project { get; set; }

        public int Count => this.renovators.Count;

        public Catalog(string name, int neededRenovators, string project)
        {
            this.Name = name;   
            this.NeededRenovators = neededRenovators;
            this.Project = project;
        }

        public string AddRenovator(Renovator renovator)
        {
            if (string.IsNullOrEmpty(renovator.Type) || string.IsNullOrEmpty(renovator.Name))
            {
                return "Invalid renovator's information.";
            }
            else if (renovators.Count() >= NeededRenovators)
            {
                return "Renovators are no more needed.";
            }
            else if (renovator.Rate > 350)
            {
                return "Invalid renovator's rate.";
            } 
            renovators.Add(renovator);
            return $"Successfully added {renovator.Name} to the catalog.";
        }

        public bool RemoveRenovator(string name)
        {
            if (renovators.Contains(renovators.Find(x => x.Name == name)))
            {
                renovators.Remove(renovators.Find(x => x.Name == name));
                return true;
            }
            return false;
        }

        public int RemoveRenovatorBySpecialty(string type)
        {
            int renovatorsRemoved = 0;
            while (true)
            {
                if (renovators.Contains(renovators.Find(x => x.Type == type)))
                {
                    renovators.Remove(renovators.Find(x => x.Type == type));
                    renovatorsRemoved++;
                }
                else
                {
                    break;
                }
            }

            if (renovatorsRemoved > 0)
            {
                return renovatorsRemoved;
            }
            return 0;
        }
        public Renovator HireRenovator(string name)
        {
            if (renovators.Contains(renovators.Find(x => x.Name == name)))
            {
                Renovator renovator = renovators.Find(x => x.Name == name);
                renovator.Hired = true;
                return renovator;
            }
            return null;
        }

        public List<Renovator> PayRenovators(int days)
        {
            List<Renovator> payedRenovators = new List<Renovator>();
            payedRenovators = renovators.FindAll(x => x.Days >= days);
            return payedRenovators;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Renovators available for Project {Project}:");
            foreach (var renovator in renovators)
            {
                if (renovator.Hired == false)
                {
                    sb.AppendLine(renovator.ToString());
                }
            }
            return sb.ToString();
        }
    }
}

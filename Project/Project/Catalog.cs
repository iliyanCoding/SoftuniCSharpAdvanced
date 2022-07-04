using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Catalog
    {
        public List<Renovator> Renovators { get; set; }

        public string Name { get; set; }

        public int NeededRenovators { get; set; }

        public string Project { get; set; }

        public Catalog(string name, int neededRenovators, string project)
        {
            this.Renovators = new List<Renovator>();
            this.Name = name;
            this.NeededRenovators = neededRenovators;
            this.Project = project;
        }

        public int Count => this.Renovators.Count;

        public string AddRenovator(Renovator renovator)
        {
            if (string.IsNullOrEmpty(renovator.Name) || string.IsNullOrEmpty(renovator.Type))
            {
                return "Invalid renovator's information.";
            }

            if (this.Renovators.Count >= this.NeededRenovators)
            {
                return "Renovators are no more needed.";
            }

            if (renovator.Rate > 350)
            {
                return "Invalid renovator's rate.";
            }

            this.Renovators.Add(renovator);
            return $"Successfully added {renovator.Name} to the catalog.";
        }

        public bool RemoveRenovator(string name)
        {
            return this.Renovators.Remove(this.Renovators.FirstOrDefault(x => x.Name == name));
        }

        public int RemoveRenovatorBySpecialty(string type)
        {
            return this.Renovators.RemoveAll(x => x.Type == type);
        }

        public Renovator HireRenovator(string name)
        {
            Renovator renovator = this.Renovators.FirstOrDefault(x => x.Name == name);
            if (this.Renovators.Contains(renovator))
            {
                renovator.Hired = true;
                return renovator;
            }
            else
            {
                return null;
            }
        }

        public List<Renovator> PayRenovators(int days)
        {
            return this.Renovators.Where(x => x.Days >= days).ToList();
        }

        public string Report()
        {
            this.Renovators = this.Renovators.Where(x => x.Hired == false).ToList();
            if (this.Renovators != null)
            {
                return $"Renovators available for Project {this.Project}:{Environment.NewLine}{String.Join(Environment.NewLine, this.Renovators)}";
            }
            return null;
        }
    }
}

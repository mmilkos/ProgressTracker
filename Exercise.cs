using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressTracker
{
    internal class Exercise
    {
        private string name;
        private int sets;
        private float weight;
        private int reps;
        private DateTime date;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Sets 
        {
            get { return sets; }
            set { sets = value; }
        }
        public float Weight 
        {
            get { return weight; }
            set { weight = value; }
        }

        public int Reps
        {
            get { return reps; }
            set { reps = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
    }
}

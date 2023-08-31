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
        private DateTime date;
        private float weight;
        private float oneRepMax;
        private int sets;
        private int reps;
  
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public float Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public float OneRepMax
        {
            get { return oneRepMax; }
            set { oneRepMax = value; }
        }

        public int Sets 
        {
            get { return sets; }
            set { sets = value; }
        }
        

        public int Reps
        {
            get { return reps; }
            set { reps = value; }
        }

       
    }
}

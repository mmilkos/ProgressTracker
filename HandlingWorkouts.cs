using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressTracker
{
    internal class HandlingWorkouts
    {
        public List<Exercise> ExercisesList { get; set; } = new List<Exercise>();

        public Exercise CreateExercise()
        {
            Exercise exercise = new Exercise();
            Console.WriteLine("Name of the exercise: ");
            string name = Console.ReadLine();
            exercise.Name = name;
          
            while (true) 
            {
                Console.WriteLine("Enter the date of the exercise (dd/mm/yyyy): ");
                if (DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime inputDate))
                {
                    exercise.Date = inputDate;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid date format. Please use the format dd/mm/yyyy.");
                }
            }
            Console.WriteLine("How many sets: ");
            string sets = Console.ReadLine();
            if (sets != null)
            {
                exercise.Sets = int.Parse(sets);
            }
            

            Console.WriteLine("How many reps: ");
            string reps = Console.ReadLine();
            if (reps != null)
            {
                exercise.Reps = int.Parse(reps);
            }
            
            Console.WriteLine("What weight was used?: ");
            string weight = Console.ReadLine();
            if (sets != null)
            {
                exercise.Weight = float.Parse(weight);
            }
            

            exercise.OneRepMax = CalculateOneRepMax(exercise.Weight, exercise.Reps);
           


            return exercise;
        }

        private float CalculateOneRepMax(float weight, int reps) 
        {
            //50kg * 5 = 58kg
            float floatReps = Convert.ToSingle(reps);
            float oneRepMaxFloat = (float)(weight * (1 + 0.0333 * floatReps));
            return oneRepMaxFloat;
        }

        public void AddExerciseToList(Exercise exercise)
        {
            ExercisesList.Add(exercise);
            ExercisesList.Sort((x,y) => x.Date.CompareTo(y.Date));
        }

        public void DisplayProgress()
        {
            Console.WriteLine("Progress from wchich exercise do you want to see? ");
            List<string> namesOfExercises = new List<string>();
            var names = ExercisesList.Select(x => x.Name).Distinct().ToList();

            if(ExercisesList != null) 
            {
                int count = 1;
                foreach (var item in names)
                {
                    Console.WriteLine(count.ToString() +"." + item);
                    count++;
                }

                string userChoice = Console.ReadLine();

                foreach (var item in ExercisesList)
                {

                    if (userChoice == item.Name)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine(item.Name);
                        Console.WriteLine(item.Date.ToString("dd/MM/yyyy"));
                        Console.WriteLine("Weight: " + item.Weight + "KG");
                        Console.WriteLine("Reps: " + item.Reps);
                        Console.WriteLine("Calculated one rep max: " + item.OneRepMax.ToString() + "KG");
                        
                    }
                }
            }
            else
            {
                Console.WriteLine("No exercises added");
            }
        }
    }
}

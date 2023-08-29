using System;
using System.Collections.Generic;
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

            while (true)
            {
                Console.WriteLine("Name of the exercise: ");
                string name = Console.ReadLine();
                exercise.Name = name;

                if (ExerciseExists(ExercisesList, exercise))
                {
                    Console.WriteLine("This exercise already exist. Try again.");
                }
                else
                {
                    break;
                }

            }
            
            while (true) 
            {
                Console.WriteLine("Enter the date of the exercise (yyyy-mm-dd): ");
                if (DateTime.TryParse(Console.ReadLine(), out DateTime inputDate))
                {
                    exercise.Date = inputDate;
                    break;
                }
                else
                {
                    Console.WriteLine("Nieprawidłowy format daty.");
                }

            }

            Console.WriteLine("How many sets: ");
            string sets = Console.ReadLine();
            exercise.Sets = int.Parse(sets);

            Console.WriteLine("How many reps: ");
            string reps = Console.ReadLine();
            exercise.Reps = int.Parse(reps);

            Console.WriteLine("What weight was used?: ");
            string weight = Console.ReadLine();

            if (float.TryParse(weight, out float floatWeight))
            {
                exercise.Weight = floatWeight;
            }

            return exercise;
        }
        private bool ExerciseExists(List<Exercise> exercises, Exercise newExercise)
        {
            return exercises.Any(exercise => exercise.Name == newExercise.Name);
        }

    

        public void AddExerciseToWorkout(Exercise exercise)
        {
            ExercisesList.Add(exercise);
        }

        
        public void DisplayProgress()
        {
            //display progress
        }
    }

}

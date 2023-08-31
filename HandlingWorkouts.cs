﻿using System;
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
            Console.WriteLine("Name of the exercise: ");
            string name = Console.ReadLine();
            exercise.Name = name;
          
            
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
                    Console.WriteLine("Invalid date format.");
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

        private string CalculateOneRepMax(float weight, int reps) 
        {
            float floatReps = Convert.ToSingle(reps);
            float oneRepMaxFloat = (float)(weight * (0.0333 * floatReps));
            string oneRepmax = oneRepMaxFloat.ToString();
            return oneRepmax;
        }

        public void AddExerciseToWorkout(Exercise exercise)
        {
            ExercisesList.Add(exercise);
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
                    Console.WriteLine(count.ToString() + item);
                    count++;
                }


                string userChoice = Console.ReadLine();

                foreach (var item in ExercisesList)
                {

                    if (userChoice == item.Name)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine(item.Name);
                        Console.WriteLine(item.Date);
                        Console.WriteLine("Weight: " + item.Weight);
                        Console.WriteLine("Reps: " + item.Reps);
                        Console.WriteLine("Calculated one rep max: " + CalculateOneRepMax(item.Weight, item.Reps));
                        Console.WriteLine(" ");

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

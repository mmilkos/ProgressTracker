using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressTracker
{
    internal class TrainingService
    {
        public void startProgram() 
        {
            HandlingWorkouts handlingWorkouts = new HandlingWorkouts();
            Console.WriteLine("Welcome in GymTracker!");
            Console.WriteLine(" ");

            while (true)
            {
                Console.WriteLine("What would you like to do? ");
                Console.WriteLine("1. Add exercise");
                Console.WriteLine("2. see your progress");
                Console.WriteLine("3. type anything else to exit the program");

                string userChoice = Console.ReadLine();
                if (userChoice == "1") 
                {
                    var exercise = handlingWorkouts.CreateExercise();
                    handlingWorkouts.AddExerciseToWorkout(exercise);
                }
                else if (userChoice == "2") 
                {
                    handlingWorkouts.DisplayProgress();
                }
                else { break; }
            }
        }
    }
}

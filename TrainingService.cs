using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressTracker
{
    internal class TrainingService
    {
        public void addTrainings() 
        {
            HandlingWorkouts handlingWorkouts = new HandlingWorkouts();
            Console.WriteLine("Welcome in GymTracker!");

            while (true)
            {
                Console.WriteLine("What would you like to do? ");
                Console.WriteLine("1. Add exercise");
                Console.WriteLine("2. see your progress");
                
                var exercise = handlingWorkouts.CreateExercise();
                handlingWorkouts.AddExerciseToWorkout(exercise);
               

            }
        }
    }
}

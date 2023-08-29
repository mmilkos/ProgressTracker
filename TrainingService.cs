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
            
                var exercise = handlingWorkouts.CreateExercise();
                handlingWorkouts.AddExerciseToWorkout(exercise);
               

            }
        }
    }
}

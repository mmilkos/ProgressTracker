using ProgressTracker;

internal class Program
{
    private static void Main(string[] args)
    {
        TrainingService trainingService = new TrainingService();
        trainingService.addTrainings();
    }
}
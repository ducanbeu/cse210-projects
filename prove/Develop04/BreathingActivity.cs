
class BreathingActivity : MedidationActivity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public override void PerformActivity()
    {
        int remainingTime = GetDuration();
        while (remainingTime > 0)
        {
            Console.WriteLine("Breathe in...");
            Pause(3);
            Console.WriteLine("Breathe out...");
            Pause(3);
            remainingTime -= 6;
        }
    }
}
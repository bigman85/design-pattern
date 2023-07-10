namespace DesignPattern.BehaviorPattern.State
{
    public class StartState : IState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("Player is in start state");
            context.State = this;
        }
        public override string ToString()
        {
            return "START STATE";
        }

    }
}
using StatePattern.Common;

namespace StatePattern.PackageExample
{
    public class DeliveredState : PackageState
    {
        public override void Revert(Package package) => package.ChangeState(new OrderedState());
        
        public override void PrintStatus()
        {
            Console.WriteLine("Package delivered to post office, not received yet.");
        }

        public override void Proceed(Package package)
        {
            package.ChangeState(new ReceivedState());
        }

        
    }
}

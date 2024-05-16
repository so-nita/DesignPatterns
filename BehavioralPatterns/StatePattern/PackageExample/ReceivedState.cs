using StatePattern.Common;

namespace StatePattern.PackageExample
{
    public class ReceivedState : PackageState
    {
        public override void Revert(Package package) => package.ChangeState(new DeliveredState());

        public override void PrintStatus()
        {
            Console.WriteLine("Package received by a client.");
        }

        public override void Proceed(Package package)
        {
            Console.WriteLine("Package is already received by a client");
        }

    }
}

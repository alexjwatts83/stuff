using System;

namespace GuessThatAnimal.UnitTests
{
    public class FluentBase
    {
        protected void Given(Action action)
        {
            action();
        }

        protected void Given(string msg, Action action)
        {
            action();
        }
        protected void When(Action action)
        {
            action();
        }

        protected void When(string msg, Action action)
        {
            action();
        }

        protected void Then(Action action)
        {
            action();
        }

        protected void Then(string msg, Action action)
        {
            action();
        }

    }
}

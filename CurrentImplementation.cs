using System;
namespace DependencyExample
{
    public interface ICurrentImplementation
    {
        int Function();
    }

    public class CurrentImplementation : ICurrentImplementation
    {
        public int Function()
        {
            return 0;
        }
    }
}


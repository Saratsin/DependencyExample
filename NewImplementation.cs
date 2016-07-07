using System;
using TinyIoC;

namespace DependencyExample
{
    public abstract class ANewImplementation
    {
        static ANewImplementation instance;

        public static ANewImplementation Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = TinyIoCContainer.Current.Resolve<ANewImplementation>();
                }
                return instance;
            }
        }

        public abstract int Function();
    }

    public class NewImplementation : ANewImplementation
    {
        public override int Function()
        {
            return 0;
        }
    }
}


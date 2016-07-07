namespace DependencyExample
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            var container = TinyIoC.TinyIoCContainer.Current;

            container.Register<ICurrentImplementation, CurrentImplementation>().AsSingleton();
            container.Register<ANewImplementation, NewImplementation>().AsSingleton();

            GetImplementations();
        }

        static void GetImplementations()
        {
            //Getting current instance, a lot of stuff to write
            var currentImplementation = TinyIoC.TinyIoCContainer.Current.Resolve<ICurrentImplementation>();

            //Getting current instance, simple and clear, just use Abstract class instead of interface
            var newImplementation = ANewImplementation.Instance;
        }
   }
}

using System;

namespace Tea_Making_Demo
{
    public interface IStep {
        void Do();
    }
    class Program
    {
        static void Main(string[] args)
        {
            var brewUp = new BrewUp(new FillKettle(new BoilKettle(new AddCoffeeToCup(new AddMilk(null)))));
            brewUp.CuppaFather();
            Console.ReadKey();
        }

        public class FillKettle : IStep
        {
            private readonly IStep _step;

            public FillKettle(IStep step)
            {
                _step = step;
            }

            public void Do()
            {
                Console.WriteLine("Fill the kettle");

                if (_step == null)
                    return;
                _step.Do();
            }
        }

        public class BoilKettle : IStep
        {
            private readonly IStep _step;

            public BoilKettle(IStep step)
            {
                _step = step;
            }

            public void Do()
            {
                Console.WriteLine("Boil the kettle");
                if (_step == null)
                    return;
                _step.Do();

            }
        }

        public class AddCoffeeToCup : IStep
        {
            private readonly IStep _step;

            public AddCoffeeToCup(IStep step)
            {
                _step = step;
            }

            public void Do()
            {
                Console.WriteLine("Add Tea");
                if (_step == null)
                    return;
                _step.Do();
            }
        }
            
        public class AddMilk :IStep
        {
            private readonly IStep _step;

            public AddMilk(IStep step)
            {
                _step = step;
            }

            public void Do()
            {
                Console.WriteLine("Add Milk");
                if (_step == null)
                    return;
                _step.Do();
            }
        }

        public class BrewUp
        {
            private readonly IStep _step;

            public BrewUp(IStep step)
            {
                _step = step;
            }

            public void CuppaFather()
            {
                _step.Do();
            }

        }


    }
}

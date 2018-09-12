using System;

namespace ChickenEgg
{

    public interface IBird
    {
        Egg Lay();
    }
    // Should implement IBird
    public class Chicken : IBird
    {
        
        public Egg Lay()
        {
            // pass the new chicken in the constructor and return it
            var egg = new Egg(() => new Chicken());
            return egg;
        }
    }
    public class Egg
    {
        private readonly Func<IBird> _createBird;
        bool _hasHatched;
        public Egg(Func<IBird> createBird)
        {
            _createBird = createBird;
        }

        public IBird Hatch()
        {
            if (_hasHatched)
            {
                // this throws when we already have a child chicken and exits the function.
                throw new NotImplementedException("The spec asks for only one child chicken per chicken.");
            }
            // set that we have a child chicken and return the chicken created in the constuctor
            _hasHatched = true;
            return _createBird();
        }
    }
}
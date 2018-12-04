using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.Objective1_4
{
    public static class UsingEvents
    {
        // Listing 1-82 Usingan Action to expose an event

        // Listing 1-83 Using the event keyword
        public static void UsingTheEventKeyword()
        {
            Car c = new Car();
            c.OnChange += c_OnChange;

            c.Speed = 5;
            c.Speed = 55;
            c.Speed = 60;
        }

        private static void c_OnChange()
        {
            Console.WriteLine("Event FIRED stay under 60 mph");
        }
    }

    // Listing 1-87 Manually raising events with exceptions handling
    public class Pub
    {
        public event EventHandler Onchange = delegate { };

        public void Raise()
        {
            var exceptions = new List<Exception>();
            foreach (Delegate handler in Onchange.GetInvocationList())
            {
                try
                {
                    handler.DynamicInvoke(this, EventArgs.Empty);
                }
                catch (Exception ex)
                {

                    exceptions.Add(ex);
                }
            }
        }
        public void CreatAndRaise()
        {
            Pub p = new Pub();
            
            p.Onchange += (sender,e)
                => Console.WriteLine("Subcriber 1 called");
            p.Onchange += (sender, e)
                => { throw new Exception(); };

            p.Onchange += (sender, e)
                => Console.WriteLine("Subcriber 1 called");
            try
            {
                p.Raise();
            }
            catch (AggregateException ex)
            {

                throw;
            }
        }
    }


}

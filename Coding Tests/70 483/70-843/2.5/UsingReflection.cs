using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.Objective2_5
{
    class UsingReflection
    {
        //Listing 2-69 Creating an interface that can be found though reflection
        public interface IPlugin
        {
            string Name { get; }
            string Description { get; }
            bool Load(MyApplication application);
        }
    }
}

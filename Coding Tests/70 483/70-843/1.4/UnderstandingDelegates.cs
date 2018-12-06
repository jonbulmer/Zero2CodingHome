using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Objective1_4
{
    class UnderstandingDelegates
    {
        // Listing 1-75 Usinga delegate
        public static void UsingDelegate()
        {
            UseDelegate d = new UseDelegate();
        }

        // Listing 1-76
        public static void MulticastDelegate()
        {
            MulticastClass m = new MulticastClass();
            m.Multicast();
        }


        // Listing 1-77 
        public delegate TextWriter CovarianceDel();
        public StreamWriter MethodStream() { return null; }
        public StringWriter MethodString() { return null; }

        //CovarianceDel del;
        //del = MethodStream;
        //    del = MethodString()

        //}

        // Listing 1-78 Contravariance with delegates
    }
}

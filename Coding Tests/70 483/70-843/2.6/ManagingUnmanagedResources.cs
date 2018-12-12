using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Exam.Objective2_6
{
    class ManagingUnmanagedResources
{
        // Listing 2-79 adding the finalizer
        ~ManagingUnmanagedResources()
        {
            Console.WriteLine();
        }

        //Listing 2-81 Forcing a gargage collection
        public static void ForcingGarbageCollection()
        {
            StreamWriter stream = File.CreateText("temp.dat");
            stream.Write("some data");
            GC.WaitForPendingFinalizers();
            File.Delete("temp.dat");
        }
}
}

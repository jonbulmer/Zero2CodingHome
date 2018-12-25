using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Text;

namespace Exam.TestQuestions
{
    public class MappingExceptions : Exception
    {
        public MappingExceptions() { }
        public MappingExceptions(String msg) : base(msg){ }
        public MappingExceptions(string msg, Exception inner) : base(msg, inner) { }
    }

    [ServiceContract]
    public class ServiceClass {
        [OperationContract]
        public void EncryptData(byte[] data)
        {
            q.Add(data);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Text;
using System.Runtime.InteropServices;

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

    public class Unmanaged : IDisposable
    {
        private SafeHandle resource;
        public Unmanaged()
        {

        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (resource != null)
                {
                    resource.Dispose();
                }

            }
        }

    }
}

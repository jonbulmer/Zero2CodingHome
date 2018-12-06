using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.LanguageFeatures
{

    class User
    {
        private string _name;
        public User(string name)
        {
            _name = name;
        }
    }

    class LanguageFeaturesPart1
    {
        // auto propertry initializer
        public Guid Id { get; } = Guid.NewGuid();

        // Dictionary Initializer
        Dictionary<string, User> _defaultUsers
            = new Dictionary<string, User>()
            {
                ["admin"] = new User("admin"),
                ["guest"] = new User("guest")
            };

        // Params and IEnumerable
        //public static Main()
        // {
        //    var result = Sum(45, 54, 14);
        //}
        //    public int Sum(params IEnumerable<int> numbers)
        //    {
        //        return Sum(n => n);
        //    }


        //Literals and Separators
        public class Digits
        {
            public byte Code { get; } = 0b1100;
            public long Length { get; } = 1_000_000_000;
        }
    }

}

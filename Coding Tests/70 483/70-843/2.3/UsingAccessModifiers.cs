/*
 Table 2-4 Allowed access modifiers on nested types
 enum       public      none
 class      private     all
 interface  public      none
 struct     private     public,internal,private 

 */


using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

[assembly: InternalsVisibleTo("Friend1b")]
namespace Exam.Objective2_3
{
    class UsingAccessModifiers
    {

    }

    // Listing 2-31 Using access modifiers

    public class Dog
    {
        public void Bark() { }
    }

    // Listing 2-32 Using the private access modifier
    public class Accessibility
    {
        private string _myField;
        public string MyProperty
        {
            get { return _myField; }
            set { _myField = value; }
        }
    }

    // Listing 2-34 Using the protected access modifier with inheritance
    public class Base
    {
        private int _privateField = 42;
        protected int _protectedField = 42;

        private void MyPrivateMethod() { }
        protected void MyProtectedMethod() { }
    }

    public class Derived : Base
    {
        public void MyDerivedMethod()
        {
            _protectedField = 43;

            MyProtectedMethod();
        }
    }

    
    internal class MyInternalClass
    {
        public void MyMethod() { }
    }

}




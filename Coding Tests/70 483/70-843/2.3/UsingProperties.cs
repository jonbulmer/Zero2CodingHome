using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.Objective2_3
{
    class UsingProperties
    {
        // Listing 2-36 Encapsulating a field with custom metods
        private int _field;
        public void SetValue(int value) { _field = value; }

        public int GetValue() { return _field; }
    }

    // Listing 2-37 Creating a property
    class Person
    {
        private string _firstname;
        public string Firstname
        {
            get { return _firstname; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException();
                }
                _firstname = value;
            }
        }

        public string Surname { get; set; }
    }

    class UsingExplcitInterfaceImplementations
    {
        // Listing 2-38 The IOjectContextAdapter
        public interface IOjectContextAdapter
        {
            ObjectContext ObjectContext { get; }
        }
    }

    public class ObjectContext
    {
    }

    // Listing 2-39 Implementing an interface explictly
    interface IInterfaceA
    {
        void MyMethod();
    }

    class Implementation : IInterfaceA
    {
        void IInterfaceA.MyMethod() { }
    }

    // Listing 2-40 Implementing an interface explicitly
    interface ILeft
    {
        void Move();
    }

    interface IRight
    {
        void Move();
    }

    class MoveableObject : ILeft, IRight
    {
        void ILeft.Move() { }
        void IRight.Move() { }
    }

}

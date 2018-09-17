/*
 A TrainComposition is built by attaching and detaching wagons from the left and the right sides.

For example, if we start by attaching wagon 7 from the left followed by attaching wagon 13, again from the left, 
we get a composition of two wagons (13 and 7 from left to right). 

Now the first wagon that can be detached from the right is 7 and the first that can be detached from the left is 13.

Implement a TrainComposition that models this problem.
 */

using System;
using System.Collections.Generic;

namespace GeneralProblems
{
    public class TrainComposition
    { 
        // Start with a linked list of int for the wagon numbers
        LinkedList<int> train = new LinkedList<int>();
        public void AttachWagonFromLeft(int wagonId)
        {
            //add a wagon to the start of the list 
            train.AddFirst(wagonId);
        }

        public void AttachWagonFromRight(int wagonId)
        {
            // add a wagon to the end of the list
            train.AddLast(wagonId);
        }

        public int DetachWagonFromLeft()
        {
            // get the wagon number before we remove it from the list
            int result = train.First.Value;
            // remove the first wagon
            train.RemoveFirst();
            // return its number
            return result;
        }

        public int DetachWagonFromRight()
        {
            // same logic as above
            int result = train.Last.Value;
            train.RemoveLast();
            return result;
        }
    }
}
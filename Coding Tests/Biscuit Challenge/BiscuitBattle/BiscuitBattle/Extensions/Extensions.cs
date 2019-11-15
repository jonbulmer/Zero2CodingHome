using System;
using System.Collections.Generic;
using System.Text;

namespace BiscuitBattle.Extensions
{
    public static class Extensions
    {

        public static void MoveItemAtIndexToFront<T>(this IList<T> list, int index)
        {
            T item = list[index];
            list.RemoveAt(index);
            list.Insert(0, item);
        }
    }

}

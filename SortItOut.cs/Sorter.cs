using System;
using System.Collections.Generic;

namespace SortItOut
{
    public class Sorter
    {
        List<int> Draws = new List<int>();

        public List<int> Balls()
        {
            return Draws;
        }

        public void Draw(int oneBall)
        {
            Draws.Add(oneBall);
        }

        public List<int> Sorted()
        {
            Draws.Sort();
            return Draws;
        }
    }
}

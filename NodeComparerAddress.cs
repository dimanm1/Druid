using System.Collections.Generic;

namespace Druid
{
    public class NodeComparerAddress : IComparer<Node>
    {
        public int Compare(Node x, Node y)
        {
            if (x.Level < y.Level)
            {
                return -1;
            }

            if (x.Level > y.Level)
            {
                return 1;
            }

            for (int i = 0; i <= x.Level; i++)
            {
                if (x.Address[i] < y.Address[i])
                {
                    return -1;
                }

                if (x.Address[i] > y.Address[i])
                {
                    return 1;
                }
            }

            return 0;
        }
    }
}

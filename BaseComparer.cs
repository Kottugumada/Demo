using System.Collections.Generic;

namespace Comparer{
    public class NamesComparer :IComparer<string>{
        public int Compare(string x, string y)
        {
            return string.Compare(x,y, false);
        }
    }
    public class LengthComparer:IComparer<int>{
        public int Compare(int l1, int l2) {
        return l1 > l2 ? 1 : -1;
        }
    }
}
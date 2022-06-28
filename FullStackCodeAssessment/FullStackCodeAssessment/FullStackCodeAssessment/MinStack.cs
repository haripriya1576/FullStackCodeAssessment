using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackCodeAssessment
{
    public class MinStack
    {
        Stack<int> st = new Stack<int>();
        Stack<int> mn = new Stack<int>();
        /** initialize your data structure here. */
        public MinStack()
        {

        }

        public void Push(int val)
        {
            if (st.Count == 0 || val <= mn?.Peek())
                mn.Push(val);
            st.Push(val);
        }

        public void Pop()
        {
            if (st.Peek().Equals(mn.Peek()))
                mn.Pop();
            st.Pop();
        }

        public int Top()
        {
            return st.Peek();
        }

        public int GetMin()
        {
            return mn.Peek();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class StackDs
    {
        private int[] _stk;
        private int count = 0;

        public StackDs(int size)
        {
            _stk = new int[size];
        }

        /// <summary>
        /// To add element into stack
        /// </summary>
        /// <param name="item"></param>
        public void Push(int item)
        {
            if (count == _stk.Length) {
                throw new StackOverflowException();
            }
            _stk[count++] = item;
        }

        /// <summary>
        /// To remove the last element of the stack
        /// </summary>
        /// <returns></returns>
        public int Pop()
        {
            if (IsEmpty()) {
                throw new Exception("Stack is Empty");
            }
            return _stk[--count];
        }

        /// <summary>
        /// To get last value of stack;
        /// </summary>
        /// <returns></returns>
        public int Peek()
        {
            return _stk[count - 1];
        }

        /// <summary>
        /// To check if stack is empty
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return count == 0;
        }
    }
}

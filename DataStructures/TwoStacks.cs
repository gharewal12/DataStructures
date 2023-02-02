using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class TwoStacks
    {
        private int[] stk;
        private int count1;
        private int count2;

        public TwoStacks(int size)
        {
            stk = new int[size];
            count1 = -1;
            count2 = size;
        }

        /// <summary>
        /// Push item into stack1
        /// </summary>
        /// <param name="item"></param>
        /// <exception cref="Exception"></exception>
        public void Push1(int item)
        {
            if (IsFull1()) {
                throw new Exception("Stack is full");
            }
            stk[++count1] = item;
        }

        /// <summary>
        /// Push item into stack2
        /// </summary>
        /// <param name="item"></param>
        /// <exception cref="Exception"></exception>
        public void Push2(int item)
        {
            if (IsFull2()) {
                throw new Exception("Stack is full");
            }
            stk[--count2] = item;
        }

        /// <summary>
        /// Remove item from stack1
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public int Pop1()
        {
            if (IsEmpty1()) {
                throw new Exception("Stack is empty");
            }

            return stk[count1--];
        }

        /// <summary>
        /// Remove item from stack2
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public int Pop2()
        {
            if (IsEmpty2()) {
                throw new Exception("Stack is empty");
            }

            return stk[count2++];
        }

        private bool IsEmpty1()
        {
            return count1 == -1;
        }
        private bool IsEmpty2()
        {
            return count2 == stk.Length;
        }


        private bool IsFull1()
        {
            return count1 == count2;
        }

        private bool IsFull2()
        {
            return count2 == count1;
        }
    }
}

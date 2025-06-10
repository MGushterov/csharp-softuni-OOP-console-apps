namespace CustomStack
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class StackOfStrings : Stack<string>
    {
        public StackOfStrings()
        {

        }
        public bool IsEmpty()
        {
            if (this.Count > 0)
            {
                return false;
            }
            return true;
        }

        public void AddRange(IEnumerable<string> collection)
        {
            foreach (var element in collection)
                this.Push(element);
        }
    }
}

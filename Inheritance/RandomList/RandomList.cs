namespace CustomRandomList
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class RandomList : List<string>
    {
        public RandomList()
        {

        }
        private Random random; 
        public string RemoveRandomElement()
        {
            int index = random.Next(0, this.Count);
            string element = this[index];
            this.RemoveAt(index);
            return element;
        }
    }
}

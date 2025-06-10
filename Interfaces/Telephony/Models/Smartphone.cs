namespace Telephony.Models
{
    using Interfaces;
    public class Smartphone : IBrowseable, ICallable
    {
        public string Call(string number)
        {
            return $"Calling... {number}";
        }

        public string Browse(string url)
        {
            return $"Browsing: {url}!";
        } 
    }
}

namespace Telephony.Core
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using IO.Interfaces;
    using Models;

    public class Engine : IEngine
    {
        private readonly IReader _reader;
        private readonly IWriter _writer;

        private readonly Smartphone smartphone;
        private readonly StationaryPhone stationaryphone;

        private Engine()
        {
            this.smartphone = new Smartphone();
            this.stationaryphone = new StationaryPhone();
        }

        public Engine(IReader reader, IWriter writer)
            : this()
        {
            this._reader = reader;
            this._writer = writer;
        }

        public void Start()
        {
            string[] phoneNumbers = _reader.ReadLine().Split(' ');
            string[] urls = _reader.ReadLine().Split(' ');

            foreach (var phoneNumber in phoneNumbers)
            {
                if (!ValidateNumber(phoneNumber))
                {
                    _writer.WriteLine("Invalid number!");
                }
                else if (phoneNumber.Length == 7)
                {
                    _writer.WriteLine(this.stationaryphone.Call(phoneNumber));
                }
                else if (phoneNumber.Length == 10)
                {
                    _writer.WriteLine(this.smartphone.Call(phoneNumber));
                }
            }
            foreach (var url in urls)
            {
                if (!ValidateUrl(url))
                {
                    _writer.WriteLine("Invalid URL!");
                }
                else
                {
                    _writer.WriteLine(this.smartphone.Browse(url));
                }
            }
        }

        public bool ValidateNumber(string number)
        {
            foreach (char digit in number)
            {
                if (!Char.IsDigit(digit))
                {
                    return false;
                }
            }
            return true;
        }

        public bool ValidateUrl(string url)
        {
            foreach (char ch in url)
            {
                if (Char.IsDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }
    }
}




namespace Telephony.Core
{
    using Interfaces;
    using System;
    using Telephony.IO.Interfaces;
    using Models.Interfaces;
    using Models;
    using Exceptions;

    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly IStationaryPhone stationaryPhone;
        private readonly ISmartPhone smartPhone;

        public Engine()
        {
            this.stationaryPhone = new StacionaryPhone();
            this.smartPhone = new Smartphone();

        }
        public Engine(IReader reader, IWriter writer) : this()
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            string[] phoneNumbers = this.reader.ReadLine().Split(' ');
            string[] urls = this.reader.ReadLine().Split(' ');

            foreach (var phoneNumber in phoneNumbers)
            {
                try
                {
                    if (phoneNumber.Length == 10)
                    {
                        this.writer.WriteLine(this.smartPhone.Call(phoneNumber));
                    }
                    else if (phoneNumber.Length == 7)
                    {
                        this.writer.WriteLine(this.stationaryPhone.Call(phoneNumber));
                    }
                    else
                    {
                        throw new InvalidPhoneNumberException();
                    }
                }
                catch (InvalidPhoneNumberException ipne)
                {
                    this.writer.WriteLine(ipne.Message);
                }
                catch (Exception)
                {
                    throw;
                }
            }
            foreach (var url in urls)
            {
                try
                {
                    this.writer.WriteLine(this.smartPhone.BrowsingURL(url));
                }
                catch (InvalidURLException iue)
                {
                    this.writer.WriteLine(iue.Message);
                }
                catch (Exception)
                {
                    throw;
                }
            }

        }
    }
}

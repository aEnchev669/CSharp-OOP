using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Telephony.Models
{
    using Interfaces;
    using Exceptions;

    public class Smartphone : ISmartPhone
    {
        public string BrowsingURL(string url)
        {
            if (ValidURL(url))
            {
                throw new InvalidURLException();
            }   
            return $"Browsing: {url}!";
        }

        public string Call(string phoneNumber)
        {
            if (!this.ValidPhoneNumber(phoneNumber))
            {
                throw new InvalidPhoneNumberException();
            }
            return $"Calling... {phoneNumber}";

        }

        private bool ValidPhoneNumber(string phoneNumber) => phoneNumber.All(ch => char.IsDigit(ch));
        private bool ValidURL(string url) => url.Any(ch => char.IsDigit(ch));
    }
}

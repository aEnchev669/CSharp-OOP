

namespace Telephony.Models
{
    using System.Linq;
    using Interfaces;
    using Exceptions;

    public class StacionaryPhone : IStationaryPhone
    {
        public string Call(string phoneNumber)
        {
            if (this.ValidPhoneNumber(phoneNumber))
            {
                throw new InvalidPhoneNumberException();
            }
            return $"Dialing... {phoneNumber}";
            
        }

        private bool ValidPhoneNumber(string phoneNumber) => phoneNumber.Any(ch => !char.IsDigit(ch));
        
    }
}

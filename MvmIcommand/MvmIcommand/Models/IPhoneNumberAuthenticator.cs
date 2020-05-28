using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MvmIcommand.Models
{
    public interface IPhoneNumberAuthenticator
    {
        Task<string> phoneNumber(string phonenumber);
    }
}

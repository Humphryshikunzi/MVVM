using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Twilio;
using Twilio.Clients;

namespace MvmIcommandAPI.Models
{
    public class UserContext : DbContext

    {
          public DbSet<User> Users { get; set; }
    }


    public class User
    {

        public int Id { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string SendToken()

        {


            var r = new Random((int)DateTime.Now.Ticks);

            var twilioClient = new TwilioRestClient(
                
                ConfigurationManager.AppSettings["TwilioAccountSid"],

                ConfigurationManager.AppSettings["TwilioAuthToken"]);



            // Generate six-digit token

            string token = r.Next(100000, 1000000).ToString();

               
               twilioClient.SendMessage(

                ConfigurationManager.AppSettings["TwilioPhoneNumber"],

                this.PhoneNumber,

                String.Format("Your auth token is {0}.", token));



            return token;

        }
    }
}
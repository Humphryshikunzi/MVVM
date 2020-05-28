using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;


namespace MvmIcommand.Models
{
  public  class Client
    {
        public int  Id { get; set; }
        public  string  Email { get; set; }
        public  string  Password { get; set; }

        FirebaseClient firebase = new FirebaseClient("https://icropaldata.firebaseio.com/");
        public async Task<List<Client>> GetAllClients()
        {

            return (await firebase
              .Child("Client")
              .OnceAsync<Client>()).Select(item => new Client
              {
                  Email = item.Object.Email,
                  Password= item.Object.Password
              }).ToList();
        }
        public async Task AddClient( string  email, string  password)
        {

            await firebase
              .Child("Client")
              .PostAsync(new  Client() {  Email =  email,  Password =  password });
        }
        public async Task< Client> GetClient(int clientId)
        {
            var  allclients = await  GetAllClients();
            await firebase
              .Child("Client")
              .OnceAsync<Client>();
            return   allclients.Where(a => a.Id == clientId).FirstOrDefault();
        }
        public async Task UpdateClient(int personId, string  email)
        {
            var toUpdateClient = (await firebase
              .Child("Client")
              .OnceAsync<Client>()).Where(a => a.Object.Id == personId).FirstOrDefault();

            await firebase
              .Child("Client")
              .Child(toUpdateClient.Key)
              .PutAsync(new  Client() {  Id = personId,  Email =  email });
        }
        public async Task DeleteClient(int  clientId)
        {
            var toDeletePerson = (await firebase
              .Child("Client")
              .OnceAsync<Client>()).Where(a => a.Object. Id ==  clientId).FirstOrDefault();
            await firebase.Child("Client").Child(toDeletePerson.Key).DeleteAsync();

        }

    }

}

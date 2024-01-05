using ContactManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ContactManagementApp.DAL.Services.Repository
{
    public class ContactRepository : IContactRepository
    {
        private readonly DatabaseContext _dbContext;
        public ContactRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<Contact> CreateContact(Contact contact)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteContactById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public List<Contact> GetAllContacts()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<Contact> GetContactById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

      
        

        public async Task<Contact> UpdateContact(Contact model)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
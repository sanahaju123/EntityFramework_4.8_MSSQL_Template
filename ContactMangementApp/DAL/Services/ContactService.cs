using ContactManagementApp.DAL.Interrfaces;
using ContactManagementApp.DAL.Services.Repository;
using ContactManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ContactManagementApp.DAL.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _repository;

        public ContactService(IContactRepository repository)
        {
            _repository = repository;
        }

        public Task<Contact> CreateContact(Contact expense)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<bool> DeleteContactById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public List<Contact> GetAllContacts()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<Contact> GetContactById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<Contact> UpdateContact(Contact model)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
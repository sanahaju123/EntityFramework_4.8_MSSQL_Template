using ContactManagement.Models;
using ContactManagementApp.DAL.Interrfaces;
using ContactManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ContactManagementApp.Controllers
{
    public class ContactController : ApiController
    {
        private readonly IContactService _service;
        public ContactController(IContactService service)
        {
            _service = service;
        }
        public ContactController()
        {
            // Constructor logic, if needed
        }
        [HttpPost]
        [Route("api/Contact/CreateContact")]
        [AllowAnonymous]
        public async Task<IHttpActionResult> CreateContact([FromBody] Contact model)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpPut]
        [Route("api/Contact/UpdateContact")]
        public async Task<IHttpActionResult> UpdateContact([FromBody] Contact model)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpDelete]
        [Route("api/Contact/DeleteContact")]
        public async Task<IHttpActionResult> DeleteContact(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("api/Contact/GetContactById")]
        public async Task<IHttpActionResult> GetContactById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("api/Contact/GetAllContacts")]
        public async Task<IEnumerable<Contact>> GetAllContacts()
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}

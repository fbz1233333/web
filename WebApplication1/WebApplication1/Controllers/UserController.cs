using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UsersController : ApiController
    {
        private User[] users = new User[] { new User{ id = 1, name = "Haleemah Redfern", email = "email1@mail.com", phone = "01111111", role = 1 },
            new User { id = 2, name = "Aya Bostock", email = "email2@mail.com", phone = "01111111", role = 1} };
    public IEnumerable<User> Get()
        {
            return users;
        }

        // GET: api/User/5
        public User Get(int id)
        {
            
            foreach(User u in users)
            {
                if (u.id == id)
                {
                    return u;
                }
                
            }
            return new User();
        }

        // POST: api/User
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/User/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
        }
    }
}

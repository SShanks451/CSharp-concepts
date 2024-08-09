using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UserApi.Data.Interfaces;

namespace UserApi.Api.Controllers
{
    public class UsersController : ApiController
    {
        private IUsersRepository _usersRepository = null;

        public UsersController(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository; 
        }

        public IHttpActionResult GetUser(int id)
        {
            var user = _usersRepository.GetById(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        public IHttpActionResult UpdateUser(int id, string name, string surname, string email)
        {
            var user = _usersRepository.GetById(id);
            if (user == null)
            {
                return NotFound();
            }

            if(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(email))
            {
                return BadRequest();
            }

            Entities.User userUpdated = new Entities.User() { Id = id, Name = name, Surname = surname, Email = email };
            _usersRepository.UpdateById(id, userUpdated);
            return Ok();
        }
    }
}

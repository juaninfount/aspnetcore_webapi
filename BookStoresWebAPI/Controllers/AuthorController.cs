using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using BookStoresWebAPI.Models;

namespace BookStoresWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {
        private readonly BookStoresDBContext _context;

        public AuthorController(BookStoresDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Author> Get()
        {            
          
                /*
                Models.Author author = new Author()
                {
                    FirstName = "Juan",
                    LastName = "Perez",
                    Address = "Sesame St 123",
                    Phone  = "927474321",
                    City = "Chicago",
                    State = "IL",
                    EmailAddress =  "jlperez123@gmail.com"
                }; */
                
                var author = _context.Author.FirstOrDefault(x => x.AuthorId == 29);
                if (author != null){
                    author.Phone = "927474322";
                    _context.SaveChanges();
                }
                
                return _context.Author.ToList();                  
        }
    }
}

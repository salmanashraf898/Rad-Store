using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rad_Store.Model;

namespace Rad_Store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RadController : ControllerBase
    {
        public readonly List<Contact> Contacts;

    public RadController()
        {
            Contacts = new List<Contact>();
            {

            }
        }
        [HttpGet]
        public IEnumerable<Contact> Get()
        {
            return Contacts;
        }
        [HttpGet("{id}")]
        public ActionResult<Contact> GetById(int id)
        {
            var message = Contacts.Find(m => m.Id == id);
            if (message == null)
            {
                return NotFound();
            }
            return message;
        }
        [HttpPost]
        public ActionResult<Contact> Post(Contact message)
        {
            message.Id = Contacts.Count + 1;
            Contacts.Add(message);
            return CreatedAtAction(nameof(GetById), new { id = message.Id }, message);
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, Contact updatedMessage)
        {
            var message = Contacts.Find(m => m.Id == id);
            if (message == null)
            {
                return NotFound();
            }
           
          
        }

    }
}

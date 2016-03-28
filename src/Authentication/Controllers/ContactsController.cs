using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using Authentication.Repository;
using Authentication.Models;

namespace Authentication.Controllers
{
[Route("api/[controller]")]
public class ContactsController : Controller
    {
        [FromServices]
        public IContactsRepository ContactsRepo{ get; set; }

        public ContactsController(IContactsRepository ContactsRepo)
        {
            this.ContactsRepo = ContactsRepo;
        }
        [HttpGet]
        public IEnumerable<Contacts>GetAll()
        {       
            return  ContactsRepo.GetAll();            
        }

        [HttpGet("{id}", Name = "GetContacts")]
        public IActionResult GetById(string id)
        {
            var item = ContactsRepo.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return new ObjectResult(item);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Contacts item)
        {
            if (item == null)
            {
                return HttpBadRequest();
            }
            ContactsRepo.Add(item);
            return CreatedAtRoute("GetContacts", new { Controller = "Contacts", id = item.MobilePhone }, item);
        }

        [HttpPut("{id}")]
        public IActionResult Update(string id, [FromBody] Contacts item)
        {
            if (item == null)
            {
                return HttpBadRequest();
            }
            var contactObj = ContactsRepo.Find(id);
            if (contactObj == null)
            {
                return HttpNotFound();
            }
            ContactsRepo.Update(item);
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            ContactsRepo.Remove(id);
        }
    }
}
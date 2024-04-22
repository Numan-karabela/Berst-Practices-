using BP.Data.Model;
using BP.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BP.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }
        [ResponseCache(Duration =10)]//Aynı Id sahip veri geldiğinden Keş'den almasını istiyoruz.
        [HttpGet("{id}")]
        public ContactDVO contactDVO(int id)
        {
            return _contactService.GetContactDVOById(id);

        }
        [HttpPost]
        public  ContactDVO CreateContactDVO(ContactDVO contact)
        {
            //create contact veriable database


            return contact;
        }

    }
}

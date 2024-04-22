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
        [HttpGet("{id}")]
        public ContactDVO contactDVO(int id)
        {
            return _contactService.GetContactDVOById(id);

        }

    }
}

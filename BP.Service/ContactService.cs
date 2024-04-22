using AutoMapper;
using BP.Data.Model;
using BP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP.Service
{
    public class ContactService : IContactService
    {
        private readonly IMapper _mapper;

        public ContactService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public ContactDVO GetContactDVOById(int Id)
        {
            Contact contact = contactFake();

            ContactDVO resultContact =_mapper.Map<ContactDVO>(contact);

            return resultContact;

        }
        private Contact contactFake()
        {
          return new Contact()
            {
                Id = 1,
                FirsName = "Numan ",
                LastName = "Karabela"
            };
        }
    }
}

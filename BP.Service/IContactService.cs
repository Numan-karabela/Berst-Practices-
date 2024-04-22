using BP.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP.Service
{
    public interface IContactService
    {
        public ContactDVO GetContactDVOById(int Id);
    }
}

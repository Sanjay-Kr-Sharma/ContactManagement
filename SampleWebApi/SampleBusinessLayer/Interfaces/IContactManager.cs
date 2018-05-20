using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SampleDataLayer;

namespace SampleBusinessLayer
{
    public interface IContactManager
    {
        List<Contact> Get();
        Contact Get(long id);

        Contact Add(Contact contact);

        Contact Update(Contact contact);
        bool Delete(long id);

    }
}

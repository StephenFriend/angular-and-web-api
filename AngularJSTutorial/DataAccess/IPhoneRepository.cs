using System.Collections.Generic;
using AngularJSTutorial.Models;

namespace AngularJSTutorial.DataAccess
{
    public interface IPhoneRepository
    {
        IEnumerable<Phone> GetAll();
    }
}

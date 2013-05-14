using System.Collections.Generic;
using System.Web.Http;
using AngularJSTutorial.DataAccess;
using AngularJSTutorial.Models;

namespace AngularJSTutorial.Controllers
{
    public class PhonesController : ApiController
    {
        private readonly IPhoneRepository phoneRepo;

        public PhonesController(IPhoneRepository phoneRepo)
        {
            this.phoneRepo = phoneRepo;
        }

        public IEnumerable<Phone> GetAll()
        {
            return this.phoneRepo.GetAll();
        }
    }
}
using System;
using System.Collections.Generic;
using AngularJSTutorial.Models;
using Newtonsoft.Json;

namespace AngularJSTutorial.DataAccess
{
    public class FileDrivenPhoneRepository : IPhoneRepository
    {
        public IEnumerable<Phone> GetAll()
        {
            string dataDirectory = AppDomain.CurrentDomain.GetData("DataDirectory").ToString();
            var phonesText = System.IO.File.ReadAllText(dataDirectory +"/phones.json");
            return JsonConvert.DeserializeObject<List<Phone>>(phonesText);
        }

        public PhoneDetail GetBy(string id)
        {
            string dataDirectory = AppDomain.CurrentDomain.GetData("DataDirectory").ToString();
            var phoneText = System.IO.File.ReadAllText(dataDirectory + "/" + id + ".json");
            return JsonConvert.DeserializeObject<PhoneDetail>(phoneText);
        }
    }
}
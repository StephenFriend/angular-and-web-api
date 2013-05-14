using System;
using System.Collections.Generic;
using System.Web.Http.Dependencies;
using AngularJSTutorial.Controllers;
using AngularJSTutorial.DataAccess;

namespace AngularJSTutorial.Infrastructure
{
    public class SimpleResolver : IDependencyResolver
    {
        public IDependencyScope BeginScope()
        {
            return this;
        }

        public object GetService(Type serviceType)
        {
            if (serviceType == typeof (PhonesController))
            {
                var repo = new FileDrivenPhoneRepository();
                return new PhonesController(repo);
            }

            return null;
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return new List<object>();
        }

        public void Dispose()
        {
            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Patterns_Bridge
{
    abstract class Manager
    {
        protected IService _service;

        public Manager(string username)
        {
            Console.WriteLine($"{username}, you are loading a manager.");
        }

        public virtual void CreateService(IService service)
        {
            this._service = service;
        }
        public abstract void UserService();
        public virtual void DisposeService()
        {
            Console.WriteLine("Service is disposed.");
        }
    }
}

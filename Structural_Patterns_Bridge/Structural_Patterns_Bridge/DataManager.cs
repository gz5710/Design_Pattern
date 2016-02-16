using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Patterns_Bridge
{
    class DataManager : Manager
    {
        public DataManager(string username) : base(username)
        {
            Console.WriteLine("DataManager is loaded");
        }
        public override void CreateService(IService service)
        {
            base.CreateService(service);
            Console.WriteLine("New data service is on...");
        }

        public override void UserService()
        {
            if (this._service != null)
            {
                this._service.DoWork();
            }
        }

        public override void DisposeService()
        {
            base.DisposeService();
            Console.WriteLine(" -- From dataManager.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Patterns_Facade
{
    class Manager
    {
        private IData _data;
        private IPresent _presenter;
        public Manager()
        {
            this._data = new Data();
            this._presenter = new Presenter();
        }
        public void ShowData()
        {
            var data = this._data.GetData();
            this._presenter.PresentData(data);
        }
    }
}

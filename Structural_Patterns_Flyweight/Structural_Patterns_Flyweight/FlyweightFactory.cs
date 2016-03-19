using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Patterns_Flyweight
{
    public class FlyweightFactory
    {
        private Dictionary<string, Flyweight> _flyweightset;

        public Flyweight this[string key]
        {
            get
            {
                if (!this._flyweightset.ContainsKey(key))
                {
                    this._flyweightset.Add(key, new ConcreteFlyweight());
                }
                return _flyweightset[key];
            }
        }
        
        public FlyweightFactory()
        {
            this._flyweightset = new Dictionary<string, Flyweight>();
            this._flyweightset.Add("X", new ConcreteFlyweight());
            this._flyweightset.Add("Y", new ConcreteFlyweight());
            this._flyweightset.Add("Z", new ConcreteFlyweight());
        }
    }
}

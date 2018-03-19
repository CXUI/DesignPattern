using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Context 
    {
        private State _state;

        public Context(State state)
        {
            this.State1 = state;
        }
        public State State1
        {
            get { return _state; }
            set { _state = value;

            Console.WriteLine("State:" + _state.GetType().Name);
            }
        }

        public void Request()
        {
            _state.Handle(this);
        }

 
    }
}

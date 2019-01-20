using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex35_ObserverPattern
{
    public class ConcreteSubject : Subject
    {
        private int state = 0;

        public int State
        {
            get { return this.state; }
            set {
                this.state = value;
                Notify();
            }
        }

        
    }
}

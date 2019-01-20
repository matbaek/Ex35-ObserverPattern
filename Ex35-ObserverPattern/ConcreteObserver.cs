using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex35_ObserverPattern
{
    public class ConcreteObserver : Observer
    {
        private ConcreteSubject subject;
        private int state = 0;

        public int State
        {
            get { return this.state; }
            private set { this.state = value; }
        }

        public ConcreteObserver(ConcreteSubject subject)
        {
            this.subject = subject;
        }

        public override void Update()
        {
            this.state = this.subject.State;
        }
    }
}
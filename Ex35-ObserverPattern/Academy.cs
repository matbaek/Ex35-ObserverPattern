using System;

namespace Ex35_ObserverPattern
{
    public class Academy : Subject
    {
        private string name;
        private string message;

        public string Name
        {
            get { return name; }
        }

        public string Message {
            get { return message; }
            set {
                message = value;
                Notify();
            }
        }

        public Academy(string name)
        {
            this.name = name;
        }
    }
}
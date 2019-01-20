namespace Ex35_ObserverPattern
{
    public class Student : Observer
    {
        private Academy subject;
        private string message;
        private readonly string name;

        public string Message
        {
            get { return this.message; }
            set { this.message = value; }
        }

        public string Name
        {
            get { return this.name; }
        }

        public Student(Academy subject, string name)
        {
            this.subject = subject;
            this.name = name;
        }

        public override void Update()
        {
            this.message = this.subject.Message;
            System.Console.WriteLine("Studerende " + name + " modtog nyheden '" + message + "' fra akadamiet " + subject.Name);
        }
    }
}
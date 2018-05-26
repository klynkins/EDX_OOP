namespace SecondModule
{
    abstract class Employee
    {
        public virtual void Login()
        {
            Console.WriteLine("Employee login");
        }

        public abstract void Hire();

        private string empNumber;
        private string firstName;
        private string lastName;
        private string address;

        public string EmpNumber
        {
            get { return empNumber; }
            set { empNumber = value; }
        }
    }
}
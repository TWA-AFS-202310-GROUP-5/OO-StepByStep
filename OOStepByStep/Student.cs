namespace OOStepByStep
{
    public class Student : Person
    {
        private readonly string jobTitle = "student";

        public Student(string name, int age) : base(name, age, new SchoolPersonnel())
        {
        }

        public override string Introduce()
        {
            return base.Introduce() + ((SchoolPersonnel)OrganizationInfo).Introduce(jobTitle);
        }

        public string Welcome(string name)
        {
            return Introduce() + ((SchoolPersonnel)OrganizationInfo).WelcomeNewClassMember(name);
        }
    }
}
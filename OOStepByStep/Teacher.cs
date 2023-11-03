namespace OOStepByStep
{
    public class Teacher : Person
    {
        private readonly string jobTitle = "teacher";

        public Teacher(string name, int age) : base(name, age, new SchoolPersonnel())
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
namespace OOStepByStep
{
    public class Student : Person
    {
        private readonly string jobTitle = "student";
        private SchoolPersonnel schoolPersonnel = new SchoolPersonnel();

        public Student(string name, int age) : base(name, age)
        {
        }

        public override string Introduce()
        {
            return base.Introduce() + schoolPersonnel.Introduce(jobTitle);
        }

        public void AssignClass(string className)
        {
            schoolPersonnel.UpdateClass(className);
        }

        public string Welcome(string name)
        {
            return Introduce() + schoolPersonnel.WelcomeNewClassMember(name);
        }
    }
}
namespace OOStepByStep
{
    public class Teacher : Person
    {
        private readonly string jobTitle = "teacher";
        private SchoolPersonnel schoolPersonnel = new SchoolPersonnel();

        public Teacher(string name, int age) : base(name, age)
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
namespace OOStepByStep
{
    public class Teacher : Person
    {
        private SchoolPersonnel schoolPersonnel = new SchoolPersonnel();

        public Teacher(string name, int age) : base(name, age)
        {
        }

        public override string Introduce()
        {
            string msg = schoolPersonnel.HasClass ? $" I am a teacher of class {schoolPersonnel.ClassName}." : " I am a teacher.";

            return base.Introduce() + msg;
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
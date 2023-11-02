namespace OOStepByStep
{
    public class Student : Person
    {
        private SchoolPersonnel schoolPersonnel = new SchoolPersonnel();

        public Student(string name, int age) : base(name, age)
        {
        }

        public override string Introduce()
        {
            string msg = schoolPersonnel.HasClass ? $" I am a student of class {schoolPersonnel.ClassName}." : " I am a student.";

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
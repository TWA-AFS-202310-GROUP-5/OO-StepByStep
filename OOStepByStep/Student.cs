namespace OOStepByStep
{
    public class Student : SchoolPersonnel
    {
        public Student(string name, int age) : base(name, age)
        {
        }

        public override string Introduce()
        {
            string msg = string.Empty;

            if (ClassName is null)
            {
                msg = " I am a student.";
            }
            else
            {
                msg = $" I am a student of class {ClassName}.";
            }

            return base.Introduce() + msg;
        }
    }
}

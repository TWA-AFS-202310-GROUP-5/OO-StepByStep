namespace OOStepByStep
{
    public class Teacher : SchoolPersonnel
    {
        public Teacher(string name, int age) : base(name, age)
        {
        }

        public override string Introduce()
        {
            string msg = string.Empty;

            if (ClassName is null)
            {
                msg = " I am a teacher.";
            }
            else
            {
                msg = $" I am a teacher of class {ClassName}.";
            }

            return base.Introduce() + msg;
        }
    }
}

namespace OOStepByStep
{
    public class SchoolPersonnel : Person
    {
        private string className;

        public SchoolPersonnel() : base()
        {
        }

        public SchoolPersonnel(string name, int age) : base(name, age)
        {
        }

        public string ClassName => className;

        public void UpdateClass(string className)
        {
            this.className = className;
        }

        public override string Introduce()
        {
            return base.Introduce();
        }

        public string Welcome(string name)
        {
            if (ClassName is null)
            {
                return string.Empty;
            }

            return Introduce() + $" Welcome {name} join class {ClassName}.";
        }
    }
}

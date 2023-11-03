using System.Diagnostics.CodeAnalysis;

namespace OOStepByStep
{
    public class SchoolPersonnel : ISchoolPersonnel
    {
        private string className;

        public string ClassName => className;
        public bool HasClass => className is not null;

        public void UpdateClass(string className)
        {
            this.className = className;
        }

        public string Introduce(string jobTitle)
        {
            string msg = HasClass ? $" I am a {jobTitle} of class {ClassName}." : $" I am a {jobTitle}.";

            return msg;
        }

        public string WelcomeNewClassMember(string name)
        {
            if (ClassName is null)
            {
                return string.Empty;
            }

            return $" Welcome {name} join class {ClassName}.";
        }
    }
}
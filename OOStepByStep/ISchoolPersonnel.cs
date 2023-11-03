namespace OOStepByStep
{
    public interface ISchoolPersonnel
    {
        public string ClassName { get; }
        public bool HasClass { get; }

        public void UpdateClass(string className);

        public string WelcomeNewClassMember(string name);
        public string Introduce(string jobTitle);
    }
}
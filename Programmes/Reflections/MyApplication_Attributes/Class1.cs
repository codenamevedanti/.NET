namespace MyApplication_Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class BonaVentureSystems:Attribute
    {

        private   string _Developer_Name;
        private string _Company_Name;
        public string Developer_Name
        {
            get { return _Developer_Name; ; }
            set { _Developer_Name = value; }
        }

        public string Company_Name
        {
            get { return _Company_Name; ; }
            set { _Company_Name = value; }
        }

    }
}

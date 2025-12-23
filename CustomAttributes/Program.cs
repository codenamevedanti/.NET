namespace CustomAttributes
{

    [AttributeUsage(AttributeTargets.Class)]
    public class TableAttribute :Attribute
    {
        private string _TableName;
       
        public string TableName
        {
            get { return _TableName; }
            set { _TableName = value; }
        }


    }

    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnAttribute :Attribute
    {
        private string _ColumnName;
        private string _Columntype;

       
        public string ColumnName
        {
            get { return _ColumnName; }
            set { _ColumnName = value; }
        }

        public string Columntype
        {
            get { return _Columntype; }
            set { _Columntype = value; }
        }



    }
}

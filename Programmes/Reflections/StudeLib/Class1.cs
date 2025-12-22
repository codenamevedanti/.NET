//using System.ComponentModel.DataAnnotations.Schema;
using System;
//using MyApplication_Attributes;
using MyApplication_Attributes3;

namespace StudeLib
{
    [Table(TableName= "StudentData")]
    public class Student
    {
        private int _id;
        private string _name;
        private string _Address;

        [Column(ColumnName= "sid", ColumnType= "int")]
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        [Column(ColumnName="Sname",ColumnType= "varchar(50)")]
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        [Column(ColumnName = "SAddress",ColumnType = "varchar(50)")]
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

    }
}

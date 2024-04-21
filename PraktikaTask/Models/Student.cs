using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PraktikaTask.Models
{
    internal class Student
    {
        private static int _count=0;
		private string _name;
		private string _suranme;
		private byte _age;
		private int _id;
		private int _credits;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		public string Surname
		{
			get { return _suranme; }
			set { _suranme = value; }
		}

		public byte Age
		{
			get { return _age; }
			set { _age = value; }
		}

		public int Id
		{
			get { return _id; }
			private set { _id = value; }

		}

		public int Credits
		{
			get { return _credits; }
			set { _credits = value; }
		}
        public Group Group { get; set; }

        public Student(string name,string surname,byte age,int cretids,Group group)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Credits = cretids;
            Group = group;
            Id =++_count;
            
        }





    }
}

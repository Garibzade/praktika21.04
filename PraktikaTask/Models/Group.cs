using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktikaTask.Models
{
    internal class Group
    {
        private static int _count=0;
		private int _id;

		public int Id
		{
			get { return _id; }
		  private	set { _id = value; }
		}

		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}
        public Group(string name)
        {
            Id=++_count;
			Name = name;
        }


    }
}

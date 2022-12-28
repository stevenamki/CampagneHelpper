using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransfer
{
	public abstract class AbstarcObjectData
	{
        String name;
        Dictionary<String, String> atttributes;

       public AbstarcObjectData()
		{
            atttributes = new Dictionary<String, String>();
		}

        public abstract Object GetData();

        public string GetName(){
            return name;
        }
        public Dictionary<String, String> GetAtttribute()
        {
            return atttributes;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void AddAttribute(string nameAttribute, string value)
        {
            atttributes.Add(nameAttribute,value);
        }
	}
}

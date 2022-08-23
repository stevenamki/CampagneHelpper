using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransfer
{
	public abstract class IDataObject
	{
        String name;
        String Id;
        public abstract Object getData();

        public string getName(){
            return name;
        }
        public String getId()
        {
            return Id;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setId(string id)
        {
            Id = id;
        }
	}
}

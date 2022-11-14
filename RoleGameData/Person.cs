using RoleGameData.Stats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleGameData
{
    public class Person
    {
        Dictionary<string, object> data;

        public Person(IStats stats,string name)
        {
            data = new Dictionary<string, object>();
            data.Add("Stats", stats);
            data.Add("name", name);
        }
    }
}

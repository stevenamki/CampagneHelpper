using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleGameData.Stats
{
    public abstract class IStats
    {
        Dictionary<string, object> _stats = new Dictionary<string, object>();

        public object getStats(string statsName)
        {
           return _stats[statsName];
        }
    }
}

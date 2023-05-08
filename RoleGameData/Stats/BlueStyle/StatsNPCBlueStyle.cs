using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleGameData.Stats
{
    public class StatNPCBlueStyle : IStats
    {
        private int hitPoint;
        private int ressourcePoints;
        private Dictionary<string, int> attributs = new Dictionary<string, int>()
        {
            {"Strenght",1}, {"Dexterity",1}, {"Endurance",1},{"Intelligence",1},{"Acuity",1},{"Willpower",1},{"Presence",1},{"Persuasion",1},{"Control",1}
        };
        private Dictionary<string, string> skills = new Dictionary<string, string>();
        private Dictionary<string, string> traits = new Dictionary<string, string>();
        private List<Object> equipment = new List<Object>();
    }
}

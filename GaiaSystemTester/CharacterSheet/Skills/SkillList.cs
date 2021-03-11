using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaiaSystemTester.Skills
    {
    public class SkillList
        {
        public SkillList()
        {
            SkillSelectionList = new List<string>();
            SkillSelectionList.AddRange(listToAdd);
        }
        public List<string> SkillSelectionList;
        string[] listToAdd = {
        "Brawl"
        };
        }
    }

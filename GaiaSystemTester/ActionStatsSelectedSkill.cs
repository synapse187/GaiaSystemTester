using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaiaSystemTester
    {
    public class ActionStatsSelectedSkill
        {
        public ActionStatsSelectedSkill()
        {
            this.offence = new CharacterStatsOffence();
            this.defence = new CharacterStatsDefence();
        }
        public CharacterStatsOffence offence { get; set; }
        public CharacterStatsDefence defence { get; set; }
        public void updateStats(List<int> vs)
        {

        }
        }
    }

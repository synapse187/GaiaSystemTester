using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace GaiaSystemTester.Skills
    {
    public class Brawl : Skill
        {
        public Brawl()
            {
            Name = "Brawl";
            this.rankModList = new int[,]{
                //TargMod-ImpMult-EndMod-CapMod-TechMod
            //TargMod-ImpMult-EndMod-CapMod-TechMod
            {    0,      0,      0,     0,     0,  },//0
            {    1,      2,      1,     0,     1   },//1
            {    1,      2,      1,     0,     2   },//2
            {    1,      2,      1,     0,     2   },//3
            {    2,      2,      1,     1,     1   },//4
            {    2,      3,      2,     1,     1   },//5
            {    2,      3,      2,     1,     1   },//6
            {    3,      3,      2,     1,     1   },//7
            {    3,      4,      2,     2,     1   },//8
            {    3,      4,      3,     2,     1   },//9
            {    4,      4,      3,     2,     1   },//10
            {    4,      5,      3,     2,     1   },//11
            {    4,      5,      3,     3,     1   },//12
            {    5,      5,      4,     3,     1   },//13
            {    5,      6,      4,     3,     1   },//14
            {    5,      6,      4,     3,     1   },//15
            {    6,      6,      4,     4,     1   },//16
            {    6,      7,      5,     4,     1   },//17
            {    6,      7,      5,     4,     1   },//18
            {    7,      7,      5,     4,     1   },//19
            {    8,      8,      6,     5,     1   }//20
            };
            }
        }
    }

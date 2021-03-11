using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace GaiaSystemTester.Skills
    {
    public class Unskilled : Skill
        {
        public Unskilled()
            {
            Name = "Un-Skilled";
            this.rankModList = new int[,]{
                //TargMod-ImpMult-EndMod-CapMod-TechMod
            //TargMod-ImpMult-EndMod-CapMod-TechMod
            {    0,      0,      0,     0,     0   },//0
            {    0,      0,      0,     0,     0   },//1
            {    0,      0,      0,     0,     0   },//2
            {    0,      0,      0,     0,     0   },//3
            {    0,      0,      0,     0,     0   },//4
            {    0,      0,      0,     0,     0   },//5
            {    0,      0,      0,     0,     0   },//6
            {    0,      0,      0,     0,     0   },//7
            {    0,      0,      0,     0,     0   },//8
            {    0,      0,      0,     0,     0   },//9
            {    0,      0,      0,     0,     0   },//10
            {    0,      0,      0,     0,     0   },//11
            {    0,      0,      0,     0,     0   },//12
            {    0,      0,      0,     0,     0   },//13
            {    0,      0,      0,     0,     0   },//14
            {    0,      0,      0,     0,     0   },//15
            {    0,      0,      0,     0,     0   },//16
            {    0,      0,      0,     0,     0   },//17
            {    0,      0,      0,     0,     0   },//18
            {    0,      0,      0,     0,     0   },//19
            {    0,      0,      0,     0,     0   }//20
            };
            }
        }
    }

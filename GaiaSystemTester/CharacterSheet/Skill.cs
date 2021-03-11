using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace GaiaSystemTester
    {
    public abstract class Skill : INotifyPropertyChanged
        {
        public Skill()
            {
            Name = "Default Skill";
            this.Rank = 0;
            this.rankModList = new int[,]{
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
        public string Name;
        protected int[,] rankModList;
        public int[] CombatStatBonusArray = {
        // Melee:
        0,//Strike 0
        0,//Feint 1
        0,//Hold 2
        0,//Block 3
        0,//Parry 4
        0,//Break 5
        // Ranged: 
        0,//Strike 6
        0,//Feint 7
        0,//Hold 8
        0,//Block 9
        0,//Parry 10
        0,//Break 11
        // Meta: 
        0,//Strike 12
        0,//Feint 13
        0,//Hold 14
        0,//Block 15
        0,//Parry 16
        0,//Break 17
        };
        private void UpdateCombatStatBonuses()
            {
            CombatStatBonusArray[0] = rankModList[Rank, 0];
            CombatStatBonusArray[2] = rankModList[Rank, 0];
            CombatStatBonusArray[3] = rankModList[Rank, 0];
            CombatStatBonusArray[5] = rankModList[Rank, 0];
            }
        private List<int> _modList;
        private int _rankCur;

        public int[] ModList
            {
            get {
                return CombatStatBonusArray; }
            }


        public int Rank
            {
            get { return _rankCur; }
            set
                {
                int valReturn;
                if(_rankCur != value)
                    {
                    if(value <= 0)
                        {
                        valReturn = 0;
                        }
                    else if(value > 20)
                        {
                        valReturn = 20;
                        }
                    else
                        {
                        valReturn = value;
                        }
                    _rankCur = valReturn;
                    UpdateCombatStatBonuses();
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Rank"));
                    }
                }
            }

        public event PropertyChangedEventHandler PropertyChanged;

        }
    }

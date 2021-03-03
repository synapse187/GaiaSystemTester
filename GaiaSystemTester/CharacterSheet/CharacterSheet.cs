using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GaiaSystemTester
    {
    public class CharacterSheet : INotifyPropertyChanged
        {
        public CharacterSheet(string name = "Default")
            {
            this.CharBio = new CharacterBio(name);
            this.CharStats = new CharacterStats();
            this.CharStatsQuick = new CharacterStatsQuick();
            this.CombatStats = new CharacterCombatStats();
            _statsToUse = false;
            }
        private int _dieToUse = 20;
        private bool _statsToUse;
        public bool StatsToUse
            {
            get { return _statsToUse; }
            set
                {
                _statsToUse = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("StatsToUse"));
                }
            }
        private List<int> _rolledList = new List<int>();
        Random random = new Random();
        private List<int> RollPool
            {
            get
                {
                _rolledList.Clear();
                for(int i = 0; i < CombatStats.CurrentPool; i++)
                    {
                    _rolledList.Add(random.Next(1, _dieToUse));
                    }
                _rolledList.OrderBy(x => x);
                return (List<int>)_rolledList;
                }
            }
        private int GetSuccesses()
            {
            int curSuc = 0;
            foreach(int item in CombatStats.CurrentRolledPool)
                {
                if(item >= CombatStats.CurrentTarget)
                    {
                    curSuc++;
                    }
                }
            return curSuc;
            }



        public void Roll()
            {
            CombatStats.CurrentRolledPool = RollPool;
            CombatStats.CurrentSuccesses = GetSuccesses();
            }


        public void SetQuickStats()
            {
            CombatStats.CurrentHealth = CharStatsQuick.Health;
            CombatStats.CurrentEndurance = CharStatsQuick.Endurance;
            CombatStats.CurrentPool = CharStatsQuick.Pool;
            CombatStats.CurrentTarget = CharStatsQuick.Target;
            CombatStats.CurrentAccuracy = CharStatsQuick.Accuracy;
            CombatStats.CurrentDamage = CharStatsQuick.Damage;
            }

        public void SetCombatStats()
            {
            if(_statsToUse)
                {
                SetQuickStats();
                }
            }

        public CharacterBio CharBio { get; set; }
        public CharacterStats CharStats { get; set; }
        public CharacterStatsQuick CharStatsQuick { get; set; }
        public CharacterCombatStats CombatStats { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        }
    }

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
            this.StepStats = new CharacterStepStats();
            this.StatsBackup = new CharacterStatsBackup();
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
            CombatStats.TotalSuccesses += CombatStats.CurrentSuccesses;
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
            if(!_statsToUse)
                {
                SetQuickStats();
                }
            else
                {
                //SetStandardStats();
                }
            }

        public void BackupStats()
        {
            this.StatsBackup.Backup.Clear();
            this.StatsBackup.Backup.AddRange(
            new List<int>{
            this.CharStatsQuick.Health,
            this.CharStatsQuick.Endurance,
            this.CharStatsQuick.Pool,
            this.CharStatsQuick.Target,
            this.CharStatsQuick.Accuracy,
            this.CharStatsQuick.Damage,

            this.CharStats.Strength,
            this.CharStats.Toughness,
            this.CharStats.Reflexes,
            this.CharStats.Coordination,
            this.CharStats.Intelligence,
            this.CharStats.Ego,
            this.CharStats.Knowledge,
            this.CharStats.SelfDiscipline,
            this.CharStats.Force,
            this.CharStats.Channeling,
            this.CharStats.Manipulation,
            this.CharStats.Reserve,
            }
            );
        }
        public void RestoreStats()
        {
            this.CharStatsQuick.Health = this.StatsBackup.Backup[0];
            this.CharStatsQuick.Endurance = this.StatsBackup.Backup[1];
            this.CharStatsQuick.Pool = this.StatsBackup.Backup[2];
            this.CharStatsQuick.Target = this.StatsBackup.Backup[3];
            this.CharStatsQuick.Accuracy = this.StatsBackup.Backup[4];
            this.CharStatsQuick.Damage = this.StatsBackup.Backup[5];

            this.CharStats.Strength = this.StatsBackup.Backup[6];
            this.CharStats.Toughness = this.StatsBackup.Backup[7];
            this.CharStats.Reflexes = this.StatsBackup.Backup[8];
            this.CharStats.Coordination = this.StatsBackup.Backup[9];
            this.CharStats.Intelligence = this.StatsBackup.Backup[10];
            this.CharStats.Ego = this.StatsBackup.Backup[11];
            this.CharStats.Knowledge = this.StatsBackup.Backup[12];
            this.CharStats.SelfDiscipline = this.StatsBackup.Backup[13];
            this.CharStats.Force = this.StatsBackup.Backup[14];
            this.CharStats.Channeling = this.StatsBackup.Backup[15];
            this.CharStats.Manipulation = this.StatsBackup.Backup[16];
            this.CharStats.Reserve = this.StatsBackup.Backup[17];

            }

        public CharacterBio CharBio { get; set; }
        public CharacterStats CharStats { get; set; }
        public CharacterStatsQuick CharStatsQuick { get; set; }
        public CharacterCombatStats CombatStats { get; set; }
        public CharacterStepStats StepStats { get; set; }
        public CharacterStatsBackup StatsBackup;
        public event PropertyChangedEventHandler PropertyChanged;
        }
    }

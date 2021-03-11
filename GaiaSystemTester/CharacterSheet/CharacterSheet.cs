using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace GaiaSystemTester
    {
    public class CharacterSheet : INotifyPropertyChanged
        {
        public CharacterSheet(string name = "Default")
            {
            this.SkillModList = new int[18];
            this.Bio = new CharacterBio(name);
            this.Health = new CharacterHealth();
            this.AttributesOther = new CharacterAttributesOther();
            this.Attributes = new CharacterAttributes();
            this.Skills = new CharacterSkills();
            this.OffenceStats = new CharacterStatsOffence();
            this.DefenceStats = new CharacterStatsDefence();
            this.StatsQuick = new CharacterStatsQuick();
            this.CombatStats = new CharacterCombatStats();
            this.StepStats = new CharacterStepStats();
            this.StatsBackup = new CharacterStatsBackup();
            this._nameOfCurrentSkill = "Un-Skilled";
            this.Skills.SkillList.Add(new Skills.Unskilled());
            this._skillModList = new int[18] {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
            RefreshStats();
            _statsToUse = true;
            }
        private string _nameOfCurrentSkill;
        private int _dieToUse = 20;
        private bool _statsToUse;
        public string NameOfCurrentSkill{
        get { return _nameOfCurrentSkill; }
        set {
                if(_nameOfCurrentSkill != value)
                    {
                    _nameOfCurrentSkill = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NameOfCurrentSkill"));
                    }
                }
        }
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
                return _rolledList;
                }
            }
        private int GetSuccesses()
            {
            int curSuc = 0;
            int addToalWins = 1;
            foreach(int die in CombatStats.CurrentRolledPool)
                {
                if(die >= CombatStats.CurrentTarget)
                    {

                    curSuc++;
                    }
                }
            return curSuc;
            }


        //GENERAL CHARACTER FUNCTIONS
        public void Roll()
            {
            CombatStats.CurrentRolledPool = RollPool;
            CombatStats.CurrentSuccesses = GetSuccesses();
            CombatStats.TotalSuccesses += CombatStats.CurrentSuccesses;
            if(CombatStats.CurrentSuccesses > 0)
                {
                CombatStats.TotalWins++;
                }
            }


        public void SetQuickStats()
            {
            CombatStats.CurrentHealth = StatsQuick.Health;
            CombatStats.CurrentEndurance = StatsQuick.Endurance;
            CombatStats.CurrentPool = StatsQuick.Pool;
            CombatStats.CurrentTarget = StatsQuick.Target;
            CombatStats.CurrentAccuracy = StatsQuick.Accuracy;
            CombatStats.CurrentDamage = StatsQuick.Damage;
            }
        private void SetStandardStats()
            {

            }

        public void SetCombatStats()
            {
            if(!_statsToUse)
                {
                SetQuickStats();
                }
            else
                {
                SetStandardStats();
                }
            }

        //STAT REFRESH METHODS
        //GETS BONUS FOR GIVEN BASE STAT
        private int SetBonus(int stat)
            {
            decimal usedStat = (((decimal)stat - 10.0M) + 1.0M) / 2.0M;
            int bonus = 0;
            bonus = (int)Math.Ceiling(usedStat);

            return bonus;
            }

        //GETS ROUNDED UP NUMBERS FOR SUPER AND POOL STATS
        private int ReturnSuperStat(int stat1, int stat2)
            {
            decimal superStat;
            superStat = ((decimal)stat1 + (decimal)stat2) / 4.0M;
            int superStatOut = (int)Math.Ceiling(superStat);
            return (int)superStatOut;
            }
        private int ReturnPoolStat(int stat1, int stat2)
            {
            decimal poolStat;
            poolStat = ((decimal)stat1 + (decimal)stat2) / 2.0M;
            int poolStatOut = (int)Math.Ceiling(poolStat);
            return (int)poolStatOut;
            }
        private List<int> ReturnActionBonus(int bonus1, int bonus2, int bonus3)
            {
            List<int> list = new List<int>();
            decimal b02 = bonus2;
            decimal b03 = bonus3;
            list.Add(bonus1);
            list.Add((int)Math.Ceiling(b02 / 2.0M));
            list.Add((int)Math.Ceiling(b03 / 3.0M));
            return list;
            }
        //SETS SUPER STATS AND POOL STATS
        private void SetSuperPoolStats()
            {
            this.Attributes.Body = ReturnSuperStat(Attributes.Strength, Attributes.Toughness);
            Attributes.Agility = ReturnSuperStat(Attributes.Reflexes, Attributes.Coordination);
            Attributes.PhysicalPool = ReturnPoolStat(Attributes.Body, Attributes.Agility);
            Attributes.Mind = ReturnSuperStat(Attributes.Intellect, Attributes.Wisdom);
            Attributes.Will = ReturnSuperStat(Attributes.Reaction, Attributes.Discipline);
            Attributes.MentalPool = ReturnPoolStat(Attributes.Mind, Attributes.Will);
            Attributes.Power = ReturnSuperStat(Attributes.Force, Attributes.Channeling);
            Attributes.Control = ReturnSuperStat(Attributes.Manipulation, Attributes.Contain);
            Attributes.MetaPool = ReturnPoolStat(Attributes.Power, Attributes.Control);
            }
        private void SetHealth()
            {
            Health.Hits = (Attributes.Body + Attributes.Will);
            Health.Endurance = (Attributes.PhysicalPool + Attributes.MentalPool + Attributes.MetaPool);
            }
        private void SetOther()
        {

        }
        private void SetBonuses()
            {
            Attributes.BonusStrength = SetBonus(Attributes.Strength);
            Attributes.BonusToughness = SetBonus(Attributes.Toughness);
            Attributes.BonusReflexes = SetBonus(Attributes.Reflexes);
            Attributes.BonusCoordination = SetBonus(Attributes.Coordination);
            Attributes.BonusIntellect = SetBonus(Attributes.Intellect);
            Attributes.BonusWisdom = SetBonus(Attributes.Wisdom);
            Attributes.BonusReaction = SetBonus(Attributes.Reaction);
            Attributes.BonusDiscipline = SetBonus(Attributes.Discipline);
            Attributes.BonusForce = SetBonus(Attributes.Force);
            Attributes.BonusChanneling = SetBonus(Attributes.Channeling);
            Attributes.BonusManipulation = SetBonus(Attributes.Manipulation);
            Attributes.BonusReserve = SetBonus(Attributes.Contain);
            }
        //SETS OFFENCE AND DEFENCE
        private void SetOffence()
            {
            List<int> list = new List<int>();
            OffenceStats.ThrowGlobal = Attributes.BonusCoordination + Attributes.BonusStrength + Attributes.BonusIntellect;
            // Melee
            list = ReturnActionBonus(Attributes.BonusStrength, Attributes.BonusReflexes, Attributes.BonusToughness);
            OffenceStats.StrikeMelee = list[0] + list[1] + list[2] + _skillModList[0];

            list = ReturnActionBonus(Attributes.BonusWisdom, Attributes.BonusCoordination, Attributes.BonusStrength);
            OffenceStats.FeintMelee = list[0] + list[1] + list[2] + _skillModList[1];

            list = ReturnActionBonus(Attributes.BonusToughness, Attributes.BonusStrength, Attributes.BonusIntellect);
            OffenceStats.HoldMelee = list[0] + list[1] + list[2] + _skillModList[2];

            //Ranged
            list = ReturnActionBonus(Attributes.BonusReflexes, Attributes.BonusReaction, Attributes.BonusCoordination);
            OffenceStats.StrikeRanged = list[0] + list[1] + list[2] + _skillModList[6];

            list = ReturnActionBonus(Attributes.BonusDiscipline, Attributes.BonusCoordination, Attributes.BonusReflexes);
            OffenceStats.FeintRanged = list[0] + list[1] + list[2] + _skillModList[7];

            list = ReturnActionBonus(Attributes.BonusCoordination, Attributes.BonusReflexes, Attributes.BonusReaction);
            OffenceStats.HoldRanged = list[0] + list[1] + list[2] + _skillModList[8];

            //Meta
            list = ReturnActionBonus(Attributes.BonusForce, Attributes.BonusIntellect, Attributes.BonusChanneling);
            OffenceStats.StrikeMeta = list[0] + list[1] + list[2] + _skillModList[12];

            list = ReturnActionBonus(Attributes.BonusWisdom, Attributes.BonusChanneling, Attributes.BonusForce);
            OffenceStats.FeintMeta = list[0] + list[1] + list[2] + _skillModList[13];

            list = ReturnActionBonus(Attributes.BonusManipulation, Attributes.BonusForce, Attributes.BonusDiscipline);
            OffenceStats.HoldMeta = list[0] + list[1] + list[2] + _skillModList[14];
            }
        private void SetDefence()
            {
            List<int> list = new List<int>();
            DefenceStats.DodgeGlobal = Attributes.BonusReflexes + Attributes.BonusReaction + Attributes.BonusCoordination;

            //Melee
            list = ReturnActionBonus(Attributes.BonusToughness, Attributes.BonusCoordination, Attributes.BonusStrength);
            DefenceStats.BlockMelee = list[0] + list[1] + list[2] + _skillModList[3];

            list = ReturnActionBonus(Attributes.BonusIntellect, Attributes.BonusReflexes, Attributes.BonusToughness);
            DefenceStats.ParryMelee = list[0] + list[1] + list[2] + _skillModList[4];

            list = ReturnActionBonus(Attributes.BonusStrength, Attributes.BonusToughness, Attributes.BonusWisdom);
            DefenceStats.BreakMelee = list[0] + list[1] + list[2] + _skillModList[5];

            //Ranged
            list = ReturnActionBonus(Attributes.BonusCoordination, Attributes.BonusDiscipline, Attributes.BonusReflexes);
            DefenceStats.BlockRanged = list[0] + list[1] + list[2] + _skillModList[9];

            list = ReturnActionBonus(Attributes.BonusReaction, Attributes.BonusReflexes, Attributes.BonusCoordination);
            DefenceStats.ParryRanged = list[0] + list[1] + list[2] + _skillModList[10];

            list = ReturnActionBonus(Attributes.BonusReflexes, Attributes.BonusCoordination, Attributes.BonusDiscipline);
            DefenceStats.BreakRanged = list[0] + list[1] + list[2] + _skillModList[11];

            //Meta
            list = ReturnActionBonus(Attributes.BonusChanneling, Attributes.BonusDiscipline, Attributes.BonusForce);
            DefenceStats.BlockMeta = list[0] + list[1] + list[2] + _skillModList[15];

            list = ReturnActionBonus(Attributes.BonusReaction, Attributes.BonusChanneling, Attributes.BonusManipulation);
            DefenceStats.ParryMeta = list[0] + list[1] + list[2] + _skillModList[16];

            list = ReturnActionBonus(Attributes.BonusForce, Attributes.BonusReaction, Attributes.BonusChanneling);
            DefenceStats.BreakMeta = list[0] + list[1] + list[2] + _skillModList[17];
            }

        //REFRESHES ALL AUTO GENERATED STATS
        public void RefreshStats()
            {
            SetSuperPoolStats();
            SetBonuses();
            SetOffence();
            SetDefence();
            SetHealth();
            }

        public void BackupStats()
            {
            this.StatsBackup.Backup.Clear();
            this.StatsBackup.Backup.AddRange(
            new List<int>{
            this.StatsQuick.Health,
            this.StatsQuick.Endurance,
            this.StatsQuick.Pool,
            this.StatsQuick.Target,
            this.StatsQuick.Accuracy,
            this.StatsQuick.Damage,

            this.Attributes.Strength,
            this.Attributes.Toughness,
            this.Attributes.Reflexes,
            this.Attributes.Coordination,
            this.Attributes.Intellect,
            this.Attributes.Wisdom,
            this.Attributes.Reaction,
            this.Attributes.Discipline,
            this.Attributes.Force,
            this.Attributes.Channeling,
            this.Attributes.Manipulation,
            this.Attributes.Contain,
            }
            );
            }
        public void RestoreStats()
            {
            this.StatsQuick.Health = this.StatsBackup.Backup[0];
            this.StatsQuick.Endurance = this.StatsBackup.Backup[1];
            this.StatsQuick.Pool = this.StatsBackup.Backup[2];
            this.StatsQuick.Target = this.StatsBackup.Backup[3];
            this.StatsQuick.Accuracy = this.StatsBackup.Backup[4];
            this.StatsQuick.Damage = this.StatsBackup.Backup[5];

            this.Attributes.Strength = this.StatsBackup.Backup[6];
            this.Attributes.Toughness = this.StatsBackup.Backup[7];
            this.Attributes.Reflexes = this.StatsBackup.Backup[8];
            this.Attributes.Coordination = this.StatsBackup.Backup[9];
            this.Attributes.Intellect = this.StatsBackup.Backup[10];
            this.Attributes.Reaction = this.StatsBackup.Backup[11];
            this.Attributes.Wisdom = this.StatsBackup.Backup[12];
            this.Attributes.Discipline = this.StatsBackup.Backup[13];
            this.Attributes.Force = this.StatsBackup.Backup[14];
            this.Attributes.Channeling = this.StatsBackup.Backup[15];
            this.Attributes.Manipulation = this.StatsBackup.Backup[16];
            this.Attributes.Contain = this.StatsBackup.Backup[17];

            }
        public void DefaultStats()
            {
            Attributes.Strength = 10;
            Attributes.Toughness = 10;
            Attributes.Reflexes = 10;
            Attributes.Coordination = 10;
            Attributes.Intellect = 10;
            Attributes.Wisdom = 10;
            Attributes.Reaction = 10;
            Attributes.Discipline = 10;
            Attributes.Force = 10;
            Attributes.Channeling = 10;
            Attributes.Manipulation = 10;
            Attributes.Contain = 10;
            }

        private int[] _skillModList;
        public int[] SkillModList {
            get { return _skillModList; }
            set {
                if(_skillModList != value)
                    {
                    _skillModList = value;
                    }
                }
            }
        private CharacterMath cMath;
        public CharacterBio Bio { get; set; }
        public CharacterHealth Health { get; set; }
        public CharacterAttributesOther AttributesOther { get; set; }
        public CharacterAttributes Attributes { get; set; }
        public CharacterSkills Skills { get; set; }
        public CharacterStatsOffence OffenceStats { get; set; }
        public CharacterStatsDefence DefenceStats { get; set; }
        public CharacterStatsQuick StatsQuick { get; set; }
        public CharacterCombatStats CombatStats { get; set; }
        public CharacterStepStats StepStats { get; set; }
        public CharacterStatsBackup StatsBackup;
        public event PropertyChangedEventHandler PropertyChanged;
        }
    }

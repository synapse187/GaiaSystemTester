﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GaiaSystemTester
    {
    public class CharacterStats : INotifyPropertyChanged
        {
        public CharacterStats()
            {
            _hits = 10;
            _endurance = 10;
            _initative = 10;
            _speed = 10;
            _physicalPool = 5;
            _body = 5;
            _strength = 10;
            _toughness = 10;
            _agility = 5;
            _reflexes = 10;
            _coordination = 10;
            _mentalPool = 5;
            _mind = 5;
            _intellect = 10;
            _wisdom = 10;
            _will = 5;
            _reaction = 10;
            _discipline = 10;
            _metaPool = 5;
            _power = 5;
            _force = 10;
            _channeling = 10;
            _control = 5;
            _manipulation = 10;
            _contain = 10;
            this.skillMods = new List<int> {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
            this.Offence = new CharacterStatsOffence();
            this.Defence = new CharacterStatsDefence();
            RefreshStats();
            }

        private int _hits;
        private int _endurance;
        private int _initative;
        private int _speed;
        
        private int _physicalPool;
        private int _body;
        private int _strength;
        private int _toughness;
        private int _agility;
        private int _reflexes;
        private int _coordination;
        private int _mentalPool;
        private int _mind;
        private int _intellect;
        private int _wisdom;
        private int _will;
        private int _reaction;
        private int _discipline;
        private int _metaPool;
        private int _power;
        private int _force;
        private int _channeling;
        private int _control;
        private int _manipulation;
        private int _contain;
        
        private int _bonusStrength;
        private int _bonusToughness;
        private int _bonusReflexes;
        private int _bonusCoordination;
        private int _bonusIntellect;
        private int _bonusWisdom;
        private int _bonusReaction;
        private int _bonusDiscipline;
        private int _bonusForce;
        private int _bonusChanneling;
        private int _bonusManipulation;
        private int _bonusReserve;

        //Secondary Stats
        public int Hits
            {
            get { return _hits; }
            set
                {
                if(_hits != value)
                    {
                    _hits = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Hits"));
                    }
                }
            }

        public int Endurance
            {
            get { return _endurance; }
            set
                {
                if(_endurance != value)
                    {
                    _endurance = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Endurance"));
                    }
                }
            }

        public int Initative
            {
            get { return _initative; }
            set
                {
                if(_initative != value)
                    {
                    _initative = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Initative"));
                    }
                }
            }

        public int Speed
            {
            get { return _speed; }
            set
                {
                if(_speed != value)
                    {
                    _speed = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Speed"));
                    }
                }
            }

        //Physical Stats
        public int PhysicalPool
            {
            get { return _physicalPool; }
            set
                {
                if(_physicalPool != value)
                    {
                    _physicalPool = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PhysicalPool"));
                    }
                }
            }

        public int Body
            {
            get { return _body; }
            set
                {
                if(_body != value)
                    {
                    _body = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Body"));
                    }
                }
            }

        public int Strength
            {
            get { return _strength; }
            set
                {
                if(_strength != value)
                    {
                    _strength = value;
                    RefreshStats();
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Strength"));
                    }
                }
            }
        public int BonusStrength
            {
            get { return _bonusStrength; }
            set
                {
                if(_bonusStrength != value)
                    {
                    _bonusStrength = value;
                    RefreshStats();
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BonusStrength"));
                    }
                }
            }

        public int Toughness
            {
            get { return _toughness; }
            set
                {
                if(_toughness != value)
                    {
                    _toughness = value;
                    RefreshStats();
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Toughness"));
                    }
                }
            }
        public int BonusToughness
            {
            get { return _bonusToughness; }
            set
                {
                if(_bonusToughness != value)
                    {
                    _bonusToughness = value;
                    RefreshStats();
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BonusToughness"));
                    }
                }
            }

        public int Agility
            {
            get { return _agility; }
            set
                {
                if(_agility != value)
                    {
                    _agility = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Agility"));
                    }
                }
            }

        public int Reflexes
            {
            get { return _reflexes; }
            set
                {
                if(_reflexes != value)
                    {
                    _reflexes = value;
                    RefreshStats();
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Reflexes"));
                    }
                }
            }
        public int BonusReflexes
            {
            get { return _bonusReflexes; }
            set
                {
                if(_bonusReflexes != value)
                    {
                    _bonusReflexes = value;
                    RefreshStats();
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BonusReflexes"));
                    }
                }
            }

        public int Coordination
            {
            get { return _coordination; }
            set
                {
                if(_coordination != value)
                    {
                    _coordination = value;
                    RefreshStats();
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Coordination"));
                    }
                }
            }
        public int BonusCoordination
            {
            get { return _bonusCoordination; }
            set
                {
                if(_bonusCoordination != value)
                    {
                    _bonusCoordination = value;
                    RefreshStats();
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BonusCoordination"));
                    }
                }
            }
        //Physical Stats END
        //Mental Stats
        public int MentalPool
            {
            get { return _mentalPool; }
            set
                {
                if(_mentalPool != value)
                    {
                    _mentalPool = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("MentalPool"));
                    }
                }
            }

        public int Mind
            {
            get { return _mind; }
            set
                {
                if(_mind != value)
                    {
                    _mind = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mind"));
                    }
                }
            }

        public int Intellect
            {
            get { return _intellect; }
            set
                {
                if(_intellect != value)
                    {
                    _intellect = value;
                    RefreshStats();
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Intellect"));
                    }
                }
            }
        public int BonusIntellect
            {
            get { return _bonusIntellect; }
            set
                {
                if(_bonusIntellect != value)
                    {
                    _bonusIntellect = value;
                    RefreshStats();
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BonusIntellect"));
                    }
                }
            }

        public int Wisdom
            {
            get { return _wisdom; }
            set
                {
                if(_wisdom != value)
                    {
                    _wisdom = value;
                    RefreshStats();
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Wisdom"));
                    }
                }
            }
        public int BonusWisdom
            {
            get { return _bonusWisdom; }
            set
                {
                if(_bonusWisdom != value)
                    {
                    _bonusWisdom = value;
                    RefreshStats();
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BonusWisdom"));
                    }
                }
            }

        public int Will
            {
            get { return _will; }
            set
                {
                if(_will != value)
                    {
                    _will = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Will"));
                    }
                }
            }
        public int Reaction
            {
            get { return _reaction; }
            set
                {
                if(_reaction != value)
                    {
                    _reaction = value;
                    RefreshStats();
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Reaction"));
                    }
                }
            }
        public int BonusReaction
            {
            get { return _bonusReaction; }
            set
                {
                if(_bonusReaction != value)
                    {
                    _bonusReaction = value;
                    RefreshStats();
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BonusReaction"));
                    }
                }
            }

        public int Discipline
            {
            get { return _discipline; }
            set
                {
                if(_discipline != value)
                    {
                    _discipline = value;
                    RefreshStats();
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Discipline"));
                    }
                }
            }
        public int BonusDiscipline
            {
            get { return _bonusDiscipline; }
            set
                {
                if(_bonusDiscipline != value)
                    {
                    _bonusDiscipline = value;
                    RefreshStats();
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BonusDiscipline"));
                    }
                }
            }
        //Mental Stats END
        //Meta Stats
        public int MetaPool
            {
            get { return _metaPool; }
            set
                {
                if(_metaPool != value)
                    {
                    _metaPool = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("MetaPool"));
                    }
                }
            }
        public int Power
            {
            get { return _power; }
            set
                {
                if(_power != value)
                    {
                    _power = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Power"));
                    }
                }
            }

        public int Force
            {
            get { return _force; }
            set
                {
                if(_force != value)
                    {
                    _force = value;
                    RefreshStats();
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Force"));
                    }
                }
            }
        public int BonusForce
            {
            get { return _bonusForce; }
            set
                {
                if(_bonusForce != value)
                    {
                    _bonusForce = value;
                    RefreshStats();
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BonusForce"));
                    }
                }
            }

        public int Channeling
            {
            get { return _channeling; }
            set
                {
                if(_channeling != value)
                    {
                    _channeling = value;
                    RefreshStats();
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Channeling"));
                    }
                }
            }
        public int BonusChanneling
            {
            get { return _bonusChanneling; }
            set
                {
                if(_bonusChanneling != value)
                    {
                    _bonusChanneling = value;
                    RefreshStats();
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BonusChanneling"));
                    }
                }
            }

        public int Control
            {
            get { return _control; }
            set
                {
                if(_control != value)
                    {
                    _control = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Control"));
                    }
                }
            }
        public int Manipulation
            {
            get { return _manipulation; }
            set
                {
                if(_manipulation != value)
                    {
                    _manipulation = value;
                    RefreshStats();
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Manipulation"));
                    }
                }
            }
        public int BonusManipulation
            {
            get { return _bonusManipulation; }
            set
                {
                if(_bonusManipulation != value)
                    {
                    _bonusManipulation = value;
                    RefreshStats();
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BonusManipulation"));
                    }
                }
            }

        public int Contain
            {
            get { return _contain; }
            set
                {
                if(_contain != value)
                    {
                    _contain = value;
                    RefreshStats();
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Contain"));
                    }
                }
            }
        public int BonusReserve
            {
            get { return _bonusReserve; }
            set
                {
                if(_bonusReserve != value)
                    {
                    _bonusReserve = value;
                    RefreshStats();
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BonusReserve"));
                    }
                }
            }
        //Meta Stats END

        private int SetBonus(int stat)
            {
            decimal usedStat = (((decimal)stat - 10.0M) + 1.0M) / 2.0M;
            int bonus = 0;
            bonus = (int)Math.Ceiling(usedStat);

            return bonus;
            }
        private int SetSuperStat(int stat1, int stat2)
            {
            decimal superStat;
            superStat = ((decimal)stat1 + (decimal)stat2) / 4.0M;
            int superStatOut = (int)Math.Ceiling(superStat);
            return (int)superStatOut;
            }
        private int SetPoolStat(int stat1, int stat2)
            {
            decimal poolStat;
            poolStat = ((decimal)stat1 + (decimal)stat2) / 2.0M;
            int poolStatOut = (int)Math.Ceiling(poolStat);
            return (int)poolStatOut;
            }
        private List<int> SetActionBonus(int bonus1, int bonus2, int bonus3)
            {
            List<int> list = new List<int>();
            decimal b02 = bonus2;
            decimal b03 = bonus3;
            list.Add(bonus1);
            list.Add((int)Math.Ceiling(b02 / 2.0M));
            list.Add((int)Math.Ceiling(b03 / 3.0M));
            return list;
            }

        private void SetSuperPoolStats()
            {
            Body = SetSuperStat(Strength, Toughness);
            Agility = SetSuperStat(Reflexes, Coordination);
            PhysicalPool = SetPoolStat(Body, Agility);
            Mind = SetSuperStat(Intellect, Wisdom);
            Will = SetSuperStat(Reaction, Discipline);
            MentalPool = SetPoolStat(Mind, Will);
            Power = SetSuperStat(Force, Channeling);
            Control = SetSuperStat(Manipulation, Contain);
            MetaPool = SetPoolStat(Power, Control);
            }
        private void SetHealthMisc()
            {
            Hits = (_toughness + _discipline) / 2;
            Endurance = (PhysicalPool + MentalPool) * 2;
            Initative = (Reflexes + Reaction);
            Speed = (Strength + Reflexes) / 2;
            }
        private void SetBonuses()
            {
            BonusStrength = SetBonus(Strength);
            BonusToughness = SetBonus(Toughness);
            BonusReflexes = SetBonus(Reflexes);
            BonusCoordination = SetBonus(Coordination);
            BonusIntellect = SetBonus(Intellect);
            BonusWisdom = SetBonus(Wisdom);
            BonusReaction = SetBonus(Reaction);
            BonusDiscipline = SetBonus(Discipline);
            BonusForce = SetBonus(Force);
            BonusChanneling = SetBonus(Channeling);
            BonusManipulation = SetBonus(Manipulation);
            BonusReserve = SetBonus(Contain);
            }
        private void SetOffence()
            {
            List<int> list = new List<int>();
            Offence.ThrowGlobal = BonusCoordination + BonusStrength + BonusIntellect;
            // Melee
            list = SetActionBonus(BonusStrength, BonusReflexes, BonusToughness);
            Offence.StrikeMelee = list[0] + list[1] + list[2] + skillMods[0];

            list = SetActionBonus(BonusWisdom, BonusCoordination, BonusStrength);
            Offence.FeintMelee = list[0] + list[1] + list[2] + skillMods[1];

            list = SetActionBonus(BonusToughness, BonusStrength, BonusIntellect);
            Offence.HoldMelee = list[0] + list[1] + list[2] + skillMods[2];

            //Ranged
            list = SetActionBonus(BonusReflexes, BonusReaction, BonusCoordination);
            Offence.StrikeRanged = list[0] + list[1] + list[2] + skillMods[6];

            list = SetActionBonus(BonusDiscipline, BonusCoordination, BonusReflexes);
            Offence.FeintRanged = list[0] + list[1] + list[2] + skillMods[7];

            list = SetActionBonus(BonusCoordination, BonusReflexes, BonusReaction);
            Offence.HoldRanged = list[0] + list[1] + list[2] + skillMods[8];

            //Meta
            list = SetActionBonus(BonusForce, BonusIntellect, BonusChanneling);
            Offence.StrikeMeta = list[0] + list[1] + list[2] + skillMods[12];

            list = SetActionBonus(BonusWisdom, BonusChanneling, BonusForce);
            Offence.FeintMeta = list[0] + list[1] + list[2] + skillMods[13];

            list = SetActionBonus(BonusManipulation, BonusForce, BonusDiscipline);
            Offence.HoldMeta = list[0] + list[1] + list[2] + skillMods[14];
            }
        private void SetDefence()
            {
            List<int> list = new List<int>();
            Defence.DodgeGlobal = BonusReflexes + BonusReaction + BonusCoordination;

            //Melee
            list = SetActionBonus(BonusToughness, BonusCoordination, BonusStrength);
            Defence.BlockMelee = list[0] + list[1] + list[2] + skillMods[3];

            list = SetActionBonus(BonusIntellect, BonusReflexes, BonusToughness);
            Defence.ParryMelee = list[0] + list[1] + list[2] + skillMods[4];

            list = SetActionBonus(BonusStrength, BonusToughness, BonusWisdom);
            Defence.BreakMelee = list[0] + list[1] + list[2] + skillMods[5];

            //Ranged
            list = SetActionBonus(BonusCoordination, BonusDiscipline, BonusReflexes);
            Defence.BlockRanged = list[0] + list[1] + list[2] + skillMods[9];

            list = SetActionBonus(BonusReaction, BonusReflexes, BonusCoordination);
            Defence.ParryRanged = list[0] + list[1] + list[2] + skillMods[10];

            list = SetActionBonus(BonusReflexes, BonusCoordination, BonusDiscipline);
            Defence.BreakRanged = list[0] + list[1] + list[2] + skillMods[11];

            //Meta
            list = SetActionBonus(BonusChanneling, BonusDiscipline, BonusForce);
            Defence.BlockMeta = list[0] + list[1] + list[2] + skillMods[15];

            list = SetActionBonus(BonusReaction, BonusChanneling, BonusManipulation);
            Defence.ParryMeta = list[0] + list[1] + list[2] + skillMods[16];

            list = SetActionBonus(BonusForce, BonusReaction, BonusChanneling);
            Defence.BreakMeta = list[0] + list[1] + list[2] + skillMods[17];
            }

        public void RefreshStats()
            {
            SetSuperPoolStats();
            SetHealthMisc();
            SetBonuses();
            SetOffence();
            SetDefence();
            }

        public void DefaultStats()
        {
            Strength = 10;
            Toughness = 10;
            Reflexes = 10;
            Coordination = 10;
            Intellect = 10;
            Wisdom = 10;
            Reaction = 10;
            Discipline = 10;
            Force = 10;
            Channeling = 10;
            Manipulation = 10;
            Contain = 10;
        }
        public List<int> skillMods;
        public CharacterStatsOffence Offence { get; set; }
        public CharacterStatsDefence Defence { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        }
    }

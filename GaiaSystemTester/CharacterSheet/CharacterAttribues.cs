using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GaiaSystemTester
    {
    public class CharacterAttributes : INotifyPropertyChanged
        {
        public CharacterAttributes()
            {
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
            }

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
                    
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BonusReserve"));
                    }
                }
            }
        //Meta Stats END
        public event PropertyChangedEventHandler PropertyChanged;
        }
    }

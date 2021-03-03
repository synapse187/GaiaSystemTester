using System;
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
            _physicalPool = 10;
            _body = 20;
            _strength = 10;
            _toughness = 10;
            _agility = 20;
            _reflexes = 10;
            _coordination = 10;
            _mentalPool = 10;
            _mind = 20;
            _intelligence = 10;
            _ego = 10;
            _willpower = 20;
            _knowledge = 10;
            _selfDiscipline = 10;
            _metaPool = 10;
            _power = 20;
            _force = 10;
            _channeling = 10;
            _control = 20;
            _manipulation = 10;
            _reserve = 10;
            }
        private int superStatDivisor = 4;
        private int poolStatDivisor = 4;

        private int _physicalPool;
        private int _body;
        private int _strength;
        private int _toughness;
        private int _agility;
        private int _reflexes;
        private int _coordination;
        private int _mentalPool;
        private int _mind;
        private int _intelligence;
        private int _ego;
        private int _willpower;
        private int _knowledge;
        private int _selfDiscipline;
        private int _metaPool;
        private int _power;
        private int _force;
        private int _channeling;
        private int _control;
        private int _manipulation;
        private int _reserve;

        //Physical Stats
        public int PhysicalPool
            {
            get { return _physicalPool; }
            set
                {
                if(_physicalPool != value)
                    {
                    _physicalPool = (_body + _agility) / poolStatDivisor;
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

        public int Intelligence
            {
            get { return _intelligence; }
            set
                {
                if(_intelligence != value)
                    {
                    _intelligence = value;
                    RefreshStats();
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Intelligence"));
                    }
                }
            }
        public int Ego
            {
            get { return _ego; }
            set
                {
                if(_ego != value)
                    {
                    _ego = value;
                    RefreshStats();
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ego"));
                    }
                }
            }
        public int Willpower
            {
            get { return _willpower; }
            set
                {
                if(_willpower != value)
                    {
                    _willpower = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Willpower"));
                    }
                }
            }
        public int Knowledge
            {
            get { return _knowledge; }
            set
                {
                if(_knowledge != value)
                    {
                    _knowledge = value;
                    RefreshStats();
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Knowledge"));
                    }
                }
            }
        public int SelfDiscipline
            {
            get { return _selfDiscipline; }
            set
                {
                if(_selfDiscipline != value)
                    {
                    _selfDiscipline = value;
                    RefreshStats();
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SelfDiscipline"));
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
        public int Reserve
            {
            get { return _reserve; }
            set
                {
                if(_reserve != value)
                    {
                    _reserve = value;
                    RefreshStats();
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Reserve"));
                    }
                }
            }
        //Meta Stats END
        public void RefreshStats()
            {
            Body = (_strength + _toughness);
            Agility = _reflexes + _coordination;
            PhysicalPool = (_body + _agility) / superStatDivisor;
            Mind = (_intelligence + _ego);
            Willpower = (_knowledge + _selfDiscipline);
            MentalPool = (_mind + _willpower) / superStatDivisor;
            Power = (_force + _channeling);
            Control = (_manipulation + _reserve);
            MetaPool = (_power + _control) / superStatDivisor;
            }
        public event PropertyChangedEventHandler PropertyChanged;
        }
    }

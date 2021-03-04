using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GaiaSystemTester
    {
    public class CharacterCombatStats : INotifyPropertyChanged
        {
        public CharacterCombatStats()
            {
            _currentHealth = 10;
            _currentEndurance = 10;
            _currentPool = 10;
            _currentTarget = 10;
            _currentAccuracy = 10;
            _currentDamage = 10;
            _currentSuccesses = 0;
            _totalSuccesses = 0;
            }
        private int _currentHealth;
        private int _currentEndurance;
        private int _currentPool;
        private int _currentTarget;
        private int _currentAccuracy;
        private int _currentDamage;

        private List<int> _currentRolledPool;
        private int _currentSuccesses;
        private int _totalSuccesses;

        public int CurrentHealth
            {
            get { return _currentHealth; }
            set
                {
                if(value != _currentHealth)
                    {
                    _currentHealth = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentHealth"));
                    }
                }
            }
        public int CurrentEndurance
            {
            get { return _currentEndurance; }
            set
                {
                if(value != _currentEndurance)
                    {
                    _currentEndurance = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentEndurance"));
                    }
                }
            }
        public int CurrentPool
            {
            get { return _currentPool; }
            set
                {
                if(value != _currentPool)
                    {
                    _currentPool = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPool"));
                    }
                }
            }
        public int CurrentTarget
            {
            get { return _currentTarget; }
            set
                {
                if(value != _currentTarget)
                    {
                    _currentTarget = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentTarget"));
                    }
                }
            }
        public int CurrentAccuracy
            {
            get { return _currentAccuracy; }
            set
                {
                if(value != _currentAccuracy)
                    {
                    _currentAccuracy = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentAccuracy"));
                    }
                }
            }
        public int CurrentDamage
            {
            get { return _currentDamage; }
            set
                {
                if(value != _currentDamage)
                    {
                    _currentDamage = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentDamage"));
                    }
                }
            }

        public List<int> CurrentRolledPool
            {
            get { return _currentRolledPool; }
            set
                {
                if(value != _currentRolledPool)
                    {
                    _currentRolledPool = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentRolledPool"));
                    }
                }
            }

        public int CurrentSuccesses
            {
            get { return _currentSuccesses; }
            set
                {
                if(value != _currentSuccesses)
                    {
                    _currentSuccesses = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentSuccesses"));
                    }
                }
            }

        public int TotalSuccesses
            {
            get { return _totalSuccesses; }
            set
                {
                if(value != _totalSuccesses)
                    {
                    _totalSuccesses = value;
                    }
                }
            }

        public event PropertyChangedEventHandler PropertyChanged;
        }
    }

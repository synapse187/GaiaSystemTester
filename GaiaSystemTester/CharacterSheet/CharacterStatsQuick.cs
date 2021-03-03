using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GaiaSystemTester
    {
    public class CharacterStatsQuick : INotifyPropertyChanged
        {
        public CharacterStatsQuick()
            {
            _health = 10;
            _endurance = 10;
            _pool = 10;
            _target = 10;
            _accuracy = 10;
            _damage = 10;
            _offence = 0;
            _defence = 0;
            }
        private int _health;
        private int _endurance;
        private int _pool;
        private int _target;
        private int _accuracy;
        private int _damage;
        private int _offence;
        private int _defence;

        public int Health
            {
            get { return _health; }
            set
                {
                if(_health != value)
                    {
                    _health = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Health"));
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
        public int Pool
            {
            get { return _pool; }
            set
                {
                if(_pool != value)
                    {
                    _pool = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pool"));
                    }
                }
            }
        public int Target
            {
            get { return _target; }
            set
                {
                if(_target != value)
                    {
                    _target = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Target"));
                    }
                }
            }
        public int Accuracy
            {
            get { return _accuracy; }
            set
                {
                if(_accuracy != value)
                    {
                    _accuracy = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Accuracy"));
                    }
                }
            }
        public int Damage
            {
            get { return _damage; }
            set
                {
                if(_damage != value)
                    {
                    _damage = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Damage"));
                    }
                }
            }
        public int OffenceType
            {
            get { return _offence; }
            set
                {

                if(_offence != value)
                    {
                    _offence = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OffenceType"));
                    }
                }
            }
        public int DefenceType
            {
            get { return _defence; }
            set
                {

                if(_defence != value)
                    {
                    _defence = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DefenceType"));
                    }
                }
            }
        public event PropertyChangedEventHandler PropertyChanged;
        }
    }

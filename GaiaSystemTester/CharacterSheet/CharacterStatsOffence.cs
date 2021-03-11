using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GaiaSystemTester
    {
    public class CharacterStatsOffence : INotifyPropertyChanged
        {
        public CharacterStatsOffence()
            {
            }
        private int _throwGlobal;

        private int _strikeMelee;
        private int _feintMelee;
        private int _holdMelee;

        private int _strikeRanged;
        private int _feintRanged;
        private int _holdRanged;

        private int _strikeMeta;
        private int _feintMeta;
        private int _holdMeta;

        public int ThrowGlobal
            {
            get { return _throwGlobal; }
            set
                {
                if(_throwGlobal != value)
                    {
                    _throwGlobal = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ThrowGlobal"));
                    }
                }
            }

        public int StrikeMelee
            {
            get { return _strikeMelee; }
            set
                {
                if(_strikeMelee != value)
                    {
                    _strikeMelee = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("StrikeMelee"));
                    }
                }
            }
        public int FeintMelee
            {
            get { return _feintMelee; }
            set
                {
                if(_feintMelee != value)
                    {
                    _feintMelee = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FeintMelee"));
                    }
                }
            }
        public int HoldMelee
            {
            get { return _holdMelee; }
            set
                {
                if(_holdMelee != value)
                    {
                    _holdMelee = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HoldMelee"));
                    }
                }
            }

        public int StrikeRanged
            {
            get { return _strikeRanged; }
            set
                {
                if(_strikeRanged != value)
                    {
                    _strikeRanged = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("StrikeRanged"));
                    }
                }
            }
        public int FeintRanged
            {
            get { return _feintRanged; }
            set
                {
                if(_feintRanged != value)
                    {
                    _feintRanged = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FeintRanged"));
                    }
                }
            }
        public int HoldRanged
            {
            get { return _holdRanged; }
            set
                {
                if(_holdRanged != value)
                    {
                    _holdRanged = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HoldRanged"));
                    }
                }
            }

        public int StrikeMeta
            {
            get { return _strikeMeta; }
            set
                {
                if(_strikeMeta != value)
                    {
                    _strikeMeta = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("StrikeMeta"));
                    }
                }
            }
        public int FeintMeta
            {
            get { return _feintMeta; }
            set
                {
                if(_feintMeta != value)
                    {
                    _feintMeta = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FeintMeta"));
                    }
                }
            }
        public int HoldMeta
            {
            get { return _holdMeta; }
            set
                {
                if(_holdMeta != value)
                    {
                    _holdMeta = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HoldMeta"));
                    }
                }
            }


        public event PropertyChangedEventHandler PropertyChanged;
        }
    }

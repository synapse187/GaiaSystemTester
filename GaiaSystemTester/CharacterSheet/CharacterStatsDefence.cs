using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GaiaSystemTester
    {
    public class CharacterStatsDefence : INotifyPropertyChanged
        {
        public CharacterStatsDefence()
            {
            }
        private int _dodgeGlobal;

        private int _blockMelee;
        private int _parryMelee;
        private int _breakMelee;

        private int _blockRanged;
        private int _parryRanged;
        private int _breakRanged;

        private int _blockMeta;
        private int _parryMeta;
        private int _breakMeta;

        public int DodgeGlobal
            {
            get { return _dodgeGlobal; }
            set
                {
                if(_dodgeGlobal != value)
                    {
                    _dodgeGlobal = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DodgeGlobal"));
                    }
                }
            }

        public int BlockMelee
            {
            get { return _blockMelee; }
            set
                {
                if(_blockMelee != value)
                    {
                    _blockMelee = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BlockMelee"));
                    }
                }
            }
        public int ParryMelee
            {
            get { return _parryMelee; }
            set
                {
                if(_parryMelee != value)
                    {
                    _parryMelee = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ParryMelee"));
                    }
                }
            }
        public int BreakMelee
            {
            get { return _breakMelee; }
            set
                {
                if(_breakMelee != value)
                    {
                    _breakMelee = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BreakMelee"));
                    }
                }
            }

        public int BlockRanged
            {
            get { return _blockRanged; }
            set
                {
                if(_blockRanged != value)
                    {
                    _blockRanged = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BlockRanged"));
                    }
                }
            }
        public int ParryRanged
            {
            get { return _parryRanged; }
            set
                {
                if(_parryRanged != value)
                    {
                    _parryRanged = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ParryRanged"));
                    }
                }
            }
        public int BreakRanged
            {
            get { return _breakRanged; }
            set
                {
                if(_breakRanged != value)
                    {
                    _breakRanged = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BreakRanged"));
                    }
                }
            }

        public int BlockMeta
            {
            get { return _blockMeta; }
            set
                {
                if(_blockMeta != value)
                    {
                    _blockMeta = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BlockMeta"));
                    }
                }
            }
        public int ParryMeta
            {
            get { return _parryMeta; }
            set
                {
                if(_parryMeta != value)
                    {
                    _parryMeta = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ParryMeta"));
                    }
                }
            }
        public int BreakMeta
            {
            get { return _breakMeta; }
            set
                {
                if(_breakMeta != value)
                    {
                    _breakMeta = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BreakMeta"));
                    }
                }
            }


        public event PropertyChangedEventHandler PropertyChanged;
        }
    }

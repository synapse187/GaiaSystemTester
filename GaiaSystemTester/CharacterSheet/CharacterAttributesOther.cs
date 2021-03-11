using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using System.Reflection;

namespace GaiaSystemTester
    {
    public class CharacterAttributesOther : INotifyPropertyChanged
        {
        public CharacterAttributesOther()
            {
            _initiative = 0;
            _move = 0;
            }
        private int _initiative;
        public int Initiative
            {
            get { return _initiative; }
            set
                {
                if(_initiative != value)
                    {
                    _initiative = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Initiative"));
                    }
                }
            }
        private int _move;
        public int Move
            {
            get { return _move; }
            set
                {
                if(_move != value)
                    {
                    _move = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Move"));
                    }
                }
            }

        public event PropertyChangedEventHandler PropertyChanged;
        }
    }

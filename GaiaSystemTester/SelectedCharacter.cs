using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GaiaSystemTester
    {
    public class SelectedCharacter : INotifyPropertyChanged
        {
        public SelectedCharacter() { _currentCharacter = new CharacterSheet(); }
        private CharacterSheet _currentCharacter;
        public CharacterSheet CurentCharacter 
        {
            get { return _currentCharacter; }
            set
                {
                if(_currentCharacter != value)
                    {
                    _currentCharacter = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurentCharacter"));
                    }
                }
            }
        public event PropertyChangedEventHandler PropertyChanged;
        }
    }

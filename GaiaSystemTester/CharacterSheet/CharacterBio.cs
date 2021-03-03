using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GaiaSystemTester
    {
    public class CharacterBio : INotifyPropertyChanged
        {
        public CharacterBio(string charName = "Default")
        {
            Name = charName;
        }
        private string _name;
        public string Name
            {
            get { return _name; }
            set
                {
                if(_name != value)
                    {
                    _name = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
                    }
                }
            }
        public event PropertyChangedEventHandler PropertyChanged;
        }
    }

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaiaSystemTester
    {
    public class CharacterHealth : INotifyPropertyChanged
        {
        public CharacterHealth()
        {
            _hits = 0;
            _endurance = 0;
            _psyche = 0;
        }
        private int _hits;
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

        private int _endurance;
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

        private int _psyche;
        public int Psyche
            {
            get { return _psyche; }
            set
                {
                if(_psyche != value)
                    {
                    _psyche = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Psyche"));
                    }
                }
            }

        public event PropertyChangedEventHandler PropertyChanged;
        }
    }

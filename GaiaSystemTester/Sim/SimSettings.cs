using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GaiaSystemTester
    {
    public class SimSettings : INotifyPropertyChanged
        {
        public SimSettings()
            {
            _steps = 1;
            _itters = 1;
            _simType = 0;
            }

        private int _steps;
        private int _itters;
        private int _simType;

        public int NumberOfSteps
            {
            get { return _steps; }
            set
                {
                if(_steps != value)
                    {
                    _steps = value;
                    }
                }
            }
        public int NumberOfItterations
            {
            get { return _itters; }
            set
                {
                if(_itters != value)
                    {
                    _itters = value;
                    }
                }
            }

        public int SimulationType
            {
            get { return _simType; }
            set
                {
                if(_simType != value)
                    {
                    _simType = value;
                    }
                }
            }

        public event PropertyChangedEventHandler PropertyChanged;
        }
    }

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
            _outputRoll = true;
            _outputIter = true;
            _outputStep = true;
            _steps = 1;
            _iters = 1;
            _simType = 0;
            }

        private int _steps;
        private int _iters;
        private int _simType;
        private bool _outputRoll;
        private bool _outputIter;
        private bool _outputStep;

        public int NumberOfSteps
            {
            get { return _steps; }
            set
                {
                if(_steps != value)
                    {
                    _steps = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NumberOfSteps"));
                    }
                }
            }
        public int NumberOfIterations
            {
            get { return _iters; }
            set
                {
                if(_iters != value)
                    {
                    _iters = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NumberOfItterations"));
                    }
                }
            }

        public bool OutputRoll
            {
            get { return _outputRoll; }
            set
                {
                if(_outputRoll != value)
                    {
                    _outputRoll = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OutputRoll"));
                    }
                }
            }

        public bool OutputIter
            {
            get { return _outputIter; }
            set
                {
                if(_outputIter != value)
                    {
                    _outputIter = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OutputIter"));
                    }
                }
            }

        public bool OutputStep
            {
            get { return _outputStep; }
            set
                {
                if(_outputStep != value)
                    {
                    _outputStep = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OutputStep"));
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
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SimulationType"));
                    }
                }
            }

        public event PropertyChangedEventHandler PropertyChanged;
        }
    }

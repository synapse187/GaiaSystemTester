using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GaiaSystemTester
    {
    public class CharacterStepStats : INotifyPropertyChanged
        {
        public CharacterStepStats()
            {
            _stepHealth = 0;
            _stepEndurance = 0;
            _stepPool = 0;
            _stepTarget = 0;
            _stepAccuracy = 0;
            _stepDamage = 0;

            _stepStrength = 0;
            _stepToughness = 0;
            _stepReflexes = 0;
            _stepCoordination = 0;
            _stepIntelligence = 0;
            _stepEgo = 0;
            _stepKnowledge = 0;
            _stepSelfDiscipline = 0;
            _stepForce = 0;
            _stepChanneling = 0;
            _stepManipulation = 0;
            _stepReserve = 0;
            }

        private int _stepHealth;
        private int _stepEndurance;
        private int _stepPool;
        private int _stepTarget;
        private int _stepAccuracy;
        private int _stepDamage;

        private int _stepStrength;
        private int _stepToughness;
        private int _stepReflexes;
        private int _stepCoordination;
        private int _stepIntelligence;
        private int _stepEgo;
        private int _stepKnowledge;
        private int _stepSelfDiscipline;
        private int _stepForce;
        private int _stepChanneling;
        private int _stepManipulation;
        private int _stepReserve;
        //QUICK STATS
        public int StepHealth {
            get { return _stepHealth; }
            set { if(_stepHealth != value) { _stepHealth = value; this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("StepHealth")); }
                }
        }
        public int StepEndurance
            {
            get { return _stepEndurance; }
            set
                {
                if(_stepEndurance != value) { _stepEndurance = value; this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("StepEndurance")); }
                }
            }
        public int StepPool
            {
            get { return _stepPool; }
            set
                {
                if(_stepPool != value) { _stepPool = value; this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("StepPool")); }
                }
            }
        public int StepTarget
            {
            get { return _stepTarget; }
            set
                {
                if(_stepTarget != value) { _stepTarget = value; this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("StepTarget")); }
                }
            }
        public int StepAccuracy
            {
            get { return _stepAccuracy; }
            set
                {
                if(_stepAccuracy != value) { _stepAccuracy = value; this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("StepAccuracy")); }
                }
            }
        public int StepDamage
            {
            get { return _stepDamage; }
            set
                {
                if(_stepDamage != value) { _stepDamage = value; this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("StepDamage")); }
                }
            }
        //FullStats
        public int StepStrength
            {
            get { return _stepStrength; }
            set
                {
                if(_stepStrength != value) { _stepStrength = value; this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("StepStrength")); }
                }
            }
        public int StepToughness
            {
            get { return _stepToughness; }
            set
                {
                if(_stepToughness != value) { _stepToughness = value; this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("StepToughness")); }
                }
            }
        public int StepReflexes
            {
            get { return _stepReflexes; }
            set
                {
                if(_stepReflexes != value) { _stepReflexes = value; this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("StepReflexes")); }
                }
            }
        public int StepCoordination
            {
            get { return _stepCoordination; }
            set
                {
                if(_stepCoordination != value) { _stepCoordination = value; this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("StepCoordination")); }
                }
            }
        public int StepIntelligence
            {
            get { return _stepIntelligence; }
            set
                {
                if(_stepIntelligence != value) { _stepIntelligence = value; this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("StepIntelligence")); }
                }
            }
        public int StepEgo
            {
            get { return _stepEgo; }
            set
                {
                if(_stepEgo != value) { _stepEgo = value; this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("StepEgo")); }
                }
            }
        public int StepKnowledge
            {
            get { return _stepKnowledge; }
            set
                {
                if(_stepKnowledge != value) { _stepKnowledge = value; this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("StepKnowledge")); }
                }
            }
        public int StepSelfDiscipline
            {
            get { return _stepSelfDiscipline; }
            set
                {
                if(_stepSelfDiscipline != value) { _stepSelfDiscipline = value; this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("StepSelfDiscipline")); }
                }
            }
        public int StepForce
            {
            get { return _stepForce; }
            set
                {
                if(_stepForce != value) { _stepForce = value; this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("StepForce")); }
                }
            }
        public int StepManipulation
            {
            get { return _stepManipulation; }
            set
                {
                if(_stepManipulation != value) { _stepManipulation = value; this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("StepManipulation")); }
                }
            }
        public int StepChanneling
            {
            get { return _stepChanneling; }
            set
                {
                if(_stepChanneling != value) { _stepChanneling = value; this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("StepChanneling")); }
                }
            }
        public int StepReserve
            {
            get { return _stepReserve; }
            set
                {
                if(_stepReserve != value) { _stepReserve = value; this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("StepReserve")); }
                }
            }


        public event PropertyChangedEventHandler PropertyChanged;
        }
    }

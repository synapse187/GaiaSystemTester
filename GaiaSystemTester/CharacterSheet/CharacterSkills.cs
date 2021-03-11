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
    public class CharacterSkills : INotifyPropertyChanged
        {
        public CharacterSkills()
        {
            _skillList = new ObservableCollection<Skill>();
        }
        private ObservableCollection<Skill> _skillList;
        public ObservableCollection<Skill> SkillList
            {
            get { return _skillList; }
            set
                {
                if(_skillList != value)
                    {
                    _skillList = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SkillList"));
                    }
                }
            }
        public void AddSkill(string skillToAdd)
        {
            Assembly assembly = typeof(Skill).Assembly;
            skill = (Skill)assembly.CreateInstance("GaiaSystemTester.Skills." + skillToAdd);
            this.SkillList.Add(skill);
        }
        public Skill skill{ get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        }
    }

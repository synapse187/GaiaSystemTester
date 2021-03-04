using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace GaiaSystemTester
    {
    static class Globals
        {
        private static ObservableCollection<CharacterSheet> _globalSheets = new ObservableCollection<CharacterSheet>();
        public static ObservableCollection<CharacterSheet> GlobalSheets
            {
            get { return _globalSheets; }
            set { _globalSheets = value; }
            }
        public static void AddCharacterSheet(string name = "Character")
        {
            CharacterSheet sheet = new CharacterSheet(name);
            _globalSheets.Add(sheet);
        }
        }
    }

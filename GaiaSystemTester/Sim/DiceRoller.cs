using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using static GaiaSystemTester.Sim.GLOBAL;


namespace GaiaSystemTester.Sim
    {
    public static class GLOBAL
    {
        public static List<CharacterSheet> _CharacterSheets = new List<CharacterSheet>();
        public static SimSettings _SimSettings = new SimSettings();
        public static TextBox _TextBox;
        public static StringBuilder _String = new StringBuilder();
    }

    public class DiceRoller
        {
        public DiceRoller(IList<CharacterSheet> characterSheetsToUse, SimSettings simSettings, ref TextBox textBoxOutputWindow)
            {
            _CharacterSheets.Clear();
            foreach(CharacterSheet sheet in characterSheetsToUse)
                {
                _CharacterSheets.Add(sheet);
                }
            _CharacterSheets.Reverse();
            _SimSettings = simSettings;
            _TextBox = textBoxOutputWindow;
            _String.Clear();
            }

        public void RunSimulation()
            {
            SetupSim();
            RunSim simToRun = new RunSim();
            simToRun.RunSimulation();
            _TextBox.Text += _String.ToString();
            }

        private void SetupSim()
            {
            SetupStats();
            }

        private void SetupStats()
            {
            foreach(CharacterSheet item in _CharacterSheets)
                {
                item.SetCombatStats();
                }
            }
        }
    }

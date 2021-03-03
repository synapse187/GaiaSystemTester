using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace GaiaSystemTester
    {
    public class DiceRoller
        {
        public DiceRoller(List<CharacterSheet> characterSheetsToUse, SimSettings simSettings, ref TextBox textBoxOutputWindow)
            {
            charSheets = characterSheetsToUse;
            settings = simSettings;
            textBox = textBoxOutputWindow;
            }
        private List<CharacterSheet> charSheets;
        private SimSettings settings;
        private TextBox textBox;

        public void RunSimulation()
            {
            SetupSim();
            RunSim simToRun = new RunSim();
            simToRun.RunSimulation(charSheets, settings, ref textBox);
            }

        private void SetupSim()
            {
            SetupStats();
            }
        private void SetupStats()
            {
            foreach(CharacterSheet item in charSheets)
                {
                item.SetCombatStats();
                }
            }
        }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace GaiaSystemTester
    {
    class SimQuick
        {
        public SimQuick()
            {
            }
        public void RunSimulation(List<CharacterSheet> charSheets, SimSettings simSettings, ref TextBox textBox)
            {
            charSheets[0].Roll();
            IOrderedEnumerable<int> sortedRolls = charSheets[0].CombatStats.CurrentRolledPool.OrderBy(x => x);
            textBox.Text += "Rolls: ";
            foreach(int roll in sortedRolls)
                {
                textBox.Text += $"-{roll}";
                }
            textBox.Text += "-\r";
            textBox.Text += $"Number Of Successes: {charSheets[0].CombatStats.CurrentSuccesses}\r";
            }
        }
    }

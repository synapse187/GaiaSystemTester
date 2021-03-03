using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaiaSystemTester
    {
    public class RunSim
        {
        public void RunSimulation(List<CharacterSheet> characterSheetsToUse, SimSettings simSettings, ref TextBox textBoxOutputWindow)
            {
            switch(simSettings.SimulationType)
                {
                case 0:
                    SimQuick sim = new SimQuick();
                    sim.RunSimulation(characterSheetsToUse, simSettings, ref textBoxOutputWindow);
                    break;
                case 1:
                    SimQuickCombat sim2 = new SimQuickCombat();
                    sim2.RunSimulation(characterSheetsToUse, simSettings, ref textBoxOutputWindow);
                    break;
                default:
                    break;
                }
            }
        }
    }

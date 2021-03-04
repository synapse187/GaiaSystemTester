using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GaiaSystemTester.Sim.GLOBAL;


namespace GaiaSystemTester.Sim
    {
    public class RunSim
        {
        private List<int> statsBackup = new List<int>();
        public void RunSimulation()
        {
            BackupStats();
            RunSteps runSteps = new RunSteps();
            runSteps.RunSimSteps();
            ResetStats();
        }
        private void BackupStats()
        {
            foreach(CharacterSheet sheet in _CharacterSheets)
                {
                sheet.BackupStats();
                }
        }
        private void ResetStats()
        {
            foreach(CharacterSheet sheet in _CharacterSheets)
                {
                sheet.RestoreStats();
                }
            }
    }
    }

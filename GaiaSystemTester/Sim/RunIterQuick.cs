using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using static GaiaSystemTester.Sim.GLOBAL;

namespace GaiaSystemTester.Sim
    {
    public class RunIterQuick
        {
        public RunIterQuick()
            {
            }
        public void RunSimulation()
            {
            for(int i = 0; i < _SimSettings.NumberOfIterations; i++)
                {
                foreach(CharacterSheet sheet in _CharacterSheets)
                    {
                    sheet.Roll();
                    }
                if(_SimSettings.OutputRoll)
                    {
                    OutputRolls();
                    }
                }
            }

        public void OutputRolls()
            {
            foreach(CharacterSheet sheet in _CharacterSheets)
                {
                _String.Append(
                $"Character: {sheet.Bio.Name}\n" +
                $"Rolls: -"
                );
                foreach(int roll in sheet.CombatStats.CurrentRolledPool)
                    {
                    _String.Append(
                    $"{roll}-"
                    );
                    }
                _String.Append(
                $"\n"+
                $"Successes: {sheet.CombatStats.CurrentSuccesses}\n"
                );

                }
            }

        }
    }

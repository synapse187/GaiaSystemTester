using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GaiaSystemTester.Sim.GLOBAL;


namespace GaiaSystemTester.Sim
    {
    public class RunSteps
        {
        public void RunSimSteps()
        {
            RunIterations runIterations = new RunIterations();
            for(int i = 0; i < _SimSettings.NumberOfSteps; i++)
                {
                runIterations.RunSimIterations();
                if(_SimSettings.OutputStep)
                    {
                    OutputSteps();
                    }
                StepStats();
                ResetCombatStats();
                }
        }
        private void StepStats()
            {
            foreach(CharacterSheet sheet in _CharacterSheets)
                {
                if(!sheet.StatsToUse)
                    {
                        sheet.CharStatsQuick.Health += sheet.StepStats.StepHealth;
                        sheet.CharStatsQuick.Endurance += sheet.StepStats.StepEndurance;
                        sheet.CharStatsQuick.Pool += sheet.StepStats.StepPool;
                        sheet.CharStatsQuick.Target += sheet.StepStats.StepTarget;
                        sheet.CharStatsQuick.Accuracy += sheet.StepStats.StepAccuracy;
                        sheet.CharStatsQuick.Damage += sheet.StepStats.StepDamage;
                    }
                else
                    {
                    sheet.CharStats.Strength += sheet.StepStats.StepStrength;
                    }
                sheet.SetCombatStats();
                }
            }
        private void ResetCombatStats()
        {
            foreach(CharacterSheet sheet in _CharacterSheets)
                {
                sheet.CombatStats.TotalSuccesses = 0;
                }
        }
        private void OutputSteps()
        {
            foreach(CharacterSheet sheet in _CharacterSheets)
                {
                decimal avgSuc;
                if(sheet.CombatStats.TotalSuccesses>0)
                    {
                    avgSuc = ((decimal)sheet.CombatStats.TotalSuccesses / (decimal)_SimSettings.NumberOfIterations);
                    }
                else
                    {
                    avgSuc = 0M;
                    }
                _String.Append(
                $"Name: {sheet.CharBio.Name}\n"+
                $"Target: {sheet.CombatStats.CurrentTarget}-Pool: {sheet.CombatStats.CurrentPool}\n"+
                $"Averave Successes: {avgSuc} Total Successes: {sheet.CombatStats.TotalSuccesses}\n"
                );
                }
            }
        }
    }

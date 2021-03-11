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
                        sheet.StatsQuick.Health += sheet.StepStats.StepHealth;
                        sheet.StatsQuick.Endurance += sheet.StepStats.StepEndurance;
                        sheet.StatsQuick.Pool += sheet.StepStats.StepPool;
                        sheet.StatsQuick.Target += sheet.StepStats.StepTarget;
                        sheet.StatsQuick.Accuracy += sheet.StepStats.StepAccuracy;
                        sheet.StatsQuick.Damage += sheet.StepStats.StepDamage;
                    }
                else
                    {
                    sheet.Attributes.Strength += sheet.StepStats.StepStrength;
                    }
                sheet.SetCombatStats();
                }
            }
        private void ResetCombatStats()
        {
            foreach(CharacterSheet sheet in _CharacterSheets)
                {
                sheet.CombatStats.TotalSuccesses = 0;
                sheet.CombatStats.TotalWins = 0;
                }
            }
        private void OutputSteps()
        {
            foreach(CharacterSheet sheet in _CharacterSheets)
                {
                decimal avgSuc;
                decimal winPerc = ((decimal)sheet.CombatStats.TotalWins / (decimal)_SimSettings.NumberOfIterations) * 100M;
                if(sheet.CombatStats.TotalSuccesses>0)
                    {
                    avgSuc = ((decimal)sheet.CombatStats.TotalSuccesses / (decimal)_SimSettings.NumberOfIterations);
                    }
                else
                    {
                    avgSuc = 0M;
                    }
                _String.Append(
                $"|Name: {sheet.Bio.Name}\n"+
                $"|Target: {sheet.CombatStats.CurrentTarget}|--|Pool: {sheet.CombatStats.CurrentPool}\n" +
                $"|Averave Successes: {avgSuc} |--|Win %: {winPerc}\n\n"
                );
                }
            }
        }
    }

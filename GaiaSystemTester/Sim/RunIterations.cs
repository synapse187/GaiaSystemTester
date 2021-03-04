using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GaiaSystemTester.Sim.GLOBAL;

namespace GaiaSystemTester.Sim
    {
    public class RunIterations
        {
        public void RunSimIterations()
            {
            switch(_SimSettings.SimulationType)
                {
                case 0:
                    RunIterQuick runIter = new RunIterQuick();
                    runIter.RunSimulation();
                    break;
                case 1:
                    break;
                case 2:
                    break;
                default:
                    break;
                }
            }
        }
    }

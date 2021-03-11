using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace GaiaSystemTester
    {
    public class CharacterMath
        {
        public int ReturnSuperStat(int stat1, int stat2)
            {
            decimal superStat;
            superStat = ((decimal)stat1 + (decimal)stat2) / 4.0M;
            int superStatOut = (int)Math.Ceiling(superStat);
            return (int)superStatOut;
            }
        }
    }

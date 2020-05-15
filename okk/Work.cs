using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okk
{
    class Work
    {
        //allows someone to work depending on the wage
        public void goWork(ref int rCash,int wage, ref int time) {
            rCash += wage * 3;
            time++;
        }
    }
}

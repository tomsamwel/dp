using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal interface IWashingMachine
    {
        public void Fill();
        public void Wash();
        public void Drain();
        public void PrintInstanceNumber();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreestylerChaselist
{
    class Chase
    {
        public string name = "";
        public string cue = "";
        public string optionsString = "";
        public int time = 0;

        public Chase(string n, string c, string o, int t)
        {
            name = n;
            cue = c;
            optionsString = o;
            time = t;
        }
    }
}

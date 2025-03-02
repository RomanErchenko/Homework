using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4
{
    public class Radio
    {
        public class NeastedRadio
        {
            public bool Condition { get; set; }
            public string MarkOfRadio { get; }
            public NeastedRadio(string MarkOfRadio)
            {
                this.MarkOfRadio = MarkOfRadio;
            }
        }
    }
}

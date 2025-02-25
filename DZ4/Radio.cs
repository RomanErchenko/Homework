using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4
{
    public class Radio
    {
        public bool Condition { get; set; }
        private string markOfRadio;
        public Radio(string markOfRadio)
        {
         this.markOfRadio=markOfRadio;
        }
        public string MarkOfRadio
        {
            get { return markOfRadio; }
        }
    }
}

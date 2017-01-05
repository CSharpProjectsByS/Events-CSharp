using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zdarzenia
{
    class ChangedArgs : EventArgs
    {
        public List<String> names { get; set;  }
        public List<String> newValues { get; set; }
        public List<String> oldValues { get; set; }

        public ChangedArgs(List<String> names, List<String> newValues, List<String> oldValues)
        {
            this.names = names;
            this.newValues = newValues;
            this.oldValues = oldValues;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zdarzenia
{
    class ChangedArgs : EventArgs
    {
        public String propertyName;
        public String oldValue;
        public String newValue;

        public ChangedArgs(String propertyName, String oldValue, String newValue)
        {
            this.propertyName = propertyName;
            this.oldValue = oldValue;
            this.newValue = newValue;
        }
    }
}

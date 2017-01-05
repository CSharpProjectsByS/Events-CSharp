using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Zdarzenia
{
    class HandlerChangeProperties
    {
        private ListBox logView;

        public HandlerChangeProperties(ListBox logView)
        {
            this.logView = logView;
        }

        public void changePropertyValuesAndLogIt(object oSender, ChangedArgs changedArgs)
        {
            String message = changedArgs.propertyName + ": newValue = " +
                changedArgs.newValue + ", oldValue = " + changedArgs.oldValue;

            logView.Items.Add(message);
        } 

        

    }
}

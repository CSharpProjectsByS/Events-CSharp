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
        private Gift gift;

        public HandlerChangeProperties(ListBox logView, Gift gift)
        {
            this.logView = logView;
            this.gift = gift;
        }

        public void changePropertiesValuesAndLogIt(object oSender, ChangedArgs changedArgs)
        {
            String message = "";

            for (int i = 0; i < changedArgs.names.Count; i++)
            {
                message = "";
                if (changedArgs.newValues[i] != changedArgs.oldValues[i])
                {
                    var property = gift.
                         GetType().
                         GetProperty(changedArgs.names[i]);

                    property.SetValue(gift, changedArgs.newValues[i]);

                    message += changedArgs.names[i] + ": newValue = " +
                        changedArgs.newValues[i] + ", oldValue = " +
                        changedArgs.oldValues[i];

                    logView.Items.Add(message);
                        
                }
            }
        }

        

    }
}

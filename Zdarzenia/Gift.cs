using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zdarzenia
{
    class Gift
    {
        private HandlerChangeProperties handlerChangeProperties;

        private string value1;
        private string value2;
        private string value3;

        public String Value1 {
            get { return value1; }
            
            set
            {
                if (value1 != value)
                {
                    changeProperty("Value1", value1, value);
                    value1 = value;
                }
            }
        }
        public String Value2
        {
            get { return value2; }

            set
            {
                if (value2 != value)
                {
                    changeProperty("Value2", value2, value);
                    value2 = value;
                }
            }
        }
        public String Value3
        {
            get { return value3; }

            set
            {
                if (value3 != value)
                {
                    changeProperty("Value3", value3, value);
                    value3 = value;
                }
            }
        }

        public delegate void ChangePropertyDelegate(object oSender, ChangedArgs oEventArgs);

        public event ChangePropertyDelegate ChangePropertyEvent;

        public Gift(ListBox logView)
        {
            value1 = "0";
            value2 = "0";
            value3 = "0";

            handlerChangeProperties = new HandlerChangeProperties(logView);
            ChangePropertyEvent = handlerChangeProperties.changePropertyValuesAndLogIt;
        }

        public void changeProperty(String propertyName, String oldValue, String newValue)
        {
            ChangedArgs changedArgs = new ChangedArgs(propertyName, oldValue, newValue);
            onChangePropertyEvent(changedArgs);
        }

        public void onChangePropertyEvent(ChangedArgs changedArgs)
        {
            ChangePropertyDelegate changePropertyEvent = ChangePropertyEvent;
            if (changePropertyEvent != null)
            {
                changePropertyEvent(this, changedArgs);
            }
        }
    }
}

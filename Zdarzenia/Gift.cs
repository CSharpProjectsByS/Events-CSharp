using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zdarzenia
{
    class Gift
    {
        public String Value1 { get; set; }
        public String Value2 { get; set; }
        public String Value3 { get; set; }

        public delegate void ChangePropertyDelegate(object oSender, ChangedArgs oEventArgs);

        public event ChangePropertyDelegate ChangePropertyEvent;

        public Gift()
        {
            Value1 = "0";
            Value2 = "0";
            Value3 = "0";
        }

        public void changeProperties(String newValue1, String newValue2, String newValue3)
        {
            List<String> names = prepareNameList();
            List<String> oldValues = prepareOldValuesList();
            List<String> newValues = prepareNewValuesList(newValue1, newValue2, newValue3);

            ChangedArgs changedArgs = new ChangedArgs(names, newValues, oldValues);

            onChangePropertyEvent(changedArgs);
        }

        public void onChangePropertyEvent(ChangedArgs changedArgs)
        {
            if (ChangePropertyEvent != null)
            {
                ChangePropertyEvent(this, changedArgs);
            }
        }

        private List<String> prepareNameList()
        {
            List<String> names = new List<String>();
            names.Add("Value1");
            names.Add("Value2");
            names.Add("Value3");

            return names;
        }

        private List<String> prepareOldValuesList()
        {
            List<String> oldValuesList = new List<String>();
            oldValuesList.Add(Value1);
            oldValuesList.Add(Value2);
            oldValuesList.Add(Value3);

            return oldValuesList;
        }

        private List<String> prepareNewValuesList(String newValue1, String newValue2, String newValue3)
        {
            List<String> newValuesList = new List<String>();

            newValuesList.Add(newValue1);
            newValuesList.Add(newValue2);
            newValuesList.Add(newValue3);

            return newValuesList;
        }

    }
}

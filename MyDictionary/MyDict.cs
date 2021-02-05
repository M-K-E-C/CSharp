using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDict<TKeys, TValues>
    {
        TKeys[] keys;
        TValues[] values;

        public MyDict()
        {
            keys = new TKeys[0];
            values = new TValues[0];

        }

        public void Add( TKeys key,TValues value)
        {
            TKeys[] tempKeys = keys;
            TValues[] tempValues = values;
            keys = new TKeys[keys.Length + 1];
            values = new TValues[values.Length + 1];
            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }


    }
}

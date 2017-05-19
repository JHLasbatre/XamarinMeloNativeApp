using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinMeloNativeApp
{
    class ClientRC
    {
        private int uid;
        private string name;

        public ClientRC(int uid, string name)
        {
            this.uid = uid;
            this.name = name;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

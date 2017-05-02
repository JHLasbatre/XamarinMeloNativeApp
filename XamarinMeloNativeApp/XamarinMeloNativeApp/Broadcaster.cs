using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinMeloNativeApp
{
    class Broadcaster
    {
        private ClientRC clientData;
        private string pseudo;
        private int userLikes;

        // Constructeurs

        public Broadcaster(ClientRC clientData, string pseudo, int userLikes)
        {
            this.ClientData = clientData;
            this.Pseudo = pseudo;
            this.UserLikes = userLikes;
        }

        // Méthodes


        public override string ToString()
        {
            return base.ToString();
        }

        public void RefreshLocation()
        {

        }

        public void RefreshBroadcastingSong()
        {

        }


        public string Pseudo
        {
            get
            {
                return pseudo;
            }

            set
            {
                pseudo = value;
            }
        }

        public int UserLikes
        {
            get
            {
                return userLikes;
            }

            set
            {
                userLikes = value;
            }
        }

        internal ClientRC ClientData
        {
            get
            {
                return clientData;
            }

            set
            {
                clientData = value;
            }
        }
    }
}

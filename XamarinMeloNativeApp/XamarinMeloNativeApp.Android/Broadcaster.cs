using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace XamarinMeloNativeApp.Droid
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
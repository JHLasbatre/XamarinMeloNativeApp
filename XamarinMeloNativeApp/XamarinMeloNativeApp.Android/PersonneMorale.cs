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
    class PersonneMorale : Broadcaster
    {
        // Attributs

        private string adresse;
        private string lienMaps;

        // Constructeurs
        public PersonneMorale(ClientRC clientData, string pseudo, int userLikes, string adresse, string lienMaps) : base(clientData, pseudo, userLikes)
        {
            this.adresse = adresse;
            this.lienMaps = lienMaps;
        }

        // Méthodes
        public override string ToString()
        {
            return base.ToString();
        }

        public void AddLike(Broadcaster b)
        {

        }

        public void Unlike(Broadcaster b)
        {

        }


    }
}
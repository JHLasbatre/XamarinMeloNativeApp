﻿using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinMeloNativeApp
{
    class PersonnePhysique : Broadcaster
    {
        public PersonnePhysique(ClientRC clientData, string pseudo, int userLikes) : base(clientData, pseudo, userLikes)
        {

        }

        // Constructeurs





        // Méthodes

        public void PlayBroadcastingSong()
        {

        }

        public void AddLike(Broadcaster b)
        {

        }

        public void Unlike(Broadcaster b)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }


    }
}
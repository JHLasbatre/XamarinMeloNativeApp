using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinMeloNativeApp
{
    class Lieu : ClientRCRetour
    {
        private string adresse;
        private string lienMaps;

        public Lieu(int uid, string name, int distance, List<Song> topListened, List<Song> topLiked, /*Image profilePic, */ Song broadcastingSong, int score, string adresse, string lienMaps) : base(uid, name, distance, topListened, topLiked, /*profilePic, */ broadcastingSong, score)
        {
            this.adresse = adresse;
            this.lienMaps = lienMaps;
        }
    }
}

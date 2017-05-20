using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinMeloNativeApp
{
    class Personne : ClientRCRetour
    {
        public Personne(int uid, string name, int distance, List<Song> topListened, List<Song> topLiked, /*ImageIO profilePic,*/ Song broadcastingSong, int score) : base(uid, name, distance, topListened, topLiked, /*profilePic,*/ broadcastingSong, score)
        {
        }

        public void PlayBroadcastingSong()
        {

        }
        
    }
}

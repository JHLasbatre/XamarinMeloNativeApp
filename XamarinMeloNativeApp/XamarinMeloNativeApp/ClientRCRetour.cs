using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinMeloNativeApp
{
    class ClientRCRetour : ClientRC
    {
        private int distance;
        private List<Song> topListened;
        private List<Song> topLiked;
        private ImageIO profilePic;
        private Song broadcastingSong;
        private int score;

        public ClientRCRetour(int uid, string name, int distance, List<Song> topListened, List<Song> topLiked, ImageIO profilePic, Song broadcastingSong, int score) : base(uid, name)
        {
            this.distance = distance;
            this.topListened = topListened;
            this.topLiked = topLiked;
            this.profilePic = profilePic;
            this.broadcastingSong = broadcastingSong;
            this.score = score;
        }
    }
}

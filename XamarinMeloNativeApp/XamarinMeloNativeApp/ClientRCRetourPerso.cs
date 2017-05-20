using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinMeloNativeApp
{
    class ClientRCRetourPerso : ClientRC
    {
        private List<Song> topListened;
        private List<Song> topLiked;
        //private Image profilePic;
        private int score;
        private int range;
        private string filterStatus;
        private Genre filterPreferences;

        public ClientRCRetourPerso(int uid, string name, List<Song> topListened, List<Song> topLiked,/* Image profilePic*/ int score, int range, string filterStatus, Genre filterPreferences) : base(uid, name)
        {
            this.topListened = topListened;
            this.topLiked = topLiked;
            this.score = score;
            this.range = range;
            //this.profilePic = profilePic;
            this.filterStatus = filterStatus;
            this.filterPreferences = filterPreferences;
        }
    }
}

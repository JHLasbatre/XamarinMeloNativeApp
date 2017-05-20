using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinMeloNativeApp
{
    class ClientRCEnvoi : ClientRC
    {
        private string position;
        private int score;
        private string serverRequest;
        private int range;
        private List<Song> updateQueue;
        //private Image profilePic;
        private bool estPersonne;
        private string filterStatus;
        private Genre filterPreferences;
        private string email;
        private string password;

        public ClientRCEnvoi(int uid, string name, string position, int score, string serverRequest, int range, List<Song> updateQueue, /*ImageIO profilePic,*/ bool estPersonne, string filterStatus, Genre filterPreferences, string email, string password) : base(uid, name)
        {
            this.position = position;
            this.score = score;
            this.serverRequest = serverRequest;
            this.range = range;
            this.updateQueue = updateQueue;
            //this.profilePic = profilePic;
            this.estPersonne = estPersonne;
            this.filterStatus = filterStatus;
            this.filterPreferences = filterPreferences;
            this.email = email;
            this.password = password;
        }
    }
}

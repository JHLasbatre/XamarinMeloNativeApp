using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinMeloNativeApp
{
    class ClientRC
    {
        private int uid;
        private List<Song> topLike;
        private List<Song> topListened;
        private string location;
        private Song broadcastingSong;


        //Constructeurs

        public ClientRC(int uid, List<Song> topLike, List<Song> topListened, string location, Song broadcastingSong)
        {
            this.Uid = uid;
            this.TopLike = topLike;
            this.TopListened = topListened;
            this.Location = location;
            this.BroadcastingSong = broadcastingSong;
        }

        // Méthodes


        public override string ToString()
        {
            return base.ToString();
        }


        public int Uid
        {
            get
            {
                return uid;
            }

            set
            {
                uid = value;
            }
        }

        internal List<Song> TopLike
        {
            get
            {
                return topLike;
            }

            set
            {
                topLike = value;
            }
        }

        internal List<Song> TopListened
        {
            get
            {
                return topListened;
            }

            set
            {
                topListened = value;
            }
        }

        public string Location
        {
            get
            {
                return location;
            }

            set
            {
                location = value;
            }
        }

        internal Song BroadcastingSong
        {
            get
            {
                return broadcastingSong;
            }

            set
            {
                broadcastingSong = value;
            }
        }

        
    }
}

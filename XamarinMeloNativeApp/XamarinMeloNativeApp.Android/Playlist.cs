using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinMeloNativeApp.Droid
{
    class Playlist
    {
        private List<Song> list;
        private string listName;
        private string ytVisibility;

        // Constructeurs

        public Playlist(List<Song> list, string listName, string ytVisibility)
        {
            this.List = list;
            this.ListName = listName;
            this.YtVisibility = ytVisibility;
        }
        // Méthodes

        public void ReadPlaylist()
        {

        }

        public void AddSong(Song s)
        {
            list.Add(s);
        }

        public void DeleteSong(Song s)
        {
            list.Remove(s);
        }

        public void DeletePlaylist()
        {

        }

        public void RenamePlaylist(string newName)
        {
            ListName = newName;
        }

        public void LoopPlaylist()
        {

        }

        public void ReadPlaylistRandomly()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }


        public string ListName
        {
            get
            {
                return listName;
            }

            set
            {
                listName = value;
            }
        }

        public string YtVisibility
        {
            get
            {
                return ytVisibility;
            }

            set
            {
                ytVisibility = value;
            }
        }

        internal List<Song> List
        {
            get
            {
                return list;
            }

            set
            {
                list = value;
            }
        }
    }
}

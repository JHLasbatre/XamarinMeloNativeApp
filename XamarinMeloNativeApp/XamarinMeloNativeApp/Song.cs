using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinMeloNativeApp
{
    class Song
    {
        private string title;
        private string songWriter;
        private string album;
        private string ytLink;
        private Genre classification;
        private int likes;

        public Song(string title, string songWriter, string album, string ytLink, Genre classification, int likes)
        {
            this.title = title;
            this.songWriter = songWriter;
            this.album = album;
            this.ytLink = ytLink;
            this.classification = classification;
            this.likes = likes;
        }
    }
}

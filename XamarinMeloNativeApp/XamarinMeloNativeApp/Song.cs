using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinMeloNativeApp
{
    class Song
    {
        private string titre;
        private string auteur;
        private string album;
        private string lienYT;
        private Genre classification;
        private int likes;

        // Constructeurs

        public Song(string titre, string auteur, string album, string lienYT, Genre classification, int likes)
        {
            this.Titre = titre;
            this.Auteur = auteur;
            this.Album = album;
            this.LienYT = lienYT;
            this.Classification = classification;
            this.Likes = likes;
        }

        // Méthodes

        public override string ToString()
        {
            return base.ToString();
        }

        public void ReadSong()
        {

        }

        public void AddLike(Broadcaster b)
        {

        }

        public void UnLike(Broadcaster b)
        {

        }

        public string Titre
        {
            get
            {
                return titre;
            }

            set
            {
                titre = value;
            }
        }

        public string Auteur
        {
            get
            {
                return auteur;
            }

            set
            {
                auteur = value;
            }
        }

        public string Album
        {
            get
            {
                return album;
            }

            set
            {
                album = value;
            }
        }

        public string LienYT
        {
            get
            {
                return lienYT;
            }

            set
            {
                lienYT = value;
            }
        }

        public Genre Classification
        {
            get
            {
                return classification;
            }

            set
            {
                classification = value;
            }
        }

        public int Likes
        {
            get
            {
                return likes;
            }

            set
            {
                likes = value;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace XamarinMeloNativeApp.Droid
{
    class Song
    {
        private string titre;
        private string auteur;
        private string album;
        private string lienYT;
        private Genre classification;
        private int likes;

        

        public Song(string titre, string auteur, string album, string lienYT, Genre classification, int likes)
        {
            this.titre = titre;
            this.auteur = auteur;
            this.album = album;
            this.lienYT = lienYT;
            this.classification = classification;
            this.likes = likes;
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

        internal Genre Classification
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
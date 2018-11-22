using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Song
    {
        public string Title { get; set; }
        public string ArtistName { get; set; }
        public int Length { get; set; }

        public Song(string Title, string ArtistName, int Length)
        {
            this.Title = Title;
            this.ArtistName = ArtistName;
            this.Length = Length;
        }
    }
}

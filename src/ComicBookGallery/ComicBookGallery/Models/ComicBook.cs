using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
    public class ComicBook
    {
        public int Id { get; set; }
        public String SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public String DescriptionHTML { get; set; }
        public Artist[] Artists { get;set;}
        public bool Favorite { get; set; }
    }
}
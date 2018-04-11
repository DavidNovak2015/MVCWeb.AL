using System;
using System.Web;

namespace Web.DL
{
    public class TeaserEntityDL
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime DateOfTeaser { get; set; }
        public string ImageName { get; set; }
    }
}

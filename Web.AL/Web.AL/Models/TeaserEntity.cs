using System;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Web.AL.Models
{
    public class TeaserEntity
    {
        [Display(Name ="Identifizierungsnummer")]
        public int Id { get; set; }

        [Display(Name = "HeadLine")]
        [StringLength(50, ErrorMessage = "Headline darf nicht länger als 50 Zeichen sein")]
        [Required(ErrorMessage = "Geben Sie bitte eine Benenung der Headline an")]
        public string Title { get; set; }

        [Display(Name = "Inhalt_der_Rubrik")]
        [StringLength(3000, ErrorMessage = "Höchslänge 3000 Zeichen wurde überschritten")]
        [DataType(DataType.MultilineText)]
        public string Text { get; set; }

        [Display(Name ="Datum_dieser_Rubrik")]
        [DataType(DataType.Date,ErrorMessage ="Geben Sie bitte das Datum im Format Tag.Monat.Jahr")]
        [Required(ErrorMessage ="Wählen Sie bitte einen Datum aus dem Kalendar aus")]
        public DateTime DateOfTeaser { get; set; }

        public string ImageName { get; set; }

        [Display(Name = "Wählen Sie ein Bild aus Ihrem Computer im Format \"jpg\"")]
        public HttpPostedFileBase Image { get; set; }

        public TeaserEntity(int iD, string title, string text, DateTime dateOfTeaser, string imageName) // for display teaser
        {
            this.Id = iD;
            this.Title = title;
            this.Text = text;
            this.DateOfTeaser = dateOfTeaser;
            this.ImageName = imageName;
        }
        public TeaserEntity()
        { }
        public TeaserEntity(int iD, string title, string text, DateTime dateOfTeaser, string imageName, HttpPostedFileBase image) // for update  teaser
        {
            this.Id = iD;
            this.Title = title;
            this.Text = text;
            this.DateOfTeaser = dateOfTeaser;
            this.ImageName = imageName;
            this.Image = image;
        }
    }
}
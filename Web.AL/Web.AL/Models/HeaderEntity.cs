using System.ComponentModel.DataAnnotations;

namespace Web.AL.Models
{
    public class HeaderEntity
    {
        [Display(Name ="HeadLine")]
        [StringLength(50,ErrorMessage ="Headline darf nicht länger als 50 Zeichen sein")]
        [Required(ErrorMessage ="HeadLine is verpflichtet")]
        public string Title { get; set; }

        [Display(Name = "Wortlaut_des_Kopfes")]
        [StringLength(1500, ErrorMessage = "Höchslänge 1500 Zeichen wurde überschritten")]
        [DataType(DataType.MultilineText)]
        public string Text { get; set; }

        [Display(Name ="Link 1")]
        public LinkHeader Link1 { get; set; }

        [Display(Name ="Link2")]
        public LinkHeader Link2 { get; set; }

    }
    public class LinkHeader
    {
        [Display(Name = "Link_Text")]
        [StringLength(50, ErrorMessage = "Wortlaut des TextsLinkes darf nicht länger als 50 Zeichen sein")]
        public string LinkText { get; set; }

        [Display(Name ="AdresseLink")]
        [StringLength(100, ErrorMessage = "Wortlaut des AdresseLinkes darf nicht länger als 100 Zeichen sein")]
        public string LinkAddress { get; set; }
    }
}
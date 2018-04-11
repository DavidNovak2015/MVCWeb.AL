using System.ComponentModel.DataAnnotations;

namespace Web.AL.Models
{
    public class FooterEntity
    {
        [Display(Name = "HeadLine_1")]
        [StringLength(50, ErrorMessage = "Headline darf nicht länger als 50 Zeichen sein")]
        [Required(ErrorMessage = "Geben Sie bitte eine Benenung der Headline an")]
        public string Title1 { get; set; }

        [Display(Name = "HeadLine_2")]
        [StringLength(50, ErrorMessage = "Headline darf nicht länger als 50 Zeichen sein")]
        [Required(ErrorMessage = "Geben Sie bitte eine Benenung der Headline an")]
        public string Title2 { get; set; }


        [Display(Name = "Wortlaut_zum_Link_1")]
        [StringLength(50, ErrorMessage = "Worlaut darf nicht länger als 50 Zeichen sein")]
        public string Text1 { get; set; }

        [Display(Name = "Link 1")]
        public LinkFooter Link1 { get; set; }


        [Display(Name = "Wortlaut_zum_Link_2")]
        [StringLength(50, ErrorMessage = "Worlaut darf nicht länger als 50 Zeichen sein")]
        public string Text2 { get; set; }

        [Display(Name = "Link 2")]
        public LinkFooter Link2 { get; set; }


        [Display(Name = "Wortlaut_zum_Link_3")]
        [StringLength(50, ErrorMessage = "Worlaut darf nicht länger als 50 Zeichen sein")]
        public string Text3 { get; set; }

        [Display(Name = "Link 3")]
        public LinkFooter Link3 { get; set; }


        [Display(Name = "Wortlaut_zum_Link_4")]
        [StringLength(50, ErrorMessage = "Worlaut darf nicht länger als 50 Zeichen sein")]
        public string Text4 { get; set; }

        [Display(Name = "Link 4")]
        public LinkFooter Link4 { get; set; }


        [Display(Name = "Wortlaut_zum_Link_5")]
        [StringLength(50, ErrorMessage = "Worlaut darf nicht länger als 50 Zeichen sein")]
        public string Text5 { get; set; }

        [Display(Name = "Link 5")]
        public LinkFooter Link5 { get; set; }


        [Display(Name = "Wortlaut_zum_Link_6")]
        [StringLength(50, ErrorMessage = "Worlaut darf nicht länger als 50 Zeichen sein")]
        public string Text6 { get; set; }

        [Display(Name = "Link 6")]
        public LinkFooter Link6 { get; set; }


        [Display(Name = "Wortlaut_zum_Link_7")]
        [StringLength(50, ErrorMessage = "Worlaut darf nicht länger als 50 Zeichen sein")]
        public string Text7 { get; set; }

        [Display(Name = "Link 7")]
        public LinkFooter Link7 { get; set; }


        [Display(Name = "Wortlaut_zum_Link_8")]
        [StringLength(50, ErrorMessage = "Worlaut darf nicht länger als 50 Zeichen sein")]
        public string Text8 { get; set; }

        [Display(Name = "Link 8")]
        public LinkFooter Link8 { get; set; }


        [Display(Name = "Wortlaut_zum_Link_9")]
        [StringLength(50, ErrorMessage = "Worlaut darf nicht länger als 50 Zeichen sein")]
        public string Text9 { get; set; }

        [Display(Name = "Link 9")]
        public LinkFooter Link9 { get; set; }


        [Display(Name = "Wortlaut_zum_Link_10")]
        [StringLength(50, ErrorMessage = "Worlaut darf nicht länger als 50 Zeichen sein")]
        public string Text10 { get; set; }

        [Display(Name = "Link 10")]
        public LinkFooter Link10 { get; set; }


        [Display(Name = "Wortlaut_zum_Link_11")]
        [StringLength(50, ErrorMessage = "Worlaut darf nicht länger als 50 Zeichen sein")]
        public string Text11 { get; set; }

        [Display(Name = "Link 11")]
        public LinkFooter Link11 { get; set; }


        [Display(Name = "Wortlaut_zum_Link_12")]
        [StringLength(50, ErrorMessage = "Worlaut darf nicht länger als 50 Zeichen sein")]
        public string Text12 { get; set; }

        [Display(Name = "Link 12")]
        public LinkFooter Link12 { get; set; }
    }
    public class LinkFooter
    {
        [Display(Name = "Link_Text")]
        [StringLength(50, ErrorMessage = "Wortlaut des TextsLinkes darf nicht länger als 50 Zeichen sein")]
        public string LinkText { get; set; }

        [Display(Name = "AdresseLink")]
        [StringLength(200, ErrorMessage = "Wortlaut des AdresseLinkes darf nicht länger als 200 Zeichen sein")]
        public string LinkAddress { get; set; }
    }
}
using Web.DL;

namespace Web.AL.Models
{
    public class FooterViewModel
    {
        DbRepository dbRepository = new DbRepository();

        public FooterEntity Footer { get; set; }

        public FooterViewModel()
        {
            FooterEntityDL footerFromDB = dbRepository.GetFooterData();

            Footer = new FooterEntity(); Footer.Link1 = new LinkFooter(); Footer.Link2 = new LinkFooter(); Footer.Link3 = new LinkFooter(); Footer.Link4 = new LinkFooter(); Footer.Link5 = new LinkFooter(); Footer.Link6 = new LinkFooter(); Footer.Link7 = new LinkFooter(); Footer.Link8 = new LinkFooter(); Footer.Link9 = new LinkFooter(); Footer.Link10 = new LinkFooter(); Footer.Link11 = new LinkFooter(); Footer.Link12 = new LinkFooter();

            Footer.Title1 = footerFromDB.Title1 ?? "Die angaben wurden nicht gelesen.";
            Footer.Title2 = footerFromDB.Title2 ?? "Die angaben wurden nicht gelesen.";

            Footer.Text1 = footerFromDB.Text1;
            Footer.Link1.LinkText = footerFromDB.Link1.LinkText;
            Footer.Link1.LinkAddress = footerFromDB.Link1.LinkAddress;

            Footer.Text2 = footerFromDB.Text2;
            Footer.Link2.LinkText = footerFromDB.Link2.LinkText;
            Footer.Link2.LinkAddress = footerFromDB.Link2.LinkAddress;

            Footer.Text3 = footerFromDB.Text3;
            Footer.Link3.LinkText = footerFromDB.Link3.LinkText;
            Footer.Link3.LinkAddress = footerFromDB.Link3.LinkAddress;

            Footer.Text4 = footerFromDB.Text4;
            Footer.Link4.LinkText = footerFromDB.Link4.LinkText;
            Footer.Link4.LinkAddress = footerFromDB.Link4.LinkAddress;

            Footer.Text5 = footerFromDB.Text5;
            Footer.Link5.LinkText = footerFromDB.Link5.LinkText;
            Footer.Link5.LinkAddress = footerFromDB.Link5.LinkAddress;

            Footer.Text6 = footerFromDB.Text6;
            Footer.Link6.LinkText = footerFromDB.Link6.LinkText;
            Footer.Link6.LinkAddress = footerFromDB.Link6.LinkAddress;

            Footer.Text7 = footerFromDB.Text7;
            Footer.Link7.LinkText = footerFromDB.Link7.LinkText;
            Footer.Link7.LinkAddress = footerFromDB.Link7.LinkAddress;

            Footer.Text8 = footerFromDB.Text8;
            Footer.Link8.LinkText = footerFromDB.Link8.LinkText;
            Footer.Link8.LinkAddress = footerFromDB.Link8.LinkAddress;

            Footer.Text9 = footerFromDB.Text9;
            Footer.Link9.LinkText = footerFromDB.Link9.LinkText;
            Footer.Link9.LinkAddress = footerFromDB.Link9.LinkAddress;

            Footer.Text10 = footerFromDB.Text10;
            Footer.Link10.LinkText = footerFromDB.Link10.LinkText;
            Footer.Link10.LinkAddress = footerFromDB.Link10.LinkAddress;

            Footer.Text11 = footerFromDB.Text11;
            Footer.Link11.LinkText = footerFromDB.Link11.LinkText;
            Footer.Link11.LinkAddress = footerFromDB.Link11.LinkAddress;

            Footer.Text12 = footerFromDB.Text12;
            Footer.Link12.LinkText = footerFromDB.Link12.LinkText;
            Footer.Link12.LinkAddress = footerFromDB.Link12.LinkAddress;
        }
    }
}
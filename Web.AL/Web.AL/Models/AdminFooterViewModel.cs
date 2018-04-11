using Web.DL;

namespace Web.AL.Models
{
    public class AdminFooterViewModel
    {
        DbRepository dbRepository = new DbRepository();

        public FooterEntity FooterOld { get; set; }
        public FooterEntity FooterNew { get; set; }

        public AdminFooterViewModel()
        {
            FooterOld = new FooterEntity();FooterOld.Link1 = new LinkFooter(); FooterOld.Link2 = new LinkFooter(); FooterOld.Link3 = new LinkFooter(); FooterOld.Link4 = new LinkFooter(); FooterOld.Link5 = new LinkFooter(); FooterOld.Link6 = new LinkFooter(); FooterOld.Link7 = new LinkFooter(); FooterOld.Link8 = new LinkFooter(); FooterOld.Link9 = new LinkFooter(); FooterOld.Link10 = new LinkFooter(); FooterOld.Link11 = new LinkFooter(); FooterOld.Link12 = new LinkFooter();
            FooterNew = new FooterEntity(); FooterNew.Link1 = new LinkFooter(); FooterNew.Link2 = new LinkFooter(); FooterNew.Link3 = new LinkFooter(); FooterNew.Link4 = new LinkFooter(); FooterNew.Link5 = new LinkFooter(); FooterNew.Link6 = new LinkFooter(); FooterNew.Link7 = new LinkFooter(); FooterNew.Link8 = new LinkFooter(); FooterNew.Link9 = new LinkFooter(); FooterNew.Link10 = new LinkFooter(); FooterNew.Link11 = new LinkFooter(); FooterNew.Link12 = new LinkFooter();

            FooterEntityDL footerFromDB = dbRepository.GetFooterData();

            FooterOld.Title1 = footerFromDB.Title1 ?? "Die angaben wurden nicht gelesen.";
            FooterOld.Title2 = footerFromDB.Title1 ?? "Die angaben wurden nicht gelesen.";

            FooterOld.Text1 = footerFromDB.Text1;
            FooterOld.Link1.LinkText = footerFromDB.Link1.LinkText;
            FooterOld.Link1.LinkAddress = footerFromDB.Link1.LinkAddress;

            FooterOld.Text2 = footerFromDB.Text2;
            FooterOld.Link2.LinkText = footerFromDB.Link2.LinkText;
            FooterOld.Link2.LinkAddress = footerFromDB.Link2.LinkAddress;

            FooterOld.Text3 = footerFromDB.Text3;
            FooterOld.Link3.LinkText = footerFromDB.Link3.LinkText;
            FooterOld.Link3.LinkAddress = footerFromDB.Link3.LinkAddress;

            FooterOld.Text4 = footerFromDB.Text4;
            FooterOld.Link4.LinkText = footerFromDB.Link4.LinkText;
            FooterOld.Link4.LinkAddress = footerFromDB.Link4.LinkAddress;

            FooterOld.Text5 = footerFromDB.Text5;
            FooterOld.Link5.LinkText = footerFromDB.Link5.LinkText;
            FooterOld.Link5.LinkAddress = footerFromDB.Link5.LinkAddress;

            FooterOld.Text6 = footerFromDB.Text6;
            FooterOld.Link6.LinkText = footerFromDB.Link6.LinkText;
            FooterOld.Link6.LinkAddress = footerFromDB.Link6.LinkAddress;

            FooterOld.Text7 = footerFromDB.Text7;
            FooterOld.Link7.LinkText = footerFromDB.Link7.LinkText;
            FooterOld.Link7.LinkAddress = footerFromDB.Link7.LinkAddress;

            FooterOld.Text8 = footerFromDB.Text8;
            FooterOld.Link8.LinkText = footerFromDB.Link8.LinkText;
            FooterOld.Link8.LinkAddress = footerFromDB.Link8.LinkAddress;

            FooterOld.Text9 = footerFromDB.Text9;
            FooterOld.Link9.LinkText = footerFromDB.Link10.LinkText;
            FooterOld.Link9.LinkAddress = footerFromDB.Link10.LinkAddress;

            FooterOld.Text10 = footerFromDB.Text10;
            FooterOld.Link10.LinkText = footerFromDB.Link10.LinkText;
            FooterOld.Link10.LinkAddress = footerFromDB.Link10.LinkAddress;

            FooterOld.Text11 = footerFromDB.Text11;
            FooterOld.Link11.LinkText = footerFromDB.Link11.LinkText;
            FooterOld.Link11.LinkAddress = footerFromDB.Link11.LinkAddress;

            FooterOld.Text12 = footerFromDB.Text12;
            FooterOld.Link12.LinkText = footerFromDB.Link12.LinkText;
            FooterOld.Link12.LinkAddress = footerFromDB.Link12.LinkAddress;

            FooterNew = FooterOld;
        }

        public string Update(AdminFooterViewModel adminFooterViewModel)
        {
            FooterEntityDL footerToDB = new FooterEntityDL();
            footerToDB.Id = 1;
            footerToDB.Link1 = new LinkDLFooter(); footerToDB.Link2 = new LinkDLFooter(); footerToDB.Link3 = new LinkDLFooter(); footerToDB.Link4 = new LinkDLFooter(); footerToDB.Link5 = new LinkDLFooter(); footerToDB.Link6 = new LinkDLFooter(); footerToDB.Link7 = new LinkDLFooter(); footerToDB.Link8 = new LinkDLFooter(); footerToDB.Link9 = new LinkDLFooter(); footerToDB.Link10 = new LinkDLFooter(); footerToDB.Link11 = new LinkDLFooter(); footerToDB.Link12 = new LinkDLFooter();

            footerToDB.Title1 = adminFooterViewModel.FooterNew.Title1;
            footerToDB.Title2 = adminFooterViewModel.FooterNew.Title2;

            footerToDB.Text1 = adminFooterViewModel.FooterNew.Text1 ?? string.Empty;
            footerToDB.Link1.LinkText = adminFooterViewModel.FooterNew.Link1.LinkText ?? string.Empty;
            footerToDB.Link1.LinkAddress = adminFooterViewModel.FooterNew.Link1.LinkAddress ?? string.Empty;

            footerToDB.Text2 = adminFooterViewModel.FooterNew.Text2 ?? string.Empty;
            footerToDB.Link2.LinkText = adminFooterViewModel.FooterNew.Link2.LinkText ?? string.Empty;
            footerToDB.Link2.LinkAddress = adminFooterViewModel.FooterNew.Link2.LinkAddress ?? string.Empty;

            footerToDB.Text3 = adminFooterViewModel.FooterNew.Text3 ?? string.Empty;
            footerToDB.Link3.LinkText = adminFooterViewModel.FooterNew.Link3.LinkText ?? string.Empty;
            footerToDB.Link3.LinkAddress = adminFooterViewModel.FooterNew.Link3.LinkAddress ?? string.Empty;

            footerToDB.Text4 = adminFooterViewModel.FooterNew.Text4 ?? string.Empty;
            footerToDB.Link4.LinkText = adminFooterViewModel.FooterNew.Link4.LinkText ?? string.Empty;
            footerToDB.Link4.LinkAddress = adminFooterViewModel.FooterNew.Link4.LinkAddress ?? string.Empty;

            footerToDB.Text5 = adminFooterViewModel.FooterNew.Text5 ?? string.Empty;
            footerToDB.Link5.LinkText = adminFooterViewModel.FooterNew.Link5.LinkText ?? string.Empty;
            footerToDB.Link5.LinkAddress = adminFooterViewModel.FooterNew.Link5.LinkAddress ?? string.Empty;

            footerToDB.Text6 = adminFooterViewModel.FooterNew.Text6 ?? string.Empty;
            footerToDB.Link6.LinkText = adminFooterViewModel.FooterNew.Link6.LinkText ?? string.Empty;
            footerToDB.Link6.LinkAddress = adminFooterViewModel.FooterNew.Link6.LinkAddress ?? string.Empty;

            footerToDB.Text7 = adminFooterViewModel.FooterNew.Text7 ?? string.Empty;
            footerToDB.Link7.LinkText = adminFooterViewModel.FooterNew.Link7.LinkText ?? string.Empty;
            footerToDB.Link7.LinkAddress = adminFooterViewModel.FooterNew.Link7.LinkAddress ?? string.Empty;

            footerToDB.Text8 = adminFooterViewModel.FooterNew.Text8 ?? string.Empty;
            footerToDB.Link8.LinkText = adminFooterViewModel.FooterNew.Link8.LinkText ?? string.Empty;
            footerToDB.Link8.LinkAddress = adminFooterViewModel.FooterNew.Link8.LinkAddress ?? string.Empty;

            footerToDB.Text9 = adminFooterViewModel.FooterNew.Text9 ?? string.Empty;
            footerToDB.Link9.LinkText = adminFooterViewModel.FooterNew.Link9.LinkText ?? string.Empty;
            footerToDB.Link9.LinkAddress = adminFooterViewModel.FooterNew.Link9.LinkAddress ?? string.Empty;

            footerToDB.Text10 = adminFooterViewModel.FooterNew.Text10 ?? string.Empty;
            footerToDB.Link10.LinkText = adminFooterViewModel.FooterNew.Link10.LinkText ?? string.Empty;
            footerToDB.Link10.LinkAddress = adminFooterViewModel.FooterNew.Link10.LinkAddress ?? string.Empty;

            footerToDB.Text11 = adminFooterViewModel.FooterNew.Text11 ?? string.Empty;
            footerToDB.Link11.LinkText = adminFooterViewModel.FooterNew.Link11.LinkText ?? string.Empty;
            footerToDB.Link11.LinkAddress = adminFooterViewModel.FooterNew.Link11.LinkAddress ?? string.Empty;

            footerToDB.Text12 = adminFooterViewModel.FooterNew.Text12 ?? string.Empty;
            footerToDB.Link12.LinkText = adminFooterViewModel.FooterNew.Link12.LinkText ?? string.Empty;
            footerToDB.Link12.LinkAddress = adminFooterViewModel.FooterNew.Link12.LinkAddress ?? string.Empty;

            return dbRepository.UpDateFooter(footerToDB);
        }
    }
}
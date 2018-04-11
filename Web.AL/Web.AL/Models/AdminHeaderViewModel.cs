using Web.DL;

namespace Web.AL.Models
{
    public class AdminHeaderViewModel
    {
        DbRepository dbRepository = new DbRepository();
        public HeaderEntity HeaderOld { get; set; }

        public HeaderEntity HeaderNew { get; set; }

        public AdminHeaderViewModel()
        {
            HeaderEntityDL headerFromDB = dbRepository.GetHeaderData();
             
                HeaderOld = new HeaderEntity(); HeaderOld.Link1 = new LinkHeader(); HeaderOld.Link2 = new LinkHeader();
                HeaderNew = new HeaderEntity(); HeaderNew.Link1 = new LinkHeader(); HeaderNew.Link2 = new LinkHeader();

                HeaderOld.Title = headerFromDB.Title ?? "Die angaben wurden nicht gelesen.";
                HeaderOld.Text = headerFromDB.Text;
                HeaderOld.Link1.LinkText = headerFromDB.Link1.LinkText;
                HeaderOld.Link1.LinkAddress = headerFromDB.Link1.LinkAddress;
                HeaderOld.Link2.LinkText = headerFromDB.Link2.LinkText;
                HeaderOld.Link2.LinkAddress = headerFromDB.Link2.LinkAddress;

            HeaderNew = HeaderOld;
        }

        public string Update (AdminHeaderViewModel adminHeaderViewModel)
        {
            HeaderEntityDL headerToDB = new HeaderEntityDL();
            headerToDB.Link1 = new LinkDL(); headerToDB.Link2 = new LinkDL();

            headerToDB.Id = 1;
            headerToDB.Title = adminHeaderViewModel.HeaderNew.Title;
            headerToDB.Text = adminHeaderViewModel.HeaderNew.Text ?? string.Empty;
            headerToDB.Link1.LinkText = adminHeaderViewModel.HeaderNew.Link1.LinkText ?? string.Empty;
            headerToDB.Link1.LinkAddress = adminHeaderViewModel.HeaderNew.Link1.LinkAddress ?? string.Empty;
            headerToDB.Link2.LinkText = adminHeaderViewModel.HeaderNew.Link2.LinkText ?? string.Empty;
            headerToDB.Link2.LinkAddress = adminHeaderViewModel.HeaderNew.Link2.LinkAddress ?? string.Empty;

            return dbRepository.UpDateHeader(headerToDB);
        }
    }
}
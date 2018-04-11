using Web.DL;

namespace Web.AL.Models
{
    public class HeaderViewModel
    {
        DbRepository dbRepository = new DbRepository();

        public HeaderEntity Header { get; set; }

        public HeaderViewModel()
        {
            HeaderEntityDL headerFromDB = dbRepository.GetHeaderData();

            Header = new HeaderEntity();Header.Link1 = new LinkHeader();Header.Link2 = new LinkHeader();

            Header.Title = headerFromDB.Title ?? "Die angaben wurden nicht gelesen.";
            Header.Text = headerFromDB.Text ?? string.Empty;
            Header.Link1.LinkText = headerFromDB.Link1.LinkText ?? string.Empty;
            Header.Link1.LinkAddress = headerFromDB.Link1.LinkAddress ?? string.Empty;
            Header.Link2.LinkText = headerFromDB.Link2.LinkText ?? string.Empty;
            Header.Link2.LinkAddress = headerFromDB.Link2.LinkAddress ?? string.Empty;
        }
    }
}
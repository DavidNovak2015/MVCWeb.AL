using System.Collections.Generic;

namespace Web.AL.Models
{
    public class PageViewModel
    {
        HeaderViewModel header;
        TeasersViewModel teasers;
        FooterViewModel footer;

        public PageViewModel()
        {
            header = new HeaderViewModel();
            teasers = new TeasersViewModel();
            footer = new FooterViewModel();
        }

        public HeaderEntity Header
        {
            get
            {
                return header.Header;
            }
        }
        public List<TeaserEntity> Teasers
        {
            get
            {
                return teasers.Teasers;
            }
        }
        public FooterEntity Footer
        {
            get
            {
                return footer.Footer;
            }
        }

        public TeaserEntity Teaser
        {
            get
            {
                return teasers.Teaser;
            }
        }

        public void SetPageWithOneTeaser(int teaserId)
        {
            teasers.GetTeaser(teaserId);
            footer = new FooterViewModel();
        }
    }
}
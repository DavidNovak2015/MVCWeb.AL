using System.Collections.Generic;
using System.Linq;
using Web.DL;

namespace Web.AL.Models
{
    public class TeasersViewModel
    {
        DbRepository dbRepository = new DbRepository();

        private const string pathToDisplayImages = "/Content/Images/Teasers/";

        public List<TeaserEntity> Teasers { get; set; }

        public TeaserEntity Teaser { get; set; }

        public TeasersViewModel()
        {
            List<TeaserEntityDL> teasersFromDB = dbRepository.GetAllTeasers();
            Teasers = new List<TeaserEntity>();
            Teasers = teasersFromDB.Select(x => new TeaserEntity(x.Id, x.Title, x.Text, x.DateOfTeaser, pathToDisplayImages + x.ImageName + ".jpg")).ToList();
        }

        public void GetTeaser(int teaserId)
        {
            TeaserEntityDL teaserFromDB = dbRepository.GetTeaserData(teaserId);
            Teaser = new TeaserEntity(teaserFromDB.Id,teaserFromDB.Title,teaserFromDB.Text,teaserFromDB.DateOfTeaser,pathToDisplayImages + teaserFromDB.ImageName + ".jpg");
        }
    }
}
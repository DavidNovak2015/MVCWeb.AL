using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Web.DL;

namespace Web.AL.Models
{
    public class AdminTeasersViewModel
    {
        DbRepository dbRepository = new DbRepository();

        private const string pathToDisplayImages = "/Content/Images/Teasers/";
        private const string pathToUpdateImages = "C:/Users/David/Desktop/David/Programovani/MVCProjects/Web.AL/Web.AL/Content/Images/Teasers/";

        [Display(Name = "Identifizierungsnummer")]
        [Required(ErrorMessage = "Geben Sie bitte eine Identifizierungsnummer der Rubrik")]
        [RegularExpression("([1-3])", ErrorMessage ="Es gibt nur drei Rubriken, deswegen geben Sie bitte eins, zwei oder drei an")]
        public int? IdTeaser { get; set; }

        public List<TeaserEntity> Teasers { get; set; }
        public TeaserEntity TeaserOld { get; set; }
        public TeaserEntity TeaserNew { get; set; }
        
        public AdminTeasersViewModel()
        {
            List<TeaserEntityDL> teasersFromDB = dbRepository.GetAllTeasers();
            Teasers = new List<TeaserEntity>();
            Teasers = teasersFromDB.Select(x => new TeaserEntity(x.Id, x.Title, x.Text, x.DateOfTeaser,pathToDisplayImages + x.ImageName + ".jpg")).ToList();
        }

        private int GetIdTeaser()
        {
            if (!IdTeaser.HasValue)
                throw new InvalidOperationException($"{nameof(IdTeaser)} is empty");
            return IdTeaser.Value;
        }
        public void FindTeaser(AdminTeasersViewModel adminTeaserViewModel)
        {
            TeaserEntityDL teaserFromDB = dbRepository.GetTeaserData(GetIdTeaser());
            if (teaserFromDB == null)
                TeaserOld = new TeaserEntity(0, "Die angaben wurden nicht gelesen", "", DateTime.Today,string.Empty);

            TeaserOld = new TeaserEntity(teaserFromDB.Id, teaserFromDB.Title, teaserFromDB.Text, teaserFromDB.DateOfTeaser, pathToDisplayImages + teaserFromDB.ImageName + ".jpg");
            TeaserNew = TeaserOld;
        }

        private string SaveImage(AdminTeasersViewModel adminTeaserViewModel)
        {
            try
            {
                adminTeaserViewModel.TeaserNew.Image.SaveAs(pathToUpdateImages + adminTeaserViewModel.TeaserOld.Id + ".jpg");
                return string.Empty;
            }
            catch (Exception ex)
            {
                return $"Das Bild zum Artikel Id: {adminTeaserViewModel.TeaserNew.Id} wurde nicht eingespeichert. Unten Fehlerbeschreibung: \n{ex.Message.ToString()}";
            }
        }
        public string UpdateTeaser(AdminTeasersViewModel adminTeaserViewModel)
        {
            TeaserEntityDL teaserToDB = new TeaserEntityDL();

            if (adminTeaserViewModel.TeaserNew.Image == null)
            {
                teaserToDB.Id = adminTeaserViewModel.TeaserOld.Id;
                teaserToDB.Title = adminTeaserViewModel.TeaserNew.Title;
                teaserToDB.Text = adminTeaserViewModel.TeaserNew.Text ?? string.Empty;
                teaserToDB.DateOfTeaser = adminTeaserViewModel.TeaserNew.DateOfTeaser;
                teaserToDB.ImageName = null;

                return dbRepository.UpdateTeaserData(teaserToDB);
            }

            string ImageSaveError = SaveImage(adminTeaserViewModel);

            if (ImageSaveError != string.Empty)
                return ImageSaveError;

            teaserToDB.Id = adminTeaserViewModel.TeaserOld.Id;
            teaserToDB.Title = adminTeaserViewModel.TeaserNew.Title;
            teaserToDB.Text = adminTeaserViewModel.TeaserNew.Text ?? string.Empty;
            teaserToDB.DateOfTeaser = adminTeaserViewModel.TeaserNew.DateOfTeaser;
            teaserToDB.ImageName = adminTeaserViewModel.TeaserOld.Id.ToString();

            return dbRepository.UpdateTeaserData(teaserToDB);
        }
    }
}
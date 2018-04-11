using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Web.AL.Models
{
    public class AdminImageViewModel
    {
        private const string pathToDisplayImages = "/Content/Images/Teasers/";
        private const string pathToUpdateImages = "C:/Users/David/Desktop/David/Programovani/MVCProjects/Web.AL/Web.AL/Content/Images/Teasers/";

        public List<string> ImagePaths { get; private set; }
        public string ImagePathToDelete { get; set; }

        public AdminImageViewModel()
        {
            ImagePaths = new List<string>();
            try
            {
                List<string> foundPathToFiles = Directory.EnumerateFiles(pathToUpdateImages).ToList();
                foreach (string foundPath in foundPathToFiles)
                {
                    ImagePaths.Add(pathToDisplayImages + Path.GetFileName(foundPath));
                }
                if (ImagePaths.Count() == 0)
                    ImagePaths.Add("Keine Bilder wurden gefunden");
            }
            catch (Exception ex)
            {
                ImagePaths.Add($"Die Bilder wurden nicht eingelesen.Unten Fehlerbeschreibung: \n{ ex.Message.ToString()}");
            }
        }
        public string DeleteImage(string imagePathToDelete)
        {
            try
            {
                File.Delete(pathToUpdateImages + Path.GetFileName(imagePathToDelete));
                return "Das Bild wurde gelöscht";
            }
            catch (Exception ex)
            {
                return $"Das Bild wurde nicht gelöscht. Unten Fehlerbeschreibung:\n {ex.Message.ToString()}";
            }
        }
    }
}
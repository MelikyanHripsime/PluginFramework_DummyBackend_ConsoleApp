using PluginFramework_DummyBackend_ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginFramework_DummyBackend_ConsoleApp.DummyRepository
{
    public class ImagesRepository
    {
        private readonly List<Image> Images;

        public ImagesRepository(List<Image> images) {
            Images = images;
        }

        public Image? GetImageById(Guid id)
        {
            return Images?.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Image> GetImages() => Images;

        public void AddImage(Image image)
        {
            Images.Add(image);
        }

        public void AddImages(IEnumerable<Image> images)
        {
            Images.AddRange(images);
        }

        public void RemoveImage(Image image)
        {
            Images.Remove(image);
        }

        //Simulating update to db will just remove old and add new to simulate update process
        public void UpdateImage(Image newImage)
        {
           var old = Images.FirstOrDefault(_ => _.Id == newImage.Id);
           this.RemoveImage(old);
           this.AddImage(newImage);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderTheSea.Controller
{
    class AdvertisementController
    {
        private static AdvertisementController ac;
        private UnderTheSeaEntities en;
        private AdvertisementController()
        {
            en = UnderTheSeaEntities.getInstance();
        }
        public static AdvertisementController getInstance()
        {
            if (ac == null)
            {
                ac = new AdvertisementController();
            }
            return ac;
        }
        public void addAdvertisement(string name, string description)
        {
            Advertisement ad = en.Advertisements.Create();
            ad.AdvertisementDescription = description;
            ad.AdvertisementName = name;
            en.Advertisements.Add(ad);
            en.SaveChanges();
        }
        public void deleteAdvertisement(Advertisement ad)
        {
            Advertisement ads = en.Advertisements.Where(x => x.AdvertisementID == ad.AdvertisementID).FirstOrDefault();
            ads.AdvertisementDescription = "Deleted";
            en.SaveChanges();
        }
        public void updateAdvertisement(Advertisement old, Advertisement newAd)
         {
            Advertisement currAd = en.Advertisements.Where(x => x.AdvertisementID == old.AdvertisementID).FirstOrDefault();
            currAd.AdvertisementName = newAd.AdvertisementName;
            currAd.AdvertisementDescription = newAd.AdvertisementDescription;
            en.SaveChanges();
         }
        public List<Advertisement> getAllAdvertisement()
        {
            List<Advertisement> ads = en.Advertisements.ToList();
            return ads;

        }
        public int getLastIndex()
        {
            return en.Advertisements.Count();
        }
           

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderTheSea.Controller
{
    class RideController
    {
        private static RideController rc;
        private UnderTheSeaEntities en;
        private RideController()
        {
            en = UnderTheSeaEntities.getInstance();
        
        }
        public static RideController getInstance()
        {
            if (rc == null)
            {
                rc = new RideController();
            }
           
            return rc;
        }
        public int getLastIndex()
        {
            return en.Rides.Count();
        }
        public void deleteRide(Ride p)
        {
            Ride temp = en.Rides.Where(x => x.ActivityID == p.ActivityID).FirstOrDefault();
            temp.Status = "Deleted";
            en.SaveChanges();

        }
        public void updateRide(Ride oldPar, Ride newPar)
        {
            Ride curPar = en.Rides.Where(x => x.ActivityID == oldPar.ActivityID).FirstOrDefault();
            curPar.ActivityName = newPar.ActivityName;
            curPar.ActivityDuration = newPar.ActivityDuration;
            curPar.ActivityDescription = newPar.ActivityDescription;
            curPar.MinHeight = newPar.MinHeight;
            curPar.Restriction = newPar.Restriction;
            curPar.MinAge = newPar.MinAge;
            curPar.Status = newPar.Status;
            en.SaveChanges();

        }
        public List<Ride> getAllRide()
        {
            
            List<Ride> rides = en.Rides.ToList();
            
            return rides;
        }
        public void addRide(string name, string desc, int dur, int age, int height, string res)
        {
            Ride temp = en.Rides.Create();

            temp.ActivityName = name;
            temp.ActivityType = "Parade";
            temp.ActivityDescription = desc;
            temp.ActivityDuration = dur;
            temp.MinAge = age;
            temp.MinHeight = height;
            temp.Restriction = res;
            temp.Status = "Active";
            en.Rides.Add(temp);
            en.SaveChanges();
        }
    }
}

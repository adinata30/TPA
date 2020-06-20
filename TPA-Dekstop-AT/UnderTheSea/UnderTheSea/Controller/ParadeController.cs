using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderTheSea.Controller
{
    class ParadeController
    {
        private static ParadeController pc;
        private UnderTheSeaEntities en;
        private ParadeController()
        {
            en = UnderTheSeaEntities.getInstance();

        }
        public static ParadeController getInstance()
        {
            if(pc==null)
            {
                pc = new ParadeController();
            }
            return pc;
        }
        public int getLastIndex()
        {
            return en.Parades.Count();
        }
        public void deleteParade(Parade p)
        {
            Parade temp = en.Parades.Where(x => x.ActivityID == p.ActivityID).FirstOrDefault();
            temp.Status = "Deleted";
            en.SaveChanges();

        }
        public void updateParade(Parade oldPar,Parade newPar)
        {
            Parade curPar = en.Parades.Where(x => x.ActivityID == oldPar.ActivityID).FirstOrDefault();
            curPar.ActivityName = newPar.ActivityName;
            curPar.ActivityDuration = newPar.ActivityDuration;
            curPar.ActivityDescription = newPar.ActivityDescription;
            curPar.PeopleCount = newPar.PeopleCount;
            en.SaveChanges();

        }
        public List<Parade> getAllParade()
        {
            List<Parade> parades = en.Parades.ToList();
            return parades;
        }
        public void addParade (string name,string desc, int dur, int ppl)
        {
            Parade temp = en.Parades.Create();

            temp.ActivityName = name;
            temp.ActivityType = "Parade";
            temp.ActivityDescription = desc;
            temp.ActivityDuration = dur;
            temp.PeopleCount = ppl;
            temp.Status = "Active";
            en.Parades.Add(temp);
            en.SaveChanges();
        }
    }
}

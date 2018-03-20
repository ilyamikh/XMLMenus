using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLMenus
{
    public class ClassMealCount
    {
        private String groupName;
        private int rosterFree, rosterReduced, rosterPaid;
        private List<DayCount> weekCount = new List<DayCount>();
        
        public ClassMealCount()
        {
        }

        public void setName(String inName)
        {
            groupName = inName;
        }

        public void setRoster(int free, int reduced, int paid)
        {
            rosterFree = free;
            rosterReduced = reduced;
            rosterPaid = paid;
        }

        public void addDay(DayCount newDay) {
            weekCount.Add(newDay);
        }
    }
}

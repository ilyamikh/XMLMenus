using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLMenus
{
    public class DayCount
    {
        private DateTime date;
        private String dayOfWeek;
        private String menuName;
        private int menuId;
        private byte[] breakfast = new byte[3];
        private byte[] lunch = new byte[3];
        private byte[] snack = new byte[3];

        public DayCount()
        {

        }

        public void setDate(DateTime theDate)
        {
            date = theDate;
        }

        public void setDay(String inDay)
        {
            dayOfWeek = inDay;
        }

        public void setMenu(String name, int id)
        {
            menuName = name;
            menuId = id;
        }

        public void setBreakfast(byte free, byte reduced, byte paid)
        {
            breakfast[0] = free;
            breakfast[1] = reduced;
            breakfast[2] = paid;
        }

        public void setLunch(byte free, byte reduced, byte paid)
        {
            lunch[0] = free;
            lunch[1] = reduced;
            lunch[2] = paid;
        }

        public void setSnack(byte free, byte reduced, byte paid)
        {
            snack[0] = free;
            snack[1] = reduced;
            snack[2] = paid;
        }
    }
}

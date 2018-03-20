using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace XMLMenus
{
    class Report
    {
        private String filename;
        private String date;
        private String comments;
        private String menuId;
        private int[] breakfastCount = new int[4];
        private int[] lunchCount = new int[4];
        private int[] snackCount = new int[4];

        private List<Item> breakfastItems = new List<Item>();
        private List<Item> snackItems = new List<Item>();
        private List<Item> lunchItems = new List<Item>();

        public Report(String inFile, String inDate, String inComments)
        {
            filename = inFile;
            date = inDate;
            comments = inComments;
            loadCounts();
            loadItems();

        }

        private void setBreakfastCounts(String free, String reduced, String paid, String nonReimburseable) {
            breakfastCount[0] = Int32.Parse(free);
            breakfastCount[1] = Int32.Parse(reduced);
            breakfastCount[2] = Int32.Parse(paid);
            breakfastCount[3] = Int32.Parse(nonReimburseable);
        }

        private void setLunchCounts(String free, String reduced, String paid, String nonReimburseable)
        {
            lunchCount[0] = Int32.Parse(free);
            lunchCount[1] = Int32.Parse(reduced);
            lunchCount[2] = Int32.Parse(paid);
            lunchCount[3] = Int32.Parse(nonReimburseable);
        }

        private void setSnackCounts(String free, String reduced, String paid, String nonReimburseable)
        {
            snackCount[0] = Int32.Parse(free);
            snackCount[1] = Int32.Parse(reduced);
            snackCount[2] = Int32.Parse(paid);
            snackCount[3] = Int32.Parse(nonReimburseable);
        }
        private void loadCounts()
        {
            XmlDocument loadCounts = new XmlDocument();
            loadCounts.Load("Monthly Counts/" + filename);

            var mgr = new XmlNamespaceManager(loadCounts.NameTable);
            mgr.AddNamespace("a", "");

            XmlNode loadDay = loadCounts.SelectSingleNode("//a:month/day[@date='" + date + "']", mgr);

            menuId = loadDay.Attributes["menuID"].Value;

            for (int i = 0; i < loadDay.ChildNodes[0].Attributes.Count; i++)
            {
                breakfastCount[i] = Int32.Parse(loadDay.ChildNodes[0].Attributes[i].Value);
            }

            for (int i = 0; i < loadDay.ChildNodes[0].Attributes.Count; i++)
            {
                lunchCount[i] = Int32.Parse(loadDay.ChildNodes[1].Attributes[i].Value);
            }

            for (int i = 0; i < loadDay.ChildNodes[0].Attributes.Count; i++)
            {
                snackCount[i] = Int32.Parse(loadDay.ChildNodes[2].Attributes[i].Value);
            }

        }

        private void loadItems()
        {
            XmlDocument meals = new XmlDocument();
            meals.Load("meals.xml");
            var mealMgr = new XmlNamespaceManager(meals.NameTable);
            mealMgr.AddNamespace("a", "");

            XmlDocument menus = new XmlDocument();
            menus.Load("menus.xml");
            var menuMgr = new XmlNamespaceManager(menus.NameTable);
            menuMgr.AddNamespace("a", "");

            XmlNodeList mealNodes = menus.SelectNodes("//a:menus/menu[@id='" + menuId + "']/meals/meal", menuMgr);
            List<String> mealIds = new List<String>();
            foreach(XmlNode node in mealNodes) {
                mealIds.Add(node.Attributes["id"].Value);
            }

            foreach (String id in mealIds)
            {
                XmlNode meal = meals.SelectSingleNode("//a:meals/meal[@id='" + id + "']", mealMgr);
                XmlNodeList items = meals.SelectNodes("//a:meals/meal[@id='" + id + "']/menuItems/menuItem", mealMgr);
                switch (meal.Attributes["type"].Value)
                {
                    case "Breakfast":
                        foreach (XmlNode item in items)
                        {
                            breakfastItems.Add(parseItem(item.Attributes["id"].Value));
                        }
                        break;
                    case "Lunch":
                        foreach (XmlNode item in items)
                        {
                            lunchItems.Add(parseItem(item.Attributes["id"].Value));
                        }
                        break;
                    case "Snack":
                        foreach (XmlNode item in items)
                        {
                            snackItems.Add(parseItem(item.Attributes["id"].Value));
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private Item parseItem(String id)
        {
            XmlDocument items = new XmlDocument();
            items.Load("menuItems.xml");
            var mgr = new XmlNamespaceManager(items.NameTable);
            mgr.AddNamespace("a", "");

            XmlNode item = items.SelectSingleNode("//a:menuItems/menuItem[@id='" + id + "']", mgr);

            Item parsedItem = new Item(
                item.Attributes["id"].Value,
                item.Attributes["name"].Value,
                item.ChildNodes[1].InnerText,
                item.ChildNodes[1].Attributes["units"].Value,
                item.ChildNodes[3].ChildNodes[0].InnerText,
                item.ChildNodes[3].ChildNodes[1].InnerText,
                item.ChildNodes[3].ChildNodes[2].InnerText,
                item.ChildNodes[3].ChildNodes[3].InnerText,
                item.ChildNodes[3].ChildNodes[4].InnerText,
                item.ChildNodes[3].ChildNodes[5].InnerText,
                item.ChildNodes[3].ChildNodes[6].InnerText,
                item.ChildNodes[3].ChildNodes[7].InnerText,
                item.ChildNodes[3].ChildNodes[8].InnerText,
                item.ChildNodes[3].ChildNodes[9].InnerText
                );

            return parsedItem;

        }

        public String getDate()
        {
            return date;
        }

        public String getParsedDate()
        {
            return date.Replace("/", "_");
        }

        public List<Item> getBreakfastItemList() 
        {
            return breakfastItems;
        }

        public List<Item> getLunchItemList()
        {
            return lunchItems;
        }

        public List<Item> getSnackItemList()
        {
            return snackItems;
        }

        public String getComments()
        {
            return comments;
        }

        public String getBreakfastStudentTotal()
        {
            int result = 0;
            for (int i = 0; i < 3; i++)
            {
                result += breakfastCount[i];
            }

            return result.ToString();
        }

        public String getBreakfastProjectedReimburseable()
        {
            return roundUp(Int32.Parse(this.getBreakfastStudentTotal())).ToString();
        }

        public String getLunchStudentTotal()
        {
            int result = 0;
            for (int i = 0; i < 3; i++)
            {
                result += lunchCount[i];
            }

            return result.ToString();
        }
        public String getLunchProjectedReimburseable()
        {
            return roundUp(Int32.Parse(this.getLunchStudentTotal())).ToString();
        }
        public String getSnackStudentTotal()
        {
            int result = 0;
            for (int i = 0; i < 3; i++)
            {
                result += snackCount[i];
            }

            return result.ToString();
        }
        public String getSnackProjectedReimburseable()
        {
            return roundUp(Int32.Parse(this.getSnackStudentTotal())).ToString();
        }
        public String getBreakfastNonReimburseable()
        {
            return breakfastCount[3].ToString();
        }

        public String getLunchNonReimburseable()
        {
            return lunchCount[3].ToString();
        }

        public String getSnackNonReimburseable()
        {
            return snackCount[3].ToString();
        }

        public String getBreakfastTotalProjected()
        {
            return roundUp((Int32.Parse(this.getBreakfastStudentTotal()) + Int32.Parse(this.getBreakfastNonReimburseable()))).ToString();
        }

        public String getBreakfastTotalProduced()
        {
            return (Int32.Parse(this.getBreakfastStudentTotal()) + Int32.Parse(this.getBreakfastNonReimburseable())).ToString();
        }

        public String getBreakfastWaste()
        {
            return (Int32.Parse(this.getBreakfastTotalProjected()) - Int32.Parse(this.getBreakfastTotalProduced())).ToString();
        }

        public String getLunchTotalProjected()
        {
            return roundUp((Int32.Parse(this.getLunchStudentTotal()) + Int32.Parse(this.getLunchNonReimburseable()))).ToString();
        }

        public String getLunchTotalProduced()
        {
            return (Int32.Parse(this.getLunchStudentTotal()) + Int32.Parse(this.getLunchNonReimburseable())).ToString();
        }

        public String getLunchWaste()
        {
            return (Int32.Parse(this.getLunchTotalProjected()) - Int32.Parse(this.getLunchTotalProduced())).ToString();
        }

        public String getSnackTotalProjected()
        {
            return roundUp((Int32.Parse(this.getSnackStudentTotal()) + Int32.Parse(this.getSnackNonReimburseable()))).ToString();
        }

        public String getSnackTotalProduced()
        {
            return (Int32.Parse(this.getSnackStudentTotal()) + Int32.Parse(this.getSnackNonReimburseable())).ToString();
        }

        public String getSnackWaste()
        {
            return (Int32.Parse(this.getSnackTotalProjected()) - Int32.Parse(this.getSnackTotalProduced())).ToString();
        }

        private static int roundUp(int num)
        {
            double deci = num / 10;
            int val = (int)deci;
            return (val * 10) + 10;

        }
        public String testCounts()
        {
            String message = "Breakfast:";
            for (int i = 0; i < breakfastCount.Length; i++)
            {
                message = message + " " + breakfastCount[i];
            }

            message += "\nLunch:";
            for (int i = 0; i < breakfastCount.Length; i++)
            {
                message = message + " " + lunchCount[i];
            }

            message += "\nSnack:";
            for (int i = 0; i < breakfastCount.Length; i++)
            {
                message = message + " " + snackCount[i];
            }

            return message;
        }
        public String testItems()
        {
            String result = "Items";

            result += "\nBreakfast items: ";
            foreach (Item testItem in breakfastItems)
            {
                result += testItem.getName();
                result += ", ";
            }

            result += "\nLunch items: ";
            foreach (Item testItem in lunchItems)
            {
                result += testItem.getName();
                result += ", ";                
            }

            result += "\nSnack items: ";
            foreach (Item testItem in snackItems)
            {
                result += testItem.getName();
                result += ", ";
            }

            return result;
        }
    }
}

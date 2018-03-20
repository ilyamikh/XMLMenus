using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLMenus
{
    public partial class ReportGenerator : Form
    {
        public ReportGenerator()
        {
            InitializeComponent();
        }

        private void ReportGenerator_Load(object sender, EventArgs e)
        {
            dateLabel.Text += this.Tag.ToString();
        }

        private void createReportButton_Click(object sender, EventArgs e)
        {
            String rawTag = this.Tag.ToString();
            String[] splitTag = rawTag.Split(':');
            String rawDate = splitTag[0];
            String monthFilename = splitTag[1];
            //MessageBox.Show("rawDate = " + rawDate + ", monthFilename = " + monthFilename);
            Report makeReport = new Report(monthFilename, rawDate, commentsTextBox.Text);
            generateReport(makeReport);
            this.Close();
        }

        private void generateReport(Report data)
        {   
            String currentPath = System.IO.Directory.GetCurrentDirectory();          
            System.IO.Directory.CreateDirectory(currentPath + "\\ProductionReports_" + data.getParsedDate());
            System.IO.Directory.CreateDirectory(currentPath + "\\DailyMenus");
            copyStyleSheet(data.getParsedDate());

            String template = System.IO.File.ReadAllText(currentPath + "\\default.html");
            String childLoop = System.IO.File.ReadAllText(currentPath + "\\loop.txt");
            String menuTemplate = System.IO.File.ReadAllText(currentPath + "\\menuTemplate.html");

            String breakfastReport = populateHeader(template, "Breakfast", data.getComments(), data.getBreakfastStudentTotal(), data.getBreakfastNonReimburseable(), data.getDate());
            String lunchReport = populateHeader(template, "Lunch", data.getComments(), data.getLunchStudentTotal(), data.getLunchNonReimburseable(), data.getDate());
            String snackReport = populateHeader(template, "Snack", data.getComments(), data.getSnackStudentTotal(), data.getSnackNonReimburseable(), data.getDate());

            breakfastReport = insertBreakfastItems(breakfastReport, data, childLoop);
            lunchReport = insertLunchItems(lunchReport, data, childLoop);
            snackReport = insertSnackItems(snackReport, data, childLoop);
            String dailyMenu = getDailyMenu(data, menuTemplate);


            String filePath = currentPath + "\\ProductionReports_" + data.getParsedDate() + "\\" + "Breakfast" + "_" + data.getParsedDate() + ".html";
            System.IO.File.WriteAllText(filePath, breakfastReport);

            filePath = currentPath + "\\ProductionReports_" + data.getParsedDate() + "\\" + "Lunch" + "_" + data.getParsedDate() + ".html";
            System.IO.File.WriteAllText(filePath, lunchReport);

            filePath = currentPath + "\\ProductionReports_" + data.getParsedDate() + "\\" + "Snack" + "_" + data.getParsedDate() + ".html";
            System.IO.File.WriteAllText(filePath, snackReport);

            String menuPath = currentPath + "\\DailyMenus\\" + data.getParsedDate() + ".html";
            System.IO.File.WriteAllText(menuPath, dailyMenu);

            MessageBox.Show("Output saved to " + currentPath + "\\ProductionReports_" + data.getParsedDate());

        }

        private String getDailyMenu(Report data, String template)
        {
            String result = template;
            DateTime currentDate = DateTime.Parse(data.getDate());
            result = result.Replace("<!--DATE-->", ("Menu for " + currentDate.DayOfWeek + ", " + currentDate.Month + " " + currentDate.Day + ", " + currentDate.Year));

            String tempMenu = itemsAsText(data.getBreakfastItemList());
            result = result.Replace("<!--BREAKFAST DATA-->", tempMenu);
            tempMenu = itemsAsText(data.getLunchItemList());
            result = result.Replace("<!--LUNCH DATA-->", tempMenu);
            tempMenu = itemsAsText(data.getSnackItemList());
            result = result.Replace("<!--SNACK DATA-->", tempMenu);

            return result;
        }

        private String itemsAsText(List<Item> items)
        {
            String result = "";

            foreach(Item current in items)
            {
                result += (current.getName() + "<br />");
            }

            return result;
        }

        private String insertBreakfastItems(String breakfastReport, Report rawData, String loop)
        {
            String result = breakfastReport;

            int currentIndex = 0;
            String row;
            foreach (Item breakfastItem in rawData.getBreakfastItemList())
            {
                currentIndex = result.IndexOf("<!--ROW START-->");
                row = loop;
                row = row.Replace("<!--Menu Item-->", breakfastItem.getName());
                row = row.Replace("<!--Planned Portion Size-->", breakfastItem.getServing());
                row = row.Replace("<!--Planned # of Reimburseable Servings-->", rawData.getBreakfastProjectedReimburseable());
                row = row.Replace("<!--Total Projected Servings-->", rawData.getBreakfastTotalProjected());
                row = row.Replace("<!--Meat/Meat Alt.-->", breakfastItem.getContrib(0));
                row = row.Replace("<!--Grains-->", breakfastItem.getContrib(1));
                row = row.Replace("<!--Fruit-->", breakfastItem.getContrib(2));
                row = row.Replace("<!--Dk. Green Veg.-->", breakfastItem.getContrib(3));
                row = row.Replace("<!--R/O Veg.-->", breakfastItem.getContrib(4));
                row = row.Replace("<!--Legumes-->", breakfastItem.getContrib(5));
                row = row.Replace("<!--Starchy Veg.-->", breakfastItem.getContrib(6));
                row = row.Replace("<!--Other Veg.-->", breakfastItem.getContrib(7));
                row = row.Replace("<!--Additional Veg.-->", breakfastItem.getContrib(8));
                row = row.Replace("<!--Total Veg.-->", breakfastItem.getContrib(9));
                row = row.Replace("<!--Servings Produced-->", rawData.getBreakfastTotalProduced());
                row = row.Replace("<!--Reimb. Servings-->", rawData.getBreakfastStudentTotal());
                row = row.Replace("<!--Non-Reimb. Servings-->", rawData.getBreakfastNonReimburseable());
                row = row.Replace("<!--Carryover-->", "0"); //maybe one day
                row = row.Replace("<!--Return to Stock-->", "0"); //but probably not. What about apple sauce and bagels and things like that?
                row = row.Replace("<!--Waste-->", rawData.getBreakfastWaste());

                result = result.Insert(currentIndex, row);

            }

            return result;
        }

        private String insertLunchItems(String lunchReport, Report rawData, String loop)
        {
            String result = lunchReport;

            int currentIndex = 0;
            String row;
            foreach (Item lunchItem in rawData.getLunchItemList())
            {
                currentIndex = result.IndexOf("<!--ROW START-->");
                row = loop;
                row = row.Replace("<!--Menu Item-->", lunchItem.getName());
                row = row.Replace("<!--Planned Portion Size-->", lunchItem.getServing());
                row = row.Replace("<!--Planned # of Reimburseable Servings-->", rawData.getLunchProjectedReimburseable());
                row = row.Replace("<!--Total Projected Servings-->", rawData.getLunchTotalProjected());
                row = row.Replace("<!--Meat/Meat Alt.-->", lunchItem.getContrib(0));
                row = row.Replace("<!--Grains-->", lunchItem.getContrib(1));
                row = row.Replace("<!--Fruit-->", lunchItem.getContrib(2));
                row = row.Replace("<!--Dk. Green Veg.-->", lunchItem.getContrib(3));
                row = row.Replace("<!--R/O Veg.-->", lunchItem.getContrib(4));
                row = row.Replace("<!--Legumes-->", lunchItem.getContrib(5));
                row = row.Replace("<!--Starchy Veg.-->", lunchItem.getContrib(6));
                row = row.Replace("<!--Other Veg.-->", lunchItem.getContrib(7));
                row = row.Replace("<!--Additional Veg.-->", lunchItem.getContrib(8));
                row = row.Replace("<!--Total Veg.-->", lunchItem.getContrib(9));
                row = row.Replace("<!--Servings Produced-->", rawData.getLunchTotalProduced());
                row = row.Replace("<!--Reimb. Servings-->", rawData.getLunchStudentTotal());
                row = row.Replace("<!--Non-Reimb. Servings-->", rawData.getLunchNonReimburseable());
                row = row.Replace("<!--Carryover-->", "0"); //maybe one day
                row = row.Replace("<!--Return to Stock-->", "0"); //but probably not. What about apple sauce and bagels and things like that?
                row = row.Replace("<!--Waste-->", rawData.getLunchWaste());

                result = result.Insert(currentIndex, row);

            }

            return result;
        }

        private String insertSnackItems(String snackReport, Report rawData, String loop)
        {
            String result = snackReport;

            int currentIndex = 0;
            String row;
            foreach (Item snackItem in rawData.getSnackItemList())
            {
                currentIndex = result.IndexOf("<!--ROW START-->");
                row = loop;
                row = row.Replace("<!--Menu Item-->", snackItem.getName());
                row = row.Replace("<!--Planned Portion Size-->", snackItem.getServing());
                row = row.Replace("<!--Planned # of Reimburseable Servings-->", rawData.getSnackProjectedReimburseable());
                row = row.Replace("<!--Total Projected Servings-->", rawData.getSnackTotalProjected());
                row = row.Replace("<!--Meat/Meat Alt.-->", snackItem.getContrib(0));
                row = row.Replace("<!--Grains-->", snackItem.getContrib(1));
                row = row.Replace("<!--Fruit-->", snackItem.getContrib(2));
                row = row.Replace("<!--Dk. Green Veg.-->", snackItem.getContrib(3));
                row = row.Replace("<!--R/O Veg.-->", snackItem.getContrib(4));
                row = row.Replace("<!--Legumes-->", snackItem.getContrib(5));
                row = row.Replace("<!--Starchy Veg.-->", snackItem.getContrib(6));
                row = row.Replace("<!--Other Veg.-->", snackItem.getContrib(7));
                row = row.Replace("<!--Additional Veg.-->", snackItem.getContrib(8));
                row = row.Replace("<!--Total Veg.-->", snackItem.getContrib(9));
                row = row.Replace("<!--Servings Produced-->", rawData.getSnackTotalProduced());
                row = row.Replace("<!--Reimb. Servings-->", rawData.getSnackStudentTotal());
                row = row.Replace("<!--Non-Reimb. Servings-->", rawData.getSnackNonReimburseable());
                row = row.Replace("<!--Carryover-->", "0"); //maybe one day
                row = row.Replace("<!--Return to Stock-->", "0"); //but probably not. What about apple sauce and bagels and things like that?
                row = row.Replace("<!--Waste-->", rawData.getSnackWaste());

                result = result.Insert(currentIndex, row);

            }

            return result;
        }

        private void copyStyleSheet(String date)
        {
            String path = System.IO.Directory.GetCurrentDirectory();
            String sheet = System.IO.File.ReadAllText(path + "\\default.css");
            String filePath = (path + "\\ProductionReports_" + date + "\\default.css");
            System.IO.File.WriteAllText(filePath, sheet);
        }

        private String populateHeader(String file, String mealType, String comments, String studentMeals, String nonReimbMeals, String date)
        {
            int insertIndex = 0;

            insertIndex = file.IndexOf("<!--DATE-->");
            file = file.Insert(insertIndex, date);

            insertIndex = file.IndexOf("<!--MEAL-->");
            file = file.Insert(insertIndex, mealType);

            insertIndex = file.IndexOf("<!-- COMMENTS-->");
            file = file.Insert(insertIndex, comments);

            insertIndex = file.IndexOf("<!--STUDENT MEALS PLANNED-->");
            int studentMealsPlanned = Int32.Parse(studentMeals);
            studentMealsPlanned = roundUp(studentMealsPlanned);
            file = file.Insert(insertIndex, studentMealsPlanned.ToString());

            insertIndex = file.IndexOf("<!--STUDENT MEALS SERVED-->");
            file = file.Insert(insertIndex, studentMeals);

            insertIndex = file.IndexOf("<!--NON-REIMBURSEABLE MEALS PLANNED -->");
            file = file.Insert(insertIndex, nonReimbMeals);

            insertIndex = file.IndexOf("<!--NON-REIMBURSEABLE MEALS SERVED-->");
            file = file.Insert(insertIndex, nonReimbMeals);

            int totalPlanned = studentMealsPlanned + Int32.Parse(nonReimbMeals);
            insertIndex = file.IndexOf("<!--TOTAL MEALS PLANNED-->");
            file = file.Insert(insertIndex, totalPlanned.ToString());

            int totalServed = Int32.Parse(studentMeals) + Int32.Parse(nonReimbMeals);
            insertIndex = file.IndexOf("<!--TOTAL MEALS SERVED-->");
            file = file.Insert(insertIndex, totalServed.ToString());

            return file;
        }

        private static int roundUp(int num)
        {
            double deci = num / 10;
            int val = (int)deci;
            return (val * 10) + 10;

        }
        private static string getTime()
        {
            return String.Format("{0:MM-dd-yyyy_hh-mm-ss}", DateTime.Now);
        }

    }
}

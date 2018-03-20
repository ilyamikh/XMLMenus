using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLMenus
{
    class Ingredient
    {
        int id;
        String name;
        float servingSize;
        String servingUnit;
        String foodDescription;
        float packageSize;
        String packageUnit;
        String packageDescription;

        public Ingredient(  
                            String inId,
                            String inName,
                            String inServSize,
                            String inServUnit, 
                            String inFoodDescription, 
                            String inPackSize,
                            String inPackUnit, //not sure why this should differ from serving units, but the one ingredient where this might somehow differ could cause problems so here it is.
                            String inPackDescription)
        {
            id = Int32.Parse(inId);
            name = inName;
            servingSize = float.Parse(inServSize);
            servingUnit = inServUnit;
            foodDescription = inFoodDescription;
            packageSize = float.Parse(inPackSize);
            packageUnit = inPackUnit;
            packageDescription = inPackDescription;
        }

        public Ingredient(
                            String inName,
                            String inServSize,
                            String inServUnit,
                            String inFoodDescription,
                            String inPackSize,
                            String inPackUnit,
                            String inPackDescription)
        {
            id = 0;
            name = inName;
            servingSize = float.Parse(inServSize);
            servingUnit = inServUnit;
            foodDescription = inFoodDescription;
            packageSize = float.Parse(inPackSize);
            packageUnit = inPackUnit;
            packageDescription = inPackDescription;
        }
        //id overloaded setters and getters (what a pain in the ass, but hopefully will save some trouble later)
        public String getIdString() { return id.ToString(); }
        public int getId() { return id; }
        public void setId(String inString) { id = Int32.Parse(inString); }
        public void setId(int newId) { id = newId; }

        //string getters
        public String getName() { return name; }
        public String getServingSizeString() { return servingSize.ToString(); }
        public String getServingUnit() { return servingUnit; }
        public String getFoodDescription() { return foodDescription; }
        public String getPackageSizeString() { return packageSize.ToString(); }
        public String getPackageUnit() { return packageUnit; }
        public String getPackageDescription() { return packageDescription; }

        //actual number getters for calculations etc. Wonder if overloading is the best idea here. Update: it isn't; renaming
        public float getServingSize() { return servingSize; }
        public float getPackageSize() { return packageSize; }

        public String getString()
        {
            String output = "Food Name: " + name +
                            "\nServing Size: " + servingSize +
                            "\nServing Unit: " + servingUnit +
                            "\nDescription: " + foodDescription +
                            "\nPackage Size: " + packageSize +
                            "\nPackage Unit: " + packageUnit +
                            "\nPackage Description: " + packageDescription;
            return output;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLMenus
{
    class Item
    {
        private String id;
        private String name;
        private String servingSize;
        private String servingUnit;
        private String[] contributions = new String[10];

        public Item(
                    String inId,
                    String inName,
                    String inServSize,
                    String inServUnit,
                    String mtMtAlt,
                    String grains,
                    String fruit,
                    String dkGreenVg,
                    String roVeg,
                    String legumes,
                    String starchyVeg,
                    String otherVeg,
                    String addVeg,
                    String totalVeg)
        {
            id = inId;
            name = inName;
            servingSize = inServSize;
            servingUnit = inServUnit;
            contributions[0] = mtMtAlt;
            contributions[1] = grains;
            contributions[2] = fruit;
            contributions[3] = dkGreenVg;
            contributions[4] = roVeg;
            contributions[5] = legumes;
            contributions[6] = starchyVeg;
            contributions[7] = otherVeg;
            contributions[8] = addVeg;
            contributions[9] = totalVeg;
        }

        public String getName() { return name; }
        public String getServing() { return (servingSize + " " + servingUnit); }
        public String getContrib(int index) { return contributions[index]; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given two Dictionaries, Dictionary<string, int>, merge the two into a new Dictionary, Dictionary<string, int> where keys in Dictionary2,
         * and their int values, are added to the int values of matching keys in Dictionary1. Return the new Dictionary.
         *
         * Unmatched keys and their int values in Dictionary2 are simply added to Dictionary1.
         *
         * ConsolidateInventory({"SKU1": 100, "SKU2": 53, "SKU3": 44} {"SKU2":11, "SKU4": 5})
         * 	 → {"SKU1": 100, "SKU2": 64, "SKU3": 44, "SKU4": 5}
         *
         */
        public Dictionary<string, int> ConsolidateInventory(Dictionary<string, int> mainWarehouse,
            Dictionary<string, int> remoteWarehouse)

        {
            var totalWareHouse= mainWarehouse.Union(remoteWarehouse);
            Dictionary<string, int> Dic5 = new Dictionary<string, int>();

            foreach (KeyValuePair<string, int>keyValue in totalWareHouse)
            {
                if (!mainWarehouse.ContainsKey(keyValue.Key))
                {
                    mainWarehouse[keyValue.Key] = 0;
                }

                if (!remoteWarehouse.ContainsKey(keyValue.Key))
                {
                    remoteWarehouse[keyValue.Key] = 0;
                    Dic5[keyValue.Key] = mainWarehouse[keyValue.Key] + remoteWarehouse[keyValue.Key];
                }

            }return Dic5; //I found the name funny had to keep it going, im sorry.
       
        
        }
    }
}

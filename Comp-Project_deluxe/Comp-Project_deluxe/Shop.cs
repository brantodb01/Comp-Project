using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp_Project_deluxe
{
    class Shop : Room
    {
        public static Item shopItemA { get; set; }
        public static Item shopItemB { get; set; }
        public static Item shopItemC { get; set; }
        public static Item shopItemD { get; set; }
        public ShopForm vShop = new ShopForm();

        public Shop()
        {
            shopItemA = new Dagger(5,5,5);
            shopItemB = new Dagger(10,10,10);
            shopItemC = new Dagger(15,15,15);
            shopItemD = new Dagger(20,20,20);
        }
    
    }
}

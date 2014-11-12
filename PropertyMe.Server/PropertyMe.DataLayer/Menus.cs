using PropertyMe.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PropertyMe.DataLayer
{
    public class Menus
    {
        public BaseListItem[] getMenuItems()
        {
            return new BaseListItem[] {
                new BaseListItem(){ ID = 1, Name = "For Sale"},
                new BaseListItem(){ ID = 2, Name = "To Rent"}, 
                new BaseListItem(){ ID = 3, Name = "Map Search"}, 
                new BaseListItem(){ ID = 4, Name = "Favourites"}, 
                new BaseListItem(){ ID = 5, Name = "Ref Search" }
            };
        }
    }
}

using PropertyMe.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PropertyMe.DataLayer
{
    public class CategoryManager
    {
        public List<Category> GetCategories()
        {
            return new List<Category>()
            {
                new Category (){ ID=1,Name="Apartment/Flat"},
                new Category (){ ID=2,Name="Commercial"},
                new Category (){ ID=3,Name="Farm"},
                new Category (){ ID=4,Name="House"},
                new Category (){ ID=5,Name="Industrial Property"},
                new Category (){ ID=6,Name="Townhouse"},
                new Category (){ ID=7,Name="Vacant Land/Plot"},
            };
        }

    }
}
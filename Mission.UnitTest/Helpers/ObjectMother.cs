using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lektion13.Domain.Entities;

namespace Lektion13.Tests.Helpers
{
    public class ObjectMother
    {
        public static User Test1Category
        {
            get 
            {
                return new User { ID = 1, Name = "Test1" };
            }
        }

        public static User Test2Category
        {
            get
            {
                return new User { ID = 2, Name = "Test2" };
            }
        }

        public static User Test3Category
        {
            get
            {
                return new User { ID = 3, Name = "Test3" };
            }
        }

        public static Post Test1Product
        {
            get
            {
                return new Post { ID = 1, Name = "Product1", Description = "Desc1", Price = 1.0M, Category = Test1Category, CategoryID = Test1Category.ID };
            }
        }

        public static Post Test2Product
        {
            get
            {
                return new Post { ID = 2, Name = "Product2", Description = "Desc2", Price = 20.0M, Category = Test2Category, CategoryID = Test2Category.ID };
            }
        }

        public static Post Test3Product
        {
            get
            {
                return new Post { ID = 3, Name = "Product3", Description = "Desc3", Price = 300.0M, Category = Test1Category, CategoryID = Test1Category.ID };
            }
        }

        public static Post Test4Product
        {
            get
            {
                return new Post { ID = 4, Name = "Product4", Description = "Desc4", Price = 4000.0M, Category = Test2Category, CategoryID = Test2Category.ID };
            }
        }

        public static Post Test5Product
        {
            get
            {
                return new Post { ID = 5, Name = "Product5", Description = "Desc5", Price = 50000.0M, Category = Test1Category, CategoryID = Test1Category.ID };
            }
        }

        public static List<Post> ProductList_5Products_Test1AndTest2Categories
        {
            get
            {
                return new List<Post> {
                    Test1Product,
                    Test2Product,
                    Test3Product,
                    Test4Product,
                    Test5Product,
                };
            }
        }
    }
}

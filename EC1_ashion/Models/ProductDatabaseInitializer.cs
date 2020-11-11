using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EC1_ashion.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseAlways<ProductContext> //IfModelChanges  Always
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
            GetShoeSize().ForEach(ss => context.ShoeSizes.Add(ss));
            GetPantsSize().ForEach(ps => context.PantsSizes.Add(ps));
            GetTopSize().ForEach(ts => context.TopSizes.Add(ts));
            GetColor().ForEach(cl => context.Colors.Add(cl));
            //GetJM2M().ForEach(j => context.M2Ms.Add(j));
        }
        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category{
                    CategoryID = 1,
                    CategoryName = "Women's Fashion",
                    CategoryImagePath = "category-1.jpg",
                    Description = "",
                    AmountOfItems = 9,
                },
                new Category{
                    CategoryID = 2,
                    CategoryName = "Men's fashion",
                    CategoryImagePath = "category-2.jpg",
                    Description = "",
                    AmountOfItems = 9,
                },
                new Category{
                    CategoryID = 3,
                    CategoryName = "Kid's fashion",
                    CategoryImagePath = "category-3.jpg",
                    Description = "",
                    AmountOfItems = 9,
                },
                new Category{
                    CategoryID = 4,
                    CategoryName = "Comestics",
                    CategoryImagePath = "category-4.jpg",
                    Description = "",
                    AmountOfItems = 4,
                },
                new Category{
                    CategoryID = 5,
                    CategoryName = "Accessories",
                    CategoryImagePath = "category-5.jpg",
                    Description = "",
                    AmountOfItems = 4,
                }
            };
            return categories;
        }
        private static List<ShoeSize> GetShoeSize()
        {
            var shoesizes = new List<ShoeSize> {
                new ShoeSize{
                    ShoeSizeID = 1,
                    ShoeSizeName = "3",
                },
                new ShoeSize{
                    ShoeSizeID = 2,
                    ShoeSizeName = "3 1/2",
                },
                new ShoeSize{
                    ShoeSizeID = 3,
                    ShoeSizeName = "4",
                },
                new ShoeSize{
                    ShoeSizeID = 4,
                    ShoeSizeName = "4 1/2",
                },
                new ShoeSize{
                    ShoeSizeID = 5,
                    ShoeSizeName = "5",
                },
                new ShoeSize{
                    ShoeSizeID = 6,
                    ShoeSizeName = "5 1/2",
                },
                new ShoeSize{
                    ShoeSizeID = 7,
                    ShoeSizeName = "6",
                },
                new ShoeSize{
                    ShoeSizeID = 8,
                    ShoeSizeName = "6 1/2",
                },
                new ShoeSize{
                    ShoeSizeID = 9,
                    ShoeSizeName = "7",
                },
                new ShoeSize{
                    ShoeSizeID = 10,
                    ShoeSizeName = "7 1/2",
                },
                new ShoeSize{
                    ShoeSizeID = 11,
                    ShoeSizeName = "8",
                },
                new ShoeSize{
                    ShoeSizeID = 12,
                    ShoeSizeName = "8 1/2",
                },
                new ShoeSize{
                    ShoeSizeID = 13,
                    ShoeSizeName = "9",
                },
                new ShoeSize{
                    ShoeSizeID = 14,
                    ShoeSizeName = "9 1/2",
                },
                new ShoeSize{
                    ShoeSizeID = 15,
                    ShoeSizeName = "10",
                },
                new ShoeSize{
                    ShoeSizeID = 16,
                    ShoeSizeName = "10 1/2",
                },
                new ShoeSize{
                    ShoeSizeID = 17,
                    ShoeSizeName = "11",
                },
                new ShoeSize{
                    ShoeSizeID = 18,
                    ShoeSizeName = "11 1/2",
                },
                new ShoeSize{
                    ShoeSizeID = 19,
                    ShoeSizeName = "12",
                },
                new ShoeSize{
                    ShoeSizeID = 20,
                    ShoeSizeName = "12 1/2",
                },
                new ShoeSize{
                    ShoeSizeID = 21,
                    ShoeSizeName = "13",
                },
                new ShoeSize{
                    ShoeSizeID = 22,
                    ShoeSizeName = "13 1/2",
                },
                new ShoeSize{
                    ShoeSizeID = 23,
                    ShoeSizeName = "14",
                },
                new ShoeSize{
                    ShoeSizeID = 24,
                    ShoeSizeName = "14 1/2",
                },
                new ShoeSize{
                    ShoeSizeID = 25,
                    ShoeSizeName = "15",
                },
                new ShoeSize{
                    ShoeSizeID = 26,
                    ShoeSizeName = "15 1/2",
                },
                new ShoeSize{
                    ShoeSizeID = 27,
                    ShoeSizeName = "16",
                }
            };
            return shoesizes;
        }

        private static List<PantsSize> GetPantsSize()
        {
            var pantssizes = new List<PantsSize> {
                new PantsSize{
                    PantsSizeID = 1,
                    PantsSizeName = "24 - 25",
                },
                new PantsSize{
                    PantsSizeID = 2,
                    PantsSizeName = "25 - 26",
                },
                new PantsSize{
                    PantsSizeID = 3,
                    PantsSizeName = "27 - 28",
                },
                new PantsSize{
                    PantsSizeID = 4,
                    PantsSizeName = "28 - 29",
                },
                new PantsSize{
                    PantsSizeID = 5,
                    PantsSizeName = "29 - 30",
                },
                new PantsSize{
                    PantsSizeID = 6,
                    PantsSizeName = "31 - 32",
                },
                new PantsSize{
                    PantsSizeID = 7,
                    PantsSizeName = "33 - 34",
                },
                new PantsSize{
                    PantsSizeID = 8,
                    PantsSizeName = "35 - 37",
                },
                new PantsSize{
                    PantsSizeID = 9,
                    PantsSizeName = "38 - 39",
                },
                new PantsSize{
                    PantsSizeID = 10,
                    PantsSizeName = "40 - 41",
                },
                new PantsSize{
                    PantsSizeID = 12,
                    PantsSizeName = "42 - 43",
                },
                new PantsSize{
                    PantsSizeID = 13,
                    PantsSizeName = "44 - 46",
                },
                new PantsSize{
                    PantsSizeID = 14,
                    PantsSizeName = "47 - 49",
                },
                new PantsSize{
                    PantsSizeID = 15,
                    PantsSizeName = "50 - 52",
                },
                new PantsSize{
                    PantsSizeID = 16,
                    PantsSizeName = "53 - 55",
                }
            };
            return pantssizes;
        }
       
        private static List<TopSize> GetTopSize()
        {
            var topsizes = new List<TopSize> {
                new TopSize{
                    TopSizeID = 1,
                    TopSizeName = "XS",
                },
                new TopSize{
                    TopSizeID = 2,
                    TopSizeName = "SM",
                },
                new TopSize{
                    TopSizeID = 3,
                    TopSizeName = "MD",
                },
                new TopSize{
                    TopSizeID = 4,
                    TopSizeName = "L",
                },
                new TopSize{
                    TopSizeID = 5,
                    TopSizeName = "XL",
                },
                new TopSize{
                    TopSizeID = 6,
                    TopSizeName = "XXL",
                }
            };
            return topsizes;
        }

        private static List<Color> GetColor()
        {
            var colors = new List<Color> {
                new Color{
                    ColorID = 1,
                    ColorName = "Blue",
                },
                new Color{
                    ColorID = 2,
                    ColorName = "Red",
                },
                new Color{
                    ColorID = 3,
                    ColorName = "Green",
                },
                new Color{
                    ColorID = 4,
                    ColorName = "Yellow",
                },
                new Color{
                    ColorID = 5,
                    ColorName = "White",
                },
                new Color{
                    ColorID = 6,
                    ColorName = "Indigo",
                },
                new Color{
                    ColorID = 7,
                    ColorName = "Orange",
                },
                new Color{
                    ColorID = 8,
                    ColorName = "Brown",
                },
                new Color{
                    ColorID = 9,
                    ColorName = "Pink",
                },
                new Color{
                    ColorID = 10,
                    ColorName = "Black",
                }
            };
            return colors;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                /*Women - Blouse*/
                new Product{
                    ProductID = 1,
                    ProductName = "Jews",
                    Brand = "Joe",
                    Description = "Hello",
                    ImagePath1 = "product-1.jpg",
                    ImagePath2 = "",
                    ImagePath3 = "",
                    ImagePath4 = "",
                    UnitPrice = 100.00,
                    Discount = 0.1,/*10%*/
                    CategoryID = 1,
                },
                new Product{
                    ProductID = 2,
                    ProductName = "jkews",
                    Brand = "Jhoe",
                    Description = "Hello",
                    ImagePath1 = "product-3.jpg",
                    ImagePath2 = "",
                    ImagePath3 = "",
                    ImagePath4 = "",
                    UnitPrice = 100.00,
                    Discount = 0.1,/*10%*/
                    CategoryID = 2,
                },
                new Product{
                    ProductID = 3,
                    ProductName = "Jems",
                    Brand = "Nike",
                    Description = "Hello",
                    ImagePath1 = "product-4.jpg",
                    ImagePath2 = "",
                    ImagePath3 = "",
                    ImagePath4 = "",
                    UnitPrice = 100.00,
                    Discount = 0.1,/*10%*/
                    CategoryID = 5,
                },
                new Product{
                    ProductID = 4,
                    ProductName = "Watch",
                    Brand = "Nike",
                    Description = "Hello",
                    ImagePath1 = "product-5.jpg",
                    ImagePath2 = "",
                    ImagePath3 = "",
                    ImagePath4 = "",
                    UnitPrice = 100.00,
                    Discount = 0.1,/*10%*/
                    CategoryID = 5,
                }
            };
            return products;
        }
    }
    /*
        private static List<JM2M> GetJM2M()
        {
            var jm2ms = new List<JM2M> {
                new JM2M{
                    JM2MID = 1,
                    JM2MName = "",
                }
            };
            return jm2ms;
        }
        */
}
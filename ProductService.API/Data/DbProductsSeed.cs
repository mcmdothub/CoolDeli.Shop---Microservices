using ProductService.API.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProductService.API.Data
{
    public static class DbProductsSeed
    {
        public static void Initialize(ProductsDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Product.Any())
                return;

            var products = new List<Product>()
            {
                new Product { 
                    Name = "Tomato Toast “Ricotta”",                
                    Description = "Breakfast", 
                    Details = "Ut enim ad minim veniam, quis nostrud exerc.", 
                    Photo = @"https://www.nutmegnanny.com/wp-content/uploads/2018/07/ricotta-tomato-toast-3.jpg.webp", 
                    Price = 36.25M, 
                    Quantity = 100 
                },

                new Product { 
                    Name = "Avocado Toast with Egg",               
                    Description = "Breakfast", 
                    Details = "Ut enim ad minim veniam, quis nostrud exercitation .", 
                    Photo = @"https://feelgoodfoodie.net/wp-content/uploads/2019/01/Avocado-Toast-with-Egg-9.jpg", 
                    Price = 28.46M, 
                    Quantity = 0 
                },

                new Product {
                    Name = "Berry & Yogurt Smoothie",       
                    Description = "Breakfast", 
                    Details = "Ut enim ad minim veniam, quis nostrud exercitation.", 
                    Photo = @"https://i2.wp.com/chefsavvy.com/wp-content/uploads/20141219-DSC_0774.jpg?resize=665%2C1000&ssl=1", 
                    Price = 76.95M, Quantity = 100 
                },

                new Product { 
                    Name = "Berry Breakfast Parfait",                   
                    Description = "Breakfast", 
                    Details = "Ut enim ad minim veniam, quis nostrud exercitation .", 
                    Photo = @"https://tmbidigitalassetsazure.blob.core.windows.net/rms3-prod/attachments/37/1200x1200/exps135657_HC2379809B04_03_2b_WEB.jpg", 
                    Price = 13.15M, 
                    Quantity = 100 
                },

                new Product { 
                    Name = "Peanut Butter & Banana",                  
                    Description = "Breakfast", 
                    Details = "Ut enim ad minim veniam, quis nostrud exercitation .", 
                    Photo = @"https://hurrythefoodup.com/wp-content/uploads/2014/12/banana-peanut-butter-sandwich.jpg", 
                    Price = 32.12M, 
                    Quantity = 100 
                },

                new Product { 
                    Name = "Quinoa Fruit Salad",           
                    Description = "Breakfast", 
                    Details = "Ut enim ad minim veniam, quis nostrud exercit.", 
                    Photo = @"https://s23209.pcdn.co/wp-content/uploads/2013/08/IMG_1473edit1.jpg", 
                    Price = 76.29M, 
                    Quantity = 100 
                },

                new Product { 
                    Name = "Pumpkin Yogurt Parfait",           
                    Description = "Breakfast", 
                    Details = "Ut enim ad minim veniam, quis nostrud exercitatio.", 
                    Photo = @"https://healthynibblesandbits.com/wp-content/uploads/2014/09/Pumpkin-Yogurt-Parfait-FF3.jpg", 
                    Price = 26.99M,
                    Quantity = 100 
                },

                new Product {
                    Name = "The Ultimate Veggie",     
                    Description = "Lunch",
                    Details = "Ut enim ad minim veniam, quis nostrud exercitation ul.",
                    Photo = @"https://www.theawesomegreen.com/wp-content/uploads/2014/09/Beet-Burger.jpg",
                    Price = 36.20M,
                    Quantity = 100
                },

                new Product {
                    Name = "The plate of barbeque",
                    Description = "Lunch",
                    Details = "Ut enim ad minim veniam, quis nostrud exercitation u.",
                    Photo = @"http://www.texasmonthly.com/wp-content/uploads/2014/10/Come-and-Take-it-BBQ-02.jpg",
                    Price = 26.50M,
                    Quantity = 100
                },

                new Product {
                    Name = "Chicken grill with sauce",
                    Description = "Lunch",
                    Details = "Ut enim ad minim veniam, quis nostrud exercitation u.",
                    Photo = @"https://noshingwiththenolands.com/wp-content/uploads/2017/06/Grilled-Chicken-with-Homemade-BBQ-Sauce-4.jpg",
                    Price = 67.50M,
                    Quantity = 100
                },

                new Product {
                    Name = "The Ultimate Veggie",
                    Description = "Dinner",
                    Details = "Ut enim ad minim veniam, quis nostrud exercitation u.",
                    Photo = @"https://www.simmerandsauce.com/wp-content/uploads/2017/03/IMG_9389.jpg",
                    Price = 52.50M,
                    Quantity = 100
                },

                new Product {
                    Name = "Chicken grill with sauce",
                    Description = "Dinner",
                    Details = "Ut enim ad minim veniam, quis nostrud exercitation u.",
                    Photo = @"https://noshingwiththenolands.com/wp-content/uploads/2017/06/Grilled-Chicken-with-Homemade-BBQ-Sauce-4.jpg",
                    Price = 46.50M,
                    Quantity = 100
                },

                new Product {
                    Name = "Quinoa Fruit Salad",
                    Description = "Dinner",
                    Details = "Ut enim ad minim veniam, quis nostrud exercitation u.",
                    Photo = @"https://www.twopeasandtheirpod.com/wp-content/uploads/2012/06/Quinoa-Fruit-Salad.jpg",
                    Price = 56.50M,
                    Quantity = 100
                },

                new Product {
                    Name = "Avocado Toast with Egg",
                    Description = "Dinner",
                    Details = "Ut enim ad minim veniam, quis nostrud exercitation u.",
                    Photo = @"https://www.skinnytaste.com/wp-content/uploads/2015/01/AvocadoToastwithEgg-2-550x804.jpg",
                    Price = 26.50M,
                    Quantity = 100
                },
            };

            foreach (var product in products)
                context.Add(product);

            context.SaveChanges();

        }
    }
}

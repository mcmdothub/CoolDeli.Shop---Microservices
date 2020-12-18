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
                    Photo = @"~/assets/images/menu1.jpg", 
                    Price = 36.25M, 
                    Quantity = 100 
                },

                new Product { 
                    Name = "Avocado Toast with Egg",               
                    Description = "Breakfast", 
                    Details = "Ut enim ad minim veniam, quis nostrud exercitation .", 
                    Photo = @"https://image.tmdb.org/t/p/w1280/8WUVHemHFH2ZIP6NWkwlHWsyrEL.jpg", 
                    Price = 28.46M, 
                    Quantity = 0 
                },

                new Product { 
                    Name = "Nut, Banana & Seed Toast",      
                    Description = "Breakfast", 
                    Details = "Ut enim ad minim veniam, quis nostrud exercitat.", 
                    Photo = @"https://image.tmdb.org/t/p/w1280/aQvJ5WPzZgYVDrxLX4R6cLJCEaQ.jpg", 
                    Price = 18.99M, 
                    Quantity = 100 
                },

                new Product {
                    Name = "Berry & Yogurt Smoothie",       
                    Description = "Breakfast", 
                    Details = "Ut enim ad minim veniam, quis nostrud exercitation.", 
                    Photo = @"https://www.expob2b.es/uploads/fotos_noticias/6418-1405962887.jpg", 
                    Price = 76.95M, Quantity = 100 
                },

                new Product { 
                    Name = "Berry Breakfast Parfait",                   
                    Description = "Breakfast", 
                    Details = "Ut enim ad minim veniam, quis nostrud exercitation .", 
                    Photo = @"https://image.tmdb.org/t/p/w1280/jHo2M1OiH9Re33jYtUQdfzPeUkx.jpg", 
                    Price = 13.15M, 
                    Quantity = 100 
                },

                new Product { 
                    Name = "Peanut Butter & Banana",                  
                    Description = "Breakfast", 
                    Details = "Ut enim ad minim veniam, quis nostrud exercitation .", 
                    Photo = @"https://image.tmdb.org/t/p/w1280/udDclJoHjfjb8Ekgsd4FDteOkCU.jpg", 
                    Price = 32.12M, 
                    Quantity = 100 
                },

                new Product { 
                    Name = "Quinoa Fruit Salad",           
                    Description = "Breakfast", 
                    Details = "Ut enim ad minim veniam, quis nostrud exercit.", 
                    Photo = @"https://image.tmdb.org/t/p/w1280/5jdLnvALCpK1NkeQU1z4YvOe2dZ.jpg", 
                    Price = 76.29M, 
                    Quantity = 100 
                },

                new Product { 
                    Name = "Pumpkin Yogurt Parfait",           
                    Description = "Breakfast", 
                    Details = "Ut enim ad minim veniam, quis nostrud exercitatio.", 
                    Photo = @"https://image.tmdb.org/t/p/w1280/h4VB6m0RwcicVEZvzftYZyKXs6K.jpg", 
                    Price = 26.99M,
                    Quantity = 100 
                },

                new Product {
                    Name = "Grilled Lamb & Feta Pita",
                    Description = "Lunch",
                    Details = "Ut enim ad minim veniam, quis nostrud exercitatio.",
                    Photo = @"https://image.tmdb.org/t/p/w1280/iZf0KyrE25z1sage4SYFLCCrMi9.jpg",
                    Price = 63.20M,
                    Quantity = 0
                },

                new Product {
                    Name = "The Ultimate Veggie",     
                    Description = "Lunch",
                    Details = "Ut enim ad minim veniam, quis nostrud exercitation ul.",
                    Photo = @"https://image.tmdb.org/t/p/w1280/qa6HCwP4Z15l3hpsASz3auugEW6.jpg",
                    Price = 36.20M,
                    Quantity = 100
                },

                new Product { 
                    Name = "Chicken Salad Lunch Box",       
                    Description = "Lunch",
                    Details = "Ut enim ad minim veniam, quis nostrud exercitation u.",
                    Photo = @"https://image.tmdb.org/t/p/w1280/niyXFhGIk4W2WTcX2Eod8vx2Mfe.jpg", 
                    Price = 23.50M, 
                    Quantity = 100 
                },

                new Product {
                    Name = "Coriander Chicken and Rice",
                    Description = "Lunch",
                    Details = "Ut enim ad minim veniam, quis nostrud exercitation u.",
                    Photo = @"https://image.tmdb.org/t/p/w1280/niyXFhGIk4W2WTcX2Eod8vx2Mfe.jpg",
                    Price = 46.50M,
                    Quantity = 100
                },

                new Product {
                    Name = "The plate of barbeque",
                    Description = "Lunch",
                    Details = "Ut enim ad minim veniam, quis nostrud exercitation u.",
                    Photo = @"https://image.tmdb.org/t/p/w1280/niyXFhGIk4W2WTcX2Eod8vx2Mfe.jpg",
                    Price = 26.50M,
                    Quantity = 100
                },

                new Product {
                    Name = "Chicken grill with sauce",
                    Description = "Lunch",
                    Details = "Ut enim ad minim veniam, quis nostrud exercitation u.",
                    Photo = @"https://image.tmdb.org/t/p/w1280/niyXFhGIk4W2WTcX2Eod8vx2Mfe.jpg",
                    Price = 67.50M,
                    Quantity = 100
                },

                new Product {
                    Name = "The Ultimate Veggie",
                    Description = "Dinner",
                    Details = "Ut enim ad minim veniam, quis nostrud exercitation u.",
                    Photo = @"https://image.tmdb.org/t/p/w1280/niyXFhGIk4W2WTcX2Eod8vx2Mfe.jpg",
                    Price = 52.50M,
                    Quantity = 100
                },

                new Product {
                    Name = "Chicken grill with sauce",
                    Description = "Dinner",
                    Details = "Ut enim ad minim veniam, quis nostrud exercitation u.",
                    Photo = @"https://image.tmdb.org/t/p/w1280/niyXFhGIk4W2WTcX2Eod8vx2Mfe.jpg",
                    Price = 46.50M,
                    Quantity = 100
                },

                new Product {
                    Name = "Quinoa Fruit Salad",
                    Description = "Dinner",
                    Details = "Ut enim ad minim veniam, quis nostrud exercitation u.",
                    Photo = @"https://image.tmdb.org/t/p/w1280/niyXFhGIk4W2WTcX2Eod8vx2Mfe.jpg",
                    Price = 56.50M,
                    Quantity = 100
                },

                new Product {
                    Name = "Avocado Toast with Egg",
                    Description = "Dinner",
                    Details = "Ut enim ad minim veniam, quis nostrud exercitation u.",
                    Photo = @"https://image.tmdb.org/t/p/w1280/niyXFhGIk4W2WTcX2Eod8vx2Mfe.jpg",
                    Price = 26.50M,
                    Quantity = 100
                },

                new Product {
                    Name = "Tomato Toast Ricotta",
                    Description = "Dinner",
                    Details = "Ut enim ad minim veniam, quis nostrud exercitation u.",
                    Photo = @"https://image.tmdb.org/t/p/w1280/niyXFhGIk4W2WTcX2Eod8vx2Mfe.jpg",
                    Price = 26.50M,
                    Quantity = 100
                },

                new Product {
                    Name = "Grilled Lamb & Feta Pita",
                    Description = "Dinner",
                    Details = "Ut enim ad minim veniam, quis nostrud exercitation u.",
                    Photo = @"https://image.tmdb.org/t/p/w1280/niyXFhGIk4W2WTcX2Eod8vx2Mfe.jpg",
                    Price = 72.50M,
                    Quantity = 100
                }
            };

            foreach (var product in products)
                context.Add(product);

            context.SaveChanges();

        }
    }
}

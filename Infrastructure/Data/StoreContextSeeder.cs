using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class StoreContextSeeder
    {
        public void SeedAsync(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductBrand>().HasData(
                    new ProductBrand { Id = 1, Name = "Angular" },
                    new ProductBrand { Id = 2, Name = "NetCore" },
                    new ProductBrand { Id = 3, Name = "VS Code" },
                    new ProductBrand { Id = 4, Name = "React" },
                    new ProductBrand { Id = 5, Name = "Typescript" },
                    new ProductBrand { Id = 6, Name = "Redis" }
            );
            modelBuilder.Entity<ProductType>().HasData(
                    new ProductBrand { Id = 1, Name = "Boards" },
                    new ProductBrand { Id = 2, Name = "Hats" },
                    new ProductBrand { Id = 3, Name = "Boots" },
                    new ProductBrand { Id = 4, Name = "Gloves" }
            );
            modelBuilder.Entity<Product>().HasData(
                    new Product { Id = 1, Name = "Angular Speedster Board 2000", Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.", Price = 200 , PictureUrl = "images/products/sb-ang1.png", ProductTypeId = 1, ProductBrandId = 1 },
                    new Product { Id = 2, Name = "Green Angular Board 3000", Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.", Price = 150 , PictureUrl = "images/products/sb-ang2.png", ProductTypeId = 1, ProductBrandId = 1 },
                    new Product { Id = 3, Name = "Core Board Speed Rush 3", Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.", Price = 180 , PictureUrl = "images/products/sb-core1.png", ProductTypeId = 1, ProductBrandId = 2 },
                    new Product { Id = 4, Name = "Net Core Super Board", Description = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.", Price = 300 , PictureUrl = "images/products/sb-core2.png", ProductTypeId = 1, ProductBrandId = 2 },
                    new Product { Id = 5, Name = "React Board Supper Whizzy Fast", Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.", Price = 250 , PictureUrl = "images/products/sb-react1.png", ProductTypeId = 1, ProductBrandId = 4 },
                    new Product { Id = 6, Name = "Typescript Entry Board", Description = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue.", Price = 120 , PictureUrl = "images/products/sb-ts1.png", ProductTypeId = 1, ProductBrandId = 5 },
                    new Product { Id = 7, Name = "Core Maroon Hat", Description = "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.", Price = 10 , PictureUrl = "images/products/hat-core1.png", ProductTypeId = 2, ProductBrandId = 2 },
                    new Product { Id = 8, Name = "Greaan React Woolen Hat", Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.", Price = 8 , PictureUrl = "images/products/hat-react1.png", ProductTypeId = 2, ProductBrandId = 4 },
                    new Product { Id = 9, Name = "Blue React Woolen Hat", Description = "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.", Price = 15 , PictureUrl = "images/products/hat-react2.png", ProductTypeId = 2, ProductBrandId = 4 },
                    new Product { Id = 10, Name = "Bliue Code Gloves", Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.", Price = 18 , PictureUrl = "images/products/glove-code1.png", ProductTypeId = 4, ProductBrandId = 3 },
                    new Product { Id = 11, Name = "Green Code Gloves", Description = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.", Price = 15 , PictureUrl = "images/products/glove-code2.png", ProductTypeId = 4, ProductBrandId = 3 },
                    new Product { Id = 12, Name = "Purple React Gloves", Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. ", Price = 16 , PictureUrl = "images/products/glove-react1.png", ProductTypeId = 4, ProductBrandId = 4 },
                    new Product { Id = 13, Name = "Green React Gloves", Description = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.", Price = 14 , PictureUrl = "images/products/glove-react2.png", ProductTypeId = 4, ProductBrandId = 4 },
                    new Product { Id = 14, Name = "Redis Red Boots", Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.", Price = 250 , PictureUrl = "images/products/boot-redis1.png", ProductTypeId = 3, ProductBrandId = 6 },
                    new Product { Id = 15, Name = "Core Red Boots", Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.", Price = 189, PictureUrl = "images/products/boot-core2.png", ProductTypeId = 3, ProductBrandId = 2 },
                    new Product { Id = 16, Name = "Core Purple Boots", Description = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.", Price = 199, PictureUrl = "images/products/boot-core1.png", ProductTypeId = 3, ProductBrandId = 2 },
                    new Product { Id = 17, Name = "Angular Purple Boots", Description = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue.", Price = 150 , PictureUrl = "images/products/boot-ang2.png", ProductTypeId = 3, ProductBrandId = 1 },
                    new Product { Id = 18, Name = "Angular Blue Boots", Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.", Price = 180 , PictureUrl = "images/products/boot-ang1.png", ProductTypeId = 3, ProductBrandId = 1 }
            );
        }
    }
}
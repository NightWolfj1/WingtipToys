using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WingtipToyss.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }
        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Cars"
                },
            new Category
            {
                CategoryID = 2,
                CategoryName = "Planes"
            },
            new Category
            {
                CategoryID = 3,
                CategoryName = "Trucks"
            },
            new Category
            {
                CategoryID = 4,
                CategoryName = "Boats"
            },
            new Category
            {
                CategoryID = 5,
                CategoryName = "Rockets"
            },
        };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product>{
                new Product
                {
                    ProductID = 1,
                    ProductName = "Coche descapotable",
                    Description = "¡Este coche descapotable es rápido! El motor funciona con una batería basada en neutrinos (no incluida)." + "¡Enciéndelo y déjalo ir!",
                    imagePath = "convertiblecar.jpg",
                    UnitPrice = 22.50,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Coche de antaño",
                    Description = "No hay nada viejo en este coche de juguete, excepto su apariencia, compatible con otros coches de juguete antiguos",
                    imagePath = "old-timecar.jpg",
                    UnitPrice = 15.95,
                    CategoryID = 1

                },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Coche rápido",
                    Description = "Sí, este coche es rápido, pero también flota en el agua",
                    imagePath = "fastcar.png",
                    UnitPrice = 32.99,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Coche super rapido",
                    Description = "Usa este auto súper rápido para entretener a los invitados. ¡Las luces y las puertas funcionan!",
                    imagePath = "superfastcar.png",
                    UnitPrice = 8.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Racer de estilo antiguo",
                    Description = "Este corredor de estilo antiguo puede volar (con la ayuda del usuario). La gravedad controla la duración del vuelo.",
                    imagePath = "oldstylerracer.png",
                    UnitPrice = 34.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Avión Ace",
                    Description = "Auténtico avión de juguete. Presenta colores y detalles realistas.",
                    imagePath = "aceplnae.png",
                    UnitPrice = 95.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Planeador",
                    Description = "Este divertido parapente está hecho de madera de balsa real. Se requiere algo de montaje.",
                    imagePath = "glider.png",
                    UnitPrice = 4.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Avión de papel",
                    Description = "Este avión de papel no se parece a ningún otro avión de papel. Se requiere un poco de plegado.",
                    imagePath = "paperplane.png",
                    UnitPrice = 2.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "Avión de hélice",
                    Description = "El avión propulsado por banda elástica cuenta con dos ruedas.",
                    imagePath = "proplenerplane.png",
                    UnitPrice = 32.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Camión primitivo",
                    Description = "This toy truck has a real gas powered engine.Requires regular tune ups.",
                    imagePath = "earlytruck.png",
                    UnitPrice = 15.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "Camión de bomberos",
                    Description = "Te divertirás sin fin con este camión de bomberos de un cuarto de tamaño.",
                    imagePath = "firetrucker.jpg",
                    UnitPrice = 26.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "Camión grande",
                    Description = "Este divertido camión de juguete se puede usar para remolcar otros camiones que no son tan grandes.",
                    imagePath = "bigtrucker.png",
                    UnitPrice = 29.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 13,
                    ProductName = "Barco grande",
                    Description = "¿Es un barco o un barco? ¡Deja que este vehículo flotante decida usando su cerebro informático " + "artificialmente inteligente!",
                    imagePath = "bigship.jpg",
                    UnitPrice = 95.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 14,
                    ProductName = "Paper Boat",
                    Description = "¡Diversión flotante para todos! Este barco de juguete se puede montar en segundos. ¡Flota durante minutos!" + "Se requiere un poco de plegado.",
                    imagePath = "paperboat.png",
                    UnitPrice = 4.95,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "Velero",
                    Description = "¡Pon este divertido velero de juguete en el agua y déjalo ir!",
                    imagePath = "sailboat.jpg",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 16,
                    ProductName = "Cohete",
                    Description = "Este divertido cohete viajará hasta una altura de 200 pies.",
                    imagePath = "rocket.jpg",
                    UnitPrice = 122.95,
                    CategoryID = 5
                },
            };
            return products;


        }
    }
}
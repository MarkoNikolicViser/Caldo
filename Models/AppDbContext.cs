using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caldo.Models
{
    public class AppDbContext:IdentityDbContext<IdentityUser>
    {
         
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Pizza> Pizza { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItem { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                    new Category { CategoryId = 1, CategoryName = "Pizze" },
                    new Category { CategoryId = 2, CategoryName = "Sendvici" },
                    new Category { CategoryId = 3, CategoryName = "Palacinke" },
                    new Category { CategoryId = 4, CategoryName = "Rostilj" }
                );

            modelBuilder.Entity<Pizza>().HasData(

                ///Pizze

              new Pizza { PizzaId = 1, Ime = "Margarita", Cena = 170, MaliOpis = "kecap, kackavalj, origano", VelikiOpis = "Regardless what else comes atop your pizza, a few fresh basil leaves will taste amazing with it. This simple summertime pizza would make a delicious cookout appetizer or light dinner paired with a salad.", CategoryId = 1, SlikaUrl = @"\Images\Menu\pica1.jpg", NaStanju = true, Najprodavanija = false, SlikaThumbUrl = @"\Images\MenuThumb\pica1mala.jpg" },
              new Pizza { PizzaId = 2, Ime = "Napolitana", Cena = 220, MaliOpis = "kecap, kackavalj, tunjevina, origano", VelikiOpis = "Who doesn’t love a little extra cheese for the perfect cheese-pull picture? We sure do. You might want to check with your local pizza joint to see how much cheese actually comes with an “extra cheese” order, because apparently, it’s hotly debated.", CategoryId = 1, SlikaUrl = @"\Images\Menu\pica2.jpg", NaStanju = true, Najprodavanija = false, SlikaThumbUrl = @"\Images\MenuThumb\pica2mala.jpg" },
              new Pizza { PizzaId = 3, Ime = "Capriciosa", Cena = 200, MaliOpis = "kecap, kackavalj, sunka, pecurke, origano", VelikiOpis = "Ham is often paired with the aforementioned pineapple for Hawaiian pizzas, but it can be delicious with other toppings (we’re looking at you, meat-lovers’ pizza). For a fancier feel, try prosciutto, or Italian ham.", CategoryId = 1, SlikaUrl = @"\Images\Menu\pica3.jpg", NaStanju = true, Najprodavanija = false, SlikaThumbUrl = @"\Images\MenuThumb\pica3mala.jpg" },
              new Pizza { PizzaId = 4, Ime = "Vegetariana", Cena = 200, MaliOpis = "kecap, kackavalj, pavlaka, pecurke, origano", VelikiOpis = "Some prefer mild, others spicy, and Southerners Conecuh, but sausage is consistently a favorite pizza topping of Americans. This cast-iron pizza recipe gives you another reason to love that skillet.", CategoryId = 1, SlikaUrl = @"\Images\Menu\pica4.jpg", NaStanju = true, Najprodavanija = false, SlikaThumbUrl = @"\Images\MenuThumb\pica4mala.jpg" },
              new Pizza { PizzaId = 5, Ime = "Romana", Cena = 200, MaliOpis = "kecap, kackavalj, sunka, masline, origano", VelikiOpis = "Green, red, yellow, or orange, peppers add a missing crunchy element to chewy, cheesy pizza. This sheet-pan recipe is the easiest way to serve pizza to a crowd, which is code for, “You should have a pizza party.”", CategoryId = 1, SlikaUrl = @"\Images\Menu\pica5.jpg", NaStanju = true, Najprodavanija = false, SlikaThumbUrl = @"\Images\MenuThumb\pica5mala.jpg" },
              new Pizza { PizzaId = 6, Ime = "Quatro Stagione", Cena = 240, MaliOpis = "kecap, kackavalj, sunka, kobasica, pecurke, masline, jaje, origano", VelikiOpis = "In case you haven’t noticed the trend, meat is always popular on top of pizzas. Whether you’re going for a dressier steak pizza, a kid-friendly cheeseburger pizza, or a pizza topped with meatballs (actually a thing), beef always has a place on pizza.", CategoryId = 1, SlikaUrl = @"\Images\Menu\pica6.jpg", NaStanju = true, Najprodavanija = false, SlikaThumbUrl = @"\Images\MenuThumb\pica6mala.jpg" },
              new Pizza { PizzaId = 7, Ime = "Vesuvio", Cena = 240, MaliOpis = "kecap, kackavalj, sunka, slanina, jaje, pecurke, crni luk, origano", VelikiOpis = "Spinach is a delicious way to add a little green to your pizza. Another popular green found on pizzas is arugula. Unlike spinach, which is usually cooked with the pizza, arugula is placed fresh on top of the pizza for a fresh, peppery pop. Try our Fig Flatbread for an arugula-topped pizza recipe.", CategoryId = 1, SlikaUrl = @"\Images\Menu\pica7.jpg", NaStanju = false, Najprodavanija = false, SlikaThumbUrl = @"\Images\MenuThumb\pica7mala.jpg" },
              new Pizza { PizzaId = 8, Ime = "Kalcona(zatvorena pizza)", Cena = 250, MaliOpis = "kecap, kackavalj, sunka, pecurke, kobasica, origano", VelikiOpis = "This earthy topping can be divisive in the kitchen, but many agree that it fits right in on a pizza, and this breakfast recipe is a perfect excuse to try eggs on a pizza. Spoiler: You’re going to love it.", CategoryId = 1, SlikaUrl = @"\Images\Menu\pica8.jpg", NaStanju = true, Najprodavanija = false, SlikaThumbUrl = @"\Images\MenuThumb\pica8mala.jpg" },
              new Pizza { PizzaId = 9, Ime = "Diablo", Cena = 250, MaliOpis = "kecap, kackavalj, sunka, pecurke, pavlaka, kobasica, origano", VelikiOpis = "The winner winner of weeknight meals goes well on pizzas, too! BBQ chicken, buffalo chicken, and chicken bacon ranch are common pizza orders that contain this protein.", CategoryId = 1, SlikaUrl = @"\Images\Menu\pica9.jpg", NaStanju = true, Najprodavanija = true, SlikaThumbUrl = @"\Images\MenuThumb\pica9mala.jpg" },
              new Pizza { PizzaId = 10, Ime = "Mexicana", Cena = 200, MaliOpis = "kecap, kackavalj, sunka, pecurke, tobasko, feferone, origano", VelikiOpis = "Whether they crisp up in the oven or go on the pizza caramelized, onions are a popular topping that add a little salty or a little sweet, depending how they’re prepared. Red onions often accompany barbecue chicken pizzas, while white and yellow onions are popular for supreme pizzas.", CategoryId = 1, SlikaUrl = @"\Images\Menu\pica10.jpg", NaStanju = true, Najprodavanija = false, SlikaThumbUrl = @"\Images\MenuThumb\pica10mala.jpg" },
              new Pizza { PizzaId = 11, Ime = "Burini", Cena = 250, MaliOpis = "kecap, kackavalj, vrat, kajmak, pecurke, jaje, origano", VelikiOpis = "People either love or hate olives, but even if you’re not a fan, you might actually like the salty bite black olives add to a generously topped pizza. Or you’ll just pick them all off. Either way.", CategoryId = 1, SlikaUrl = @"\Images\Menu\pica11.jpg", NaStanju = false, Najprodavanija = false, SlikaThumbUrl = @"\Images\MenuThumb\pica11mala.jpg" },
              new Pizza { PizzaId = 12, Ime = "Posna Pizza", Cena = 210, MaliOpis = "kecap, pecurke, tunjevina, masline, origano", VelikiOpis = "People either love or hate olives, but even if you’re not a fan, you might actually like the salty bite black olives add to a generously topped pizza. Or you’ll just pick them all off. Either way.", CategoryId = 1, SlikaUrl = @"\Images\Menu\pica12.jpg", NaStanju = false, Najprodavanija = false, SlikaThumbUrl = @"\Images\MenuThumb\pica12mala.jpg" },
              new Pizza { PizzaId = 13, Ime = "Caldo Special", Cena = 250, MaliOpis = "kecap, kackavalj, prsut, sampinjoni, jaje, pavlaka, masline, origano", VelikiOpis = "People either love or hate olives, but even if you’re not a fan, you might actually like the salty bite black olives add to a generously topped pizza. Or you’ll just pick them all off. Either way.", CategoryId = 1, SlikaUrl = @"\Images\Menu\pica13.jpg", NaStanju = false, Najprodavanija = false, SlikaThumbUrl = @"\Images\MenuThumb\pica13mala.jpg" },
              new Pizza { PizzaId = 14, Ime = "Specijal", Cena = 250, MaliOpis = "kecap, kackavalj, vrat, kobasica, jaje, pecurke, luk, origano", VelikiOpis = "People either love or hate olives, but even if you’re not a fan, you might actually like the salty bite black olives add to a generously topped pizza. Or you’ll just pick them all off. Either way.", CategoryId = 1, SlikaUrl = @"\Images\Menu\pica14.jpg", NaStanju = false, Najprodavanija = false, SlikaThumbUrl = @"\Images\MenuThumb\pica14mala.jpg" },
              new Pizza { PizzaId = 15, Ime = "Piroska", Cena = 250, MaliOpis = "kecap, kackavalj, sunka, pecurke, pavlaka, origano", VelikiOpis = "People either love or hate olives, but even if you’re not a fan, you might actually like the salty bite black olives add to a generously topped pizza. Or you’ll just pick them all off. Either way.", CategoryId = 1, SlikaUrl = @"\Images\Menu\pica15.jpg", NaStanju = false, Najprodavanija = false, SlikaThumbUrl = @"\Images\MenuThumb\pica15mala.jpg" },


              //Sendvici
              new Pizza { PizzaId = 16, Ime = "Sendvic prazan", Cena = 50, MaliOpis = "lepinja", VelikiOpis = "", CategoryId = 2, SlikaUrl = @"\Images\Carousel\Sendvic.jpg", NaStanju = true, Najprodavanija = false, SlikaThumbUrl = @"\Images\Carousel\Sendvic.jpg" },
              new Pizza { PizzaId = 17, Ime = "Sendvic pecurke", Cena = 240, MaliOpis = "lepinja, kackavalj, sunka, pecurke salata", VelikiOpis = "", CategoryId = 2, SlikaUrl = @"\Images\Carousel\Sendvic.jpg", NaStanju = true, Najprodavanija = false, SlikaThumbUrl = @"\Images\Carousel\Sendvic.jpg" },
              new Pizza { PizzaId = 18, Ime = "Sendvic ruska", Cena = 240, MaliOpis = "lepinja, kackavalj, sunka, ruska salata", VelikiOpis = "", CategoryId = 2, SlikaUrl = @"\Images\Carousel\Sendvic.jpg", NaStanju = true, Najprodavanija = false, SlikaThumbUrl = @"\Images\Carousel\Sendvic.jpg" },
              new Pizza { PizzaId = 19, Ime = "Sendvic govedja", Cena = 240, MaliOpis = "lepinja, kackavalj, sunka, govedja salata", VelikiOpis = "", CategoryId = 2, SlikaUrl = @"\Images\Carousel\Sendvic.jpg", NaStanju = true, Najprodavanija = false, SlikaThumbUrl = @"\Images\Carousel\Sendvic.jpg" },
              new Pizza { PizzaId = 20, Ime = "Sendvic pileca", Cena = 240, MaliOpis = "lepinja, kackavalj, sunka, pileca salata", VelikiOpis = "", CategoryId = 2, SlikaUrl = @"\Images\Carousel\Sendvic.jpg", NaStanju = true, Najprodavanija = true, SlikaThumbUrl = @"\Images\Carousel\Sendvic.jpg" },
              new Pizza { PizzaId = 21, Ime = "Sendvic prsut", Cena = 320, MaliOpis = "lepinja, kackavalj, njegoski prsut, salata po izboru", VelikiOpis = "", CategoryId = 2, SlikaUrl = @"\Images\Carousel\Sendvic.jpg", NaStanju = true, Najprodavanija = false, SlikaThumbUrl = @"\Images\Carousel\Sendvic.jpg" },
              new Pizza { PizzaId = 22, Ime = "Sendvic pecenica", Cena = 290, MaliOpis = "lepinja, kackavalj, pecenica, salata po izboru", VelikiOpis = "", CategoryId = 2, SlikaUrl = @"\Images\Carousel\Sendvic.jpg", NaStanju = true, Najprodavanija = false, SlikaThumbUrl = @"\Images\Carousel\Sendvic.jpg" },
              new Pizza { PizzaId = 23, Ime = "Sendvic suvi vrat", Cena = 290, MaliOpis = "lepinja, kackavalj, suvi vrat, salata po izboru", VelikiOpis = "", CategoryId = 2, SlikaUrl = @"\Images\Carousel\Sendvic.jpg", NaStanju = true, Najprodavanija = false, SlikaThumbUrl = @"\Images\Carousel\Sendvic.jpg" },
              new Pizza { PizzaId = 24, Ime = "Sendvic kulen", Cena = 300, MaliOpis = "lepinja, kackavalj, kulen, salata po izboru", VelikiOpis = "", CategoryId = 2, SlikaUrl = @"\Images\Carousel\Sendvic.jpg", NaStanju = true, Najprodavanija = false, SlikaThumbUrl = @"\Images\Carousel\Sendvic.jpg" },

              //Palacinke (slatke)
              new Pizza { PizzaId = 25, Ime = "Prazna palacinka", Cena = 70, MaliOpis = "Prazna palacinka bez priloga", VelikiOpis = "", CategoryId = 3, SlikaUrl = @"\Images\Carousel\Palacinka.jpg", NaStanju = true, Najprodavanija = false, SlikaThumbUrl = @"\Images\Carousel\Palacinka.jpg" },
              new Pizza { PizzaId = 26, Ime = "Slatka palacinka orah", Cena = 140, MaliOpis = "Prilozi: orasi, smedji secer", VelikiOpis = "", CategoryId = 3, SlikaUrl = @"\Images\Carousel\Palacinka.jpg", NaStanju = true, Najprodavanija = false, SlikaThumbUrl = @"\Images\Carousel\Palacinka.jpg" },
              new Pizza { PizzaId = 27, Ime = "Slatka palacinka med", Cena = 130, MaliOpis = "Prilog: med", VelikiOpis = "", CategoryId = 3, SlikaUrl = @"\Images\Carousel\Palacinka.jpg", NaStanju = true, Najprodavanija = false, SlikaThumbUrl = @"\Images\Carousel\Palacinka.jpg" },
              new Pizza { PizzaId = 28, Ime = "Slatka palacinka marmelada", Cena = 130, MaliOpis = "Prilozi: marmelada po izboru(sipurak, breskva, kajsija, sljiva)", VelikiOpis = "", CategoryId = 3, SlikaUrl = @"\Images\Carousel\Palacinka.jpg", NaStanju = true, Najprodavanija = false, SlikaThumbUrl = @"\Images\Carousel\Palacinka.jpg" },
              new Pizza { PizzaId = 29, Ime = "Slatka palacinka krem", Cena = 140, MaliOpis = "Prilog: krem", VelikiOpis = "", CategoryId = 3, SlikaUrl = @"\Images\Carousel\Palacinka.jpg", NaStanju = true, Najprodavanija = false, SlikaThumbUrl = @"\Images\Carousel\Palacinka.jpg" },
              new Pizza { PizzaId = 30, Ime = "Slatka palacinka nutela", Cena = 160, MaliOpis = "Prilog: nutela", VelikiOpis = "", CategoryId = 3, SlikaUrl = @"\Images\Carousel\Palacinka.jpg", NaStanju = true, Najprodavanija = true, SlikaThumbUrl = @"\Images\Carousel\Palacinka.jpg" },

              //Palacinke (slane)
              new Pizza { PizzaId = 31, Ime = "Slana palacinka pavlaka", Cena = 230, MaliOpis = "Prilozi: sunka, pavlaka, kackavalj", VelikiOpis = "", CategoryId = 3, SlikaUrl = @"\Images\Carousel\Slana.jpg", NaStanju = true, Najprodavanija = false, SlikaThumbUrl = @"\Images\Carousel\Slana.jpg" },
              new Pizza { PizzaId = 32, Ime = "Slana palacinka kajmak", Cena = 250, MaliOpis = "Prilozi: sunka, kajmak, kackavalj", VelikiOpis = "", CategoryId = 3, SlikaUrl = @"\Images\Carousel\Slana.jpg", NaStanju = true, Najprodavanija = false, SlikaThumbUrl = @"\Images\Carousel\Slana.jpg" },
              new Pizza { PizzaId = 33, Ime = "Slana palacinka prsut", Cena = 350, MaliOpis = "Prilozi: sunka, prsut, kackavalj", VelikiOpis = "", CategoryId = 3, SlikaUrl = @"\Images\Carousel\Slana.jpg", NaStanju = true, Najprodavanija = false, SlikaThumbUrl = @"\Images\Carousel\Slana.jpg" },
              new Pizza { PizzaId = 34, Ime = "Slana palacinka pecenica", Cena = 300, MaliOpis = "Prilozi: sunka, pecenica, kackavalj, pavlaka", VelikiOpis = "", CategoryId = 3, SlikaUrl = @"\Images\Carousel\Slana.jpg", NaStanju = true, Najprodavanija = false, SlikaThumbUrl = @"\Images\Carousel\Slana.jpg" },
              new Pizza { PizzaId = 35, Ime = "Slana palacinka kulen", Cena = 300, MaliOpis = "Prilozi: sunka, kulen, pavlaka, kackavalj", VelikiOpis = "", CategoryId = 3, SlikaUrl = @"\Images\Carousel\Slana.jpg", NaStanju = true, Najprodavanija = false, SlikaThumbUrl = @"\Images\Carousel\Slana.jpg" },
              new Pizza { PizzaId = 36, Ime = "Slana palacinka suvi vrat", Cena = 300, MaliOpis = "Prilozi: sunka, suvi vrat, pavlaka, kackavalj", VelikiOpis = "", CategoryId = 3, SlikaUrl = @"\Images\Carousel\Slana.jpg", NaStanju = true, Najprodavanija = false, SlikaThumbUrl = @"\Images\Carousel\Slana.jpg" },
              new Pizza { PizzaId = 37, Ime = "Slana palacinka pecenica/kulen", Cena = 300, MaliOpis = "Prilozi: pecenica, kulen, kackavalj, pavlaka", VelikiOpis = "", CategoryId = 3, SlikaUrl = @"\Images\Carousel\Slana.jpg", NaStanju = true, Najprodavanija = false, SlikaThumbUrl = @"\Images\Carousel\Slana.jpg" },
             
              ///Rostilj
              new Pizza { PizzaId = 38, Ime = "Pljeskavica", Cena = 240, MaliOpis = "160g", VelikiOpis = "", CategoryId = 4, SlikaUrl = @"\Images\Carousel\Rostilj.jpg", NaStanju = true, Najprodavanija = false, SlikaThumbUrl = @"\Images\Carousel\Rostilj.jpg" },
              new Pizza { PizzaId = 39, Ime = "Cevapi", Cena = 270, MaliOpis = "5 komada, 160g", VelikiOpis = "", CategoryId = 4, SlikaUrl = @"\Images\Carousel\Rostilj.jpg", NaStanju = true, Najprodavanija = false, SlikaThumbUrl = @"\Images\Carousel\Rostilj.jpg" },
              new Pizza { PizzaId = 40, Ime = "Rolovani cevapi", Cena = 320, MaliOpis = "5 komada, 200g (meso i slanina)", VelikiOpis = "", CategoryId = 4, SlikaUrl = @"\Images\Carousel\Rostilj.jpg", NaStanju = true, Najprodavanija = false, SlikaThumbUrl = @"\Images\Carousel\Rostilj.jpg" },
              new Pizza { PizzaId = 41, Ime = "Pojacana pljeskavica", Cena = 300, MaliOpis = "200g", VelikiOpis = "", CategoryId = 4, SlikaUrl = @"\Images\Carousel\Rostilj.jpg", NaStanju = true, Najprodavanija = false, SlikaThumbUrl = @"\Images\Carousel\Rostilj.jpg" },
              new Pizza { PizzaId = 42, Ime = "Pljeskavica sa kajmakom", Cena = 310, MaliOpis = "190g (meso i kajmak)", VelikiOpis = "", CategoryId = 4, SlikaUrl = @"\Images\Carousel\Rostilj.jpg", NaStanju = true, Najprodavanija = false, SlikaThumbUrl = @"\Images\Carousel\Rostilj.jpg" },
              new Pizza { PizzaId = 43, Ime = "Pljeskavica u susamu", Cena = 250, MaliOpis = "180g (meso plus susam)", VelikiOpis = "", CategoryId = 4, SlikaUrl = @"\Images\Carousel\Rostilj.jpg", NaStanju = true, Najprodavanija = false, SlikaThumbUrl = @"\Images\Carousel\Rostilj.jpg" },
              new Pizza { PizzaId = 44, Ime = "Gurmanska pljeskavica", Cena = 350, MaliOpis = "300g (meso, kackavalj, crniluk, tucana paprika)", VelikiOpis = "", CategoryId = 4, SlikaUrl = @"\Images\Carousel\Rostilj.jpg", NaStanju = true, Najprodavanija = false, SlikaThumbUrl = @"\Images\Carousel\Rostilj.jpg" },
              new Pizza { PizzaId = 45, Ime = "Punjena pljeskavica", Cena = 350, MaliOpis = "300g (meso, kackavalj, sunka, kulen)", VelikiOpis = "", CategoryId = 4, SlikaUrl = @"\Images\Carousel\Rostilj.jpg", NaStanju = true, Najprodavanija = true, SlikaThumbUrl = @"\Images\Carousel\Rostilj.jpg" },
              new Pizza { PizzaId = 46, Ime = "Dimljena kobasica", Cena = 280, MaliOpis = "160g", VelikiOpis = "", CategoryId = 4, SlikaUrl = @"\Images\Carousel\Rostilj.jpg", NaStanju = true, Najprodavanija = false, SlikaThumbUrl = @"\Images\Carousel\Rostilj.jpg" },
              new Pizza { PizzaId = 47, Ime = "Bela vesalica", Cena = 320, MaliOpis = "200g", VelikiOpis = "", CategoryId = 4, SlikaUrl = @"\Images\Carousel\Rostilj.jpg", NaStanju = true, Najprodavanija = false, SlikaThumbUrl = @"\Images\Carousel\Rostilj.jpg" },
              new Pizza { PizzaId = 48, Ime = "Punjena bela vesalica", Cena = 400, MaliOpis = "300g (vesalica, senf, kackavalj, kulen, sunka)", VelikiOpis = "", CategoryId = 4, SlikaUrl = @"\Images\Carousel\Rostilj.jpg", NaStanju = true, Najprodavanija = false, SlikaThumbUrl = @"\Images\Carousel\Rostilj.jpg" },
              new Pizza { PizzaId = 49, Ime = "Dimljeni vrat", Cena = 350, MaliOpis = "180g", VelikiOpis = "", CategoryId = 4, SlikaUrl = @"\Images\Carousel\Rostilj.jpg", NaStanju = true, Najprodavanija = false, SlikaThumbUrl = @"\Images\Carousel\Rostilj.jpg" },
              new Pizza { PizzaId = 50, Ime = "Dimljena slanina", Cena = 300, MaliOpis = "160g", VelikiOpis = "", CategoryId = 4, SlikaUrl = @"\Images\Carousel\Rostilj.jpg", NaStanju = true, Najprodavanija = false, SlikaThumbUrl = @"\Images\Carousel\Rostilj.jpg" },
              new Pizza { PizzaId = 51, Ime = "Pileca dzigerica", Cena = 230, MaliOpis = "160g", VelikiOpis = "", CategoryId = 4, SlikaUrl = @"\Images\Carousel\Rostilj.jpg", NaStanju = true, Najprodavanija = false, SlikaThumbUrl = @"\Images\Carousel\Rostilj.jpg" },
              new Pizza { PizzaId = 52, Ime = "Rolovana pileca dzigerica", Cena = 280, MaliOpis = "200g (dzigerica plus slanina)", VelikiOpis = "", CategoryId = 4, SlikaUrl = @"\Images\Carousel\Rostilj.jpg", NaStanju = true, Najprodavanija = false, SlikaThumbUrl = @"\Images\Carousel\Rostilj.jpg" },
              new Pizza { PizzaId = 53, Ime = "Pileci file", Cena = 300, MaliOpis = "200g", VelikiOpis = "", CategoryId = 4, SlikaUrl = @"\Images\Carousel\Rostilj.jpg", NaStanju = true, Najprodavanija = false, SlikaThumbUrl = @"\Images\Carousel\Rostilj.jpg" },
              new Pizza { PizzaId = 54, Ime = "Rolovano pilece belo", Cena = 350, MaliOpis = "250g (file plus panceta)", VelikiOpis = "", CategoryId = 4, SlikaUrl = @"\Images\Carousel\Rostilj.jpg", NaStanju = true, Najprodavanija = false, SlikaThumbUrl = @"\Images\Carousel\Rostilj.jpg" },
              new Pizza { PizzaId = 55, Ime = "Pilece belo u susamu", Cena = 320, MaliOpis = "220g (pilece belo plus susam)", VelikiOpis = "", CategoryId = 4, SlikaUrl = @"\Images\Carousel\Rostilj.jpg", NaStanju = true, Najprodavanija = false, SlikaThumbUrl = @"\Images\Carousel\Rostilj.jpg" },
              new Pizza { PizzaId = 56, Ime = "Punjeni pileci file", Cena = 350, MaliOpis = "300g (file, kackavalj, sunka, kulen)", VelikiOpis = "", CategoryId = 4, SlikaUrl = @"\Images\Carousel\Rostilj.jpg", NaStanju = true, Najprodavanija = false, SlikaThumbUrl = @"\Images\Carousel\Rostilj.jpg" },
              new Pizza { PizzaId = 57, Ime = "Batak", Cena = 290, MaliOpis = "200g", VelikiOpis = "", CategoryId = 4, SlikaUrl = @"\Images\Carousel\Rostilj.jpg", NaStanju = true, Najprodavanija = false, SlikaThumbUrl = @"\Images\Carousel\Rostilj.jpg" },
              new Pizza { PizzaId = 58, Ime = "Punjeni batak", Cena = 350, MaliOpis = "300g (batak, pecurke, kackavalj, sunka)", VelikiOpis = "", CategoryId = 4, SlikaUrl = @"\Images\Carousel\Rostilj.jpg", NaStanju = true, Najprodavanija = false, SlikaThumbUrl = @"\Images\Carousel\Rostilj.jpg" }


              );
        }

    }
}

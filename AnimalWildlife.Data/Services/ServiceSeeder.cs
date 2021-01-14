using System;
using System.Collections.Generic;
using System.Text;
using AnimalWildlife.Data.Animals;

namespace AnimalWildlife.Data.Services
{
    public class ServiceSeeder
    {
        public static void Seed(IAnimalDataService service)
        {
            service.Initialise();

            var c1 = service.Insert(new Animal
            {
                Name = "Rosie",
                Type = "Cat",
                Breed = "Bengal",
                Gender = 'F',
                DOB = DateTime.Parse("23/08/2019"),
                Description = "A young cat looking for love.",
                Image = "https://www.zooplus.co.uk/magazine/wp-content/uploads/2018/02/fotolia_82719975-768x582.jpg"
            });

            var c2 = service.Insert(new Animal
            {
                Name = "Ralph",
                Type = "Dog",
                Breed = "Labrador",
                Gender = 'M',
                DOB = DateTime.Parse("11/05/2007"),
                Description = "An old dog looking for love.",
                Image = "https://www.thelabradorsite.com/wp-content/uploads/2018/09/Labrador-Retriever-LS-long.jpg"
            });

        }

    }
}

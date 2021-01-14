using System;
using Xunit;
using AnimalWildlife.Data.Services;
using System.Linq;
using AnimalWildlife.Data.Animals;

namespace AnimalWildlife.Test
{
    public class AnimalServiceTests
    {
        private IAnimalDataService service;

        public AnimalServiceTests()
        {
            service = new AnimalDataService();
            service.Initialise();
            ServiceSeeder.Seed(service);

        }

        [Fact]
        public void TestSelectAll()
        {

            var animals = service.SelectAll();
            var animalCount = animals.Count();
            // Assert
            Assert.Equal(2, animalCount);
        }

        [Fact]
        public void TestSelectByID()
        {
            var animal = service.SelectByID(2);
            string animalName = animal.Name;
            // Assert
            Assert.Equal("Ralph", animalName);
        }


        [Fact]
        public void TestInsert()
        {
            Animal animal = new Animal();
            animal.Name = "rhys";
            animal.Type = "cat";
            animal.Breed = "bengal";
            animal.Gender = 'M';
            animal.DOB = DateTime.Parse("23 / 09 / 2016");
            animal.Description = "Young cat";
            animal.Image = "https://www.zooplus.co.uk/magazine/wp-content/uploads/2018/02/fotolia_82719975-768x582.jpg";

            var returnedAnimal = service.Insert(animal);
            string animalName = returnedAnimal.Name;

            // Assert
            Assert.Equal("rhys", animalName);   
        }

        [Fact]
        public void TestUpdate()
        {
            var animalExisting = service.SelectByID(2);
            animalExisting.Name = "Bob";
            service.Update(animalExisting);

            var animalUpdated = service.SelectByID(2);
            string animalName = animalUpdated.Name;

            // Assert
            Assert.Equal("Bob", animalName);
        }

        [Fact]
        public void TestDelete()
        {
            bool deleteAnimal = service.Delete(2);
            // Assert
            Assert.True(deleteAnimal);
        }

    }
}


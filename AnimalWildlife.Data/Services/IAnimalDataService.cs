using System;
using System.Collections.Generic;
using System.Text;
using AnimalWildlife.Data.Animals;

namespace AnimalWildlife.Data.Services
{
    public interface IAnimalDataService
    {
        void Initialise();
        IList<Animal> SelectAll();
        Animal SelectByID(int id);
        Animal Insert(Animal obj);
        void Update(Animal obj);
        bool Delete(int id);

    }
}

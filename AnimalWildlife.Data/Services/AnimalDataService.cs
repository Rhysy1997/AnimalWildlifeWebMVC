using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AnimalWildlife.Data.Animals;
using AnimalWildlife.Data.Repository;
using Microsoft.EntityFrameworkCore;



namespace AnimalWildlife.Data.Services
{
    public class AnimalDataService : IAnimalDataService
    {
        private AnimalsDBContext db = null;

        public AnimalDataService()
        {
            this.db = new AnimalsDBContext();
        }

        public AnimalDataService(AnimalsDBContext db)
        {
            this.db = db;
        }

        public void Initialise()
        {
            db.Initialise();
        }

        public IList<Animal> SelectAll()
        {
            return db.Animals.OrderBy(a => a.DOB).ToList();
        }

        public Animal SelectByID(int id)
        {
            return db.Animals.FirstOrDefault(c => c.Id == id);
        }

        public Animal Insert(Animal obj)
        {
            db.Animals.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public void Update(Animal obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var existing = db.Animals.FirstOrDefault(c => c.Id == id);
            if (existing == null)
            {
                return false;
            }
            db.Remove(existing);
            db.SaveChanges();
            return true;
        }

    }
}

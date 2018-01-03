using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetApi.Models;

namespace PetApi.DataAccess
{
    public class DataAccessGodObject : IDataAccessGodObject
    {
        private readonly List<Pet> _allPets;

        #region Silly constructor to fudge some data

        public DataAccessGodObject()
        {
            _allPets = new List<Pet>
            {
                new Pet
                {
                    Id = 1,
                    Name = "Fluffy",
                    Owner = new Owner
                    {
                        Id = 100,
                        Name = "Fred Swanson"
                    }
                },
                new Pet
                {
                    Id = 2,
                    Name = "Muffin",
                    Owner = new Owner
                    {
                        Id = 101,
                        Name = "Anna Zubel"
                    }
                },
                new Pet
                {
                    Id = 3,
                    Name = "Cally",
                    Owner = new Owner
                    {
                        Id = 103,
                        Name = "Nick Moranis"
                    }
                },
                new Pet
                {
                    Id = 4,
                    Name = "Gracie",
                    Owner = new Owner
                    {
                        Id = 104,
                        Name = "Marie Curie"
                    }
                }
            };
        }

        #endregion

        public IQueryable<Pet> AllPets => _allPets.AsQueryable();

        public Pet SavePet(Pet pet)
        {
            pet.Id = DateTime.UtcNow.Millisecond;
            return pet;
        }
    }
}
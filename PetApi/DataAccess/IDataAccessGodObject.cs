using System.Linq;
using PetApi.Models;

namespace PetApi.DataAccess
{
    public interface IDataAccessGodObject
    {
        IQueryable<Pet> AllPets { get; }

        Pet SavePet(Pet pet);
    }
}
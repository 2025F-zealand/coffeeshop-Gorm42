using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalLib;

namespace AnimalLibTests
{
    public class AnimalRepository
    {
        private List<Animal>? animalList;
        private int _id;
        
        /// <summary>
        /// Return the list with all objects of the animals.
        /// </summary>
        /// <returns>List<Animal> </returns>
        public List<Animal> GetAll()
        {
            return animalList;
        }

        /// <summary>
        /// Method to find a specific animal object in the list of Animal objects animalList.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public Animal GetById(int id)
        {
            if (id == null)
            {
                throw new ArgumentNullException("Id does not exist.");
            }
            else
            {
                return animalList.Find(animal => animal.Id == id);
            }
        }

        /// <summary>
        /// Returns a list of animals with the same category.
        /// </summary>
        /// <param name="category"></param>
        /// <returns>All animals of a specific category returned. </returns>
        /// <exception cref="ArgumentNullException"></exception>
        public List<Animal>? GetByCategory(string category)
        {
            if (category == null)
            {
                throw new ArgumentNullException("There is nothing in category");
            }
            return animalList.FindAll(animal => animal.Category.ToLower() == category.ToLower());
        }

        /// <summary>
        /// Create a new animal object and adds it to the list animalList.
        /// </summary>
        /// <param name="newAnimal"></param>
        /// <returns> returns the new Animal animal object</returns>
        public Animal AddAnimal(Animal newAnimal)
        {
            Animal animal = new Animal(_id++, newAnimal.Category, newAnimal.Age, newAnimal.Price);
            animalList.Add(animal);
            return animal;
        }

        /// <summary>
        /// Goes through the list of animal objects with the same id.
        /// Then removes the object from the list.
        /// Then returns the removed object
        /// Cleverly, the Find(); method contains a thrownullexception, in case there isn't any object with the same id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns> </returns>
        public Animal Delete(int id)
        {

            Animal animal = animalList.Find(animal => animal.Id == id);
            animalList.Remove(animal);
            return animal;
        }


        /// <summary>
        /// Goes through the list of animal objects with the same id.
        /// Then, if found, updates the object with the new object.
        /// Again, the Find method contains an exception in case there isn't any object with the same id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="updateAnimal"></param>
        /// <returns></returns>
        public Animal Update(int id, Animal updateAnimal)
        {
            Animal animal = animalList.Find(animal => animal.Id == id);
            animal.Category = updateAnimal.Category;
            animal.Age = updateAnimal.Age;
            animal.Price = updateAnimal.Price;
            return animal;

        }


        /// <summary>
        /// Sorts the list of animal objects by category.
        /// </summary>
        /// <returns> returns the list of animal objects sorted </returns>
        public List<Animal> SortByCategory()
        {
            return animalList.OrderByDescending(animal => animal.Category).ToList();
        }


        /// <summary>
        /// Sorts the list of animal objects by price.
        /// </summary>
        /// <returns> Returns from the animalList all the animals sorted by price, descending.</returns>
        public List<Animal> SortByPrice()
        {
            return animalList.OrderByDescending(animal => animal.Price).ToList();
        }
    }
}

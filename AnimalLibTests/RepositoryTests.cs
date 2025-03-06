using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalLibTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalLib;

namespace AnimalLibTests.RepositoryTests
{
    [TestClass()]
    public class RepositoryTests
    {
        //We need to test GetById, GetByCategory and Add.
        //Arrange
        AnimalRepository animalRepository = new AnimalRepository();
        private List<Animal> animalList = new List<Animal>();
        Animal animal = new Animal(1, "Mammal", 10, 1500);
        


        [TestMethod()]
        [DataRow(1, "Mammal", 10, 1500)]
        [DataRow(2, "Insect", 2, 50)]
        public void GetByIdTest(int id, string category, int age, double price)
        {
            //We need to test the Find(); method.
            //Arrange
            Animal newAnimal = new Animal(id, category, age, price);
            animalList.Add(newAnimal);
            Animal actualAnimal = animalList.Find(animal => animal.Id == id);

            //Act
            Assert.AreSame(newAnimal, actualAnimal);
            
        }

        [TestMethod()]
        public void GetByCategoryTest()
        {
            //Så her skal vi se om den kan finde ud af at sætte vores category i orden.
            //Arrange.
            //Act.
            //Assert.
            Assert.Fail();
        }

        [TestMethod()]
        public void AddTest()
        {
            Assert.Fail();
        }

    }
}
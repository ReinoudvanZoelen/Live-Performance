using System;
using System.Collections.Generic;
using Live_Performance.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Live_Performance.Repositories.MSSQLRepository;

namespace Live_Performance_UnitTest
{
    [TestClass]
    public class TU_MSSQLIngredientRepository
    {
        [TestMethod]
        public void GetAll()
        {
            // Arrange
            MSSQLIngredientRepository IngredientRepository = new MSSQLIngredientRepository();
            List<Ingredient> ingredients = IngredientRepository.GetAll();

            // Act
            int count = ingredients.Count;

            // Assert
            Assert.AreNotEqual(0, ingredients.Count);
        }


        [TestMethod]
        public void GetById()
        {
            // Arrange
            MSSQLIngredientRepository IngredientRepository = new MSSQLIngredientRepository();
            Ingredient ingredient = IngredientRepository.GetById(9);

            // Act


            // Assert
            Assert.AreEqual("Paprika", ingredient.Naam);
        }


        [TestMethod]
        public void Insert()
        {
            // Arrange
            MSSQLIngredientRepository IngredientRepository = new MSSQLIngredientRepository();
            Ingredient ingredient = new Ingredient(-1, "Sugar and Spice", new decimal(5), new decimal(3), false, true);

            // Act
            int startCount = IngredientRepository.GetAll().Count;

            IngredientRepository.Insert(ingredient);

            int endCount = IngredientRepository.GetAll().Count;

            // Assert
            Assert.AreEqual(startCount + 1, endCount);
        }


        [TestMethod]
        public void Update()
        {
            // Arrange
            MSSQLIngredientRepository IngredientRepository = new MSSQLIngredientRepository();
            List<Ingredient> ingredienten = IngredientRepository.GetAll();
            Ingredient ingredient = ingredienten[ingredienten.Count - 1];
            Ingredient verifyIngredient;

            // Act
            ingredient.Naam = "And everything nice!";
            ingredient.Halal = true;
            ingredient.Veganistisch = false;

            IngredientRepository.Update(ingredient);

            ingredienten = IngredientRepository.GetAll();
            verifyIngredient = ingredienten[ingredienten.Count - 1];

            // Assert
            Assert.AreEqual("And everything nice!", verifyIngredient.Naam);
            Assert.AreEqual(true, verifyIngredient.Halal);
            Assert.AreEqual(false, verifyIngredient.Veganistisch);
        }


        [TestMethod]
        public void Delete()
        {
            // Arrange
            MSSQLIngredientRepository IngredientRepository = new MSSQLIngredientRepository();
            List<Ingredient> ingredienten = IngredientRepository.GetAll();
            Ingredient ingredient = ingredienten[ingredienten.Count - 1];

            // Act
            int startCount = IngredientRepository.GetAll().Count;

            IngredientRepository.Delete(ingredient.ID);

            int endCount = IngredientRepository.GetAll().Count;

            // Assert
            Assert.AreEqual(startCount - 1, endCount);
        }
    }
}

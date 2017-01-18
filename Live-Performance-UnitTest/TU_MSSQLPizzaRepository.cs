using System;
using System.Collections.Generic;
using Live_Performance.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Live_Performance.Repositories.MSSQLRepository;

namespace Live_Performance_UnitTest
{
    [TestClass]
    public class TU_MSSQLPizzaRepository
    {
        [TestMethod]
        public void GetAll()
        {
            // Arrange
            MSSQLPizzaRepository PizzaRepository = new MSSQLPizzaRepository();
            List<Pizza> pizzas = PizzaRepository.GetAll();

            // Act
            int count = pizzas.Count;

            // Assert
            Assert.AreNotEqual(0, count);
        }


        [TestMethod]
        public void GetById()
        {
            // Arrange
            MSSQLPizzaRepository PizzaRepository = new MSSQLPizzaRepository();
            Pizza pizza = PizzaRepository.GetById(4);

            // Act
            string naam = pizza.Naam;

            // Assert
            Assert.AreEqual("Margherita", naam);
        }


        [TestMethod]
        public void Insert()
        {
            // Arrange
            MSSQLPizzaRepository PizzaRepository = new MSSQLPizzaRepository();
            MSSQLIngredientRepository IngredientRepository = new MSSQLIngredientRepository();


            // Act
            int[] afmetingen = new int[3];
            afmetingen[0] = 20;
            afmetingen[1] = 25;


            // Echt een hoop shit en een dikke bodem
            List<Ingredient> ingredienten = new List<Ingredient>();
            ingredienten.Add(IngredientRepository.GetById(1));
            ingredienten.Add(IngredientRepository.GetById(3));
            ingredienten.Add(IngredientRepository.GetById(6));
            ingredienten.Add(IngredientRepository.GetById(11));
            ingredienten.Add(IngredientRepository.GetById(14));

            Pizza pizza = new Pizza("Pizza Magnifico!", true, true, afmetingen, ingredienten);

            PizzaRepository.Insert(pizza);

            List<Pizza> pizzas = PizzaRepository.GetAll();
            Pizza verifyPizza = pizzas[pizzas.Count - 1];

            // Assert
            Assert.AreEqual(pizza.Naam, verifyPizza.Naam);
        }


        [TestMethod]
        public void Update()
        {
            // Arrange
            MSSQLPizzaRepository PizzaRepository = new MSSQLPizzaRepository();
            MSSQLIngredientRepository IngredientRepository = new MSSQLIngredientRepository();
            List<Pizza> Pizzas = PizzaRepository.GetAll();
            Pizza pizza = Pizzas[Pizzas.Count - 1];
            Pizza verifyPizza;

            // Act

            pizza.Naam = "Vieze glutenvrije tomaten/olijvenpizza";

            pizza.Ingredienten.Clear();
            pizza.Ingredienten.Add(IngredientRepository.GetById(2));
            pizza.Ingredienten.Add(IngredientRepository.GetById(7));
            pizza.Ingredienten.Add(IngredientRepository.GetById(15));

            int[] afmetingen = new int[3];
            afmetingen[0] = 20;
            afmetingen[1] = 25;
            afmetingen[2] = 30;

            pizza.Afmetingen = afmetingen;

            pizza.Glutenvrij = false;
            pizza.Custom = false;

            PizzaRepository.Update(pizza);

            Pizzas = PizzaRepository.GetAll();
            verifyPizza = Pizzas[Pizzas.Count - 1];

            // Assert
            Assert.AreNotEqual(4, verifyPizza.Ingredienten.Count);
        }


        [TestMethod]
        public void Delete()
        {
            // Arrange
            MSSQLPizzaRepository PizzaRepository = new MSSQLPizzaRepository();
            MSSQLIngredientRepository IngredientRepository = new MSSQLIngredientRepository();
            List<Pizza> Pizzas = PizzaRepository.GetAll();
            Pizza pizza = Pizzas[Pizzas.Count - 1];

            // Act
            int startCount = PizzaRepository.GetAll().Count;

            PizzaRepository.Delete(pizza.ID);

            int endCount = PizzaRepository.GetAll().Count;

            // Assert
            Assert.AreEqual(startCount - 1, endCount);
        }
    }
}


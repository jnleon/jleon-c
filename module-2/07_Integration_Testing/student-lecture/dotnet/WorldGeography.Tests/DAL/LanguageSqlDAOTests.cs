using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using WorldGeography.DAL;
using WorldGeography.Models;
using WorldGeography.Tests.DAL;

namespace WorldGeography.Tests
{
    [TestClass]
    public class LanguageSqlDAOTests : WorldDAOTests
    {
        [TestMethod]
        [DataRow("USA", 1)]
        [DataRow("XYZ", 0)]
        public void GetLanguagesTest(string countryCode, int expectedCount)
        {
            // Arrange



            // Act



            // Assert
            Assert.Fail(); //remove me


        }

        [TestMethod]
        public void AddLanguage()
        {
            // Arrange
            Language lang = new Language();
            lang.CountryCode = "USA";
            lang.IsOfficial = false;
            lang.Name = "miaw";
            lang.Percentage = 5;

            ILanguageDAO dao = new LanguageSqlDAO(ConnectionString);
            // Act
            bool result = dao.AddNewLanguage(lang);

            // Assert
            Assert.IsTrue(result);


        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void AddLanguage_FailsBecauseLanguageExists()
        {
            //ARRANGE
            ILanguageDAO dao = new LanguageSqlDAO(ConnectionString);
            ICollection<Language> allUSLanguages = dao.GetLanguages("USA");
           
            //ACT
            Language dup = allUSLanguages.ToArray()[0];
            dao.AddNewLanguage(dup);


        }

        [TestMethod]
        public void RemoveLanguage()
        {
            // Arrange

            ILanguageDAO dao = new LanguageSqlDAO(ConnectionString);
           
            Language lang = new Language();
            lang.CountryCode = "USA";
            lang.IsOfficial = false;
            lang.Name = "miaw";
            lang.Percentage = 5;


            // Act
            bool result = dao.RemoveLanguage(lang);
            int beforeRowCount = GetRowCount("countrylanguage");

            // Assert
            Assert.IsTrue(result); //remove me
            Assert.AreEqual(beforeRowCount - 1, GetRowCount("countrylanguage"));

        }

    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace HotelApp.Tests
{
    [TestClass]
    public class DatabaseServiceTests
    {
        [TestMethod]
        public void GetGuests_ReturnsGuestsList()
        {
            // arrange
            DatabaseService databaseService = new DatabaseService();

            // act
            List<string[]> result = databaseService.GetGuests();

            // assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result[0], typeof(string[]));
        }
        [TestMethod]
        public void TestGetReservedGuests_ReturnsGuestsFromDatabase()
        {
            // Arrange
            var databaseService = new DatabaseService();
            var expectedGuests = new List<string[]> {
                new[] { "1", "1" },
                new[] { "2", "2" }
            };

            // Act
            var actualGuests = databaseService.GetReservedGuests();

            // Assert
            AssertListsAreEqual(expectedGuests, actualGuests);

        }
        private static void AssertListsAreEqual(List<string[]> expected, List<string[]> actual)
        {
            if (expected.Count != actual.Count)
            {
                throw new Exception($"Ожидали {expected.Count} элементов, но получили {actual.Count}");
            }

            for (int i = 0; i < expected.Count; i++)
            {
                for (int j = 0; j < actual.Count; j++)
                {
                    if (expected[i][j] != actual[i][j])
                    {
                        throw new Exception($"Несовпадение элементов: {expected[i][j]} и {actual[i][j]}");
                    }
                }
            }
        }
    }
}

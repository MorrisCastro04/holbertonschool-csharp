using System;
using System.Collections.Generic;
using System.IO;
using Xunit;
using InventoryLibrary;

namespace InventoryManagement.Tests
{
    public class JSONStorageTests
    {
        private readonly string testFilePath = Path.Combine("storage", "test_inventory_manager.json");

        /// <summary>
        /// Helper method to create a test-specific JSONStorage instance.
        /// </summary>
        private JSONStorage CreateTestStorage()
        {
            var storage = new JSONStorage();

            // Use reflection to override the private filePath field
            var filePathField = typeof(JSONStorage).GetField("filePath", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            filePathField?.SetValue(storage, testFilePath);

            return storage;
        }

        [Fact]
        public void Test_New_And_All_Methods()
        {
            // Arrange
            JSONStorage storage = CreateTestStorage();
            Item item = new Item("TestItem");

            // Act
            storage.New(item);
            var objects = storage.All();

            // Assert
            Assert.Single(objects);
            Assert.Contains($"Item.{item.id}", objects.Keys);
        }

        [Fact]
        public void Test_Save_And_Load_Methods()
        {
            // Arrange
            JSONStorage storage = CreateTestStorage();
            Item item = new Item("TestItem");
            storage.New(item);

            // Act
            storage.Save(); // Save to JSON file
            storage.Load(); // Reload from JSON file
            var objects = storage.All();

            // Assert
            Assert.Single(objects);
            Assert.Contains($"Item.{item.id}", objects.Keys);

            // Cleanup
            if (File.Exists(testFilePath))
            {
                File.Delete(testFilePath);
            }
        }

        [Fact]
        public void Test_Empty_File_Load()
        {
            // Arrange
            JSONStorage storage = CreateTestStorage();
            Directory.CreateDirectory("storage"); // Ensure directory exists
            File.WriteAllText(testFilePath, string.Empty); // Write an empty file

            // Act
            storage.Load();
            var objects = storage.All();

            // Assert
            Assert.Empty(objects);

            // Cleanup
            if (File.Exists(testFilePath))
            {
                File.Delete(testFilePath);
            }
        }

        [Fact]
        public void Test_Nonexistent_File_Load()
        {
            // Arrange
            JSONStorage storage = CreateTestStorage();

            // Ensure the test file does not exist
            if (File.Exists(testFilePath))
            {
                File.Delete(testFilePath);
            }

            // Act
            storage.Load(); // No file exists
            var objects = storage.All();

            // Assert
            Assert.Empty(objects);
        }
    }
}
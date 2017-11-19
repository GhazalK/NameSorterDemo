using System;
using Util;
using Xunit;

namespace NameSorterDemoTest
{
    // limited facts since the name entries were simple and conditions were limited 
    public class UnitTest
    {
        private readonly Sorter _sorter;
        public UnitTest(){
            _sorter = new Sorter();
        }
        [Fact]
        public void TestingWithoutNameEntries()
        {
            var noEntry = new String[0];
            Assert.Equal("", String.Join(" ", _sorter.SortNamesList(noEntry)));

        }
        public void TestingWithOneNameEntry()
        {
            string[] oneEntry = { "Ghazal" };
            Assert.Equal("Ghazal", String.Join(" ", _sorter.SortNamesList(oneEntry)));

        }
        public void TestingWithMoreThanFourNameEntries()
        {
            string[] fiveEntry = { "John Abraham Summer Davis Miller" };
            Assert.Equal("John Abraham Summer Davis Miller", String.Join(" ", _sorter.SortNamesList(fiveEntry)));

        }
        public void TestingWithFourNameEntries()
        {
            string[] fourEntry = { "John Abraham Summer Davis Miller" };
            Assert.Equal("John Abraham Summer Davis Miller", String.Join(" ", _sorter.SortNamesList(fourEntry)));

        }
        public void TestingWithMultipleNameEntriesSorted()
        {
            string[] multipleEntries = { "John Abraham Summer Davis" , "Ella Scott", "Craige Harper" };
            Assert.Equal("John Abraham Summer Davis Craige Harper Ella Scott ", String.Join(" ", _sorter.SortNamesList(multipleEntries)));

        }
        public void TestingWithAllGivenNameEntriesSorted()
        {
            string[] givenEntries = { "Janet Parsons", "Vaughn Lewis", "Adonis Julius Archer", "Shelby Nathan Yoder", "Marin Alvarez",
                "London Lindsey", "Beau Tristan Bentley", "Leo Gardner", "Hunter Uriah Mathew Clarke",
                "Mikayla Lopez","Frankie Conner Ritter" };
            Assert.Equal("Marin Alvarez Adonis Julius Archer Beau Tristan Bentley Hunter Uriah Mathew Clarke Leo Gardner" +
                         "Vaughn Lewis London Lindsey Mikayla Lopez Janet Parsons Frankie Conner Ritter Shelby Nathan Yoder",
                         String.Join(" ", _sorter.SortNamesList(givenEntries)));

        }

    }
}

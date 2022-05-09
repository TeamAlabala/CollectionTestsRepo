using NUnit.Framework;
using System.Diagnostics;

namespace CollectionsTests
{
    public class CollectionsTests
    {

        [Test]
        public void Test_Collections_1MillionItems()
        {
            //Arrange
            var myValues = new Collections.Collection<int>(new int[1000000]);
            var expected = myValues.Count;

            //Act

            //Assert
            Assert.AreEqual(expected, myValues.Count, $"The collection number of elements is:{myValues.Count}");
            Trace.WriteLine($"The collection number of elements is:{myValues.Count.ToString("#,##0")}");
        }

        [Test]
        public void Test_Collections_Add()
        {
            //Arrange
            var myValues = new Collections.Collection<int>(5, 10, 15, 20, 25);

            //Act
            myValues.Add(30);

            //Assert
            var expected = new Collections.Collection<int>(5, 10, 15, 20, 25, 30);
            Assert.AreEqual(expected.ToString(), myValues.ToString(), $"The new collection is:{myValues.ToString()}");
            Trace.WriteLine($"The new collection is:{myValues.ToString()}");
        }

    }
}
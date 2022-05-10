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
        
         [Test]
        public void ExchangeFirstLast()
        {
            //arrange
            var numsToTest = new Collection<int>(1, 2, 3, 4, 5);
            var numsExpected = new Collection<int>(5, 2, 3, 4, 1);
            //act
            numsToTest.Exchange(0, 4) ;
            //assert
            Assert.AreEqual(numsToTest[0], numsExpected[0]);
        }
        
        [Test]
        public void ExchangeMiddleIndexes()
        {
            //arrange
            var numsToTest = new Collection<int>(1, 2, 3, 4, 5);
            var numsExpected = new Collection<int>(1, 2, 4, 3, 5);
          
            //act
            numsToTest.Exchange(2, 3);

            //assert
            Assert.AreEqual(numsToTest[2], numsExpected[2]);
        }        
        
        [Test]
        public void GetByIndex()
        {
            //arrange
            var numsToTest = new Collection<int>(1, 2, 3, 4, 5);
            int numByIndex = 4;
            //act
            int testedNum = numsToTest[3];
            //assert
            Assert.That(testedNum == numByIndex);
        }
        
        [Test]
        public void InsertAtEnd()
        {
            //arrange
            var numsToTest = new Collection<int>(1, 2, 3, 4, 5);
            int numToInsert = 6;
            //act
            numsToTest.Add(numToInsert);
            //assert
            Assert.That(numsToTest[numsToTest.Count-1] == numToInsert);
        }  
        
        [Test]
        public void ExchangeInvalidIndexes()
        {
            //arrange
            var numsToTest = new Collection<int>(1, 2, 3, 4, 5);
            //assert
            Assert.That(() => numsToTest.Exchange(0, 6), Throws.InstanceOf<System.ArgumentOutOfRangeException>());
        }
        
        [Test]
        public void GetByInvalidIndex()
        {
            //arrange
            var numsToTest = new Collection<int>(1, 2, 3, 4, 5);
            //assert
            Assert.That(() => numsToTest[15], Throws.InstanceOf<System.ArgumentOutOfRangeException>());
        }
        
        [Test]
        public void InsertByInvalidIndex()
        {
            //arrange
            var numsToTest = new Collection<int>(1, 2, 3, 4, 5);    
            //assert
            Assert.That(() => numsToTest.InsertAt(15, 6), Throws.InstanceOf<System.ArgumentOutOfRangeException>());
        }
      
        [Test]
        public void Test_Collections_RemoveAll()
        {
            //Arrange
            var myValues = new Collections.Collection<int>(5, 10, 15, 20, 25);
            int i = myValues.Count;

            //Act
            for (; i>0; i--)
            {
                myValues.RemoveAt(0);
            }
       
            //Assert
            var expected = new Collections.Collection<int>();
            Assert.AreEqual(expected.ToString(), myValues.ToString(), $"The new collection is:{myValues.ToString()}");
            Assert.That(myValues.Count == 0);
            Trace.WriteLine($"The new collection is:{myValues.ToString()}");
        }
    }
}

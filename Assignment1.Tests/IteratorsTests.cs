using System;
using Xunit;

namespace Assignment1.Tests
{
    public class IteratorsTests
    {
        [Fact]
        public void Flatten_when_given_2_collections_make_them_into_1()
        {

            var array1 = new[] { "Test1", "Test2" };
            var array2 = new[] { "Test3", "Test4" };

            var arrayOf1And2 = new[] { array1, array2 };

            var output = Iterators.Flatten(arrayOf1And2);

            Assert.Equal(new[] { "Test1", "Test2", "Test3", "Test4" }, output);

        }


        [Fact]
        public void TestName()
        {

            Predicate<string> predicate = isStringToLong;
            var array1 = new[] { "Bo", "Bord", "Is", "Computer", "Solskinsvejr" };
            var output = Iterators.Filter(array1, predicate);

            Assert.Equal(new[] {"Bo", "Is"}, output);

        }

        bool isStringToLong(string s)
            {
                if (s.Length < 3)
                {
                    return true;
                }
                return false;
            }
    }
}

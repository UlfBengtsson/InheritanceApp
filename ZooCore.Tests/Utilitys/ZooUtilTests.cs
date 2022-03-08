using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ZooCore.Models;
using ZooCore.Utilitys;

namespace ZooCore.Tests.Utilitys
{
    public class ZooUtilTests
    {
        public static IEnumerable<object[]> DogCountedLists()
        {
            yield return new object[]
            {
                new List<Animal>()
                {   //animals
                    new Dog(1,"Blizten1", "2000-01-01","ASD323"),
                    new Bird(1,"Blizten2", "2000-01-01",12,true),
                    new Dog(1,"Blizten3", "2000-01-01","ASD323"),
                    new Bird(1,"Blizten4", "2000-01-01",12,true),
                    new Dog(1,"Blizten5", "2000-01-01","ASD323")
                },
                3   //expectedCount
            };

            yield return new object[]
            {
                new List<Animal>()
                {   //animals
                    new Bird(1,"Blizten2", "2000-01-01",12,true),
                    new Bird(1,"Blizten4", "2000-01-01",12,true)
                },
                0   //expectedCount
            };

            yield return new object[]
            {
                new List<Animal>()
                {   //animals
                    new Dog(1,"Blizten1", "2000-01-01","ASD323"),
                    new Dog(1,"Blizten3", "2000-01-01","ASD323"),
                    new Dog(1,"Blizten5", "2000-01-01","ASD323")
                },
                3   //expectedCount
            };
        }

        [Theory]
        [MemberData(nameof(DogCountedLists))]
        public void FilterOutJustDogs(List<Animal> animals, int expectedCount)
        {
            //Arrange - MembersData

            //Act
            var result = ZooUtil.FilterToOnlyDogs(animals);

            //Assert
            Assert.IsType<List<Dog>>(result);
            Assert.Equal(expectedCount, result.Count);
        }
    }
}

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
        [Fact]
        public void FilterOutJustDogs()
        {
            //Arrange
            List<Animal> animals = new List<Animal>()
            {
                new Dog(1,"Blizten1", "2000-01-01","ASD323"),
                new Bird(1,"Blizten2", "2000-01-01",12,true),
                new Dog(1,"Blizten3", "2000-01-01","ASD323"),
                new Bird(1,"Blizten4", "2000-01-01",12,true),
                new Dog(1,"Blizten5", "2000-01-01","ASD323")
            };

            //Act
            var result = ZooUtil.FilterToOnlyDogs(animals);

            //Assert
            Assert.IsType<List<Dog>>(result);
            Assert.Equal(3, result.Count);
            //Assert.True(result.Count == 3);
        }
    }
}

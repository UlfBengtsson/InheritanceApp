using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ZooCore.Models;

namespace ZooCore.Tests.Models
{
    public class DogTests
    {
        [Fact]
        public void ConstructorCreatesDogWithCorrectInfo()
        {
            //Arrange
            int id = 66;
            string name = "Molly";
            string birthDate = "2000-03-21";
            string chipId = "HUND12";
            bool expectedIsAlive = true;

            //Act
            Dog result = new Dog(id, name, birthDate, chipId);

            //Assert
            Assert.Equal(id ,result.Id);
            Assert.Equal(name, result.Name);
            Assert.Equal(birthDate, result.Birth.ToShortDateString());
            Assert.Equal(chipId, result.ChipId);
            Assert.Equal(expectedIsAlive, result.IsAlive);
        }

        [Fact]
        public void SetDeathMakesIsAliveFalse()
        {
            //Arrange
            int id = 77;
            string name = "Molly";
            string birthDate = "2000-03-21";
            string chipId = "HUND12";
            Dog dog = new Dog(id, name, birthDate, chipId);

            DateTime deathOfDog = DateTime.Parse("2012-03-21");

            //Act
            dog.Death = deathOfDog;
            var resultDeath = dog.Death;

            //Assert
            Assert.False(dog.IsAlive);
            Assert.Equal(deathOfDog, resultDeath);
        }

        [Theory]
        [InlineData("2004-03-21", "Age: 4")]
        [InlineData("2009-03-21", "Age: 9")]
        [InlineData("2012-03-21", "Age: 12")]
        public void DeadDogsAge(string deathString, string expected)
        {
            //Arrange
            string birthDate = "2000-03-21";
            int id = 77;
            string name = "Molly";
            string chipId = "HUND12";
            Dog dog = new Dog(id, name, birthDate, chipId);
            DateTime deathOfDog = DateTime.Parse(deathString);
            dog.Death = deathOfDog;

            //Act
            var result = dog.Age();

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void AliveDogsAge()
        {
            //Arrange
            int id = 77;
            string name = "Molly";
            //string birthDate = DateTime.Now.ToShortDateString();
            string birthDate = DateTime.Now.AddYears(-1).ToShortDateString();
            string chipId = "HUND12";
            Dog dog = new Dog(id, name, birthDate, chipId);

            string expected = "Age: 1";

            //Act
            var result = dog.Age();

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void DeathBeforeBirthException()
        {
            //Arrange
            int id = 77;
            string name = "Molly";
            string birthDate = "2000-02-12";
            string deathDate = "1990-12-02";
            string chipId = "HUND12";
            Dog dog = new Dog(id, name, birthDate, chipId);

            //Act - Assert
            var result = Assert.Throws<ArgumentException>(() => 
                            dog.Death = DateTime.Parse(deathDate));

            //Assert
            Assert.Equal("Death can not be before it was born.", result.Message);
        }
    }
}

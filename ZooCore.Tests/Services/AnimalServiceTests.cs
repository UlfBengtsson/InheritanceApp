using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ZooCore.Models;
using ZooCore.Services;

namespace ZooCore.Tests.Services
{
    public class AnimalServiceTests
    {
        [Fact]
        public void CreateAndSaveDog()
        {
            //Arrange
            ICrud<Animal> service = new AnimalService();
            string name = "Thunder";
            string birth = "2000-12-12";
            string chipId = "ase42";
            int dangerLevel = 6;
            Dog dog = new Dog(int.MaxValue, name, birth, chipId, dangerLevel);

            //Act
            Animal animalResult = service.CreateAndSave(dog);
            List<Animal> animalsListResult = service.FindAll();

            //Assert
            Assert.NotNull(animalResult);
            Assert.Contains(animalResult, animalsListResult);
            Assert.NotEqual(0, animalResult.Id);
            Assert.NotEqual(int.MaxValue, animalResult.Id);
            Assert.Equal(name, animalResult.Name);
            Assert.Equal(birth, animalResult.Birth.ToShortDateString());
            
            Dog dogResult = Assert.IsType<Dog>(animalResult);
            Assert.Equal(chipId, dogResult.ChipId);
            Assert.Equal(dangerLevel, dogResult.DangerLevel());
        }

        [Fact]
        public void CreateAndSaveBird()
        {
            //Arrange
            ICrud<Animal> service = new AnimalService();
            string name = "Segual";
            string birth = "2000-12-12";
            int wingSpan = 42;
            bool canFly = true;
            Bird bird = new Bird(int.MaxValue, name, birth, wingSpan, canFly);

            //Act
            Animal animalResult = service.CreateAndSave(bird);
            List<Animal> animalsListResult = service.FindAll();

            //Assert
            Assert.NotNull(animalResult);
            Assert.Contains(animalResult, animalsListResult);
            Assert.NotEqual(0, animalResult.Id);
            Assert.NotEqual(int.MaxValue, animalResult.Id);
            Assert.Equal(name, animalResult.Name);
            Assert.Equal(birth, animalResult.Birth.ToShortDateString());

            Bird birdResult = Assert.IsType<Bird>(animalResult);
            Assert.Equal(wingSpan, birdResult.WingSpan);
            Assert.Equal(canFly, birdResult.CanFly);
        }
    }
}

using LightController;
using NUnit.Framework;

namespace TestProject
{
    public class Tests
    {
        
        [Test]
        public void CreationTest()
        {
            var controller = new Controller(4, 5);
            Assert.AreEqual(0, controller.GetTurnedOnAmount());
        }

        [Test]
        public void TurnOnSingleElementTest()
        {
            var controller = new Controller(3, 3);
            controller.TurnOnRange(1,1,1,1);
            Assert.AreEqual(1, controller.GetTurnedOnAmount());
        }

        [Test]
        public void TurnOnTest()
        {
            var controller = new Controller(4, 5);
            controller.TurnOnRange(1, 1, 2, 2);
            Assert.AreEqual(4,controller.GetTurnedOnAmount());
        }
        
        [Test]
        public void TurnOffSingleElementTest()
        {
            var controller = new Controller(4, 5);
            controller.TurnOnRange(1, 1, 2, 2);
            controller.TurnOffRange(2, 2, 2, 2);
            Assert.AreEqual(3,controller.GetTurnedOnAmount());
        }
        
        [Test]
        public void TurnOffTest()
        {
            var controller = new Controller(4, 5);
            controller.TurnOnRange(0, 0, 3, 4);
            controller.TurnOffRange(2, 2, 3, 3);
            Assert.AreEqual(16,controller.GetTurnedOnAmount());
        }
        
        [Test]
        public void ToggleSingleElementTest()
        {
            var controller = new Controller(3, 3);
            controller.ToggleRange(1,1,1,1);
            Assert.AreEqual(1, controller.GetTurnedOnAmount());
        }
        
        [Test]
        public void ToggleTest()
        {
            var controller = new Controller(4, 5);
            controller.ToggleRange(1, 1, 2, 2);
            Assert.AreEqual(4,controller.GetTurnedOnAmount());
        }

        [Test]
        public void ComplexTest()
        {
            var controller = new Controller(5, 5);
            controller.TurnOnRange(1,1,3,3);
            controller.TurnOffRange(2,2,2,2);
            Assert.AreEqual(8, controller.GetTurnedOnAmount());
            controller.ToggleRange(0,0,4,4);
            Assert.AreEqual(17, controller.GetTurnedOnAmount());
        }
        
    }
}
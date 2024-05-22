using Technology;
namespace TechnologyTests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestIncreasingRam()
    {
        // Arrange
        Computer testingComputer = new Computer(2, 3, true);
        // Act
        testingComputer.IncreaseRam(3);
        // Assert
        Assert.AreEqual(5, testingComputer.Ram);
    }
    [TestMethod]
    public void TestIncreasingStorage()
    {
        // Arrange
        Computer testingComputer = new Computer(2, 3, true);
        // Act
        testingComputer.IncreaseStorage(3);
        // Assert
        Assert.AreEqual(6, testingComputer.Storage);
    }
    [TestMethod]
    public void TestLaptopInheritsRam()
    {
        // Arrange
        Laptop testingLaptop = new Laptop(2, 3, true, 4);
        // Act
        // Assert
        Assert.AreEqual(2, testingLaptop.Ram);
    }
    [TestMethod]
    public void TestLaptopInheritsStorage()
    {
        // Arrange
        Laptop testingLaptop = new Laptop(2, 3, true, 4);
        // Act
        // Assert
        Assert.AreEqual(3, testingLaptop.Storage);
    }
    [TestMethod]
    public void TestClunky()
    {
        // Arrange
        Laptop testingLaptop = new Laptop(2, 3, true, 4);
        // Act
        // Assert
        Assert.IsFalse(testingLaptop.IsClunky());
    }
    [TestMethod]
    public void TestSmartPhoneInheritsStorage()
    {
        // Arrange
        SmartPhone testingSmartPhone = new SmartPhone(2, 3, false, 0);
        // Act
        // Assert
        Assert.AreEqual(3, testingSmartPhone.Storage);
    }
    [TestMethod]
    public void TestSmartPhoneInheritsHasKeyboard()
    {
        // Arrange
        SmartPhone testingSmartPhone = new SmartPhone(2, 3, false, 0);
        // Act
        // Assert
        Assert.IsFalse(testingSmartPhone.hasKeyboard);
    }
    [TestMethod]
    public void TestSmartPhoneTakesSelfie()
    {
        // Arrange
        SmartPhone testingSmartPhone = new SmartPhone(2, 3, false, 0);
        // Act
        testingSmartPhone.TakeSelfie();
        // Assert
        Assert.AreEqual(1, testingSmartPhone.NumberOfSelfies);
    }
}
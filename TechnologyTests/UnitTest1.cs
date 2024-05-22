using Technology;
namespace TechnologyTests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestInheritsId()
    {
        // Arrange
        Computer testingComputer = new Computer(2, 3, true);
        Computer testingComputer2 = new Computer(4, 6, true);
        // Act
        // Assert
        // TODO: this test is unstable/flaky. Static ID increments with each
        //   instance a Computer/Laptop/SmartPhone is created. Hence, if
        //   TestInheritsId() is called before other tests, the instance
        //   Id are 1 & 2 respectively. However, if TestInheritsId() is called
        //   after another test that creates an instance of Computer/Laptop/
        //   SmartPhone, the instance Id wiil not be 1 & 2. Need to figure out
        //   how to fix this.
        Assert.AreEqual(1, testingComputer.Id);
        Assert.AreEqual(2, testingComputer2.Id);
    }
    [TestMethod]
    public void TestInheritingBaseConstructor()
    {
        // Arrange
        SmartPhone testingSmartphone = new SmartPhone(2, 3, true, 800);
        // Act
        // Assert
        Assert.IsNotNull(testingSmartphone.Id);
    }
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
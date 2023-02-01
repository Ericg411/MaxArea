namespace MaxArea.Tests;

[TestClass]
public class UnitTest1
{
    private readonly MaxAreaClass _maxArea;

    public UnitTest1() 
    {
        _maxArea = new MaxAreaClass();
    }

    [TestMethod]
    public void TestMethod1()
    {
        int[] ints = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };

        int result = _maxArea.MaxArea(ints);

        Assert.AreEqual(49, result);
    }

    [TestMethod]
    public void TestMethod2()
    {
        int[] ints = { 1, 1 };

        int result = _maxArea.MaxArea(ints);

        Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void TestMethod3()
    {
        int[] ints = { 1, 8, 6, 2, 5, 4, 8, 3, 7, 6, 7, 9, 9, 6, 4, 3, 3, 6, 87, 9, 9, 7, 5, 4, 43, 4, 5, 76, 8, 9, 9, 7, 5, 4 };

        int result = _maxArea.MaxArea(ints);

        Assert.AreEqual(684, result);
    }
}
namespace Calculate.Tests;

public class CalculatorTests
{
    // ---- Add ----

    [Fact]
    public void Add_TwoPositiveNumbers_ReturnsSum()
    {
        Calculator calculate = new Calculator();
        Assert.Equal(5, calculate.Add(2, 3));
    }

    [Fact]
    public void Add_PositiveAndNegative_ReturnsSum()
    {
        Calculator calculate = new Calculator();
        Assert.Equal(-1, calculate.Add(2, -3));
    }

    [Fact]
    public void Add_TwoNegatives_ReturnsSum()
    {
        Calculator calculate = new Calculator();
        Assert.Equal(-7, calculate.Add(-3, -4));
    }

    [Fact]
    public void Add_WithZero_ReturnsOtherOperand()
    {
        Calculator calculate = new Calculator();
        Assert.Equal(42, calculate.Add(42, 0));
        Assert.Equal(42, calculate.Add(0, 42));
    }

    
    // ---- Theory-based sanity check ----

    [Theory]
    [InlineData(1, 1, 2)]
    [InlineData(10, 5, 15)]
    [InlineData(-4, -6, -10)]
    [InlineData(0, 0, 0)]
    public void Add_VariousInputs_ReturnsExpected(int a, int b, int expected)
    {
        Calculator calculate = new Calculator();
        Assert.Equal(expected, calculate.Add(a, b));
    }

}

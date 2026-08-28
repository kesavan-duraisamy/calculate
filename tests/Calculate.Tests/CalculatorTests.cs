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

    // ---- Subtract ----

    [Fact]
    public void Subtract_TwoPositiveNumbers_ReturnsDifference()
    {
        Calculator calculate = new Calculator();
        Assert.Equal(2, calculate.Subtract(5, 3));
    }

    [Fact]
    public void Subtract_ResultingInNegative_ReturnsNegative()
    {
        Calculator calculate = new Calculator();
        Assert.Equal(-2, calculate.Subtract(3, 5));
    }

    [Fact]
    public void Subtract_TwoNegatives_ReturnsDifference()
    {
        Calculator calculate = new Calculator();
        Assert.Equal(1, calculate.Subtract(-3, -4));
    }

    [Fact]
    public void Subtract_WithZero_ReturnsOtherOperand()
    {
        Calculator calculate = new Calculator();
        Assert.Equal(42, calculate.Subtract(42, 0));
        Assert.Equal(-42, calculate.Subtract(0, 42));
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

    [Theory]
    [InlineData(10, 3, 7)]
    [InlineData(3, 10, -7)]
    [InlineData(-5, -2, -3)]
    [InlineData(0, 0, 0)]
    public void Subtract_VariousInputs_ReturnsExpected(int a, int b, int expected)
    {
        Calculator calculate = new Calculator();
        Assert.Equal(expected, calculate.Subtract(a, b));
    }
}

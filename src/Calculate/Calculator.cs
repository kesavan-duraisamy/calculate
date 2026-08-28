namespace Calculate;

/// <summary>
/// Provides basic arithmetic operations: addition and subtraction.
/// </summary>
public class Calculator
{
    /// <summary>
    /// Returns the sum of two integers.
    /// </summary>
    /// <param name="a">The first operand.</param>
    /// <param name="b">The second operand.</param>
    /// <returns>The result of <paramref name="a"/> + <paramref name="b"/>.</returns>
    public int Add(int a, int b) {
        int value = a + b;
        return value;
    }

    /// <summary>
    /// Returns the difference of two integers (<paramref name="a"/> - <paramref name="b"/>).
    /// </summary>
    /// <param name="a">The minuend.</param>
    /// <param name="b">The subtrahend.</param>
    /// <returns>The result of <paramref name="a"/> - <paramref name="b"/>.</returns>
    public int Subtract(int a, int b) {
        int value = a - b;
        return value;
    }
}
public static class SimpleCalculator
{



    public static string Calculate(int operand1, int operand2, string? operation)
    {
        string[] possibleValues = { "+", "-", "/" };
        long sum;

        switch (operation)
        {
            case "+":
                sum = operand1 + operand2;
                break;
            case "-":
                sum = operand1 - operand2;
                break;
            case "/":
                if ((operand1 == 0) || (operand2 == 0))
                {
                    return "Division by zero is not allowed.";
                    //divideByZero = "Division by zero is not allowed.";
                    //throw new ArgumentOutOfRangeException("Division by zero is not allowed.");
                }
                else
                {
                    sum = operand1 / operand2;
                }
                break;
            case "*":
                sum = operand1 * operand2;
                break;
            case "":
                throw new ArgumentException();
            case null:
                throw new ArgumentNullException();
            default:
                throw new ArgumentOutOfRangeException(nameof(operation), $"Operation {operation} not allowed.");
        }

        return $"{operand1} {operation} {operand2} = {sum}";
    }
}

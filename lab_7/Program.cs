namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator<int> intCalculator = new Calculator<int>();
            Calculator<double> doubleCalculator = new Calculator<double>();
            Calculator<float> floatCalculator = new Calculator<float>();

            bool continueCalculations = true;

            while (continueCalculations)
            {
                Console.WriteLine("Choose data type: 'int' 'double' 'float' or 'exit' to quit");
                string dataType = Console.ReadLine();

                if (dataType.ToLower() == "exit")
                {
                    break;
                }

                if (dataType == "int")
                {
                    int firstValue, secondValue;
                    string operation;

                    Console.WriteLine("Enter first number:");
                    if (int.TryParse(Console.ReadLine(), out firstValue))
                    {
                        Console.WriteLine("Enter second number:");
                        if (int.TryParse(Console.ReadLine(), out secondValue))
                        {
                            Console.WriteLine("Choose operation: '+', '-', '*', '/'");
                            operation = Console.ReadLine();

                            Calculator<int>.MathOperation mathOperation = operation switch
                            {
                                "+" => (a, b) => a + b,
                                "-" => (a, b) => a - b,
                                "*" => (a, b) => a * b,
                                "/" => (a, b) => a / b,
                                _ => throw new InvalidOperationException("Invalid operation"),
                            };

                            int result = intCalculator.PerformOperation(firstValue, secondValue, mathOperation);
                            Console.WriteLine($"Result: {result}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid second number");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid first number");
                    }
                }
                else if (dataType == "double")
                {
                    double firstValue, secondValue;
                    string operation;

                    Console.WriteLine("Enter first number:");
                    if (double.TryParse(Console.ReadLine(), out firstValue))
                    {
                        Console.WriteLine("Enter second number:");
                        if (double.TryParse(Console.ReadLine(), out secondValue))
                        {
                            Console.WriteLine("Choose operation: '+', '-', '*', '/'");
                            operation = Console.ReadLine();

                            Calculator<double>.MathOperation mathOperation = operation switch
                            {
                                "+" => (a, b) => a + b,
                                "-" => (a, b) => a - b,
                                "*" => (a, b) => a * b,
                                "/" => (a, b) => a / b,
                                _ => throw new InvalidOperationException("Invalid operation"),
                            };

                            double result = doubleCalculator.PerformOperation(firstValue, secondValue, mathOperation);
                            Console.WriteLine($"Result: {result}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid second number");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid first number");
                    }
                }
                else if (dataType == "float")
                {
                    float firstValue, secondValue;
                    string operation;

                    Console.WriteLine("Enter first number:");
                    if (float.TryParse(Console.ReadLine(), out firstValue))
                    {
                        Console.WriteLine("Enter second number:");
                        if (float.TryParse(Console.ReadLine(), out secondValue))
                        {
                            Console.WriteLine("Choose operation: '+', '-', '*', '/'");
                            operation = Console.ReadLine();

                            Calculator<float>.MathOperation mathOperation = operation switch
                            {
                                "+" => (a, b) => a + b,
                                "-" => (a, b) => a - b,
                                "*" => (a, b) => a * b,
                                "/" => (a, b) => a / b,
                                _ => throw new InvalidOperationException("Invalid operation"),
                            };

                            float result = floatCalculator.PerformOperation(firstValue, secondValue, mathOperation);
                            Console.WriteLine($"Result: {result}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid second number");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid first number");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid data type. Please choose 'int' 'double' 'float' or 'exit'");
                }
            }
        }
    }
}
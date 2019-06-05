using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        //Метод приёма и ввывода расчётных данных
        static public double Calculate(string input)
        {
            string output = GetPOZ(input);
            double result = Counting(output);
            return result;
        }

        //Метод переводящий в обратную Польскую запись
        static public string GetPOZ(string input)
        {
            string output = string.Empty;
            Stack<char> stackPOZ = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (isDelimetr(input[i])) { continue; }

                if (Char.IsDigit(input[i]))
                {
                    while (!isDelimetr(input[i]) && !isOperatr(input[i]))
                    {
                        output += input[i];
                        i++;

                        if (i == input.Length) { break; }
                    }

                    output += " ";
                    i--;
                }

                if (isOperatr(input[i]))
                {
                    if (input[i] == '(')
                    {
                        stackPOZ.Push(input[i]);
                    }
                    else if (input[i] == ')')
                    {
                        char s = stackPOZ.Pop();

                        while (s != '(')
                        {
                            output += s.ToString() + " ";
                            s = stackPOZ.Pop();
                        }
                    }
                    else
                    {
                        if (stackPOZ.Count > 0)
                        {
                            if (getPriority(input[i]) <= getPriority(stackPOZ.Peek()))
                            {
                                output += stackPOZ.Pop().ToString() + " ";
                            }

                            stackPOZ.Push(Char.Parse(input[i].ToString()));
                        }
                        else
                        { stackPOZ.Push(Char.Parse(input[i].ToString())); }
                    }
                }

            }

            while (stackPOZ.Count > 0)
            {
                output += stackPOZ.Pop() + " ";
            }
            return output;

        }

        //Метад вычисляющий выражение, уже преобразованного в обратную Польскую запись
        static private double Counting(string input)
        {
            double result = 0;
            Stack<double> stackResult = new Stack<double>();

            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]))
                {
                    string number = string.Empty;

                    while (!isDelimetr(input[i]) && !isOperatr(input[i]))
                    {
                        number += input[i];
                        i++;
                        if (i == input.Length) { break; }
                    }

                    stackResult.Push(double.Parse(number));
                    i--;
                }
                else if (isOperatr(input[i]))
                {
                    double a = stackResult.Pop();
                    double b = stackResult.Pop();

                    switch (input[i])
                    {
                        case '+':
                            result = b + a;
                            break;
                        case '-':
                            result = b - a;
                            break;
                        case '*':
                            result = b * a;
                            break;
                        case '/':
                            result = b / a;
                            break;
                        case '^':
                            result = double.Parse(Math.Pow(double.Parse(b.ToString()), double.Parse(a.ToString())).ToString());
                            break;
                    }
                    stackResult.Push(result);
                }
            }
            return stackResult.Peek();
        }

        static private bool isDelimetr(char c)
        {
            if (" =".IndexOf(c) != -1)
            {
                return true;
            }
            return false;
        }
        static private bool isOperatr(char c)
        {
            if ("+-*/^()".IndexOf(c) != -1)
            {
                return true;
            }
            return false;
        }
        static private byte getPriority(char s)
        {
            switch (s)
            {
                case '(':
                    return 0;
                case ')':
                    return 1;
                case '+':
                    return 2;
                case '-':
                    return 3;
                case '*':
                    return 4;
                case '/':
                    return 5;
                case '^':
                    return 6;
                default: return 7;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите выражение: ");
            Console.WriteLine(Calculator.Calculate(Console.ReadLine()));
            Console.ReadKey();
        }
    }
}

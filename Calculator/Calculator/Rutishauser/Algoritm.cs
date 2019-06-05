using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rutishauser
{
    abstract class Algoritm
    {
        protected static double AfterAlgoritm(string input)
        {
            List<string> afterPars = ToParsString(input);
            double result = Calculate(afterPars);
            return result;
        }

        private static double Calculate(List<string> input)
        {
            double result = 0;
            bool while1 = true;
            while (while1)
            {
                double peremenayaMax1 = 0;
                int indexMax1 = 0;
                double peremenayaMax2 = 0;
                int indexMax2 = 0;
                string operant = string.Empty;
                int max = 0;
                int[] levels = Leveling(input);

                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] == "(" || input[i] == ")")
                    {
                        continue;
                    }
                    if (levels[i] > max)
                    {
                        max = levels[i];
                        peremenayaMax1 = double.Parse(input[i]);
                        indexMax1 = i;
                    }
                    else if (levels[i] == max)
                    {
                        peremenayaMax2 = double.Parse(input[i]);
                        operant = input[i - 1];
                        indexMax2 = i;

                    }
                }

                switch (operant)
                {
                    case "+":
                        result = peremenayaMax1 + peremenayaMax2;
                        input.RemoveRange(indexMax1 - 1, 5);
                        string st = result.ToString();
                        input.Insert(indexMax1 - 1, st);
                        break;
                    case "-":
                        result = peremenayaMax1 - peremenayaMax2;
                        input.RemoveRange(indexMax1 - 1, 5);
                        string st1 = result.ToString();
                        input.Insert(indexMax1 - 1, st1);
                        break;

                    case "*":
                        result = peremenayaMax1 * peremenayaMax2;
                        input.RemoveRange(indexMax1 - 1, 5);
                        string st2 = result.ToString();
                        input.Insert(indexMax1 - 1, st2);
                        break;

                    case "/":
                        result = peremenayaMax1 / peremenayaMax2;
                        input.RemoveRange(indexMax1 - 1, 5);
                        string st3 = result.ToString();
                        input.Insert(indexMax1 - 1, st3);
                        break;
                }

                if (input.Count < 2)
                {
                    while1 = false;
                }
            }
            return result;
        }

        private static int[] Leveling(List<string> input)
        {
            int numberLevel = 0;
            int[] levels = new int[input.Count];

            for (int i = 0; i < input.Count; i++)
            {
                if (IsNumber(input[i]))
                {
                    numberLevel += 1;
                    levels[i] = numberLevel;
                }
                else if (IsOperation(input[i]))
                {
                    numberLevel -= 1;
                    levels[i] = numberLevel;
                }
                else
                {
                    Console.WriteLine("В выражении не допустимый символ!");
                }
            }

            return levels;
        }

        private static List<string> ToParsString(string input)
        {
            List<string> afterPars = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                if(input[i] == '(' || IsOperation(input[i]))
                {
                    afterPars.Add(input[i].ToString());
                }
                else if(input[i -1] == '(' || IsOperation(input[i-1]))
                {
                    afterPars.Add(input[i].ToString());
                }
                else
                {
                    afterPars[afterPars.Count -1] += input[i];
                }
            }
            return afterPars;
        }

        private static bool IsNumber(dynamic c)
        {
            double d = 4.2d;
            if ("(".IndexOf(c) != -1 || double.TryParse(c, out double a))
            {
                return true;
            }
            return false;
        }

        private static bool IsOperation(dynamic c)
        {
            if ("+-*/)".IndexOf(c) != -1)
            {
                return true;
            }
            return false;
        }
    }
}

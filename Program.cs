namespace PTFirstLabThirdTask
{
    class Logic
    {
        public static int GetExpressionResult(string inputText)
        {
            int currentNumber = 0;
            char currentSign = '+';

            int numberMultiplier;
            int textNumbersSum = 0;

            foreach (char c in inputText)
            {
                if (c == '+' || c == '-')
                {
                    numberMultiplier = (currentSign == '-') ? -1 : 1;
                    textNumbersSum += numberMultiplier * currentNumber;
                    currentNumber = 0;
                    currentSign = c;
                }
                else
                {
                    currentNumber = currentNumber * 10 + (c - '0');
                }
            }

            numberMultiplier = (currentSign == '-') ? -1 : 1;
            textNumbersSum += numberMultiplier * currentNumber;

            return textNumbersSum;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст вида d_1±d_2±...±d_n, где d_i — цифры (n > 1): ");

            string inputText = Console.ReadLine();

            int textNumbersSum = Logic.GetExpressionResult(inputText);

            Console.WriteLine($"Вычисленная сумма равна {textNumbersSum}");
        }
    }
}

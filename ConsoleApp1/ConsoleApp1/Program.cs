using System.Diagnostics;
using System.Net.Http.Headers;

namespace ConsoleApp1
{
    internal class Program
    {
        static private Random Random = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine(Integer8(8));
            //Console.WriteLine(Integer27(14));
            Console.WriteLine(Boolean39((2, 2), (1, 1)));
            Console.WriteLine(If18(0, 2 ,0));
            Console.WriteLine(If27(3));
            Console.WriteLine(For10(10));
            Console.WriteLine(For25(0.5f, 5));
            Console.WriteLine(While10(28));
            Console.WriteLine(Series23(new int[] { 1, 2, 1, 3, 2, 3, 3, 3 }));
            Console.WriteLine(Proc28(new int[] { 4, 3, 5, 7, 11, 13, 17, 19, 23, 29 }));
            Proc29(new int[] { 231, 233, 23454, 2222, 22, 22, 22, 2, 423, 54353534});
        }

        private static int[] FillRandomIntArray(int Length)
        {
            int[] array = new int[Length];

            for(int i =0; i < Length; i++)
            {
                array[i] = Random.Next();
            }

            return array;
        }

        #region Integers
        private static int Integer8(int number)
        {
            if(number / 10 == 0)
                return number;

            int firstNumber = (number % 10) * 10;
            int secondNumber = number / 10;

            return firstNumber + secondNumber;
        }
        //Fix this
        private static int Integer27(int dayNumber)
        {
            int countOfWeeks = dayNumber / 7;

            dayNumber -= countOfWeeks * 7;

            int dayOfWeekNumber = dayNumber + 1;

            return dayOfWeekNumber;
        }
        #endregion

        #region Boolean
        private static bool Boolean39((int x, int y) newCords, (int x, int y) currentCords)
        {
            if (newCords == currentCords)
                return false;

            int XDiagonal = newCords.x - currentCords.x;
            int YDiagonal = newCords.y - currentCords.y;

            return XDiagonal == YDiagonal;
        }
        #endregion

        #region If
        static private int If18(int Number1, int Number2, int Number3)
        {
            if (Number1 == Number2)
                return 3;
            else if (Number2 == Number3)
                return 1;
            else if (Number3 == Number1)
                return 2;

            return 0;
        }
        static private int If27(int X)
        {
            if (X < 0)
                return 0;

            if (X % 2 == 0)
                return 1; 
            else return -1;
        }
        #endregion

        #region For
        static private float For10(int number)
        {
            float summ = 0;

            for (int i = 1; i <= number; i++)
                summ += 1 / i;

            return summ;
        }
        static private float For25(float X, float number)
        {
            float previousSquare = 1;

            float summ = 0;

            int currentTurn = 1;

            for(int i = 1; i <= number; i++)
            {
                summ += (previousSquare / i) * currentTurn;

                previousSquare *= X;

                currentTurn *= -1;
            }

            return summ;
        }
        #endregion

        #region While
        private static int While10(int Number)
        {
            int three = 3;

            int power = 1;

            while(three < Number)
            {
                three *= 3;

                power++;
            }

            return power;
        }
        #endregion

        #region Series
        private static int Series23(int[] Numbers)
        {
            int invalidNumber = 0;

            for(int i = 1; i <= Numbers.Length - 1;i++) 
            {
                if (IsDifferentFromNeigbors(Numbers[i - 1], Numbers[i], Numbers[i + 1]))
                    continue;

                invalidNumber = i;

                break;
            }

            return invalidNumber;
        }

        private static bool IsDifferentFromNeigbors(int LeftNumber, int MiddleNumber, int RightNumber)
        {
            bool isHigher = MiddleNumber > RightNumber && MiddleNumber > LeftNumber;
            bool isLower = MiddleNumber < RightNumber && MiddleNumber < LeftNumber;

            return isHigher || isLower;
        }
        #endregion

        #region Proc
        private static int Proc28(int[] Numbers)
        {
            int countOfPrimeNumbers = 0;

            foreach(var number in Numbers)
            {
                if(IsPrime(number))
                    countOfPrimeNumbers++;
            }

            return countOfPrimeNumbers;
        }
        private static bool IsPrime(int Number)
        {
            for(int i = 2; i < 10; i ++)
            {
                if (Number % i == 0 && i != Number)
                    return false;
            }

            return true;
        }

        private static void Proc29(int[] Numbers)
        {
            Console.WriteLine();
            Console.WriteLine("-PROC 29-");

            foreach (var number in Numbers)
                Console.WriteLine(DigitCount(number));

            Console.WriteLine();
        }
        private static int DigitCount(int Number)
            => Number.ToString().Length;
        #endregion

        #region MinMax
        static private List<int> MinMax23(int Length)
        {
            int[] numbers = FillRandomIntArray(Length);

            List<int> biggestValues = new();

            for(int i = 0; i < 3; i++)
            {
                int biggestNumber = -1;

                for (int j = 0; j < Length; j++)
                {
                    if (numbers[j] > biggestNumber)
                        biggestNumber = numbers[j];
                }

                biggestValues.Add(biggestNumber);
            }

            //Sorting here

            return biggestValues;
        }
        #endregion
    }
}
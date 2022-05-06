using System;

namespace BasicProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");

            FlipCoin Coin = new FlipCoin();
            Coin.FlipCoinCount();

            PowerOfTwo Power = new PowerOfTwo();
            Power.PowerOf();

            QuotientAndRemainder FindQandR = new QuotientAndRemainder();
            FindQandR.FindQuotientAndRemainder();

            SwapTwoNum TwoNum = new SwapTwoNum();
            TwoNum.SwapTwoNumber();

            EvenOdd NumberIsEvenOdd = new EvenOdd();
            NumberIsEvenOdd.FindEvenOdd();

            VowelOrConsonant.FindVowelOrConsonant();

            ThreeNumber Largest = new ThreeNumber();
            Largest.FindThreeNum();
        }
    }
}

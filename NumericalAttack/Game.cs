using System;

namespace NumericalAttack
{
    class Game
    {
        private static readonly Random random = new Random();

        /// <summary>
        /// 次の問題を作成する
        /// </summary>
        /// <returns></returns>
        public static CalcInfo MakeNextQuestion()
        {
            CalcOperators opr = (CalcOperators)random.Next(0, 4);
            int value1 = random.Next(10, 100);
            int value2 = random.Next(10, 100);
            switch (opr)
            {
                case CalcOperators.Subtract:
                    if (value1 < value2) // マイナスにならないようにする
                    {
                        int tmp = value1;
                        value1 = value2;
                        value2 = tmp;
                    }
                    break;
                case CalcOperators.Multiply:
                    value2 = random.Next(0, 10); // 2番目の数字を小さめにする
                    break;
                case CalcOperators.Division:
                    while (value1 < value2 || value1 % value2 != 0) // 割り切れるような問題を作る
                    {
                        value1 = random.Next(10, 100);
                        value2 = random.Next(10, 100);
                    }
                    break;
            }

            CalcInfo info = new CalcInfo(value1, value2, opr);
            return info;
        }
    }
}

using System.Collections.Generic;

namespace NumericalAttack
{
    class GameStatus
    {
        public int No { get; set; }

        public int Correct { get; set; }

        public int Miss { get; set; }

        public int Combo { get; set; }

        public int MaxCombo { get; set; }

        public List<CalcInfo> History { get; private set; }

        public CalcInfo Current { get; private set; }

        public bool GameOver { get; set; }

        public void Reset()
        {
            No = 0;
            Correct = 0;
            Miss = 0;
            Combo = 0;
            MaxCombo = 0;
            History = new List<CalcInfo>();
            GameOver = false;
        }

        public void AddInfo(CalcInfo info)
        {
            Current = info;
            History.Add(info);
        }

        public double GetCorrectRate()
        {
            return Correct * 100.0 / No;
        }

        public double GetMissRate()
        {
            return Miss * 100.0 / No;
        }
    }
}

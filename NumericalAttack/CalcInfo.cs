namespace NumericalAttack
{
    public enum CalcOperators
    {
        Add = 0, Subtract, Multiply, Division
    }

    public class CalcInfo
    {
        public static readonly string[] OperatorChars = {"＋", "－", "×", "÷"};

        public static string CALC_STRING = "{0} {1} {2} ＝ {3}";

        public int Value1 { get; set; }
        public int Value2 { get; set; }
        public CalcOperators Operator { get; set; }
        public int CorrectAnswer { get; set; }
        public string UserAnswer { get; set; }

        public bool JudgeResult { get; set; }

        public CalcInfo(int value1, int value2, CalcOperators calcOperator)
        {
            this.Value1 = value1;
            this.Value2 = value2;
            this.Operator = calcOperator;
            this.CorrectAnswer = Calc();
            this.UserAnswer = "？";
        }

        public int Calc() {
            int result = 0;

            switch (this.Operator)
            {
                case CalcOperators.Add:
                    result = Value1 + Value2;
                    break;
                case CalcOperators.Subtract:
                    result = Value1 - Value2;
                    break;
                case CalcOperators.Multiply:
                    result = Value1 * Value2;
                    break;
                case CalcOperators.Division:
                    result = Value1 / Value2;
                    break;
            }

            return result;
        }

        public override string ToString()
        {
            return string.Format(CALC_STRING, Value1, OperatorChars[(int)Operator], Value2, UserAnswer);
        }

        public string Judge(string strUserAnswer)
        {
            JudgeResult = false;

            UserAnswer = strUserAnswer;
            int userAnswer;
            if (int.TryParse(strUserAnswer, out userAnswer))
            {
                JudgeResult = CorrectAnswer == userAnswer;
            }
            
            return JudgeResult ? "○" : "× (" + CorrectAnswer + ")";
        }
    }
}

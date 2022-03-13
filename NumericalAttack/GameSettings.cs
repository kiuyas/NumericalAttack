namespace NumericalAttack
{
    public class GameSettings
    {
        /// <summary>思考時間(デフォルト5秒)</summary>
        public int Count { get; set; }

        /// <summary>出題集(デフォルト50問)</summary>
        public int Questions { get; set; }

        public GameSettings()
        {
            Count = 5;
            Questions = 50;
        }
    }
}

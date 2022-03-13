using System.Windows.Forms;

namespace NumericalAttack
{
    /// <summary>
    /// 設定画面フォームクラス
    /// </summary>
    public partial class Form2 : Form
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Form2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="settings"></param>
        public Form2(GameSettings settings)
            : this()
        {
            if (settings.Count == 5)
            {
                rdoSec5.Checked = true;
            }
            else
            {
                rdoSec10.Checked = true;
            }

            if (settings.Questions == 50)
            {
                rdoQ50.Checked = true;
            }
            else
            {
                rdoQ100.Checked = true;
            }
        }

        /// <summary>
        /// ゲーム設定取得
        /// </summary>
        /// <returns>ゲーム設定</returns>
        public GameSettings GetSettings()
        {
            GameSettings settings = new GameSettings();
            if (rdoSec10.Checked)
            {
                settings.Count = 10;
            }
            if (rdoQ100.Checked)
            {
                settings.Questions = 100;
            }
            return settings;
        }
    }
}

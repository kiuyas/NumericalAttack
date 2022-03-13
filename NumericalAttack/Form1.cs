using System;
using System.Windows.Forms;

namespace NumericalAttack
{
    /// <summary>
    /// メイン画面フォームクラス
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>ゲーム設定</summary>
        private GameSettings settings = new GameSettings();

        /// <summary>ゲーム状況</summary>
        private GameStatus status = null;

        /// <summary>表示欄ラベル</summary>
        private Label[] labels = null;

        /// <summary>カウント</summary>
        private int count = 0;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            labels = new Label[] { lblCorrect, lblCorrectRate, lblMiss, lblMissRate, lblCombo, lblMaxCombo };
            prbCount.Minimum = 0;
            prbCount.Maximum = settings.Count;
        }

        /// <summary>
        /// 開始ボタン押下時処理
        /// </summary>
        /// <param name="sender">イベント発生オブジェクト</param>
        /// <param name="e">イベント引数</param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnSettings.Enabled = false;
            InitGameStatus();
            MakeNextQuestion();
        }

        /// <summary>
        /// ゲーム状況初期化
        /// </summary>
        private void InitGameStatus()
        {
            status = new GameStatus();
            status.Reset();
            lblUserAnswer.Text = "";
            foreach(Label lbl in labels)
            {
                lbl.Text = "";
            }
            prbQuestions.Maximum = settings.Questions;
            prbQuestions.Value = 0;
            txtQuestions.Text = "";
            settings.Questions = 10; //DEBUG
        }

        /// <summary>
        /// 次の問題を作成する
        /// </summary>
        private void MakeNextQuestion()
        {
            status.No++;
            if (status.No > settings.Questions)
            {
                GameEnd();
                return;
            }
            prbQuestions.Value = status.No;
            var info = Game.MakeNextQuestion();
            status.AddInfo(info);
            txtQuestions.Text = "<" + status.No + ">   " + info.ToString() + "\r\n" + txtQuestions.Text;
            count = settings.Count;
            ShowCount(true);
            timOneSecond.Start();
        }

        /// <summary>
        /// キー押下時処理
        /// </summary>
        /// <param name="sender">イベント発生オブジェクト</param>
        /// <param name="e">イベント引数</param>
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (!timOneSecond.Enabled)
            {
                return;
            }

            switch (e.KeyData)
            {
                case Keys.Enter:
                    if (lblUserAnswer.Text != "")
                    {
                        AcceptAnswer();
                    }
                    e.Handled = true;
                    break;
                case Keys.Escape:
                    ClearAnswer();
                    e.Handled = true;
                    break;
                case Keys.Back:
                    DeleteOneCharacter();
                    e.Handled = true;
                    break;
                default:
                    if (e.KeyValue >= '0' && e.KeyValue <= '9')
                    {
                        InputCharacter(e.KeyValue - '0');
                        e.Handled = true;
                    }
                    else if (e.KeyValue >= 96 && e.KeyValue <= 105)
                    {
                        InputCharacter(e.KeyValue - 96);
                        e.Handled = true;
                    }
                    break;
            }
        }

        /// <summary>
        /// １文字入力する
        /// </summary>
        /// <param name="c"></param>
        private void InputCharacter(int c)
        {
            if (lblUserAnswer.Text.Length < 8)
            {
                lblUserAnswer.Text += c.ToString();
            }
        }

        /// <summary>
        /// 回答を受け付ける
        /// </summary>
        private void AcceptAnswer()
        {
            ApplyAnswer();
            MakeNextQuestion();
        }

        /// <summary>
        /// 回答を適用する
        /// </summary>
        private void ApplyAnswer()
        {
            timOneSecond.Stop();

            var strUserAnswer = lblUserAnswer.Text;
            ClearAnswer();

            var strResult = status.Current.Judge(strUserAnswer);

            txtQuestions.Text = txtQuestions.Text.Replace("？", strUserAnswer + " " + strResult);

            if (status.Current.JudgeResult)
            {
                status.Correct++;
                status.Combo++;
                if (status.MaxCombo < status.Combo)
                {
                    status.MaxCombo = status.Combo;
                }
            }
            else
            {
                status.Miss++;
                status.Combo = 0;
            }

            ShowGameResult();
        }

        private void ShowGameResult()
        {
            string[] results = { 
                status.Correct.ToString(),
                (int)status.GetCorrectRate() + "%",
                status.Miss.ToString(),
                (int)status.GetMissRate() + "%",
                status.Combo.ToString(),
                status.MaxCombo.ToString(),
            };

            for(int i = 0; i < labels.Length; i++)
            {
                labels[i].Text = results[i];
            }
        }

        /// <summary>
        /// 回答をクリアする
        /// </summary>
        private void ClearAnswer()
        {
            lblUserAnswer.Text = "";
        }

        /// <summary>
        /// １文字消す
        /// </summary>
        private void DeleteOneCharacter()
        {
            lblUserAnswer.Text = lblUserAnswer.Text.Substring(0, lblUserAnswer.Text.Length - 1);
        }

        /// <summary>
        /// タイマーTICK時処理
        /// </summary>
        /// <param name="sender">イベント発生オブジェクト</param>
        /// <param name="e">イベント引数</param>
        private void timOneSecond_Tick(object sender, EventArgs e)
        {
            count--;
            ShowCount(false);
            if (count == 0)
            {
                ApplyAnswer();
                MakeNextQuestion();
            }
        }

        /// <summary>
        /// カウント表示
        /// </summary>
        /// <param name="reset">カウンタをリセットする</param>
        private void ShowCount(bool reset)
        {
            if (reset)
            {
                ResetCount();
            }
            else
            {
                prbCount.Value = count;
            }
        }

        /// <summary>
        /// カウンタをリセットする
        /// </summary>
        private void ResetCount()
        {
            prbCount.Maximum = settings.Count + 1; // プログレスバーが徐々に伸びるのを抑制
            prbCount.Value = count + 1;
            prbCount.Value = count;
            prbCount.Maximum = settings.Count;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var f = new Form2(settings);
            f.ShowDialog();
            settings = f.GetSettings();
        }

        private void GameEnd()
        {
            status.GameOver = true;
            prbCount.Value = 0;
            prbQuestions.Value = prbQuestions.Maximum;
            MessageBox.Show("そこまで！");
            btnStart.Enabled = true;
            btnSettings.Enabled = true;
        }
    }
}

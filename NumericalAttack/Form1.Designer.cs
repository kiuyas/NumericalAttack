namespace NumericalAttack
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtQuestions = new System.Windows.Forms.TextBox();
            this.lblUserAnswer = new System.Windows.Forms.Label();
            this.timOneSecond = new System.Windows.Forms.Timer(this.components);
            this.prbCount = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.lblMiss = new System.Windows.Forms.Label();
            this.lblCombo = new System.Windows.Forms.Label();
            this.lblMaxCombo = new System.Windows.Forms.Label();
            this.lblCorrectRate = new System.Windows.Forms.Label();
            this.lblMissRate = new System.Windows.Forms.Label();
            this.prbQuestions = new System.Windows.Forms.ProgressBar();
            this.btnSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnStart.Location = new System.Drawing.Point(544, 8);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 32);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "開始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtQuestions
            // 
            this.txtQuestions.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtQuestions.Location = new System.Drawing.Point(8, 48);
            this.txtQuestions.Multiline = true;
            this.txtQuestions.Name = "txtQuestions";
            this.txtQuestions.ReadOnly = true;
            this.txtQuestions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQuestions.Size = new System.Drawing.Size(420, 200);
            this.txtQuestions.TabIndex = 1;
            // 
            // lblUserAnswer
            // 
            this.lblUserAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUserAnswer.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblUserAnswer.Location = new System.Drawing.Point(432, 48);
            this.lblUserAnswer.Name = "lblUserAnswer";
            this.lblUserAnswer.Size = new System.Drawing.Size(120, 40);
            this.lblUserAnswer.TabIndex = 2;
            this.lblUserAnswer.Text = "99999999";
            this.lblUserAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timOneSecond
            // 
            this.timOneSecond.Interval = 1000;
            this.timOneSecond.Tick += new System.EventHandler(this.timOneSecond_Tick);
            // 
            // prbCount
            // 
            this.prbCount.Location = new System.Drawing.Point(16, 16);
            this.prbCount.Name = "prbCount";
            this.prbCount.Size = new System.Drawing.Size(520, 23);
            this.prbCount.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "正解";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "誤答";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "コンボ";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(440, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "MAXコンボ";
            // 
            // lblCorrect
            // 
            this.lblCorrect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCorrect.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblCorrect.Location = new System.Drawing.Point(472, 104);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(72, 32);
            this.lblCorrect.TabIndex = 8;
            this.lblCorrect.Text = "999";
            this.lblCorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMiss
            // 
            this.lblMiss.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMiss.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMiss.Location = new System.Drawing.Point(472, 144);
            this.lblMiss.Name = "lblMiss";
            this.lblMiss.Size = new System.Drawing.Size(72, 32);
            this.lblMiss.TabIndex = 9;
            this.lblMiss.Text = "999";
            this.lblMiss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCombo
            // 
            this.lblCombo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCombo.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblCombo.Location = new System.Drawing.Point(472, 184);
            this.lblCombo.Name = "lblCombo";
            this.lblCombo.Size = new System.Drawing.Size(72, 32);
            this.lblCombo.TabIndex = 10;
            this.lblCombo.Text = "999";
            this.lblCombo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaxCombo
            // 
            this.lblMaxCombo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMaxCombo.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMaxCombo.Location = new System.Drawing.Point(472, 224);
            this.lblMaxCombo.Name = "lblMaxCombo";
            this.lblMaxCombo.Size = new System.Drawing.Size(72, 32);
            this.lblMaxCombo.TabIndex = 11;
            this.lblMaxCombo.Text = "999";
            this.lblMaxCombo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCorrectRate
            // 
            this.lblCorrectRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCorrectRate.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblCorrectRate.Location = new System.Drawing.Point(544, 104);
            this.lblCorrectRate.Name = "lblCorrectRate";
            this.lblCorrectRate.Size = new System.Drawing.Size(72, 32);
            this.lblCorrectRate.TabIndex = 12;
            this.lblCorrectRate.Text = "99%";
            this.lblCorrectRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMissRate
            // 
            this.lblMissRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMissRate.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMissRate.Location = new System.Drawing.Point(544, 144);
            this.lblMissRate.Name = "lblMissRate";
            this.lblMissRate.Size = new System.Drawing.Size(72, 32);
            this.lblMissRate.TabIndex = 13;
            this.lblMissRate.Text = "99%";
            this.lblMissRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prbQuestions
            // 
            this.prbQuestions.Location = new System.Drawing.Point(8, 248);
            this.prbQuestions.Name = "prbQuestions";
            this.prbQuestions.Size = new System.Drawing.Size(424, 16);
            this.prbQuestions.TabIndex = 14;
            // 
            // btnSettings
            // 
            this.btnSettings.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSettings.Location = new System.Drawing.Point(544, 224);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 32);
            this.btnSettings.TabIndex = 15;
            this.btnSettings.Text = "設定";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 273);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.prbQuestions);
            this.Controls.Add(this.lblMissRate);
            this.Controls.Add(this.lblCorrectRate);
            this.Controls.Add(this.lblMaxCombo);
            this.Controls.Add(this.lblCombo);
            this.Controls.Add(this.lblMiss);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prbCount);
            this.Controls.Add(this.lblUserAnswer);
            this.Controls.Add(this.txtQuestions);
            this.Controls.Add(this.btnStart);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numerical Attack";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtQuestions;
        private System.Windows.Forms.Label lblUserAnswer;
        private System.Windows.Forms.Timer timOneSecond;
        private System.Windows.Forms.ProgressBar prbCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label lblMiss;
        private System.Windows.Forms.Label lblCombo;
        private System.Windows.Forms.Label lblMaxCombo;
        private System.Windows.Forms.Label lblCorrectRate;
        private System.Windows.Forms.Label lblMissRate;
        private System.Windows.Forms.ProgressBar prbQuestions;
        private System.Windows.Forms.Button btnSettings;
    }
}


namespace NumericalAttack
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoSec5 = new System.Windows.Forms.RadioButton();
            this.rdoSec10 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdoQ50 = new System.Windows.Forms.RadioButton();
            this.rdoQ100 = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "出題数";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "思考時間";
            // 
            // rdoSec5
            // 
            this.rdoSec5.AutoSize = true;
            this.rdoSec5.Checked = true;
            this.rdoSec5.Location = new System.Drawing.Point(0, 0);
            this.rdoSec5.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rdoSec5.Name = "rdoSec5";
            this.rdoSec5.Size = new System.Drawing.Size(60, 25);
            this.rdoSec5.TabIndex = 12;
            this.rdoSec5.TabStop = true;
            this.rdoSec5.Text = "5秒";
            this.rdoSec5.UseVisualStyleBackColor = true;
            // 
            // rdoSec10
            // 
            this.rdoSec10.AutoSize = true;
            this.rdoSec10.Location = new System.Drawing.Point(72, 0);
            this.rdoSec10.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rdoSec10.Name = "rdoSec10";
            this.rdoSec10.Size = new System.Drawing.Size(71, 25);
            this.rdoSec10.TabIndex = 13;
            this.rdoSec10.TabStop = true;
            this.rdoSec10.Text = "10秒";
            this.rdoSec10.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoSec5);
            this.panel1.Controls.Add(this.rdoSec10);
            this.panel1.Location = new System.Drawing.Point(132, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 26);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdoQ50);
            this.panel2.Controls.Add(this.rdoQ100);
            this.panel2.Location = new System.Drawing.Point(133, 48);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(156, 28);
            this.panel2.TabIndex = 15;
            // 
            // rdoQ50
            // 
            this.rdoQ50.AutoSize = true;
            this.rdoQ50.Checked = true;
            this.rdoQ50.Location = new System.Drawing.Point(0, 0);
            this.rdoQ50.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rdoQ50.Name = "rdoQ50";
            this.rdoQ50.Size = new System.Drawing.Size(71, 25);
            this.rdoQ50.TabIndex = 12;
            this.rdoQ50.TabStop = true;
            this.rdoQ50.Text = "50問";
            this.rdoQ50.UseVisualStyleBackColor = true;
            // 
            // rdoQ100
            // 
            this.rdoQ100.AutoSize = true;
            this.rdoQ100.Location = new System.Drawing.Point(72, 0);
            this.rdoQ100.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rdoQ100.Name = "rdoQ100";
            this.rdoQ100.Size = new System.Drawing.Size(82, 25);
            this.rdoQ100.TabIndex = 13;
            this.rdoQ100.TabStop = true;
            this.rdoQ100.Text = "100問";
            this.rdoQ100.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(216, 80);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 32);
            this.btnOK.TabIndex = 16;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 122);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "設定";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoSec5;
        private System.Windows.Forms.RadioButton rdoSec10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdoQ50;
        private System.Windows.Forms.RadioButton rdoQ100;
        private System.Windows.Forms.Button btnOK;
    }
}
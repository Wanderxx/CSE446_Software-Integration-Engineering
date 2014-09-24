namespace testApp
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lowerTxt = new System.Windows.Forms.TextBox();
            this.UpperTxt = new System.Windows.Forms.TextBox();
            this.GuessTxt = new System.Windows.Forms.TextBox();
            this.GenerateBtn = new System.Windows.Forms.Button();
            this.GuessBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AttemptLbl = new System.Windows.Forms.Label();
            this.NumIsLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lowerTxt
            // 
            this.lowerTxt.Location = new System.Drawing.Point(75, 34);
            this.lowerTxt.Name = "lowerTxt";
            this.lowerTxt.Size = new System.Drawing.Size(100, 22);
            this.lowerTxt.TabIndex = 0;
            // 
            // UpperTxt
            // 
            this.UpperTxt.Location = new System.Drawing.Point(255, 34);
            this.UpperTxt.Name = "UpperTxt";
            this.UpperTxt.Size = new System.Drawing.Size(100, 22);
            this.UpperTxt.TabIndex = 1;
            // 
            // GuessTxt
            // 
            this.GuessTxt.Location = new System.Drawing.Point(75, 102);
            this.GuessTxt.Name = "GuessTxt";
            this.GuessTxt.Size = new System.Drawing.Size(100, 22);
            this.GuessTxt.TabIndex = 2;
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.Location = new System.Drawing.Point(377, 34);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(119, 23);
            this.GenerateBtn.TabIndex = 3;
            this.GenerateBtn.Text = "Generate secretNum";
            this.GenerateBtn.UseVisualStyleBackColor = true;
            this.GenerateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);
            // 
            // GuessBtn
            // 
            this.GuessBtn.Location = new System.Drawing.Point(185, 101);
            this.GuessBtn.Name = "GuessBtn";
            this.GuessBtn.Size = new System.Drawing.Size(75, 23);
            this.GuessBtn.TabIndex = 4;
            this.GuessBtn.Text = "Guess";
            this.GuessBtn.UseVisualStyleBackColor = true;
            this.GuessBtn.Click += new System.EventHandler(this.GuessBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "LowerBound";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "UpperBound";
            // 
            // AttemptLbl
            // 
            this.AttemptLbl.AutoSize = true;
            this.AttemptLbl.Location = new System.Drawing.Point(281, 112);
            this.AttemptLbl.Name = "AttemptLbl";
            this.AttemptLbl.Size = new System.Drawing.Size(46, 12);
            this.AttemptLbl.TabIndex = 7;
            this.AttemptLbl.Text = "Attempts";
            // 
            // NumIsLbl
            // 
            this.NumIsLbl.AutoSize = true;
            this.NumIsLbl.Location = new System.Drawing.Point(391, 112);
            this.NumIsLbl.Name = "NumIsLbl";
            this.NumIsLbl.Size = new System.Drawing.Size(59, 12);
            this.NumIsLbl.TabIndex = 8;
            this.NumIsLbl.Text = "The Num is";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 296);
            this.Controls.Add(this.NumIsLbl);
            this.Controls.Add(this.AttemptLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GuessBtn);
            this.Controls.Add(this.GenerateBtn);
            this.Controls.Add(this.GuessTxt);
            this.Controls.Add(this.UpperTxt);
            this.Controls.Add(this.lowerTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lowerTxt;
        private System.Windows.Forms.TextBox UpperTxt;
        private System.Windows.Forms.TextBox GuessTxt;
        private System.Windows.Forms.Button GenerateBtn;
        private System.Windows.Forms.Button GuessBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AttemptLbl;
        private System.Windows.Forms.Label NumIsLbl;
    }
}


﻿namespace ConvertHexToAscii
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
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.tbInputString = new System.Windows.Forms.TextBox();
            this.tbConvertASCII0 = new System.Windows.Forms.TextBox();
            this.tbConvertASCII1 = new System.Windows.Forms.TextBox();
            this.tbConvertASCII2 = new System.Windows.Forms.TextBox();
            this.tbConvertASCII3 = new System.Windows.Forms.TextBox();
            this.tbConvertASCII4 = new System.Windows.Forms.TextBox();
            this.tbConvertASCII5 = new System.Windows.Forms.TextBox();
            this.tbConvertASCII6 = new System.Windows.Forms.TextBox();
            this.btStartConvert = new System.Windows.Forms.Button();
            this.rbSingle = new System.Windows.Forms.RadioButton();
            this.rbDouble = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbInputString
            // 
            this.tbInputString.Location = new System.Drawing.Point(12, 31);
            this.tbInputString.Name = "tbInputString";
            this.tbInputString.Size = new System.Drawing.Size(133, 19);
            this.tbInputString.TabIndex = 0;
            // 
            // tbConvertASCII0
            // 
            this.tbConvertASCII0.Location = new System.Drawing.Point(172, 31);
            this.tbConvertASCII0.Name = "tbConvertASCII0";
            this.tbConvertASCII0.Size = new System.Drawing.Size(100, 19);
            this.tbConvertASCII0.TabIndex = 1;
            // 
            // tbConvertASCII1
            // 
            this.tbConvertASCII1.Location = new System.Drawing.Point(172, 56);
            this.tbConvertASCII1.Name = "tbConvertASCII1";
            this.tbConvertASCII1.Size = new System.Drawing.Size(100, 19);
            this.tbConvertASCII1.TabIndex = 1;
            // 
            // tbConvertASCII2
            // 
            this.tbConvertASCII2.Location = new System.Drawing.Point(172, 81);
            this.tbConvertASCII2.Name = "tbConvertASCII2";
            this.tbConvertASCII2.Size = new System.Drawing.Size(100, 19);
            this.tbConvertASCII2.TabIndex = 1;
            // 
            // tbConvertASCII3
            // 
            this.tbConvertASCII3.Location = new System.Drawing.Point(172, 106);
            this.tbConvertASCII3.Name = "tbConvertASCII3";
            this.tbConvertASCII3.Size = new System.Drawing.Size(100, 19);
            this.tbConvertASCII3.TabIndex = 1;
            // 
            // tbConvertASCII4
            // 
            this.tbConvertASCII4.Location = new System.Drawing.Point(172, 131);
            this.tbConvertASCII4.Name = "tbConvertASCII4";
            this.tbConvertASCII4.Size = new System.Drawing.Size(100, 19);
            this.tbConvertASCII4.TabIndex = 1;
            // 
            // tbConvertASCII5
            // 
            this.tbConvertASCII5.Location = new System.Drawing.Point(172, 156);
            this.tbConvertASCII5.Name = "tbConvertASCII5";
            this.tbConvertASCII5.Size = new System.Drawing.Size(100, 19);
            this.tbConvertASCII5.TabIndex = 1;
            // 
            // tbConvertASCII6
            // 
            this.tbConvertASCII6.Location = new System.Drawing.Point(172, 181);
            this.tbConvertASCII6.Name = "tbConvertASCII6";
            this.tbConvertASCII6.Size = new System.Drawing.Size(100, 19);
            this.tbConvertASCII6.TabIndex = 1;
            // 
            // btStartConvert
            // 
            this.btStartConvert.Location = new System.Drawing.Point(12, 81);
            this.btStartConvert.Name = "btStartConvert";
            this.btStartConvert.Size = new System.Drawing.Size(133, 55);
            this.btStartConvert.TabIndex = 2;
            this.btStartConvert.Text = "Start";
            this.btStartConvert.UseVisualStyleBackColor = true;
            this.btStartConvert.Click += new System.EventHandler(this.btStartConvert_Click);
            // 
            // rbSingle
            // 
            this.rbSingle.AutoSize = true;
            this.rbSingle.Checked = true;
            this.rbSingle.Location = new System.Drawing.Point(12, 159);
            this.rbSingle.Name = "rbSingle";
            this.rbSingle.Size = new System.Drawing.Size(54, 16);
            this.rbSingle.TabIndex = 3;
            this.rbSingle.TabStop = true;
            this.rbSingle.Text = "Single";
            this.rbSingle.UseVisualStyleBackColor = true;
            this.rbSingle.CheckedChanged += new System.EventHandler(this.rbSingle_CheckedChanged);
            // 
            // rbDouble
            // 
            this.rbDouble.AutoSize = true;
            this.rbDouble.Location = new System.Drawing.Point(12, 193);
            this.rbDouble.Name = "rbDouble";
            this.rbDouble.Size = new System.Drawing.Size(58, 16);
            this.rbDouble.TabIndex = 3;
            this.rbDouble.Text = "Double";
            this.rbDouble.UseVisualStyleBackColor = true;
            this.rbDouble.CheckedChanged += new System.EventHandler(this.rbDouble_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "入力文字列";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "アスキー変換後文字列";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbDouble);
            this.Controls.Add(this.rbSingle);
            this.Controls.Add(this.btStartConvert);
            this.Controls.Add(this.tbConvertASCII6);
            this.Controls.Add(this.tbConvertASCII5);
            this.Controls.Add(this.tbConvertASCII4);
            this.Controls.Add(this.tbConvertASCII3);
            this.Controls.Add(this.tbConvertASCII2);
            this.Controls.Add(this.tbConvertASCII1);
            this.Controls.Add(this.tbConvertASCII0);
            this.Controls.Add(this.tbInputString);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInputString;
        private System.Windows.Forms.TextBox tbConvertASCII0;
        private System.Windows.Forms.TextBox tbConvertASCII1;
        private System.Windows.Forms.TextBox tbConvertASCII2;
        private System.Windows.Forms.TextBox tbConvertASCII3;
        private System.Windows.Forms.TextBox tbConvertASCII4;
        private System.Windows.Forms.TextBox tbConvertASCII5;
        private System.Windows.Forms.TextBox tbConvertASCII6;
        private System.Windows.Forms.Button btStartConvert;
        private System.Windows.Forms.RadioButton rbSingle;
        private System.Windows.Forms.RadioButton rbDouble;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


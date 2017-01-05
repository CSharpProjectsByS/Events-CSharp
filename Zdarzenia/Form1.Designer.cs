namespace Zdarzenia
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Value3TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Value2TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Value1ChangeButton = new System.Windows.Forms.Button();
            this.Value1TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ClearLogButton = new System.Windows.Forms.Button();
            this.LogView = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Value3TextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Value2TextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Value1ChangeButton);
            this.groupBox1.Controls.Add(this.Value1TextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(17, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zmiana wartosci";
            // 
            // Value3TextBox
            // 
            this.Value3TextBox.Location = new System.Drawing.Point(95, 130);
            this.Value3TextBox.Name = "Value3TextBox";
            this.Value3TextBox.Size = new System.Drawing.Size(100, 26);
            this.Value3TextBox.TabIndex = 7;
            this.Value3TextBox.Text = "0";
            this.Value3TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "War3";
            // 
            // Value2TextBox
            // 
            this.Value2TextBox.Location = new System.Drawing.Point(95, 82);
            this.Value2TextBox.Name = "Value2TextBox";
            this.Value2TextBox.Size = new System.Drawing.Size(100, 26);
            this.Value2TextBox.TabIndex = 4;
            this.Value2TextBox.Text = "0";
            this.Value2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "War2";
            // 
            // Value1ChangeButton
            // 
            this.Value1ChangeButton.Location = new System.Drawing.Point(151, 162);
            this.Value1ChangeButton.Name = "Value1ChangeButton";
            this.Value1ChangeButton.Size = new System.Drawing.Size(105, 46);
            this.Value1ChangeButton.TabIndex = 2;
            this.Value1ChangeButton.Text = "Zmień";
            this.Value1ChangeButton.UseVisualStyleBackColor = true;
            this.Value1ChangeButton.Click += new System.EventHandler(this.Value1ChangeButton_Click);
            // 
            // Value1TextBox
            // 
            this.Value1TextBox.Location = new System.Drawing.Point(95, 36);
            this.Value1TextBox.Name = "Value1TextBox";
            this.Value1TextBox.Size = new System.Drawing.Size(100, 26);
            this.Value1TextBox.TabIndex = 1;
            this.Value1TextBox.Text = "0";
            this.Value1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "War1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ClearLogButton);
            this.groupBox2.Controls.Add(this.LogView);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(17, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 242);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log";
            // 
            // ClearLogButton
            // 
            this.ClearLogButton.Location = new System.Drawing.Point(271, 191);
            this.ClearLogButton.Name = "ClearLogButton";
            this.ClearLogButton.Size = new System.Drawing.Size(105, 51);
            this.ClearLogButton.TabIndex = 5;
            this.ClearLogButton.Text = "Wyczyść";
            this.ClearLogButton.UseVisualStyleBackColor = true;
            this.ClearLogButton.Click += new System.EventHandler(this.ClearLogButton_Click);
            // 
            // LogView
            // 
            this.LogView.FormattingEnabled = true;
            this.LogView.ItemHeight = 20;
            this.LogView.Location = new System.Drawing.Point(0, 31);
            this.LogView.Name = "LogView";
            this.LogView.Size = new System.Drawing.Size(370, 144);
            this.LogView.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 491);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Zdarzenia";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Value3TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Value2TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Value1ChangeButton;
        private System.Windows.Forms.TextBox Value1TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ClearLogButton;
        private System.Windows.Forms.ListBox LogView;
    }
}


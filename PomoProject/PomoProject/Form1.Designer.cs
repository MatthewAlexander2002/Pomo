namespace PomoProject
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CurrTime = new System.Windows.Forms.Label();
            this.WorkTimeText = new System.Windows.Forms.Label();
            this.BreakTimeText = new System.Windows.Forms.Label();
            this.WorkTimeTextBox = new System.Windows.Forms.TextBox();
            this.BreakTimeTextBox = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.RealTimeText = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CurrTime
            // 
            this.CurrTime.AutoSize = true;
            this.CurrTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CurrTime.Location = new System.Drawing.Point(120, 132);
            this.CurrTime.Name = "CurrTime";
            this.CurrTime.Size = new System.Drawing.Size(44, 31);
            this.CurrTime.TabIndex = 0;
            this.CurrTime.Text = "00";
            this.CurrTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CurrTime.Click += new System.EventHandler(this.label1_Click);
            // 
            // WorkTimeText
            // 
            this.WorkTimeText.AutoSize = true;
            this.WorkTimeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.WorkTimeText.Location = new System.Drawing.Point(10, 175);
            this.WorkTimeText.Name = "WorkTimeText";
            this.WorkTimeText.Size = new System.Drawing.Size(264, 31);
            this.WorkTimeText.TabIndex = 1;
            this.WorkTimeText.Text = "Work Time (Minutes)";
            // 
            // BreakTimeText
            // 
            this.BreakTimeText.AutoSize = true;
            this.BreakTimeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.BreakTimeText.Location = new System.Drawing.Point(16, 258);
            this.BreakTimeText.Name = "BreakTimeText";
            this.BreakTimeText.Size = new System.Drawing.Size(272, 31);
            this.BreakTimeText.TabIndex = 2;
            this.BreakTimeText.Text = "Break Time (Minutes)";
            // 
            // WorkTimeTextBox
            // 
            this.WorkTimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.WorkTimeTextBox.Location = new System.Drawing.Point(92, 217);
            this.WorkTimeTextBox.Name = "WorkTimeTextBox";
            this.WorkTimeTextBox.Size = new System.Drawing.Size(100, 38);
            this.WorkTimeTextBox.TabIndex = 3;
            this.WorkTimeTextBox.Text = "15";
            this.WorkTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WorkTimeTextBox.TextChanged += new System.EventHandler(this.WorkTimeTextBox_TextChanged);
            // 
            // BreakTimeTextBox
            // 
            this.BreakTimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.BreakTimeTextBox.Location = new System.Drawing.Point(92, 310);
            this.BreakTimeTextBox.Name = "BreakTimeTextBox";
            this.BreakTimeTextBox.Size = new System.Drawing.Size(100, 38);
            this.BreakTimeTextBox.TabIndex = 4;
            this.BreakTimeTextBox.Text = "5";
            this.BreakTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BreakTimeTextBox.TextChanged += new System.EventHandler(this.BreakTimeTextBox_TextChanged);
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.StartButton.Location = new System.Drawing.Point(54, 73);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(176, 41);
            this.StartButton.TabIndex = 5;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // RealTimeText
            // 
            this.RealTimeText.AutoSize = true;
            this.RealTimeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RealTimeText.Location = new System.Drawing.Point(68, 24);
            this.RealTimeText.Name = "RealTimeText";
            this.RealTimeText.Size = new System.Drawing.Size(152, 31);
            this.RealTimeText.TabIndex = 6;
            this.RealTimeText.Text = "0:00:00 AM";
            this.RealTimeText.Click += new System.EventHandler(this.RealTimeText_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 379);
            this.Controls.Add(this.RealTimeText);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.BreakTimeTextBox);
            this.Controls.Add(this.WorkTimeTextBox);
            this.Controls.Add(this.BreakTimeText);
            this.Controls.Add(this.WorkTimeText);
            this.Controls.Add(this.CurrTime);
            this.Name = "Form1";
            this.Text = "Pomo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label CurrTime;
        private System.Windows.Forms.Label WorkTimeText;
        private System.Windows.Forms.Label BreakTimeText;
        private System.Windows.Forms.TextBox WorkTimeTextBox;
        private System.Windows.Forms.TextBox BreakTimeTextBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label RealTimeText;
        private System.Windows.Forms.Timer timer2;
    }
}


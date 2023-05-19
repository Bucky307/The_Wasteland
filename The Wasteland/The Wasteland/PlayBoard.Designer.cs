namespace The_Wasteland
{
    partial class PlayBoard
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
            this.DisplayBox = new System.Windows.Forms.TextBox();
            this.EnterBox = new System.Windows.Forms.TextBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.BagBox = new System.Windows.Forms.GroupBox();
            this.I3lb = new System.Windows.Forms.Label();
            this.I2lb = new System.Windows.Forms.Label();
            this.I1lb = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Timerlb = new System.Windows.Forms.Label();
            this.Statuslb = new System.Windows.Forms.Label();
            this.Foodlb = new System.Windows.Forms.Label();
            this.Waterlb = new System.Windows.Forms.Label();
            this.Healthlb = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BackgroundTimer = new System.Windows.Forms.Timer(this.components);
            this.WaitingTimer = new System.Windows.Forms.Timer(this.components);
            this.BagBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DisplayBox
            // 
            this.DisplayBox.BackColor = System.Drawing.Color.Black;
            this.DisplayBox.Font = new System.Drawing.Font("Prestige Elite Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayBox.ForeColor = System.Drawing.SystemColors.Window;
            this.DisplayBox.Location = new System.Drawing.Point(12, 12);
            this.DisplayBox.Multiline = true;
            this.DisplayBox.Name = "DisplayBox";
            this.DisplayBox.ReadOnly = true;
            this.DisplayBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DisplayBox.Size = new System.Drawing.Size(650, 324);
            this.DisplayBox.TabIndex = 0;
            // 
            // EnterBox
            // 
            this.EnterBox.BackColor = System.Drawing.Color.Silver;
            this.EnterBox.Font = new System.Drawing.Font("Prestige Elite Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterBox.Location = new System.Drawing.Point(270, 338);
            this.EnterBox.Name = "EnterBox";
            this.EnterBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EnterBox.Size = new System.Drawing.Size(304, 27);
            this.EnterBox.TabIndex = 1;
            // 
            // EnterButton
            // 
            this.EnterButton.Font = new System.Drawing.Font("Prestige Elite Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterButton.Location = new System.Drawing.Point(580, 337);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(82, 26);
            this.EnterButton.TabIndex = 2;
            this.EnterButton.Text = "&Enter";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            this.EnterButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterButton_KeyPress);
            // 
            // BagBox
            // 
            this.BagBox.Controls.Add(this.I3lb);
            this.BagBox.Controls.Add(this.I2lb);
            this.BagBox.Controls.Add(this.I1lb);
            this.BagBox.Font = new System.Drawing.Font("Prestige Elite Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BagBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BagBox.Location = new System.Drawing.Point(270, 376);
            this.BagBox.Name = "BagBox";
            this.BagBox.Size = new System.Drawing.Size(235, 161);
            this.BagBox.TabIndex = 5;
            this.BagBox.TabStop = false;
            this.BagBox.Text = "Bag";
            // 
            // I3lb
            // 
            this.I3lb.AutoSize = true;
            this.I3lb.Font = new System.Drawing.Font("Prestige Elite Std", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.I3lb.Location = new System.Drawing.Point(6, 120);
            this.I3lb.Name = "I3lb";
            this.I3lb.Padding = new System.Windows.Forms.Padding(1);
            this.I3lb.Size = new System.Drawing.Size(73, 17);
            this.I3lb.TabIndex = 3;
            this.I3lb.Text = "Item 3: ";
            // 
            // I2lb
            // 
            this.I2lb.AutoSize = true;
            this.I2lb.Font = new System.Drawing.Font("Prestige Elite Std", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.I2lb.Location = new System.Drawing.Point(6, 75);
            this.I2lb.Name = "I2lb";
            this.I2lb.Padding = new System.Windows.Forms.Padding(1);
            this.I2lb.Size = new System.Drawing.Size(73, 17);
            this.I2lb.TabIndex = 2;
            this.I2lb.Text = "Item 2: ";
            // 
            // I1lb
            // 
            this.I1lb.AutoSize = true;
            this.I1lb.Font = new System.Drawing.Font("Prestige Elite Std", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.I1lb.Location = new System.Drawing.Point(6, 30);
            this.I1lb.Name = "I1lb";
            this.I1lb.Padding = new System.Windows.Forms.Padding(1);
            this.I1lb.Size = new System.Drawing.Size(73, 17);
            this.I1lb.TabIndex = 1;
            this.I1lb.Text = "Item 1: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Timerlb);
            this.groupBox1.Controls.Add(this.Statuslb);
            this.groupBox1.Controls.Add(this.Foodlb);
            this.groupBox1.Controls.Add(this.Waterlb);
            this.groupBox1.Controls.Add(this.Healthlb);
            this.groupBox1.Font = new System.Drawing.Font("Prestige Elite Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 342);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 195);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stats";
            // 
            // Timerlb
            // 
            this.Timerlb.AutoSize = true;
            this.Timerlb.Font = new System.Drawing.Font("Prestige Elite Std", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timerlb.Location = new System.Drawing.Point(6, 154);
            this.Timerlb.Name = "Timerlb";
            this.Timerlb.Padding = new System.Windows.Forms.Padding(1);
            this.Timerlb.Size = new System.Drawing.Size(105, 17);
            this.Timerlb.TabIndex = 7;
            this.Timerlb.Text = "Timer: 00:00";
            // 
            // Statuslb
            // 
            this.Statuslb.AutoSize = true;
            this.Statuslb.Font = new System.Drawing.Font("Prestige Elite Std", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statuslb.Location = new System.Drawing.Point(6, 124);
            this.Statuslb.Name = "Statuslb";
            this.Statuslb.Padding = new System.Windows.Forms.Padding(1);
            this.Statuslb.Size = new System.Drawing.Size(129, 17);
            this.Statuslb.TabIndex = 3;
            this.Statuslb.Text = "Status: Running";
            // 
            // Foodlb
            // 
            this.Foodlb.AutoSize = true;
            this.Foodlb.Font = new System.Drawing.Font("Prestige Elite Std", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Foodlb.Location = new System.Drawing.Point(6, 94);
            this.Foodlb.Name = "Foodlb";
            this.Foodlb.Padding = new System.Windows.Forms.Padding(1);
            this.Foodlb.Size = new System.Drawing.Size(89, 17);
            this.Foodlb.TabIndex = 2;
            this.Foodlb.Text = "Food: 100 ";
            // 
            // Waterlb
            // 
            this.Waterlb.AutoSize = true;
            this.Waterlb.Font = new System.Drawing.Font("Prestige Elite Std", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Waterlb.Location = new System.Drawing.Point(6, 64);
            this.Waterlb.Name = "Waterlb";
            this.Waterlb.Padding = new System.Windows.Forms.Padding(1);
            this.Waterlb.Size = new System.Drawing.Size(89, 17);
            this.Waterlb.TabIndex = 1;
            this.Waterlb.Text = "Water: 100";
            // 
            // Healthlb
            // 
            this.Healthlb.AutoSize = true;
            this.Healthlb.Font = new System.Drawing.Font("Prestige Elite Std", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Healthlb.Location = new System.Drawing.Point(6, 34);
            this.Healthlb.Name = "Healthlb";
            this.Healthlb.Padding = new System.Windows.Forms.Padding(1);
            this.Healthlb.Size = new System.Drawing.Size(97, 17);
            this.Healthlb.TabIndex = 0;
            this.Healthlb.Text = "Health: 100";
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 1000;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Prestige Elite Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(511, 376);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 161);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Key";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Prestige Elite Std", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(1);
            this.label1.Size = new System.Drawing.Size(129, 122);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start\r\nUse Item #_\r\nReplace Item #_\r\nPunch\r\nRun Away\r\nRest\r\nRun\r\nScavenge";
            // 
            // BackgroundTimer
            // 
            this.BackgroundTimer.Interval = 1000;
            this.BackgroundTimer.Tick += new System.EventHandler(this.MovementCommentaryTimer_Tick);
            // 
            // PlayBoard
            // 
            this.AcceptButton = this.EnterButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(663, 550);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BagBox);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.EnterBox);
            this.Controls.Add(this.DisplayBox);
            this.Name = "PlayBoard";
            this.Load += new System.EventHandler(this.PlayBoard_Load);
            this.BagBox.ResumeLayout(false);
            this.BagBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DisplayBox;
        private System.Windows.Forms.TextBox EnterBox;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.GroupBox BagBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Timerlb;
        private System.Windows.Forms.Label Foodlb;
        private System.Windows.Forms.Label Waterlb;
        private System.Windows.Forms.Label Healthlb;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer BackgroundTimer;
        private System.Windows.Forms.Label I3lb;
        private System.Windows.Forms.Label I2lb;
        private System.Windows.Forms.Label I1lb;
        private System.Windows.Forms.Label Statuslb;
        private System.Windows.Forms.Timer WaitingTimer;
    }
}


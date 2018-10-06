namespace A7Stack
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CGoButton = new System.Windows.Forms.Button();
            this.CStepSize = new System.Windows.Forms.ComboBox();
            this.CStepDirection = new System.Windows.Forms.ComboBox();
            this.LStepSize = new System.Windows.Forms.Label();
            this.LStepDirection = new System.Windows.Forms.Label();
            this.CFrames = new System.Windows.Forms.NumericUpDown();
            this.LFrames = new System.Windows.Forms.Label();
            this.CCycleTime = new System.Windows.Forms.NumericUpDown();
            this.LCycleTime = new System.Windows.Forms.Label();
            this.CProgress = new System.Windows.Forms.ProgressBar();
            this.CAboutButton = new System.Windows.Forms.Button();
            this.CRunTimer = new System.Windows.Forms.Timer(this.components);
            this.CDryRun = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CSteps = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.CFrames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CCycleTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSteps)).BeginInit();
            this.SuspendLayout();
            // 
            // CGoButton
            // 
            this.CGoButton.Location = new System.Drawing.Point(15, 287);
            this.CGoButton.Name = "CGoButton";
            this.CGoButton.Size = new System.Drawing.Size(185, 37);
            this.CGoButton.TabIndex = 0;
            this.CGoButton.Text = "Go";
            this.CGoButton.UseVisualStyleBackColor = true;
            this.CGoButton.Click += new System.EventHandler(this.CGoButton_Click);
            // 
            // CStepSize
            // 
            this.CStepSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CStepSize.Items.AddRange(new object[] {
            "small",
            "normal",
            "big"});
            this.CStepSize.Location = new System.Drawing.Point(128, 16);
            this.CStepSize.Name = "CStepSize";
            this.CStepSize.Size = new System.Drawing.Size(121, 21);
            this.CStepSize.TabIndex = 0;
            // 
            // CStepDirection
            // 
            this.CStepDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CStepDirection.FormattingEnabled = true;
            this.CStepDirection.Items.AddRange(new object[] {
            "far to near",
            "near to far"});
            this.CStepDirection.Location = new System.Drawing.Point(128, 54);
            this.CStepDirection.Name = "CStepDirection";
            this.CStepDirection.Size = new System.Drawing.Size(121, 21);
            this.CStepDirection.TabIndex = 1;
            // 
            // LStepSize
            // 
            this.LStepSize.AutoSize = true;
            this.LStepSize.Location = new System.Drawing.Point(12, 19);
            this.LStepSize.Name = "LStepSize";
            this.LStepSize.Size = new System.Drawing.Size(50, 13);
            this.LStepSize.TabIndex = 3;
            this.LStepSize.Text = "Step size";
            this.LStepSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LStepDirection
            // 
            this.LStepDirection.AutoSize = true;
            this.LStepDirection.Location = new System.Drawing.Point(12, 57);
            this.LStepDirection.Name = "LStepDirection";
            this.LStepDirection.Size = new System.Drawing.Size(72, 13);
            this.LStepDirection.TabIndex = 4;
            this.LStepDirection.Text = "Step direction";
            this.LStepDirection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CFrames
            // 
            this.CFrames.Location = new System.Drawing.Point(129, 130);
            this.CFrames.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CFrames.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CFrames.Name = "CFrames";
            this.CFrames.Size = new System.Drawing.Size(120, 20);
            this.CFrames.TabIndex = 5;
            this.CFrames.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // LFrames
            // 
            this.LFrames.AutoSize = true;
            this.LFrames.Location = new System.Drawing.Point(12, 132);
            this.LFrames.Name = "LFrames";
            this.LFrames.Size = new System.Drawing.Size(41, 13);
            this.LFrames.TabIndex = 6;
            this.LFrames.Text = "Frames";
            this.LFrames.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CCycleTime
            // 
            this.CCycleTime.Location = new System.Drawing.Point(129, 180);
            this.CCycleTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.CCycleTime.Minimum = new decimal(new int[] {
            750,
            0,
            0,
            0});
            this.CCycleTime.Name = "CCycleTime";
            this.CCycleTime.Size = new System.Drawing.Size(120, 20);
            this.CCycleTime.TabIndex = 7;
            this.CCycleTime.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // LCycleTime
            // 
            this.LCycleTime.AutoSize = true;
            this.LCycleTime.Location = new System.Drawing.Point(12, 182);
            this.LCycleTime.Name = "LCycleTime";
            this.LCycleTime.Size = new System.Drawing.Size(77, 13);
            this.LCycleTime.TabIndex = 8;
            this.LCycleTime.Text = "Cycle time (ms)";
            this.LCycleTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CProgress
            // 
            this.CProgress.Location = new System.Drawing.Point(15, 258);
            this.CProgress.Name = "CProgress";
            this.CProgress.Size = new System.Drawing.Size(234, 23);
            this.CProgress.TabIndex = 9;
            // 
            // CAboutButton
            // 
            this.CAboutButton.Location = new System.Drawing.Point(207, 287);
            this.CAboutButton.Name = "CAboutButton";
            this.CAboutButton.Size = new System.Drawing.Size(42, 37);
            this.CAboutButton.TabIndex = 10;
            this.CAboutButton.Text = "?";
            this.CAboutButton.UseVisualStyleBackColor = true;
            this.CAboutButton.Click += new System.EventHandler(this.CAboutButton_Click);
            // 
            // CRunTimer
            // 
            this.CRunTimer.Tick += new System.EventHandler(this.CRunTimer_Tick);
            // 
            // CDryRun
            // 
            this.CDryRun.AutoSize = true;
            this.CDryRun.Checked = true;
            this.CDryRun.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CDryRun.Location = new System.Drawing.Point(15, 213);
            this.CDryRun.Name = "CDryRun";
            this.CDryRun.Size = new System.Drawing.Size(156, 17);
            this.CDryRun.TabIndex = 11;
            this.CDryRun.Text = "Only focus step, no capture";
            this.CDryRun.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Steps per frame";
            // 
            // CSteps
            // 
            this.CSteps.LargeChange = 1;
            this.CSteps.Location = new System.Drawing.Point(128, 81);
            this.CSteps.Maximum = 7;
            this.CSteps.Minimum = 1;
            this.CSteps.Name = "CSteps";
            this.CSteps.Size = new System.Drawing.Size(121, 45);
            this.CSteps.TabIndex = 14;
            this.CSteps.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.CSteps.Value = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 342);
            this.Controls.Add(this.CSteps);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CDryRun);
            this.Controls.Add(this.CAboutButton);
            this.Controls.Add(this.CProgress);
            this.Controls.Add(this.LCycleTime);
            this.Controls.Add(this.CCycleTime);
            this.Controls.Add(this.LFrames);
            this.Controls.Add(this.CFrames);
            this.Controls.Add(this.LStepDirection);
            this.Controls.Add(this.LStepSize);
            this.Controls.Add(this.CStepDirection);
            this.Controls.Add(this.CStepSize);
            this.Controls.Add(this.CGoButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "B8 Stack 0.02";
            ((System.ComponentModel.ISupportInitialize)(this.CFrames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CCycleTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSteps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CGoButton;
        private System.Windows.Forms.ComboBox CStepSize;
        private System.Windows.Forms.ComboBox CStepDirection;
        private System.Windows.Forms.Label LStepSize;
        private System.Windows.Forms.Label LStepDirection;
        private System.Windows.Forms.NumericUpDown CFrames;
        private System.Windows.Forms.Label LFrames;
        private System.Windows.Forms.NumericUpDown CCycleTime;
        private System.Windows.Forms.Label LCycleTime;
        private System.Windows.Forms.ProgressBar CProgress;
        private System.Windows.Forms.Button CAboutButton;
        private System.Windows.Forms.Timer CRunTimer;
        private System.Windows.Forms.CheckBox CDryRun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar CSteps;
    }
}


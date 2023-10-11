namespace isellnow
{
    partial class Form_isellnow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnSubtractSellCount = new Button();
            btnAddSellCount = new Button();
            lblSellPointCount = new Label();
            groupBoxSettings = new GroupBox();
            btnSetEndHotkey = new Button();
            label4 = new Label();
            btnSetPauseHotkey = new Button();
            label3 = new Label();
            btnCommitSettings = new Button();
            groupBoxMain = new GroupBox();
            btnStart = new Button();
            lblRustProcess = new Label();
            btnRegisterRustProcess = new Button();
            btnSetupSellButtons = new Button();
            groupBoxRunning = new GroupBox();
            labelPaused = new Label();
            btnStop = new Button();
            groupBoxSettings.SuspendLayout();
            groupBoxMain.SuspendLayout();
            groupBoxRunning.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 0;
            label1.Text = "# of sell points";
            // 
            // btnSubtractSellCount
            // 
            btnSubtractSellCount.Location = new Point(6, 45);
            btnSubtractSellCount.Name = "btnSubtractSellCount";
            btnSubtractSellCount.Size = new Size(27, 29);
            btnSubtractSellCount.TabIndex = 1;
            btnSubtractSellCount.Text = "-";
            btnSubtractSellCount.UseVisualStyleBackColor = true;
            btnSubtractSellCount.Click += BtnSubtractSellCount_Click;
            // 
            // btnAddSellCount
            // 
            btnAddSellCount.Location = new Point(63, 45);
            btnAddSellCount.Name = "btnAddSellCount";
            btnAddSellCount.Size = new Size(27, 29);
            btnAddSellCount.TabIndex = 2;
            btnAddSellCount.Text = "+";
            btnAddSellCount.UseVisualStyleBackColor = true;
            btnAddSellCount.Click += BtnAddSellCount_Click;
            // 
            // lblSellPointCount
            // 
            lblSellPointCount.AutoSize = true;
            lblSellPointCount.Location = new Point(40, 51);
            lblSellPointCount.Name = "lblSellPointCount";
            lblSellPointCount.Size = new Size(17, 20);
            lblSellPointCount.TabIndex = 3;
            lblSellPointCount.Text = "1";
            // 
            // groupBoxSettings
            // 
            groupBoxSettings.Controls.Add(btnSetEndHotkey);
            groupBoxSettings.Controls.Add(label4);
            groupBoxSettings.Controls.Add(btnSetPauseHotkey);
            groupBoxSettings.Controls.Add(label3);
            groupBoxSettings.Controls.Add(label1);
            groupBoxSettings.Controls.Add(lblSellPointCount);
            groupBoxSettings.Controls.Add(btnSubtractSellCount);
            groupBoxSettings.Controls.Add(btnAddSellCount);
            groupBoxSettings.Location = new Point(11, 12);
            groupBoxSettings.Name = "groupBoxSettings";
            groupBoxSettings.Size = new Size(183, 219);
            groupBoxSettings.TabIndex = 4;
            groupBoxSettings.TabStop = false;
            groupBoxSettings.Text = "Settings";
            // 
            // btnSetEndHotkey
            // 
            btnSetEndHotkey.Location = new Point(7, 179);
            btnSetEndHotkey.Name = "btnSetEndHotkey";
            btnSetEndHotkey.Size = new Size(163, 29);
            btnSetEndHotkey.TabIndex = 7;
            btnSetEndHotkey.Text = "Z";
            btnSetEndHotkey.UseVisualStyleBackColor = true;
            btnSetEndHotkey.Click += BtnSetEndHotkey_Click;
            btnSetEndHotkey.KeyUp += ChangeEndHotkey;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 156);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 6;
            label4.Text = "End hotkey";
            // 
            // btnSetPauseHotkey
            // 
            btnSetPauseHotkey.Location = new Point(7, 112);
            btnSetPauseHotkey.Name = "btnSetPauseHotkey";
            btnSetPauseHotkey.Size = new Size(163, 29);
            btnSetPauseHotkey.TabIndex = 5;
            btnSetPauseHotkey.Text = "P";
            btnSetPauseHotkey.UseVisualStyleBackColor = true;
            btnSetPauseHotkey.Click += ButtonSetPauseHotkey_Click;
            btnSetPauseHotkey.KeyUp += ChangePauseHotkey;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 89);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 4;
            label3.Text = "Pause hotkey";
            // 
            // btnCommitSettings
            // 
            btnCommitSettings.Location = new Point(11, 237);
            btnCommitSettings.Name = "btnCommitSettings";
            btnCommitSettings.Size = new Size(183, 29);
            btnCommitSettings.TabIndex = 5;
            btnCommitSettings.Text = "Commit settings";
            btnCommitSettings.UseVisualStyleBackColor = true;
            btnCommitSettings.Click += BtnCommitSettings_Click;
            // 
            // groupBoxMain
            // 
            groupBoxMain.Controls.Add(btnStart);
            groupBoxMain.Controls.Add(lblRustProcess);
            groupBoxMain.Controls.Add(btnRegisterRustProcess);
            groupBoxMain.Controls.Add(btnSetupSellButtons);
            groupBoxMain.Location = new Point(201, 12);
            groupBoxMain.Margin = new Padding(3, 4, 3, 4);
            groupBoxMain.Name = "groupBoxMain";
            groupBoxMain.Padding = new Padding(3, 4, 3, 4);
            groupBoxMain.Size = new Size(352, 219);
            groupBoxMain.TabIndex = 6;
            groupBoxMain.TabStop = false;
            groupBoxMain.Text = "Main";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(186, 29);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(160, 45);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += BtnStart_Click;
            // 
            // lblRustProcess
            // 
            lblRustProcess.AutoSize = true;
            lblRustProcess.Location = new Point(7, 127);
            lblRustProcess.Name = "lblRustProcess";
            lblRustProcess.Size = new Size(122, 20);
            lblRustProcess.TabIndex = 2;
            lblRustProcess.Text = "Rust process: null";
            // 
            // btnRegisterRustProcess
            // 
            btnRegisterRustProcess.Location = new Point(7, 68);
            btnRegisterRustProcess.Margin = new Padding(3, 4, 3, 4);
            btnRegisterRustProcess.Name = "btnRegisterRustProcess";
            btnRegisterRustProcess.Size = new Size(173, 55);
            btnRegisterRustProcess.TabIndex = 1;
            btnRegisterRustProcess.Text = "Recognize and register rust process";
            btnRegisterRustProcess.UseVisualStyleBackColor = true;
            btnRegisterRustProcess.Click += ButtonRegisterRust;
            // 
            // btnSetupSellButtons
            // 
            btnSetupSellButtons.Location = new Point(7, 29);
            btnSetupSellButtons.Margin = new Padding(3, 4, 3, 4);
            btnSetupSellButtons.Name = "btnSetupSellButtons";
            btnSetupSellButtons.Size = new Size(173, 31);
            btnSetupSellButtons.TabIndex = 0;
            btnSetupSellButtons.Text = "Setup sell buttons";
            btnSetupSellButtons.UseVisualStyleBackColor = true;
            btnSetupSellButtons.Click += BtnSetupSellButtons_Click;
            // 
            // groupBoxRunning
            // 
            groupBoxRunning.Controls.Add(labelPaused);
            groupBoxRunning.Controls.Add(btnStop);
            groupBoxRunning.Location = new Point(559, 13);
            groupBoxRunning.Margin = new Padding(3, 4, 3, 4);
            groupBoxRunning.Name = "groupBoxRunning";
            groupBoxRunning.Padding = new Padding(3, 4, 3, 4);
            groupBoxRunning.Size = new Size(124, 219);
            groupBoxRunning.TabIndex = 7;
            groupBoxRunning.TabStop = false;
            groupBoxRunning.Text = "Running";
            // 
            // labelPaused
            // 
            labelPaused.AutoSize = true;
            labelPaused.Location = new Point(6, 76);
            labelPaused.Name = "labelPaused";
            labelPaused.Size = new Size(93, 20);
            labelPaused.TabIndex = 1;
            labelPaused.Text = "Paused: false";
            // 
            // btnStop
            // 
            btnStop.Location = new Point(6, 30);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(105, 43);
            btnStop.TabIndex = 0;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += BtnStop_Click;
            // 
            // Form_isellnow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 279);
            Controls.Add(groupBoxRunning);
            Controls.Add(groupBoxMain);
            Controls.Add(btnCommitSettings);
            Controls.Add(groupBoxSettings);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form_isellnow";
            Text = "isellnow";
            Load += Form_isellnow_Load;
            groupBoxSettings.ResumeLayout(false);
            groupBoxSettings.PerformLayout();
            groupBoxMain.ResumeLayout(false);
            groupBoxMain.PerformLayout();
            groupBoxRunning.ResumeLayout(false);
            groupBoxRunning.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnSubtractSellCount;
        private Button btnAddSellCount;
        private Label lblSellPointCount;
        private GroupBox groupBoxSettings;
        private Label label3;
        private Button btnSetPauseHotkey;
        private Button btnSetEndHotkey;
        private Label label4;
        private Button btnCommitSettings;
        private GroupBox groupBoxMain;
        private Button btnSetupSellButtons;
        private Button btnRegisterRustProcess;
        private Label lblRustProcess;
        private GroupBox groupBoxRunning;
        private Button btnStop;
        private Button btnStart;
        private Label labelPaused;
    }
}
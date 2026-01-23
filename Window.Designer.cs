namespace AutoClicker
{
	partial class Window
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
			components = new System.ComponentModel.Container();
			btnStartStopClicker = new Button();
			lblInterval = new Label();
			tmrClicker = new System.Windows.Forms.Timer(components);
			nudUserInterval = new NumericUpDown();
			tmrKeyDown = new System.Windows.Forms.Timer(components);
			lblStartStopTip = new Label();
			pnlUserTimeFrame = new Panel();
			lblUserTimeFrame = new Label();
			pnlInteractClicker = new Panel();
			btnChangeWindowState = new Button();
			tlpWindow = new TableLayoutPanel();
			pnlDefaultTimeFrame = new Panel();
			lblStandardTimeFrame = new Label();
			btn30sec = new Button();
			btn1min = new Button();
			btn5min = new Button();
			pnlTimeCalculator = new Panel();
			tbResultInMs = new TextBox();
			nudTimeToCalc = new NumericUpDown();
			lblResultInMs = new Label();
			cbTimeUnitToCalc = new ComboBox();
			tcWindow = new TabControl();
			tpMain = new TabPage();
			tpSettings = new TabPage();
			lblStartStopKeyTip = new Label();
			btnChangeStartStopKey = new Button();
			lblChangeStartStopKey = new Label();
			((System.ComponentModel.ISupportInitialize)nudUserInterval).BeginInit();
			pnlUserTimeFrame.SuspendLayout();
			pnlInteractClicker.SuspendLayout();
			tlpWindow.SuspendLayout();
			pnlDefaultTimeFrame.SuspendLayout();
			pnlTimeCalculator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nudTimeToCalc).BeginInit();
			tcWindow.SuspendLayout();
			tpMain.SuspendLayout();
			tpSettings.SuspendLayout();
			SuspendLayout();
			// 
			// btnStartStopClicker
			// 
			btnStartStopClicker.Anchor = AnchorStyles.None;
			btnStartStopClicker.AutoSize = true;
			btnStartStopClicker.Cursor = Cursors.Hand;
			btnStartStopClicker.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnStartStopClicker.Location = new Point(49, 4);
			btnStartStopClicker.Margin = new Padding(4, 3, 4, 3);
			btnStartStopClicker.Name = "btnStartStopClicker";
			btnStartStopClicker.Size = new Size(163, 28);
			btnStartStopClicker.TabIndex = 0;
			btnStartStopClicker.Text = "Start Autoclicker";
			btnStartStopClicker.UseVisualStyleBackColor = true;
			btnStartStopClicker.Click += btnStartStopClicker_Click;
			// 
			// lblInterval
			// 
			lblInterval.Anchor = AnchorStyles.None;
			lblInterval.AutoSize = true;
			lblInterval.Font = new Font("Bahnschrift", 11F);
			lblInterval.Location = new Point(16, 28);
			lblInterval.Margin = new Padding(4, 0, 4, 0);
			lblInterval.Name = "lblInterval";
			lblInterval.Size = new Size(97, 18);
			lblInterval.TabIndex = 1;
			lblInterval.Text = "Interval (ms):";
			// 
			// tmrClicker
			// 
			tmrClicker.Tick += tmrClicker_Tick;
			// 
			// nudUserInterval
			// 
			nudUserInterval.Anchor = AnchorStyles.None;
			nudUserInterval.AutoSize = true;
			nudUserInterval.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			nudUserInterval.Location = new Point(126, 24);
			nudUserInterval.Margin = new Padding(4, 3, 4, 3);
			nudUserInterval.Maximum = new decimal(new int[] { 2400000, 0, 0, 0 });
			nudUserInterval.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			nudUserInterval.Name = "nudUserInterval";
			nudUserInterval.Size = new Size(102, 26);
			nudUserInterval.TabIndex = 2;
			nudUserInterval.Tag = "interval";
			nudUserInterval.Value = new decimal(new int[] { 1, 0, 0, 0 });
			nudUserInterval.ValueChanged += nudInput_ValueChanged;
			nudUserInterval.KeyPress += nudInput_KeyPress;
			// 
			// tmrKeyDown
			// 
			tmrKeyDown.Enabled = true;
			tmrKeyDown.Tick += tmrKeyDown_Tick;
			// 
			// lblStartStopTip
			// 
			lblStartStopTip.Anchor = AnchorStyles.None;
			lblStartStopTip.AutoSize = true;
			lblStartStopTip.Font = new Font("Bahnschrift", 11F);
			lblStartStopTip.ForeColor = SystemColors.ControlDarkDark;
			lblStartStopTip.Location = new Point(27, 35);
			lblStartStopTip.Margin = new Padding(4, 0, 4, 0);
			lblStartStopTip.Name = "lblStartStopTip";
			lblStartStopTip.Size = new Size(209, 18);
			lblStartStopTip.TabIndex = 3;
			lblStartStopTip.Text = "Press Right Shift to start/stop";
			// 
			// pnlUserTimeFrame
			// 
			pnlUserTimeFrame.Controls.Add(nudUserInterval);
			pnlUserTimeFrame.Controls.Add(lblUserTimeFrame);
			pnlUserTimeFrame.Controls.Add(lblInterval);
			pnlUserTimeFrame.Dock = DockStyle.Fill;
			pnlUserTimeFrame.Location = new Point(5, 4);
			pnlUserTimeFrame.Margin = new Padding(4, 3, 4, 3);
			pnlUserTimeFrame.Name = "pnlUserTimeFrame";
			pnlUserTimeFrame.Size = new Size(261, 56);
			pnlUserTimeFrame.TabIndex = 4;
			// 
			// lblUserTimeFrame
			// 
			lblUserTimeFrame.Anchor = AnchorStyles.None;
			lblUserTimeFrame.AutoSize = true;
			lblUserTimeFrame.Font = new Font("Bahnschrift", 11F);
			lblUserTimeFrame.Location = new Point(16, 3);
			lblUserTimeFrame.Margin = new Padding(4, 0, 4, 0);
			lblUserTimeFrame.Name = "lblUserTimeFrame";
			lblUserTimeFrame.Size = new Size(173, 18);
			lblUserTimeFrame.TabIndex = 3;
			lblUserTimeFrame.Text = "User-defined time frame";
			// 
			// pnlInteractClicker
			// 
			pnlInteractClicker.Controls.Add(btnStartStopClicker);
			pnlInteractClicker.Controls.Add(lblStartStopTip);
			pnlInteractClicker.Dock = DockStyle.Fill;
			pnlInteractClicker.Location = new Point(5, 67);
			pnlInteractClicker.Margin = new Padding(4, 3, 4, 3);
			pnlInteractClicker.Name = "pnlInteractClicker";
			pnlInteractClicker.Size = new Size(261, 56);
			pnlInteractClicker.TabIndex = 11;
			// 
			// btnChangeWindowState
			// 
			btnChangeWindowState.Cursor = Cursors.Hand;
			btnChangeWindowState.Dock = DockStyle.Fill;
			btnChangeWindowState.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnChangeWindowState.Location = new Point(544, 4);
			btnChangeWindowState.MaximumSize = new Size(21, 0);
			btnChangeWindowState.MinimumSize = new Size(21, 0);
			btnChangeWindowState.Name = "btnChangeWindowState";
			tlpWindow.SetRowSpan(btnChangeWindowState, 2);
			btnChangeWindowState.Size = new Size(21, 119);
			btnChangeWindowState.TabIndex = 10;
			btnChangeWindowState.Text = "<<";
			btnChangeWindowState.UseVisualStyleBackColor = true;
			btnChangeWindowState.Click += btnChangeWindowState_Click;
			// 
			// tlpWindow
			// 
			tlpWindow.AutoSize = true;
			tlpWindow.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			tlpWindow.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
			tlpWindow.ColumnCount = 3;
			tlpWindow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tlpWindow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tlpWindow.ColumnStyles.Add(new ColumnStyle());
			tlpWindow.Controls.Add(btnChangeWindowState, 2, 0);
			tlpWindow.Controls.Add(pnlUserTimeFrame, 0, 0);
			tlpWindow.Controls.Add(pnlDefaultTimeFrame, 1, 0);
			tlpWindow.Controls.Add(pnlTimeCalculator, 1, 1);
			tlpWindow.Controls.Add(pnlInteractClicker, 0, 1);
			tlpWindow.Dock = DockStyle.Fill;
			tlpWindow.Location = new Point(3, 3);
			tlpWindow.Name = "tlpWindow";
			tlpWindow.RowCount = 2;
			tlpWindow.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tlpWindow.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tlpWindow.Size = new Size(570, 127);
			tlpWindow.TabIndex = 4;
			// 
			// pnlDefaultTimeFrame
			// 
			pnlDefaultTimeFrame.Controls.Add(lblStandardTimeFrame);
			pnlDefaultTimeFrame.Controls.Add(btn30sec);
			pnlDefaultTimeFrame.Controls.Add(btn1min);
			pnlDefaultTimeFrame.Controls.Add(btn5min);
			pnlDefaultTimeFrame.Dock = DockStyle.Fill;
			pnlDefaultTimeFrame.Location = new Point(275, 4);
			pnlDefaultTimeFrame.Margin = new Padding(4, 3, 4, 3);
			pnlDefaultTimeFrame.Name = "pnlDefaultTimeFrame";
			pnlDefaultTimeFrame.Size = new Size(261, 56);
			pnlDefaultTimeFrame.TabIndex = 12;
			// 
			// lblStandardTimeFrame
			// 
			lblStandardTimeFrame.Anchor = AnchorStyles.None;
			lblStandardTimeFrame.AutoSize = true;
			lblStandardTimeFrame.Font = new Font("Bahnschrift", 11F);
			lblStandardTimeFrame.Location = new Point(14, 3);
			lblStandardTimeFrame.Margin = new Padding(4, 0, 4, 0);
			lblStandardTimeFrame.Name = "lblStandardTimeFrame";
			lblStandardTimeFrame.Size = new Size(142, 18);
			lblStandardTimeFrame.TabIndex = 9;
			lblStandardTimeFrame.Text = "Default time frames";
			// 
			// btn30sec
			// 
			btn30sec.Anchor = AnchorStyles.None;
			btn30sec.AutoSize = true;
			btn30sec.Cursor = Cursors.Hand;
			btn30sec.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btn30sec.Location = new Point(15, 24);
			btn30sec.Margin = new Padding(4, 3, 4, 3);
			btn30sec.Name = "btn30sec";
			btn30sec.Size = new Size(76, 28);
			btn30sec.TabIndex = 5;
			btn30sec.Text = "30 sec";
			btn30sec.UseVisualStyleBackColor = true;
			btn30sec.Click += btnStandardTimeFrame_Click;
			// 
			// btn1min
			// 
			btn1min.Anchor = AnchorStyles.None;
			btn1min.AutoSize = true;
			btn1min.Cursor = Cursors.Hand;
			btn1min.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btn1min.Location = new Point(97, 24);
			btn1min.Margin = new Padding(4, 3, 4, 3);
			btn1min.Name = "btn1min";
			btn1min.Size = new Size(76, 28);
			btn1min.TabIndex = 6;
			btn1min.Text = "1 min";
			btn1min.UseVisualStyleBackColor = true;
			btn1min.Click += btnStandardTimeFrame_Click;
			// 
			// btn5min
			// 
			btn5min.Anchor = AnchorStyles.None;
			btn5min.AutoSize = true;
			btn5min.Cursor = Cursors.Hand;
			btn5min.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btn5min.Location = new Point(180, 24);
			btn5min.Margin = new Padding(4, 3, 4, 3);
			btn5min.Name = "btn5min";
			btn5min.Size = new Size(76, 28);
			btn5min.TabIndex = 7;
			btn5min.Text = "5 min";
			btn5min.UseVisualStyleBackColor = true;
			btn5min.Click += btnStandardTimeFrame_Click;
			// 
			// pnlTimeCalculator
			// 
			pnlTimeCalculator.Controls.Add(tbResultInMs);
			pnlTimeCalculator.Controls.Add(nudTimeToCalc);
			pnlTimeCalculator.Controls.Add(lblResultInMs);
			pnlTimeCalculator.Controls.Add(cbTimeUnitToCalc);
			pnlTimeCalculator.Dock = DockStyle.Fill;
			pnlTimeCalculator.Location = new Point(275, 67);
			pnlTimeCalculator.Margin = new Padding(4, 3, 4, 3);
			pnlTimeCalculator.Name = "pnlTimeCalculator";
			pnlTimeCalculator.Size = new Size(261, 56);
			pnlTimeCalculator.TabIndex = 10;
			// 
			// tbResultInMs
			// 
			tbResultInMs.Anchor = AnchorStyles.None;
			tbResultInMs.Font = new Font("Bahnschrift", 11.25F);
			tbResultInMs.Location = new Point(97, 30);
			tbResultInMs.Margin = new Padding(4, 3, 4, 3);
			tbResultInMs.Name = "tbResultInMs";
			tbResultInMs.ReadOnly = true;
			tbResultInMs.Size = new Size(158, 26);
			tbResultInMs.TabIndex = 9;
			// 
			// nudTimeToCalc
			// 
			nudTimeToCalc.Anchor = AnchorStyles.None;
			nudTimeToCalc.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			nudTimeToCalc.Location = new Point(14, 2);
			nudTimeToCalc.Margin = new Padding(4, 3, 4, 3);
			nudTimeToCalc.Maximum = new decimal(new int[] { 2400, 0, 0, 0 });
			nudTimeToCalc.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			nudTimeToCalc.Name = "nudTimeToCalc";
			nudTimeToCalc.Size = new Size(71, 26);
			nudTimeToCalc.TabIndex = 3;
			nudTimeToCalc.Tag = "calculate";
			nudTimeToCalc.Value = new decimal(new int[] { 10, 0, 0, 0 });
			nudTimeToCalc.ValueChanged += nudInput_ValueChanged;
			nudTimeToCalc.KeyPress += nudInput_KeyPress;
			// 
			// lblResultInMs
			// 
			lblResultInMs.Anchor = AnchorStyles.None;
			lblResultInMs.AutoSize = true;
			lblResultInMs.Font = new Font("Bahnschrift", 11.25F);
			lblResultInMs.Location = new Point(14, 36);
			lblResultInMs.Margin = new Padding(4, 0, 4, 0);
			lblResultInMs.Name = "lblResultInMs";
			lblResultInMs.Size = new Size(64, 18);
			lblResultInMs.TabIndex = 3;
			lblResultInMs.Text = "in ms is:";
			// 
			// cbTimeUnitToCalc
			// 
			cbTimeUnitToCalc.Anchor = AnchorStyles.None;
			cbTimeUnitToCalc.DropDownStyle = ComboBoxStyle.DropDownList;
			cbTimeUnitToCalc.Font = new Font("Bahnschrift", 11.25F);
			cbTimeUnitToCalc.FormattingEnabled = true;
			cbTimeUnitToCalc.Items.AddRange(new object[] { "minute(s)", "second(s)" });
			cbTimeUnitToCalc.Location = new Point(97, 2);
			cbTimeUnitToCalc.Margin = new Padding(4, 3, 4, 3);
			cbTimeUnitToCalc.Name = "cbTimeUnitToCalc";
			cbTimeUnitToCalc.Size = new Size(158, 26);
			cbTimeUnitToCalc.TabIndex = 8;
			cbTimeUnitToCalc.SelectedIndexChanged += cbTimes_ValueChanged;
			// 
			// tcWindow
			// 
			tcWindow.Controls.Add(tpMain);
			tcWindow.Controls.Add(tpSettings);
			tcWindow.Dock = DockStyle.Fill;
			tcWindow.Location = new Point(0, 0);
			tcWindow.Name = "tcWindow";
			tcWindow.SelectedIndex = 0;
			tcWindow.Size = new Size(584, 161);
			tcWindow.TabIndex = 13;
			tcWindow.SelectedIndexChanged += tcWindow_SelectedIndexChanged;
			// 
			// tpMain
			// 
			tpMain.Controls.Add(tlpWindow);
			tpMain.Location = new Point(4, 24);
			tpMain.Name = "tpMain";
			tpMain.Padding = new Padding(3);
			tpMain.Size = new Size(576, 133);
			tpMain.TabIndex = 0;
			tpMain.Text = "Main";
			tpMain.UseVisualStyleBackColor = true;
			// 
			// tpSettings
			// 
			tpSettings.Controls.Add(lblStartStopKeyTip);
			tpSettings.Controls.Add(btnChangeStartStopKey);
			tpSettings.Controls.Add(lblChangeStartStopKey);
			tpSettings.Location = new Point(4, 24);
			tpSettings.Name = "tpSettings";
			tpSettings.Padding = new Padding(3);
			tpSettings.Size = new Size(576, 133);
			tpSettings.TabIndex = 1;
			tpSettings.Text = "Settings";
			tpSettings.UseVisualStyleBackColor = true;
			// 
			// lblStartStopKeyTip
			// 
			lblStartStopKeyTip.Anchor = AnchorStyles.None;
			lblStartStopKeyTip.AutoSize = true;
			lblStartStopKeyTip.Font = new Font("Bahnschrift", 11F);
			lblStartStopKeyTip.ForeColor = SystemColors.ControlDarkDark;
			lblStartStopKeyTip.Location = new Point(178, 73);
			lblStartStopKeyTip.Margin = new Padding(4, 0, 4, 0);
			lblStartStopKeyTip.Name = "lblStartStopKeyTip";
			lblStartStopKeyTip.Size = new Size(221, 18);
			lblStartStopKeyTip.TabIndex = 7;
			lblStartStopKeyTip.Text = "Press the button again to cancel";
			// 
			// btnChangeStartStopKey
			// 
			btnChangeStartStopKey.Anchor = AnchorStyles.None;
			btnChangeStartStopKey.AutoSize = true;
			btnChangeStartStopKey.Cursor = Cursors.Hand;
			btnChangeStartStopKey.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnChangeStartStopKey.Location = new Point(298, 42);
			btnChangeStartStopKey.Margin = new Padding(4, 3, 4, 3);
			btnChangeStartStopKey.Name = "btnChangeStartStopKey";
			btnChangeStartStopKey.Size = new Size(117, 28);
			btnChangeStartStopKey.TabIndex = 6;
			btnChangeStartStopKey.Text = "_startStopKey";
			btnChangeStartStopKey.UseVisualStyleBackColor = true;
			btnChangeStartStopKey.Click += btnStartStopKey_Click;
			btnChangeStartStopKey.KeyDown += btnStartStopKey_KeyDown;
			// 
			// lblChangeStartStopKey
			// 
			lblChangeStartStopKey.Anchor = AnchorStyles.None;
			lblChangeStartStopKey.AutoSize = true;
			lblChangeStartStopKey.Font = new Font("Bahnschrift", 11.25F);
			lblChangeStartStopKey.Location = new Point(162, 47);
			lblChangeStartStopKey.Margin = new Padding(4, 0, 4, 0);
			lblChangeStartStopKey.Name = "lblChangeStartStopKey";
			lblChangeStartStopKey.Size = new Size(124, 18);
			lblChangeStartStopKey.TabIndex = 4;
			lblChangeStartStopKey.Text = "Key to start/stop:";
			// 
			// Window
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(584, 161);
			Controls.Add(tcWindow);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			MaximumSize = new Size(600, 200);
			MinimumSize = new Size(0, 200);
			Name = "Window";
			ShowIcon = false;
			Text = "Autoclicker";
			FormClosing += Window_Closing;
			Load += Window_Load;
			((System.ComponentModel.ISupportInitialize)nudUserInterval).EndInit();
			pnlUserTimeFrame.ResumeLayout(false);
			pnlUserTimeFrame.PerformLayout();
			pnlInteractClicker.ResumeLayout(false);
			pnlInteractClicker.PerformLayout();
			tlpWindow.ResumeLayout(false);
			pnlDefaultTimeFrame.ResumeLayout(false);
			pnlDefaultTimeFrame.PerformLayout();
			pnlTimeCalculator.ResumeLayout(false);
			pnlTimeCalculator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)nudTimeToCalc).EndInit();
			tcWindow.ResumeLayout(false);
			tpMain.ResumeLayout(false);
			tpMain.PerformLayout();
			tpSettings.ResumeLayout(false);
			tpSettings.PerformLayout();
			ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnStartStopClicker;
		private System.Windows.Forms.Label lblInterval;
		private System.Windows.Forms.Timer tmrClicker;
		private System.Windows.Forms.NumericUpDown nudUserInterval;
		private System.Windows.Forms.Timer tmrKeyDown;
		private System.Windows.Forms.Label lblStartStopTip;
		private System.Windows.Forms.Panel pnlUserTimeFrame;
		private System.Windows.Forms.Label lblUserTimeFrame;
		private System.Windows.Forms.Panel pnlInteractClicker;
		private System.Windows.Forms.Button btnChangeWindowState;
		private TableLayoutPanel tlpWindow;
		private Panel pnlDefaultTimeFrame;
		private Label lblStandardTimeFrame;
		private Button btn30sec;
		private Button btn1min;
		private Button btn5min;
		private Panel pnlTimeCalculator;
		private TextBox tbResultInMs;
		private NumericUpDown nudTimeToCalc;
		private Label lblResultInMs;
		private ComboBox cbTimeUnitToCalc;
		private TabControl tcWindow;
		private TabPage tpMain;
		private TabPage tpSettings;
		private Button btnChangeStartStopKey;
		private Label lblChangeStartStopKey;
		private Label lblStartStopKeyTip;
	}
}


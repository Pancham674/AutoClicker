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
			btnStartStop = new Button();
			lblInterval = new Label();
			tmrClicker = new System.Windows.Forms.Timer(components);
			nudInterval = new NumericUpDown();
			tmrKeyDown = new System.Windows.Forms.Timer(components);
			lblHint = new Label();
			pnlUserTimeFrame = new Panel();
			lblUserTimeFrame = new Label();
			pnlInteractClicker = new Panel();
			btnChangeWindowState = new Button();
			tlpWindow = new TableLayoutPanel();
			pnlStandardTimeFrame = new Panel();
			lblStandardTimeFrame = new Label();
			btn30sec = new Button();
			btn1min = new Button();
			btn5min = new Button();
			pnlTimeCalculator = new Panel();
			tbCalcResult = new TextBox();
			nudInputTime = new NumericUpDown();
			lblCalculate = new Label();
			cbTimeUnit = new ComboBox();
			tcWindow = new TabControl();
			tpMain = new TabPage();
			tpSettings = new TabPage();
			lblStartStopKeyHint = new Label();
			btnStartStopKey = new Button();
			lbl = new Label();
			lblChangeControlKey = new Label();
			((System.ComponentModel.ISupportInitialize)nudInterval).BeginInit();
			pnlUserTimeFrame.SuspendLayout();
			pnlInteractClicker.SuspendLayout();
			tlpWindow.SuspendLayout();
			pnlStandardTimeFrame.SuspendLayout();
			pnlTimeCalculator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nudInputTime).BeginInit();
			tcWindow.SuspendLayout();
			tpMain.SuspendLayout();
			tpSettings.SuspendLayout();
			SuspendLayout();
			// 
			// btnStartStop
			// 
			btnStartStop.Anchor = AnchorStyles.None;
			btnStartStop.AutoSize = true;
			btnStartStop.Cursor = Cursors.Hand;
			btnStartStop.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnStartStop.Location = new Point(49, 4);
			btnStartStop.Margin = new Padding(4, 3, 4, 3);
			btnStartStop.Name = "btnStartStop";
			btnStartStop.Size = new Size(163, 28);
			btnStartStop.TabIndex = 0;
			btnStartStop.Text = "Start Autoclicker";
			btnStartStop.UseVisualStyleBackColor = true;
			btnStartStop.Click += btnStartStop_Click;
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
			tmrClicker.Tick += timer_Tick;
			// 
			// nudInterval
			// 
			nudInterval.Anchor = AnchorStyles.None;
			nudInterval.AutoSize = true;
			nudInterval.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			nudInterval.Location = new Point(126, 24);
			nudInterval.Margin = new Padding(4, 3, 4, 3);
			nudInterval.Maximum = new decimal(new int[] { 2400000, 0, 0, 0 });
			nudInterval.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			nudInterval.Name = "nudInterval";
			nudInterval.Size = new Size(102, 26);
			nudInterval.TabIndex = 2;
			nudInterval.Tag = "interval";
			nudInterval.Value = new decimal(new int[] { 1, 0, 0, 0 });
			nudInterval.ValueChanged += nudInput_ValueChanged;
			nudInterval.KeyPress += nudInput_KeyPress;
			// 
			// tmrKeyDown
			// 
			tmrKeyDown.Enabled = true;
			tmrKeyDown.Tick += tmrKeyDown_Tick;
			// 
			// lblHint
			// 
			lblHint.Anchor = AnchorStyles.None;
			lblHint.AutoSize = true;
			lblHint.Font = new Font("Bahnschrift", 11F);
			lblHint.ForeColor = SystemColors.ControlDarkDark;
			lblHint.Location = new Point(27, 35);
			lblHint.Margin = new Padding(4, 0, 4, 0);
			lblHint.Name = "lblHint";
			lblHint.Size = new Size(209, 18);
			lblHint.TabIndex = 3;
			lblHint.Text = "Press Right Shift to start/stop";
			// 
			// pnlUserTimeFrame
			// 
			pnlUserTimeFrame.Controls.Add(nudInterval);
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
			pnlInteractClicker.Controls.Add(btnStartStop);
			pnlInteractClicker.Controls.Add(lblHint);
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
			tlpWindow.Controls.Add(pnlStandardTimeFrame, 1, 0);
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
			// pnlStandardTimeFrame
			// 
			pnlStandardTimeFrame.Controls.Add(lblStandardTimeFrame);
			pnlStandardTimeFrame.Controls.Add(btn30sec);
			pnlStandardTimeFrame.Controls.Add(btn1min);
			pnlStandardTimeFrame.Controls.Add(btn5min);
			pnlStandardTimeFrame.Dock = DockStyle.Fill;
			pnlStandardTimeFrame.Location = new Point(275, 4);
			pnlStandardTimeFrame.Margin = new Padding(4, 3, 4, 3);
			pnlStandardTimeFrame.Name = "pnlStandardTimeFrame";
			pnlStandardTimeFrame.Size = new Size(261, 56);
			pnlStandardTimeFrame.TabIndex = 12;
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
			pnlTimeCalculator.Controls.Add(tbCalcResult);
			pnlTimeCalculator.Controls.Add(nudInputTime);
			pnlTimeCalculator.Controls.Add(lblCalculate);
			pnlTimeCalculator.Controls.Add(cbTimeUnit);
			pnlTimeCalculator.Dock = DockStyle.Fill;
			pnlTimeCalculator.Location = new Point(275, 67);
			pnlTimeCalculator.Margin = new Padding(4, 3, 4, 3);
			pnlTimeCalculator.Name = "pnlTimeCalculator";
			pnlTimeCalculator.Size = new Size(261, 56);
			pnlTimeCalculator.TabIndex = 10;
			// 
			// tbCalcResult
			// 
			tbCalcResult.Anchor = AnchorStyles.None;
			tbCalcResult.Font = new Font("Bahnschrift", 11.25F);
			tbCalcResult.Location = new Point(97, 30);
			tbCalcResult.Margin = new Padding(4, 3, 4, 3);
			tbCalcResult.Name = "tbCalcResult";
			tbCalcResult.ReadOnly = true;
			tbCalcResult.Size = new Size(158, 26);
			tbCalcResult.TabIndex = 9;
			// 
			// nudInputTime
			// 
			nudInputTime.Anchor = AnchorStyles.None;
			nudInputTime.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			nudInputTime.Location = new Point(14, 2);
			nudInputTime.Margin = new Padding(4, 3, 4, 3);
			nudInputTime.Maximum = new decimal(new int[] { 2400, 0, 0, 0 });
			nudInputTime.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			nudInputTime.Name = "nudInputTime";
			nudInputTime.Size = new Size(71, 26);
			nudInputTime.TabIndex = 3;
			nudInputTime.Tag = "calculate";
			nudInputTime.Value = new decimal(new int[] { 10, 0, 0, 0 });
			nudInputTime.ValueChanged += nudInput_ValueChanged;
			nudInputTime.KeyPress += nudInput_KeyPress;
			// 
			// lblCalculate
			// 
			lblCalculate.Anchor = AnchorStyles.None;
			lblCalculate.AutoSize = true;
			lblCalculate.Font = new Font("Bahnschrift", 11.25F);
			lblCalculate.Location = new Point(14, 36);
			lblCalculate.Margin = new Padding(4, 0, 4, 0);
			lblCalculate.Name = "lblCalculate";
			lblCalculate.Size = new Size(64, 18);
			lblCalculate.TabIndex = 3;
			lblCalculate.Text = "in ms is:";
			// 
			// cbTimeUnit
			// 
			cbTimeUnit.Anchor = AnchorStyles.None;
			cbTimeUnit.DropDownStyle = ComboBoxStyle.DropDownList;
			cbTimeUnit.Font = new Font("Bahnschrift", 11.25F);
			cbTimeUnit.FormattingEnabled = true;
			cbTimeUnit.Items.AddRange(new object[] { "minute(s)", "second(s)" });
			cbTimeUnit.Location = new Point(97, 2);
			cbTimeUnit.Margin = new Padding(4, 3, 4, 3);
			cbTimeUnit.Name = "cbTimeUnit";
			cbTimeUnit.Size = new Size(158, 26);
			cbTimeUnit.TabIndex = 8;
			cbTimeUnit.SelectedIndexChanged += cbTimes_ValueChanged;
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
			tpSettings.Controls.Add(lblStartStopKeyHint);
			tpSettings.Controls.Add(btnStartStopKey);
			tpSettings.Controls.Add(lbl);
			tpSettings.Controls.Add(lblChangeControlKey);
			tpSettings.Location = new Point(4, 24);
			tpSettings.Name = "tpSettings";
			tpSettings.Padding = new Padding(3);
			tpSettings.Size = new Size(576, 133);
			tpSettings.TabIndex = 1;
			tpSettings.Text = "Settings";
			tpSettings.UseVisualStyleBackColor = true;
			// 
			// lblStartStopKeyHint
			// 
			lblStartStopKeyHint.Anchor = AnchorStyles.None;
			lblStartStopKeyHint.AutoSize = true;
			lblStartStopKeyHint.Font = new Font("Bahnschrift", 11F);
			lblStartStopKeyHint.ForeColor = SystemColors.ControlDarkDark;
			lblStartStopKeyHint.Location = new Point(178, 73);
			lblStartStopKeyHint.Margin = new Padding(4, 0, 4, 0);
			lblStartStopKeyHint.Name = "lblStartStopKeyHint";
			lblStartStopKeyHint.Size = new Size(221, 18);
			lblStartStopKeyHint.TabIndex = 7;
			lblStartStopKeyHint.Text = "Press the button again to cancel";
			// 
			// btnStartStopKey
			// 
			btnStartStopKey.Anchor = AnchorStyles.None;
			btnStartStopKey.AutoSize = true;
			btnStartStopKey.Cursor = Cursors.Hand;
			btnStartStopKey.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnStartStopKey.Location = new Point(298, 42);
			btnStartStopKey.Margin = new Padding(4, 3, 4, 3);
			btnStartStopKey.Name = "btnStartStopKey";
			btnStartStopKey.Size = new Size(117, 28);
			btnStartStopKey.TabIndex = 6;
			btnStartStopKey.Text = "_startStopKey";
			btnStartStopKey.UseVisualStyleBackColor = true;
			btnStartStopKey.Click += btnStartStopKey_Click;
			btnStartStopKey.KeyDown += btnStartStopKey_KeyDown;
			// 
			// lbl
			// 
			lbl.Anchor = AnchorStyles.None;
			lbl.AutoSize = true;
			lbl.Font = new Font("Bahnschrift", 11.25F);
			lbl.Location = new Point(279, 54);
			lbl.Margin = new Padding(4, 0, 4, 0);
			lbl.Name = "lbl";
			lbl.Size = new Size(0, 18);
			lbl.TabIndex = 5;
			// 
			// lblChangeControlKey
			// 
			lblChangeControlKey.Anchor = AnchorStyles.None;
			lblChangeControlKey.Font = new Font("Bahnschrift", 11.25F);
			lblChangeControlKey.Location = new Point(162, 47);
			lblChangeControlKey.Margin = new Padding(4, 0, 4, 0);
			lblChangeControlKey.Name = "lblChangeControlKey";
			lblChangeControlKey.Size = new Size(128, 23);
			lblChangeControlKey.TabIndex = 4;
			lblChangeControlKey.Text = "Key to start/stop:";
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
			((System.ComponentModel.ISupportInitialize)nudInterval).EndInit();
			pnlUserTimeFrame.ResumeLayout(false);
			pnlUserTimeFrame.PerformLayout();
			pnlInteractClicker.ResumeLayout(false);
			pnlInteractClicker.PerformLayout();
			tlpWindow.ResumeLayout(false);
			pnlStandardTimeFrame.ResumeLayout(false);
			pnlStandardTimeFrame.PerformLayout();
			pnlTimeCalculator.ResumeLayout(false);
			pnlTimeCalculator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)nudInputTime).EndInit();
			tcWindow.ResumeLayout(false);
			tpMain.ResumeLayout(false);
			tpMain.PerformLayout();
			tpSettings.ResumeLayout(false);
			tpSettings.PerformLayout();
			ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnStartStop;
		private System.Windows.Forms.Label lblInterval;
		private System.Windows.Forms.Timer tmrClicker;
		private System.Windows.Forms.NumericUpDown nudInterval;
		private System.Windows.Forms.Timer tmrKeyDown;
		private System.Windows.Forms.Label lblHint;
		private System.Windows.Forms.Panel pnlUserTimeFrame;
		private System.Windows.Forms.Label lblUserTimeFrame;
		private System.Windows.Forms.Panel pnlInteractClicker;
		private System.Windows.Forms.Button btnChangeWindowState;
		private TableLayoutPanel tlpWindow;
		private Panel pnlStandardTimeFrame;
		private Label lblStandardTimeFrame;
		private Button btn30sec;
		private Button btn1min;
		private Button btn5min;
		private Panel pnlTimeCalculator;
		private TextBox tbCalcResult;
		private NumericUpDown nudInputTime;
		private Label lblCalculate;
		private ComboBox cbTimeUnit;
		private TabControl tcWindow;
		private TabPage tpMain;
		private TabPage tpSettings;
		private Button btnStartStopKey;
		private Label lbl;
		private Label lblChangeControlKey;
		private Label lblStartStopKeyHint;
	}
}


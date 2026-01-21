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
			((System.ComponentModel.ISupportInitialize)nudInterval).BeginInit();
			pnlUserTimeFrame.SuspendLayout();
			pnlInteractClicker.SuspendLayout();
			tlpWindow.SuspendLayout();
			pnlStandardTimeFrame.SuspendLayout();
			pnlTimeCalculator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nudInputTime).BeginInit();
			SuspendLayout();
			// 
			// btnStartStop
			// 
			btnStartStop.Anchor = AnchorStyles.None;
			btnStartStop.AutoSize = true;
			btnStartStop.Cursor = Cursors.Hand;
			btnStartStop.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnStartStop.Location = new Point(52, 8);
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
			lblInterval.Location = new Point(19, 31);
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
			nudInterval.Location = new Point(129, 27);
			nudInterval.Margin = new Padding(4, 3, 4, 3);
			nudInterval.Maximum = new decimal(new int[] { 2400000, 0, 0, 0 });
			nudInterval.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			nudInterval.Name = "nudInterval";
			nudInterval.Size = new Size(102, 26);
			nudInterval.TabIndex = 2;
			nudInterval.Tag = "interval";
			nudInterval.Value = new decimal(new int[] { 60000, 0, 0, 0 });
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
			lblHint.Location = new Point(30, 39);
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
			pnlUserTimeFrame.Size = new Size(266, 63);
			pnlUserTimeFrame.TabIndex = 4;
			// 
			// lblUserTimeFrame
			// 
			lblUserTimeFrame.Anchor = AnchorStyles.None;
			lblUserTimeFrame.AutoSize = true;
			lblUserTimeFrame.Font = new Font("Bahnschrift", 11F);
			lblUserTimeFrame.Location = new Point(19, 6);
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
			pnlInteractClicker.Location = new Point(5, 74);
			pnlInteractClicker.Margin = new Padding(4, 3, 4, 3);
			pnlInteractClicker.Name = "pnlInteractClicker";
			pnlInteractClicker.Size = new Size(266, 64);
			pnlInteractClicker.TabIndex = 11;
			// 
			// btnChangeWindowState
			// 
			btnChangeWindowState.Cursor = Cursors.Hand;
			btnChangeWindowState.Dock = DockStyle.Right;
			btnChangeWindowState.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnChangeWindowState.Location = new Point(549, 0);
			btnChangeWindowState.Margin = new Padding(4, 3, 4, 3);
			btnChangeWindowState.Name = "btnChangeWindowState";
			btnChangeWindowState.Size = new Size(21, 139);
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
			tlpWindow.ColumnCount = 2;
			tlpWindow.ColumnStyles.Add(new ColumnStyle());
			tlpWindow.ColumnStyles.Add(new ColumnStyle());
			tlpWindow.Controls.Add(pnlUserTimeFrame, 0, 0);
			tlpWindow.Controls.Add(pnlStandardTimeFrame, 1, 0);
			tlpWindow.Controls.Add(pnlTimeCalculator, 1, 1);
			tlpWindow.Controls.Add(pnlInteractClicker, 0, 1);
			tlpWindow.Dock = DockStyle.Fill;
			tlpWindow.Location = new Point(0, 0);
			tlpWindow.Name = "tlpWindow";
			tlpWindow.RowCount = 2;
			tlpWindow.RowStyles.Add(new RowStyle());
			tlpWindow.RowStyles.Add(new RowStyle());
			tlpWindow.Size = new Size(549, 139);
			tlpWindow.TabIndex = 4;
			// 
			// pnlStandardTimeFrame
			// 
			pnlStandardTimeFrame.Controls.Add(lblStandardTimeFrame);
			pnlStandardTimeFrame.Controls.Add(btn30sec);
			pnlStandardTimeFrame.Controls.Add(btn1min);
			pnlStandardTimeFrame.Controls.Add(btn5min);
			pnlStandardTimeFrame.Dock = DockStyle.Fill;
			pnlStandardTimeFrame.Location = new Point(280, 4);
			pnlStandardTimeFrame.Margin = new Padding(4, 3, 4, 3);
			pnlStandardTimeFrame.Name = "pnlStandardTimeFrame";
			pnlStandardTimeFrame.Size = new Size(267, 63);
			pnlStandardTimeFrame.TabIndex = 12;
			// 
			// lblStandardTimeFrame
			// 
			lblStandardTimeFrame.Anchor = AnchorStyles.None;
			lblStandardTimeFrame.AutoSize = true;
			lblStandardTimeFrame.Font = new Font("Bahnschrift", 11F);
			lblStandardTimeFrame.Location = new Point(17, 6);
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
			btn30sec.Location = new Point(18, 27);
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
			btn1min.Location = new Point(100, 27);
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
			btn5min.Location = new Point(183, 27);
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
			pnlTimeCalculator.Location = new Point(280, 74);
			pnlTimeCalculator.Margin = new Padding(4, 3, 4, 3);
			pnlTimeCalculator.Name = "pnlTimeCalculator";
			pnlTimeCalculator.Size = new Size(267, 64);
			pnlTimeCalculator.TabIndex = 10;
			// 
			// tbCalcResult
			// 
			tbCalcResult.Anchor = AnchorStyles.None;
			tbCalcResult.Font = new Font("Bahnschrift", 11.25F);
			tbCalcResult.Location = new Point(100, 34);
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
			nudInputTime.Location = new Point(17, 6);
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
			lblCalculate.Location = new Point(17, 40);
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
			cbTimeUnit.Location = new Point(100, 6);
			cbTimeUnit.Margin = new Padding(4, 3, 4, 3);
			cbTimeUnit.Name = "cbTimeUnit";
			cbTimeUnit.Size = new Size(158, 26);
			cbTimeUnit.TabIndex = 8;
			cbTimeUnit.SelectedIndexChanged += cbTimes_ValueChanged;
			// 
			// Window
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(570, 139);
			Controls.Add(tlpWindow);
			Controls.Add(btnChangeWindowState);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			MaximumSize = new Size(586, 196);
			Name = "Window";
			ShowIcon = false;
			Text = "Autoclicker";
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
			ResumeLayout(false);
			PerformLayout();

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
	}
}


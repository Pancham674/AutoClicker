using AutoClicker.Properties;
using System.Diagnostics;
using System.Media;
using System.Runtime.InteropServices;

namespace AutoClicker
{
	public partial class Window : Form
	{
		/// <summary>
		/// Used for the click event
		/// </summary>
		/// <param name="dwFlags"></param>
		/// <param name="dx"></param>
		/// <param name="dy"></param>
		/// <param name="dwData"></param>
		/// <param name="dwextrainfo"></param>
		[DllImport("user32.dll")]
		static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwextrainfo);

		/// <summary>
		/// Used for de/activating the autoclicker when a key is pressed and window isn't in focus
		/// </summary>
		/// <param name="vKey"></param>
		/// <returns></returns>
		[DllImport("User32.dll")]
		static extern short GetAsyncKeyState(Int32 vKey);

		SoundPlayer _onSound;
		SoundPlayer _offSound;

		bool _clickerIsActive;
		bool _keyIsBeingChanged;

		Keys _startStopKey;
		State _windowState;
		Button[] _timeFrames;

		int _ogWidth;
		int _intervalToUse;

		public Window()
		{
			InitializeComponent();
			SetStartStopKey((Keys)Settings.Default.StartStopKey);

			_windowState = State.HideExtended;
			_ogWidth = Width;
			_timeFrames = new Button[3]
			{
				btn30sec,
				btn1min,
				btn5min
			};

			_onSound = new SoundPlayer(Resources.Clicker_On);
			_offSound = new SoundPlayer(Resources.Clicker_Off);
		}

		enum MouseEventsFlags
		{
			LeftDown = 2,
			LeftUp = 4,
		}

		enum State
		{
			HideExtended,
			ShowExtended
		}

		void SetStartStopKey(Keys myNewCurrentKey)
		{
			_startStopKey = myNewCurrentKey;
			btnStartStopKey.Text = _startStopKey.ToString();
			lblHint.Text = string.Concat("Press ", _startStopKey.ToString(), " to start/stop");

			int xPos = pnlInteractClicker.Width / 2 - lblHint.Width / 2;
			lblHint.Location = new Point(xPos, lblHint.Location.Y);
		}

		void Window_Load(object sender, EventArgs e)
		{
			tmrKeyDown.Start();
			_intervalToUse = Settings.Default.ClickInterval;
			nudInterval.Value = _intervalToUse;
			cbTimeUnit.SelectedIndex = 0;
			ChangeWindow();
		}

		void Window_Closing(object sender, FormClosingEventArgs e)
		{
			Settings.Default.StartStopKey = (int)_startStopKey;
			Settings.Default.ClickInterval = _intervalToUse;
			Settings.Default.Save();
		}

		void LeftClick(Point p)
		{
			mouse_event((int)MouseEventsFlags.LeftDown, p.X, p.Y, 0, 0);
			mouse_event((int)MouseEventsFlags.LeftUp, p.X, p.Y, 0, 0);
		}

		void btnStartStop_Click(object sender, EventArgs e)
		{
			ChangeActiveState();
		}

		/// <summary>
		/// Will start/stop the timer based on if the clicker is active or not.
		/// </summary>
		void ChangeActiveState()
		{
			_clickerIsActive = !_clickerIsActive;
			tmrClicker.Interval = _intervalToUse;
			tmrClicker.Enabled = true;

			if (_clickerIsActive)
			{
				btnStartStop.Text = "Stop Autoclicker";
				tmrClicker.Start();
				_onSound.Play();
			}
			else
			{
				btnStartStop.Text = "Start Autoclicker";
				tmrClicker.Stop();
				_offSound.Play();
			}
		}

		/// <summary>
		/// Event that will trigger the click method if raised.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void timer_Tick(object sender, EventArgs e)
		{
			LeftClick(new Point(MousePosition.X, MousePosition.Y));
		}

		/// <summary>
		/// Will check if the user has pressed the start/stop key during runtime
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void tmrKeyDown_Tick(object sender, EventArgs e)
		{
			short keyStatus = GetAsyncKeyState((short)_startStopKey);

			if (keyStatus < 0)
			{
				ChangeActiveState();
				Thread.Sleep(200);		//prevent enabling/disabling multiple times in a short time
			}
		}

		/// <summary>
		/// Will set up the timers interval to the desired buttons data
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void btnStandardTimeFrame_Click(object sender, EventArgs e)
		{
			Button senderButton = (Button)sender;
			string[] btnData = senderButton.Text.Split();

			int timeFrame = Convert.ToInt32(btnData[0]);
			string timeUnit = btnData[1];

			timeUnit = DetermineNextTimeUnit(timeUnit);
			_intervalToUse = CalculateToMilliSeconds(timeFrame, timeUnit);

			senderButton.Enabled = false;
			Button[] uninteractedBtns = _timeFrames.Where(btn => btn != senderButton).ToArray();
			foreach (Button btn in uninteractedBtns)
			{
				btn.Enabled = true;
			}
		}

		/// <summary>
		/// Returns the time frame the selected time frame needs to be converted to.
		/// </summary>
		/// <param name="timeUnit"></param>
		/// <returns></returns>
		string DetermineNextTimeUnit(string timeUnit)
		{
			switch (timeUnit)
			{
				case "minute(s)":
				case "min":
					timeUnit = "sec";
					break;

				case "second(s)":
				case "sec":
					timeUnit = "ms";
					break;
			}

			return timeUnit;
		}

		int CalculateToMilliSeconds(int myTimeFrame, string myNextTimeUnit)
		{
			// convert min to sec
			if (myNextTimeUnit.Equals("sec"))
			{
				myTimeFrame *= 60;
				myNextTimeUnit = "ms";
			}

			// convert sec to ms
			if (myNextTimeUnit.Equals("ms"))
			{
				myTimeFrame *= 1000;
			}

			return myTimeFrame;
		}

		void cbTimes_ValueChanged(object sender, EventArgs e)
		{
			CalculateResult();
		}

		/// <summary>
		/// Event that handles the nud controls whose value have changed
		/// Will either stop the clicker if the new click time isnt the same or calculate the given time to ms
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void nudInput_ValueChanged(object sender, EventArgs e)
		{
			NumericUpDown nudSender = (NumericUpDown)sender;
			if (nudSender == nudInputTime)
			{
				CalculateResult();
			}
			else if (nudSender == nudInterval && _intervalToUse != (int)nudSender.Value)
			{
				if (_clickerIsActive)
				{
					ChangeActiveState();
				}

				_intervalToUse = (int)nudSender.Value;

				Button[] toDisable = _timeFrames.Where(b => !b.Enabled).ToArray();

				foreach (Button btn in toDisable)
				{
					btn.Enabled = true;
				}
			}
		}

		/// <summary>
		/// Will update the interval and stop the clicker if the user presses a number key.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void nudInput_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (int.TryParse(e.KeyChar.ToString(), out int result) || (Keys)e.KeyChar == Keys.Back || (Keys)e.KeyChar == Keys.OemBackslash)
			{
				nudInput_ValueChanged(sender, e);
			}
			else
			{
				e.Handled = true;
			}
		}

		void CalculateResult()
		{
			string nextTimeUnit = DetermineNextTimeUnit(cbTimeUnit.Text);
			int timeFrame = (int)nudInputTime.Value;
			int result = CalculateToMilliSeconds(timeFrame, nextTimeUnit);
			tbCalcResult.Text = result > 0 ? result.ToString() : "ERROR";
		}

		void btnChangeWindowState_Click(object sender, EventArgs e)
		{
			_windowState = _windowState == State.HideExtended ? State.ShowExtended : State.HideExtended;
			ChangeWindow();
		}

		/// <summary>
		/// This will either widen the window to show its other options or reduce it to show its main functions.
		/// </summary>
		void ChangeWindow()
		{
			ColumnStyle fstColumn = tlpWindow.ColumnStyles[0];
			ColumnStyle sndColumn = tlpWindow.ColumnStyles[1];

			if (_windowState == State.HideExtended)
			{
				btnChangeWindowState.Text = ">>";
				Width = pnlInteractClicker.Width + btnChangeWindowState.Width * 3;

				fstColumn.Width = 100;
				sndColumn.Width = 0;

				pnlStandardTimeFrame.Visible = false;
				pnlTimeCalculator.Visible = false;
			}
			else if (_windowState == State.ShowExtended)
			{
				btnChangeWindowState.Text = "<<";
				Width = _ogWidth;

				pnlStandardTimeFrame.Visible = true;
				pnlTimeCalculator.Visible = true;

				fstColumn.Width = 50;
				sndColumn.Width = 50;
			}
		}

		private void btnStartStopKey_Click(object sender, EventArgs e)
		{
			_keyIsBeingChanged = !_keyIsBeingChanged;

			if (_keyIsBeingChanged)
			{
				btnStartStopKey.Text = "Press any key...";
			}
			else     //Cancel the changing and set it back to the current key
			{	
				SetStartStopKey(_startStopKey);
			}
		}

		private void btnStartStopKey_KeyDown(object sender, KeyEventArgs e)
		{
			if (_keyIsBeingChanged)
			{
				SetStartStopKey(e.KeyCode);
				_keyIsBeingChanged = false;
				this.Focus();                   //Remove focus from button	
			}
		}

		/// <summary>
		/// Will revert the stop/start key back if the User changes tabs while updating the stop/start key in settings
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void tcWindow_SelectedIndexChanged(object sender, EventArgs e)
		{
			TabPage currentTap = tcWindow.SelectedTab!;
			
			if (currentTap == tpMain)
			{
				tmrKeyDown.Start();
				if (_keyIsBeingChanged)
				{
					_keyIsBeingChanged = false;
					SetStartStopKey(_startStopKey);
				}
			}
			else if (currentTap == tpSettings)
			{
				tmrKeyDown.Stop();              //will otherwise activate when setting the key
				if (_clickerIsActive)
				{
					ChangeActiveState();
				}
			}
		}
	}
}
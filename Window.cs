using AutoClicker.Properties;
using System.Diagnostics;
using System.Media;
using System.Runtime.InteropServices;

namespace AutoClicker
{
	public partial class Window : Form
	{
		#region DLLImports
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
		#endregion

		#region Globals
		//Sounds that are played when the clicker is started/stopped
		SoundPlayer _sndOn;
		SoundPlayer _sndOff;

		bool _IsClickerActive;
		bool _IsKeyBeingChanged;

		/// <summary>
		/// Current state of the Window. Is either showing extended options or not.
		/// </summary>
		State _windowState;
		Keys _startStopKey;
		Button[] _defaultTimeFramesBtn;

		int _fullWidth;
		int _holdClick;
		int _intervalToUse;
		#endregion

		#region Enums
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
		#endregion
		public Window()
		{
			InitializeComponent();
			SetStartStopKey((Keys)Settings.Default.StartStopKey);
			_intervalToUse = Settings.Default.ClickInterval;

			_windowState = State.HideExtended;
			_fullWidth = Width;
			_defaultTimeFramesBtn = new Button[3]
			{
				btn30sec,
				btn1min,
				btn5min
			};

			_sndOn = new SoundPlayer(Settings.Default.SoundStart);
			_sndOff = new SoundPlayer(Settings.Default.SoundStop);
		}

		void Window_Load(object sender, EventArgs e)
		{
			tmrKeyDown.Start();
			nudUserInterval.Value = _intervalToUse;
			cbTimeUnitToCalc.SelectedIndex = 0;
			ChangeWindow();
		}

		/// <summary>
		/// Will save User data such as click interval and start/stop key
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void Window_Closing(object sender, FormClosingEventArgs e)
		{
			Settings.Default.StartStopKey = (int)_startStopKey;
			Settings.Default.ClickInterval = _intervalToUse;
			Settings.Default.Save();
		}

		void btnStartStopClicker_Click(object sender, EventArgs e)
		{
			ChangeActiveState();
		}

		/// <summary>
		/// Will start/stop the clicker based on if the clicker is active or not.
		/// </summary>
		void ChangeActiveState()
		{
			_IsClickerActive = !_IsClickerActive;
			tmrClicker.Interval = _intervalToUse;
			tmrClicker.Enabled = true;

			if (_IsClickerActive)
			{
				btnStartStopClicker.Text = "Stop Autoclicker";
				tmrClicker.Start();
				_sndOn.Play();
			}
			else
			{
				btnStartStopClicker.Text = "Start Autoclicker";
				tmrClicker.Stop();
				_sndOff.Play();
			}
		}

		/// <summary>
		/// Event that will trigger the click method if raised.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void tmrClicker_Tick(object sender, EventArgs e)
		{
			LeftClick(new Point(MousePosition.X, MousePosition.Y));
		}

		void LeftClick(Point p)
		{
			mouse_event((int)MouseEventsFlags.LeftDown, p.X, p.Y, 0, 0);
			mouse_event((int)MouseEventsFlags.LeftUp, p.X, p.Y, 0, 0);
		}

		/// <summary>
		/// Will set the start/stop key to myNewCurrentKey and update everything associated to it.
		/// </summary>
		/// <param name="myNewCurrentKey"></param>
		void SetStartStopKey(Keys myNewCurrentKey)
		{
			_startStopKey = myNewCurrentKey;
			btnChangeStartStopKey.Text = _startStopKey.ToString();
			lblStartStopTip.Text = string.Concat("Press ", _startStopKey.ToString(), " to start/stop");

			int xPos = pnlInteractClicker.Width / 2 - lblStartStopTip.Width / 2;
			lblStartStopTip.Location = new Point(xPos, lblStartStopTip.Location.Y);
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
				Thread.Sleep(200);      //prevent enabling/disabling multiple times in a short time
			}
		}

		/// <summary>
		/// Will set up the click interval to the desired buttons data
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

			foreach (Button btn in _defaultTimeFramesBtn)
			{
				btn.Enabled = !btn.Equals(senderButton);
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
			}

			// convert sec to ms
			myTimeFrame *= 1000;

			return myTimeFrame;
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
			if (nudSender == nudTimeToCalc)
			{
				CalculateResult();
			}
			else if (nudSender == nudUserInterval && _intervalToUse != (int)nudSender.Value)
			{
				if (_IsClickerActive)
				{
					ChangeActiveState();
				}

				_intervalToUse = (int)nudSender.Value;

				Button[] toDisable = _defaultTimeFramesBtn.Where(b => !b.Enabled).ToArray();

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

		void cbTimes_ValueChanged(object sender, EventArgs e)
		{
			CalculateResult();
		}

		void CalculateResult()
		{
			string nextTimeUnit = DetermineNextTimeUnit(cbTimeUnitToCalc.Text);
			int result = CalculateToMilliSeconds((int)nudTimeToCalc.Value, nextTimeUnit);
			tbResultInMs.Text = result > 0 ? result.ToString() : "ERROR";
		}

		void btnChangeWindowState_Click(object sender, EventArgs e)
		{
			_windowState = _windowState.Equals(State.HideExtended) ? State.ShowExtended : State.HideExtended;
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

				pnlDefaultTimeFrame.Visible = false;
				pnlTimeCalculator.Visible = false;
			}
			else if (_windowState == State.ShowExtended)
			{
				btnChangeWindowState.Text = "<<";
				Width = _fullWidth;

				pnlDefaultTimeFrame.Visible = true;
				pnlTimeCalculator.Visible = true;

				fstColumn.Width = 50;
				sndColumn.Width = 50;
			}
		}

		void btnStartStopKey_Click(object sender, EventArgs e)
		{
			_IsKeyBeingChanged = !_IsKeyBeingChanged;

			if (_IsKeyBeingChanged)
			{
				btnChangeStartStopKey.Text = "Press any key...";
			}
			else     //Cancel the changing and set it back to the current key
			{
				SetStartStopKey(_startStopKey);
			}
		}

		void btnStartStopKey_KeyDown(object sender, KeyEventArgs e)
		{
			if (_IsKeyBeingChanged)
			{
				SetStartStopKey(e.KeyCode);
				_IsKeyBeingChanged = false;
				this.Focus();                   //Remove focus from button	
			}
		}

		/// <summary>
		/// Will revert the stop/start key back if the User changes tabs while updating the stop/start key in settings
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void tcWindow_SelectedIndexChanged(object sender, EventArgs e)
		{
			TabPage currentTap = tcWindow.SelectedTab!;

			if (currentTap == tpMain)
			{
				tmrKeyDown.Start();
				if (_IsKeyBeingChanged)
				{
					_IsKeyBeingChanged = false;
					SetStartStopKey(_startStopKey);
				}
			}
			else if (currentTap == tpSettings)
			{
				tmrKeyDown.Stop();              //will otherwise activate when setting the key
				if (_IsClickerActive)
				{
					ChangeActiveState();
				}
			}
		}

		private void ChangeSounds_Click(object sender, EventArgs e)
		{
			//Use an openfiledialog to select a sound file (wav only) and set it as the new sound
		}

		private void ResetSounds_Click(object sender, EventArgs e)
		{
			//Reset one of the sounds with the default sounds that are in the sounds folder
		}
	}
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace A7Stack
{
    enum ERunState
    {
        Idle,
        Running
    }

    public partial class MainForm : Form
    {
        // ancient win api functions that we need
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr childAfter, string className, string windowTitle);
        
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr childAfter, IntPtr className, string windowTitle);

        [DllImport("user32.dll")]
        static extern bool PostMessage(IntPtr hWnd, uint Msg, int wParam, uint lParam);

        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern uint MapVirtualKey(uint uCode, uint uMapType);

        // some constants from win api
        static uint wm_keydown = 0x0100;
        static uint wm_keyup = 0x0101;
        static uint wm_char = 0x0102;

        // state
        private ERunState RState = ERunState.Idle;
        private int CaptureCount = 0;
        private int CaptureCountTarget = 0;

        public MainForm()
        {
            InitializeComponent();
            CStepSize.SelectedIndex = 1;
            CStepDirection.SelectedIndex = 1;
            CProgress.Value = 0;
        }

        private void CGoButton_Click(object sender, EventArgs e)
        {
            switch(RState)
            {
                case ERunState.Idle:
                    ToRunning();
                    break;

                case ERunState.Running:
                    ToIdle();
                    break;
            }
        }

        private void CRunTimer_Tick(object sender, EventArgs e)
        {
            switch(RState)
            {
                case ERunState.Idle:
                    CRunTimer.Stop();
                    break;

                case ERunState.Running:
                    FrameTick();
                    break;
            }
        }

        private void ToIdle()
        {
            RState = ERunState.Idle;
            CRunTimer.Stop();

            CGoButton.Text = "Go";
            CProgress.Value = 0;
            CCycleTime.Enabled = true;
            CStepSize.Enabled = true;
            CStepDirection.Enabled = true;
            CDryRun.Enabled = true;
            CFrames.Enabled = true;
            CSteps.Enabled = true;

            CaptureCount = 0;
            CaptureCountTarget = 0;
        }

        private void ToRunning()
        {
            CGoButton.Text = "Stop";
            CProgress.Value = 0;
            CProgress.Maximum = (int)CFrames.Value;
            CRunTimer.Interval = (int)CCycleTime.Value;
            CCycleTime.Enabled = false;
            CStepSize.Enabled = false;
            CStepDirection.Enabled = false;
            CDryRun.Enabled = false;
            CFrames.Enabled = false;
            CSteps.Enabled = false;

            CaptureCount = 0;
            CaptureCountTarget = (int)CFrames.Value;

            RState = ERunState.Running;
            CRunTimer.Start();
        }

        private void FrameTick()
        {
            // get remote imagine edge window and find the focus button inside it
            IntPtr dialogClass = IntPtr.Zero;
            dialogClass += 0x8002;
            IntPtr hwnd = FindWindowEx(IntPtr.Zero, IntPtr.Zero, dialogClass, "Remote");
            if(hwnd == IntPtr.Zero)
            {
                ToIdle();
                MessageBox.Show(this,  "Unable to find main window, please start image edge remote application.", "B8 Stack", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            hwnd = FindWindowEx(hwnd, IntPtr.Zero, "Button", string.Empty);
            if (hwnd == IntPtr.Zero)
            {
                ToIdle();
                MessageBox.Show(this, "Unable to find control window, this version of imagine edge is not supported.", "B8 Stack", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // send key sequence
            SimulateUserInput(
                hwnd,
                CStepSize.SelectedIndex,
                CStepDirection.SelectedIndex,
                (int)CCycleTime.Value,
                CDryRun.Checked,
                CSteps.Value);

            ++CProgress.Value;
            ++CaptureCount;
            if (CaptureCount == CaptureCountTarget)
                ToIdle();
        }

        private void SimulateUserInput(IntPtr hwnd, int stepSize, int stepDir, int cycleTime, bool dryRun, int steps)
        {
            int keyCode = 0x00;
            if(stepDir == 0)
            {
                switch(stepSize)
                {
                    case 0: keyCode = 0x45; break;
                    case 1: keyCode = 0x57; break;
                    case 2: keyCode = 0x51; break;
                }
            }
            else if(stepDir == 1)
            {
                switch (stepSize)
                {
                    case 0: keyCode = 0x52; break;
                    case 1: keyCode = 0x54; break;
                    case 2: keyCode = 0x59; break;
                }
            }

            if(keyCode != 0)
            {
                for(int i = 0; i < steps; ++i)
                {
                    SendPressSequence(hwnd, keyCode);
                    Thread.Sleep(80); // give the sony some time to do the adjustment
                }

                if (!dryRun)
                {
                    SendPressSequence(hwnd, 0x31);
                }
            }
        }

        private void SendPressSequence(IntPtr hwnd, int keyCode)
        {
            // simulate up, char and down window messages
            uint lParamDown = (0x00000001 | (MapVirtualKey((uint)keyCode, (uint)0) << 16));
            uint lParamUp = (0xC0000001 | (MapVirtualKey((uint)keyCode, (uint)0) << 16));

            PostMessage(hwnd, wm_keydown, keyCode, lParamDown);
            PostMessage(hwnd, wm_char, keyCode, lParamDown);
            PostMessage(hwnd, wm_keyup, keyCode, lParamUp);
        }

        private void CAboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("B8 Stack by binarycamera\nbinarycamera@codecreator.net");
        }
    }
}

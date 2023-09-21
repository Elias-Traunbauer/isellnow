using Gma.System.MouseKeyHook;
using Mouse_Click_Simulator;
using System.Diagnostics;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace isellnow
{
    public partial class Form_isellnow : Form
    {
        private IKeyboardMouseEvents m_GlobalHook;

        public Form_isellnow()
        {
            InitializeComponent();
            m_GlobalHook = Hook.GlobalEvents();

            m_GlobalHook.MouseDownExt += GlobalHookMouseDownExt;
            m_GlobalHook.KeyUp += GlobalHookKeyPress;
        }

        private void GlobalHookKeyPress(object? sender, KeyEventArgs e)
        {
            string key = e.KeyData.ToString();

            // check for hotkeys
            if (key == pauseHotkey && running)
            {
                paused = !paused;
                UpdateUIEnabledStates();
            }

            if (key == endHotkey)
            {
                running = false;
                UpdateUIEnabledStates();
            }
        }

        private void GlobalHookMouseDownExt(object? sender, MouseEventExtArgs e)
        {
            if (!settingUpSellButtons)
            {
                return;
            }

            if (e.Button == MouseButtons.Left)
            {
                sellButtonLocations.Add(new Point(e.X, e.Y));
                if (sellButtonLocations.Count == sellCount)
                {
                    settingUpSellButtons = false;
                    UpdateUIEnabledStates();
                }
            }
        }

        bool settingsCommit;
        bool paused;
        string pauseHotkey = "P";
        bool changingPauseHotkey;
        string endHotkey = "Z";
        bool changingEndHotkey;
        bool running;
        int sellCount = 1;
        bool settingUpSellButtons;
        IntPtr rustWindowHandle = IntPtr.Zero;
        List<Point> sellButtonLocations = new();

        private void UpdateUIEnabledStates()
        {
            labelPaused.Text = "Paused: " + paused.ToString();

            this.Enabled = !settingUpSellButtons;
            if (settingUpSellButtons)
            {
                return;
            }

            // enable all
            btnSetPauseHotkey.Enabled = true;
            btnSetEndHotkey.Enabled = true;
            btnCommitSettings.Enabled = true;
            btnAddSellCount.Enabled = true;
            btnSubtractSellCount.Enabled = true;

            // if changing hotkey, disable all other buttons
            if (changingPauseHotkey)
            {
                btnSetPauseHotkey.Enabled = true;
                btnSetEndHotkey.Enabled = false;
                btnCommitSettings.Enabled = false;
                btnAddSellCount.Enabled = false;
                btnSubtractSellCount.Enabled = false;
            }

            if (changingEndHotkey)
            {
                btnSetPauseHotkey.Enabled = false;
                btnSetEndHotkey.Enabled = true;
                btnCommitSettings.Enabled = false;
                btnAddSellCount.Enabled = false;
                btnSubtractSellCount.Enabled = false;
            }

            if (settingsCommit)
            {
                groupBoxSettings.Enabled = false;
                groupBoxMain.Enabled = true;
                btnCommitSettings.Text = "Edit settings";
            }
            else
            {
                groupBoxSettings.Enabled = true;
                groupBoxMain.Enabled = false;
                btnCommitSettings.Text = "Commit settings";
            }

            if (running)
            {
                groupBoxRunning.Enabled = true;
                groupBoxMain.Enabled = false;
                btnCommitSettings.Enabled = false;
            }
            else
            {
                groupBoxRunning.Enabled = false;
                btnCommitSettings.Enabled = true;
            }
            btnStart.Enabled = rustWindowHandle != IntPtr.Zero && sellButtonLocations.Count != 0;
        }

        private void BtnCommitSettings_Click(object sender, EventArgs e)
        {
            settingsCommit = !settingsCommit;
            UpdateUIEnabledStates();
        }

        private void BtnSetEndHotkey_Click(object sender, EventArgs e)
        {
            changingEndHotkey = true;
            UpdateUIEnabledStates();
        }

        private void ButtonSetPauseHotkey_Click(object sender, EventArgs e)
        {
            changingPauseHotkey = true;
            UpdateUIEnabledStates();
        }

        private void BtnSubtractSellCount_Click(object sender, EventArgs e)
        {
            if (sellCount > 1)
            {
                sellCount--;
            }
            lblSellPointCount.Text = sellCount.ToString();
        }

        private void BtnAddSellCount_Click(object sender, EventArgs e)
        {
            if (sellCount < 5)
            {
                sellCount++;
            }
            lblSellPointCount.Text = sellCount.ToString();
        }

        private void ChangePauseHotkey(object sender, KeyEventArgs e)
        {
            if (!changingPauseHotkey)
            {
                return;
            }

            string key = e.KeyData.ToString();
            if (endHotkey != key)
            {
                pauseHotkey = key;
                btnSetPauseHotkey.Text = key;
            }
            else
            {
                MessageBox.Show("Hotkey already taken.", "isellnow - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            pauseHotkey = key;
            btnSetPauseHotkey.Text = key;
            changingPauseHotkey = false;
            UpdateUIEnabledStates();
        }

        private void ChangeEndHotkey(object sender, KeyEventArgs e)
        {
            if (!changingEndHotkey)
            {
                return;
            }

            string key = e.KeyData.ToString();
            if (pauseHotkey != key)
            {
                endHotkey = key;
                btnSetEndHotkey.Text = key;
            }
            else
            {
                MessageBox.Show("Hotkey already taken.", "isellnow - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            changingEndHotkey = false;
            UpdateUIEnabledStates();
        }

        private void BtnSetupSellButtons_Click(object sender, EventArgs e)
        {
            settingUpSellButtons = true;
            sellButtonLocations.Clear();
            UpdateUIEnabledStates();
        }

        private void DetectRustAndGetWindowHandle()
        {
            var processes = Process.GetProcesses();

            var rustProcess = processes.Where(x => x.ProcessName == "RustClient").FirstOrDefault();
            if (rustProcess == null)
            {
                MessageBox.Show("Rust process not found. If rust is running, contact developer.", "isellnow - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            rustProcess.Refresh();

            if (rustProcess.MainWindowHandle == IntPtr.Zero)
            {
                MessageBox.Show("Windowhandle was zero. Rust process was found. If rust is running, contact developer.", "isellnow - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            rustWindowHandle = rustProcess.MainWindowHandle;
            lblRustProcess.Text = "Rust process: " + rustProcess.ProcessName + "\nid=" + rustProcess.Id.ToString() + "\n"
                + "" + rustProcess.Threads.Count + " Threads";
        }

        private void ButtonRegisterRust(object sender, EventArgs e)
        {
            DetectRustAndGetWindowHandle();
            UpdateUIEnabledStates();
        }

        private void Form_isellnow_Load(object sender, EventArgs e)
        {
            UpdateUIEnabledStates();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            running = true;
            paused = false;
            UpdateUIEnabledStates();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            running = false;
            paused = false;
            UpdateUIEnabledStates();
        }
    }
}
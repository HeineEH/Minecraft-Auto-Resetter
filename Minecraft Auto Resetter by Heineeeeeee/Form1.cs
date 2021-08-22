using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using gma.System.Windows;
using System.Threading;
using WindowsInput;
using WindowsInput.Native;



namespace Minecraft_Auto_Resetter_by_Heineeeeeee
{
    

    public partial class Form1 : Form
    {
        public int delay = 30;
        bool busy = false;
        UserActivityHook keyboardHook;
        Process mcProcess = null;
        Keys createHotkey;
        Keys exitHotkey;
        public int attemptsAmount;
        renameMethod selectedRenameMethod;
        string customName;
        bool running = true;
        InputSimulator inputSim = new InputSimulator();


        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out uint ProcessId);

        enum renameMethod
        {
            none = 0,
            custom = 1,
            attempts = 2
        }

        enum sendInputType
        {
            normal,
            modified,
            text,
            sleep
        }

        public enum Hotkey
        {
            Create = 1,
            Exit = 2
        }


        void saveSettings()
        {
            Properties.Settings.Default.delay = delay;
            Properties.Settings.Default.customName = customName;
            Properties.Settings.Default.renameMethod = Convert.ToInt32(selectedRenameMethod);
            Properties.Settings.Default.createHotkey = createHotkey;
            Properties.Settings.Default.exitHotkey = exitHotkey;
            Properties.Settings.Default.attemptsAmount = attemptsAmount;
            Properties.Settings.Default.Save();
        }
        void getSettings()
        {
            delay = Properties.Settings.Default.delay;
            customName = Properties.Settings.Default.customName;
            selectedRenameMethod = (renameMethod)Properties.Settings.Default.renameMethod;
            createHotkey = Properties.Settings.Default.createHotkey;
            exitHotkey = Properties.Settings.Default.exitHotkey;
            attemptsAmount = Properties.Settings.Default.attemptsAmount;
        }

        public Form1()
        {
            getSettings();
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getMcProcess();
        }


        void getMcProcess()
        {
            Process[] processes = Process.GetProcesses();
            foreach (Process p in processes)
            {
                if ((p.ProcessName == "javaw" || p.ProcessName == "java") && p.MainWindowTitle.ToLower().Contains("minecraft"))
                {
                    mcProcess = p;
                    mcProcessText.Text = mcProcess.MainWindowTitle;
                    return;
                }
            }
            mcProcessText.Text = "No Minecraft process selected...";
            mcProcess = null;
            return;
        }


        private void Form1_Load(object sender, EventArgs e)
        {


            trayIcon_exit.Click += trayIconExit_Click;
            trayIcon_open.Click += trayIconOpen_Click;

            getMcProcess();
            delayBox.Text = delay.ToString();

            attemptsAmountBox.Text = Properties.Settings.Default.attemptsAmount.ToString();
            if (createHotkey != Keys.None)
            {
                createHotkeyBox.PlaceholderText = createHotkey.ToString();
            }
            else
            {
                createHotkeyBox.PlaceholderText = "<Click to set hotkey>";
            }

            if (exitHotkey != Keys.None)
            {
                exitHotkeyBox.PlaceholderText = exitHotkey.ToString();
            }
            else
            {
                exitHotkeyBox.PlaceholderText = "<Click to set hotkey>";
            }

            attemptsAmountBox.Enabled = false;

            if (selectedRenameMethod == renameMethod.none)
            {
                radioNoName.Checked = true;
            } else if (selectedRenameMethod == renameMethod.custom)
            {
                radioCustomName.Checked = true;
            } else if (selectedRenameMethod == renameMethod.attempts)
            {
                radioAttemptAmountName.Checked = true;
            }
            customNameBox.Text = customName;

            initHotkeys();


        }


        private void createHotkeyBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;

            if (e.KeyCode == Keys.Escape) {
                createHotkey = Keys.None;
                createHotkeyBox.PlaceholderText = "<Click to set hotkey>";
            }
            else { 
                
                createHotkey = e.KeyCode;
                createHotkeyBox.PlaceholderText = e.KeyCode.ToString();
            }
            label1.Focus();
         

        }

        private void exitHotkeyBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            if (e.KeyCode == Keys.Escape)
            {
                exitHotkey = Keys.None;
                exitHotkeyBox.PlaceholderText = "<Click to set hotkey>";

            }
            else
            {
                exitHotkey = e.KeyCode;
                exitHotkeyBox.PlaceholderText = e.KeyCode.ToString();
            }
            label1.Focus();

        }

        private void clearHotkeyBox(object sender, EventArgs e)
        {
            createHotkeyBox.Text = "";
        }

        
        void initHotkeys()
        {
            keyboardHook = new UserActivityHook();
            keyboardHook.KeyUp += new KeyEventHandler(keyboardHook_KeyPress);
        }

        private void form_Closed(object sender, FormClosedEventArgs e)
        {
            saveSettings();
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                e.Cancel = true;
                Hide();
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void changeAttemptsButton_Click(object sender, EventArgs e)
        {
            attemptsAmountBox.Enabled = true;
            attemptsAmountBox.Focus();
            attemptsAmountBox.SelectAll();
        }

        private void attemptsAmountBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == (char)13))
            {
                e.Handled = true;
            } if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                attemptsAmountBox_Leave(new object(), new EventArgs());
            }
            

        }

        private void attemptsAmountBox_Leave(object sender, EventArgs e)
        {
            attemptsAmount = Convert.ToInt32(attemptsAmountBox.Text);
            label1.Focus();
            attemptsAmountBox.Enabled = false;
        }

        private void radioCustomName_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCustomName.Checked)
            {
                selectedRenameMethod = renameMethod.custom;
                customNameBox.Visible = true;
            }
            else { 
            customNameBox.Visible = false;
            }


        }

        private void radioNoName_CheckedChanged(object sender, EventArgs e)
        {
            if (radioNoName.Checked == true)
            {
                selectedRenameMethod = renameMethod.none;
            }
        }

        private void radioAttemptAmountName_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAttemptAmountName.Checked == true)
            {
                selectedRenameMethod = renameMethod.attempts;
            }
        }

        void keyboardHook_KeyPress(object sender, KeyEventArgs e)
        {
            if (running == false)
            {
                return;
            }
            

            if (busy)
            {
                return;
            }

            if (e.KeyCode != Keys.None)
            {
                if (e.KeyCode == createHotkey)
                {
                    hotkeyPressed(sender, e, Hotkey.Create);
                } 
                if (e.KeyCode == exitHotkey)
                {
                    hotkeyPressed(sender, e, Hotkey.Exit);
                }
            }
        }

        void hotkeyPressed(object sender, KeyEventArgs e, Hotkey hotkey)
        {
            getMcProcess();
            uint pid;
            GetWindowThreadProcessId(GetForegroundWindow(), out pid);
            Process p = Process.GetProcessById((int)pid);
            if (mcProcess != null)
            {
                if (mcProcess.Id == p.Id)
                {
                    e.Handled = true;
                    if (hotkey == Hotkey.Create && !mcProcess.MainWindowTitle.Contains("player")) { 
                    createWorld();
                    }
                    if (hotkey == Hotkey.Exit && mcProcess.MainWindowTitle.Contains("player"))
                    {
                        exitWorld();
                    }

                    return;
                }
            }


        }

        private void customNameBox_TextChanged(object sender, EventArgs e)
        {
            customName = customNameBox.Text;
        }

        void createWorld()
        {
            attemptsAmount++;
            attemptsAmountBox.Text = attemptsAmount.ToString();
            Properties.Settings.Default.attemptsAmount = attemptsAmount;
            Properties.Settings.Default.Save();


            List<Object[]> keys = new List<object[]>();


            keys.Add(new object[] { sendInputType.normal, VirtualKeyCode.TAB });
            keys.Add(new object[] { sendInputType.normal, VirtualKeyCode.RETURN });

            keys.Add(new object[] { sendInputType.normal, VirtualKeyCode.TAB });
            keys.Add(new object[] { sendInputType.normal, VirtualKeyCode.TAB });
            keys.Add(new object[] { sendInputType.normal, VirtualKeyCode.TAB });
            keys.Add(new object[] { sendInputType.normal, VirtualKeyCode.RETURN });

            if (selectedRenameMethod != renameMethod.none) { 
                keys.Add(new object[] {sendInputType.modified, new VirtualKeyCode[] { VirtualKeyCode.CONTROL, VirtualKeyCode.VK_A} });
                if (selectedRenameMethod == renameMethod.attempts)
                {
                    keys.Add(new object[] { sendInputType.text, attemptsAmount.ToString() });
                } else if(selectedRenameMethod == renameMethod.custom)
                {
                    keys.Add(new object[] { sendInputType.text, customName});
                }
            }

            keys.Add(new object[] { sendInputType.normal, VirtualKeyCode.TAB });
            keys.Add(new object[] { sendInputType.normal, VirtualKeyCode.TAB });
            keys.Add(new object[] { sendInputType.normal, VirtualKeyCode.RETURN });
            keys.Add(new object[] { sendInputType.normal, VirtualKeyCode.RETURN });
            keys.Add(new object[] { sendInputType.normal, VirtualKeyCode.RETURN });
            keys.Add(new object[] { sendInputType.normal, VirtualKeyCode.TAB });
            keys.Add(new object[] { sendInputType.normal, VirtualKeyCode.TAB });
            keys.Add(new object[] { sendInputType.normal, VirtualKeyCode.TAB });
            keys.Add(new object[] { sendInputType.normal, VirtualKeyCode.TAB });
            keys.Add(new object[] { sendInputType.normal, VirtualKeyCode.TAB });
            keys.Add(new object[] { sendInputType.normal, VirtualKeyCode.RETURN });


            

            sendKeyStrokes(keys);
        }

        void exitWorld()
        {
            List<Object[]> keys = new List<object[]>();
            keys.Add(new object[] { sendInputType.normal, VirtualKeyCode.ESCAPE });
            keys.Add(new object[] { sendInputType.modified, new VirtualKeyCode[] { VirtualKeyCode.SHIFT, VirtualKeyCode.TAB } });
            keys.Add(new object[] { sendInputType.normal, VirtualKeyCode.RETURN });

            sendKeyStrokes(keys);
        }

        void updateButtons()
        {
            label1.Focus();
            if (running)
            {
                
                startButton.Enabled = false;
                stopButton.Enabled = true;

            }
            
            else
            {
                startButton.Enabled = true;
                stopButton.Enabled = false;
            }
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            running = true;
            updateButtons();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            running = false;
            updateButtons();
        }

        void sendKeyStrokes(List<Object[]>  keys) {
            busy = true;
            foreach (var key in keys)
            {

                if ((sendInputType)key[0] == sendInputType.normal)
                {
                    inputSim.Keyboard.KeyPress((VirtualKeyCode)key[1]);
                }
                else if ((sendInputType)key[0] == sendInputType.modified)
                {
                    VirtualKeyCode localKey = ((VirtualKeyCode[])key[1])[1];
                    VirtualKeyCode localModifierKey = ((VirtualKeyCode[])key[1])[0];

                    inputSim.Keyboard.ModifiedKeyStroke(localModifierKey, localKey);
                }
                else if ((sendInputType)key[0] == sendInputType.text)
                {
                    inputSim.Keyboard.TextEntry((string)key[1]);
                }
                else if ((sendInputType)key[0] == sendInputType.sleep)
                {
                    Thread.Sleep((int)key[1]);
                }
                Thread.Sleep(delay);
            }

            busy = false;
        }


        private void delayBoxPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == (char)13))
            {
                
                e.Handled = true;
            } else
            {
                delay = Convert.ToInt32(delayBox.Text);
            }
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                label1.Focus();
            }
        }

        private void TrayIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) { return; }
            Show();
            this.WindowState = FormWindowState.Normal;
        }


        private void trayIconOpen_Click(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void trayIconExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.Hide();

        }
    }

}

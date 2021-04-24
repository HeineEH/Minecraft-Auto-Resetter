
namespace Minecraft_Auto_Resetter_by_Heineeeeeee
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mcProcessText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hotkeyLabel = new System.Windows.Forms.Label();
            this.createHotkeyBox = new System.Windows.Forms.TextBox();
            this.exitHotkeyBox = new System.Windows.Forms.TextBox();
            this.note1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.changeAttemptsButton = new System.Windows.Forms.Button();
            this.attemptsAmountBox = new System.Windows.Forms.TextBox();
            this.radioNoName = new System.Windows.Forms.RadioButton();
            this.radioCustomName = new System.Windows.Forms.RadioButton();
            this.radioAttemptAmountName = new System.Windows.Forms.RadioButton();
            this.customNameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.delayBox = new System.Windows.Forms.TextBox();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayIconContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trayIcon_open = new System.Windows.Forms.ToolStripMenuItem();
            this.trayIcon_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.TrayIconContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mcProcessText
            // 
            this.mcProcessText.Enabled = false;
            this.mcProcessText.Location = new System.Drawing.Point(15, 68);
            this.mcProcessText.Name = "mcProcessText";
            this.mcProcessText.ReadOnly = true;
            this.mcProcessText.Size = new System.Drawing.Size(259, 23);
            this.mcProcessText.TabIndex = 0;
            this.mcProcessText.Text = "No Minecraft process selected...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Reload";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Minecraft", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(13, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(359, 18);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Minecraft Auto Resetter by Heineeeeeee";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(12, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 4);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Press reload to search for Minecraft process";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(214, 215);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(94, 215);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(113, 23);
            this.textBox3.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Create world";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Exit world";
            // 
            // hotkeyLabel
            // 
            this.hotkeyLabel.AutoSize = true;
            this.hotkeyLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hotkeyLabel.Location = new System.Drawing.Point(123, 104);
            this.hotkeyLabel.Name = "hotkeyLabel";
            this.hotkeyLabel.Size = new System.Drawing.Size(154, 20);
            this.hotkeyLabel.TabIndex = 12;
            this.hotkeyLabel.Text = "Assign keys to macros";
            this.hotkeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createHotkeyBox
            // 
            this.createHotkeyBox.AcceptsReturn = true;
            this.createHotkeyBox.AcceptsTab = true;
            this.createHotkeyBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.createHotkeyBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createHotkeyBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.createHotkeyBox.Location = new System.Drawing.Point(161, 128);
            this.createHotkeyBox.Multiline = true;
            this.createHotkeyBox.Name = "createHotkeyBox";
            this.createHotkeyBox.PlaceholderText = "<Click to set hotkey>";
            this.createHotkeyBox.Size = new System.Drawing.Size(158, 23);
            this.createHotkeyBox.TabIndex = 13;
            this.createHotkeyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.createHotkeyBox.Enter += new System.EventHandler(this.clearHotkeyBox);
            this.createHotkeyBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.createHotkeyBox_KeyDown);
            this.createHotkeyBox.Leave += new System.EventHandler(this.clearHotkeyBox);
            // 
            // exitHotkeyBox
            // 
            this.exitHotkeyBox.AcceptsReturn = true;
            this.exitHotkeyBox.AcceptsTab = true;
            this.exitHotkeyBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.exitHotkeyBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitHotkeyBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.exitHotkeyBox.Location = new System.Drawing.Point(161, 153);
            this.exitHotkeyBox.Multiline = true;
            this.exitHotkeyBox.Name = "exitHotkeyBox";
            this.exitHotkeyBox.PlaceholderText = "<Click to set hotkey>";
            this.exitHotkeyBox.Size = new System.Drawing.Size(158, 23);
            this.exitHotkeyBox.TabIndex = 14;
            this.exitHotkeyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.exitHotkeyBox.Enter += new System.EventHandler(this.clearHotkeyBox);
            this.exitHotkeyBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.exitHotkeyBox_KeyDown);
            this.exitHotkeyBox.Leave += new System.EventHandler(this.clearHotkeyBox);
            // 
            // note1
            // 
            this.note1.AutoSize = true;
            this.note1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.note1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.note1.Location = new System.Drawing.Point(81, 179);
            this.note1.Name = "note1";
            this.note1.Size = new System.Drawing.Size(257, 13);
            this.note1.TabIndex = 15;
            this.note1.Text = "The two macros can be assigned to the same key";
            this.note1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(123, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Attempts amount:";
            // 
            // changeAttemptsButton
            // 
            this.changeAttemptsButton.Location = new System.Drawing.Point(223, 235);
            this.changeAttemptsButton.Name = "changeAttemptsButton";
            this.changeAttemptsButton.Size = new System.Drawing.Size(60, 25);
            this.changeAttemptsButton.TabIndex = 18;
            this.changeAttemptsButton.Text = "Change";
            this.changeAttemptsButton.UseVisualStyleBackColor = true;
            this.changeAttemptsButton.Click += new System.EventHandler(this.changeAttemptsButton_Click);
            // 
            // attemptsAmountBox
            // 
            this.attemptsAmountBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.attemptsAmountBox.Location = new System.Drawing.Point(117, 235);
            this.attemptsAmountBox.Name = "attemptsAmountBox";
            this.attemptsAmountBox.Size = new System.Drawing.Size(100, 25);
            this.attemptsAmountBox.TabIndex = 20;
            this.attemptsAmountBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.attemptsAmountBox_KeyPress);
            this.attemptsAmountBox.Leave += new System.EventHandler(this.attemptsAmountBox_Leave);
            this.attemptsAmountBox.MouseCaptureChanged += new System.EventHandler(this.attemptsAmountBox_Leave);
            // 
            // radioNoName
            // 
            this.radioNoName.AutoSize = true;
            this.radioNoName.Location = new System.Drawing.Point(118, 306);
            this.radioNoName.Name = "radioNoName";
            this.radioNoName.Size = new System.Drawing.Size(97, 19);
            this.radioNoName.TabIndex = 21;
            this.radioNoName.TabStop = true;
            this.radioNoName.Text = "Don\'t rename";
            this.radioNoName.UseVisualStyleBackColor = true;
            this.radioNoName.CheckedChanged += new System.EventHandler(this.radioNoName_CheckedChanged);
            // 
            // radioCustomName
            // 
            this.radioCustomName.AutoSize = true;
            this.radioCustomName.Location = new System.Drawing.Point(118, 332);
            this.radioCustomName.Name = "radioCustomName";
            this.radioCustomName.Size = new System.Drawing.Size(67, 19);
            this.radioCustomName.TabIndex = 22;
            this.radioCustomName.TabStop = true;
            this.radioCustomName.Text = "Custom";
            this.radioCustomName.UseVisualStyleBackColor = true;
            this.radioCustomName.CheckedChanged += new System.EventHandler(this.radioCustomName_CheckedChanged);
            // 
            // radioAttemptAmountName
            // 
            this.radioAttemptAmountName.AutoSize = true;
            this.radioAttemptAmountName.Location = new System.Drawing.Point(118, 358);
            this.radioAttemptAmountName.Name = "radioAttemptAmountName";
            this.radioAttemptAmountName.Size = new System.Drawing.Size(114, 19);
            this.radioAttemptAmountName.TabIndex = 23;
            this.radioAttemptAmountName.TabStop = true;
            this.radioAttemptAmountName.Text = "Attempt amount";
            this.radioAttemptAmountName.UseVisualStyleBackColor = true;
            this.radioAttemptAmountName.CheckedChanged += new System.EventHandler(this.radioAttemptAmountName_CheckedChanged);
            // 
            // customNameBox
            // 
            this.customNameBox.Location = new System.Drawing.Point(191, 331);
            this.customNameBox.Name = "customNameBox";
            this.customNameBox.Size = new System.Drawing.Size(100, 23);
            this.customNameBox.TabIndex = 24;
            this.customNameBox.Visible = false;
            this.customNameBox.TextChanged += new System.EventHandler(this.customNameBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(108, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Choose a rename method:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startButton.Location = new System.Drawing.Point(12, 436);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(176, 53);
            this.startButton.TabIndex = 26;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stopButton.Location = new System.Drawing.Point(196, 436);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(176, 53);
            this.stopButton.TabIndex = 27;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(116, 395);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Delay (ms)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // delayBox
            // 
            this.delayBox.Location = new System.Drawing.Point(191, 394);
            this.delayBox.Name = "delayBox";
            this.delayBox.Size = new System.Drawing.Size(100, 23);
            this.delayBox.TabIndex = 30;
            this.delayBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.delayBoxPress);
            // 
            // TrayIcon
            // 
            this.TrayIcon.ContextMenuStrip = this.TrayIconContextMenu;
            this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Text = "Auto Resetter by Heineeeeeee";
            this.TrayIcon.Visible = true;
            this.TrayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseClick);
            // 
            // TrayIconContextMenu
            // 
            this.TrayIconContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trayIcon_open,
            this.trayIcon_exit});
            this.TrayIconContextMenu.Name = "TrayIconContextMenu";
            this.TrayIconContextMenu.Size = new System.Drawing.Size(104, 48);
            // 
            // trayIcon_open
            // 
            this.trayIcon_open.Name = "trayIcon_open";
            this.trayIcon_open.Size = new System.Drawing.Size(103, 22);
            this.trayIcon_open.Text = "Open";
            // 
            // trayIcon_exit
            // 
            this.trayIcon_exit.Name = "trayIcon_exit";
            this.trayIcon_exit.Size = new System.Drawing.Size(103, 22);
            this.trayIcon_exit.Text = "Exit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 501);
            this.Controls.Add(this.delayBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.customNameBox);
            this.Controls.Add(this.radioAttemptAmountName);
            this.Controls.Add(this.radioCustomName);
            this.Controls.Add(this.radioNoName);
            this.Controls.Add(this.attemptsAmountBox);
            this.Controls.Add(this.changeAttemptsButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.note1);
            this.Controls.Add(this.exitHotkeyBox);
            this.Controls.Add(this.createHotkeyBox);
            this.Controls.Add(this.hotkeyLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mcProcessText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 540);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 540);
            this.Name = "Form1";
            this.Text = "Minecraft Auto Resetter by Heineeeeeee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_Closed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.TrayIconContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mcProcessText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label hotkeyLabel;
        private System.Windows.Forms.TextBox createHotkeyBox;
        private System.Windows.Forms.TextBox exitHotkeyBox;
        private System.Windows.Forms.Label note1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button changeAttemptsButton;
        private System.Windows.Forms.TextBox attemptsAmountBox;
        private System.Windows.Forms.RadioButton radioNoName;
        private System.Windows.Forms.RadioButton radioCustomName;
        private System.Windows.Forms.RadioButton radioAttemptAmountName;
        private System.Windows.Forms.TextBox customNameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox delayBox;
        private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.ContextMenuStrip TrayIconContextMenu;
        private System.Windows.Forms.ToolStripMenuItem trayIcon_exit;
        private System.Windows.Forms.ToolStripMenuItem trayIcon_open;
    }
}


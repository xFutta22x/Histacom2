﻿namespace TimeHACK
{
    partial class TitleScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TitleScreen));
            this.gameversion = new System.Windows.Forms.Label();
            this.vm_mode = new System.Windows.Forms.CheckBox();
            this.vmModeTimer = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.VM_Height = new System.Windows.Forms.NumericUpDown();
            this.VM_Width = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.startbutton = new System.Windows.Forms.PictureBox();
            this.program = new System.Windows.Forms.Panel();
            this.programContent = new System.Windows.Forms.Panel();
            this.programtopbar = new System.Windows.Forms.Panel();
            this.maximizebutton = new System.Windows.Forms.PictureBox();
            this.minimizebutton = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.closebutton = new System.Windows.Forms.PictureBox();
            this.toprightcorner = new System.Windows.Forms.Panel();
            this.bottomrightcorner = new System.Windows.Forms.Panel();
            this.bottomleftcorner = new System.Windows.Forms.Panel();
            this.topleftcorner = new System.Windows.Forms.Panel();
            this.left = new System.Windows.Forms.Panel();
            this.bottom = new System.Windows.Forms.Panel();
            this.right = new System.Windows.Forms.Panel();
            this.top = new System.Windows.Forms.Panel();
            this.startmenu = new System.Windows.Forms.Panel();
            this.startmenuitems = new System.Windows.Forms.MenuStrip();
            this.ProgramsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DocumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ControlPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TaskbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShutdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ossidestartmenu = new System.Windows.Forms.Panel();
            this.osimage = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VM_Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VM_Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startbutton)).BeginInit();
            this.program.SuspendLayout();
            this.programContent.SuspendLayout();
            this.programtopbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximizebutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizebutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closebutton)).BeginInit();
            this.startmenu.SuspendLayout();
            this.startmenuitems.SuspendLayout();
            this.ossidestartmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.osimage)).BeginInit();
            this.SuspendLayout();
            // 
            // gameversion
            // 
            this.gameversion.AutoSize = true;
            this.gameversion.BackColor = System.Drawing.Color.Transparent;
            this.gameversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameversion.Location = new System.Drawing.Point(25, 8);
            this.gameversion.Name = "gameversion";
            this.gameversion.Size = new System.Drawing.Size(78, 13);
            this.gameversion.TabIndex = 0;
            this.gameversion.Text = "gameversion";
            this.gameversion.Click += new System.EventHandler(this.startbutton_Click);
            this.gameversion.MouseLeave += new System.EventHandler(this.gameversion_MouseLeave);
            this.gameversion.MouseHover += new System.EventHandler(this.gameversion_MouseHover);
            // 
            // vm_mode
            // 
            this.vm_mode.AutoSize = true;
            this.vm_mode.BackColor = System.Drawing.Color.Transparent;
            this.vm_mode.ForeColor = System.Drawing.Color.Black;
            this.vm_mode.Location = new System.Drawing.Point(712, 7);
            this.vm_mode.Name = "vm_mode";
            this.vm_mode.Size = new System.Drawing.Size(72, 17);
            this.vm_mode.TabIndex = 4;
            this.vm_mode.Text = "VM Mode";
            this.vm_mode.UseVisualStyleBackColor = false;
            // 
            // vmModeTimer
            // 
            this.vmModeTimer.Tick += new System.EventHandler(this.vmModeTimer_Tick);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.VM_Height);
            this.panel2.Controls.Add(this.VM_Width);
            this.panel2.Controls.Add(this.vm_mode);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.gameversion);
            this.panel2.Controls.Add(this.startbutton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 546);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(792, 28);
            this.panel2.TabIndex = 10;
            // 
            // VM_Height
            // 
            this.VM_Height.Location = new System.Drawing.Point(658, 5);
            this.VM_Height.Maximum = new decimal(new int[] {
            2160,
            0,
            0,
            0});
            this.VM_Height.Minimum = new decimal(new int[] {
            480,
            0,
            0,
            0});
            this.VM_Height.Name = "VM_Height";
            this.VM_Height.Size = new System.Drawing.Size(50, 20);
            this.VM_Height.TabIndex = 15;
            this.VM_Height.Value = new decimal(new int[] {
            480,
            0,
            0,
            0});
            // 
            // VM_Width
            // 
            this.VM_Width.Location = new System.Drawing.Point(605, 5);
            this.VM_Width.Maximum = new decimal(new int[] {
            3840,
            0,
            0,
            0});
            this.VM_Width.Minimum = new decimal(new int[] {
            640,
            0,
            0,
            0});
            this.VM_Width.Name = "VM_Width";
            this.VM_Width.Size = new System.Drawing.Size(50, 20);
            this.VM_Width.TabIndex = 14;
            this.VM_Width.Value = new decimal(new int[] {
            640,
            0,
            0,
            0});
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(603, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 28);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // startbutton
            // 
            this.startbutton.Image = ((System.Drawing.Image)(resources.GetObject("startbutton.Image")));
            this.startbutton.Location = new System.Drawing.Point(2, 4);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(279, 22);
            this.startbutton.TabIndex = 12;
            this.startbutton.TabStop = false;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // program
            // 
            this.program.BackColor = System.Drawing.Color.Silver;
            this.program.Controls.Add(this.programContent);
            this.program.Controls.Add(this.programtopbar);
            this.program.Controls.Add(this.toprightcorner);
            this.program.Controls.Add(this.bottomrightcorner);
            this.program.Controls.Add(this.bottomleftcorner);
            this.program.Controls.Add(this.topleftcorner);
            this.program.Controls.Add(this.left);
            this.program.Controls.Add(this.bottom);
            this.program.Controls.Add(this.right);
            this.program.Controls.Add(this.top);
            this.program.Dock = System.Windows.Forms.DockStyle.Fill;
            this.program.Location = new System.Drawing.Point(0, 0);
            this.program.Name = "program";
            this.program.Size = new System.Drawing.Size(800, 600);
            this.program.TabIndex = 11;
            // 
            // programContent
            // 
            this.programContent.BackColor = System.Drawing.Color.Teal;
            this.programContent.Controls.Add(this.startmenu);
            this.programContent.Controls.Add(this.panel2);
            this.programContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.programContent.Location = new System.Drawing.Point(4, 22);
            this.programContent.Name = "programContent";
            this.programContent.Size = new System.Drawing.Size(792, 574);
            this.programContent.TabIndex = 9;
            // 
            // programtopbar
            // 
            this.programtopbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(170)))));
            this.programtopbar.Controls.Add(this.maximizebutton);
            this.programtopbar.Controls.Add(this.minimizebutton);
            this.programtopbar.Controls.Add(this.Title);
            this.programtopbar.Controls.Add(this.closebutton);
            this.programtopbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.programtopbar.Location = new System.Drawing.Point(4, 4);
            this.programtopbar.Name = "programtopbar";
            this.programtopbar.Size = new System.Drawing.Size(792, 18);
            this.programtopbar.TabIndex = 0;
            this.programtopbar.Tag = "";
            // 
            // maximizebutton
            // 
            this.maximizebutton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.maximizebutton.Image = ((System.Drawing.Image)(resources.GetObject("maximizebutton.Image")));
            this.maximizebutton.Location = new System.Drawing.Point(757, 2);
            this.maximizebutton.Name = "maximizebutton";
            this.maximizebutton.Size = new System.Drawing.Size(16, 14);
            this.maximizebutton.TabIndex = 6;
            this.maximizebutton.TabStop = false;
            // 
            // minimizebutton
            // 
            this.minimizebutton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.minimizebutton.Image = ((System.Drawing.Image)(resources.GetObject("minimizebutton.Image")));
            this.minimizebutton.Location = new System.Drawing.Point(741, 2);
            this.minimizebutton.Name = "minimizebutton";
            this.minimizebutton.Size = new System.Drawing.Size(16, 14);
            this.minimizebutton.TabIndex = 5;
            this.minimizebutton.TabStop = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(2, 1);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(124, 13);
            this.Title.TabIndex = 3;
            this.Title.Text = "TimeHACK Launcher";
            // 
            // closebutton
            // 
            this.closebutton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.closebutton.Image = ((System.Drawing.Image)(resources.GetObject("closebutton.Image")));
            this.closebutton.Location = new System.Drawing.Point(775, 2);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(16, 14);
            this.closebutton.TabIndex = 4;
            this.closebutton.TabStop = false;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click_1);
            // 
            // toprightcorner
            // 
            this.toprightcorner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toprightcorner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toprightcorner.BackgroundImage")));
            this.toprightcorner.Location = new System.Drawing.Point(796, 0);
            this.toprightcorner.Name = "toprightcorner";
            this.toprightcorner.Size = new System.Drawing.Size(4, 4);
            this.toprightcorner.TabIndex = 6;
            // 
            // bottomrightcorner
            // 
            this.bottomrightcorner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bottomrightcorner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bottomrightcorner.BackgroundImage")));
            this.bottomrightcorner.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.bottomrightcorner.Location = new System.Drawing.Point(796, 596);
            this.bottomrightcorner.Name = "bottomrightcorner";
            this.bottomrightcorner.Size = new System.Drawing.Size(4, 4);
            this.bottomrightcorner.TabIndex = 4;
            // 
            // bottomleftcorner
            // 
            this.bottomleftcorner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bottomleftcorner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bottomleftcorner.BackgroundImage")));
            this.bottomleftcorner.Location = new System.Drawing.Point(0, 596);
            this.bottomleftcorner.Name = "bottomleftcorner";
            this.bottomleftcorner.Size = new System.Drawing.Size(4, 4);
            this.bottomleftcorner.TabIndex = 2;
            // 
            // topleftcorner
            // 
            this.topleftcorner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("topleftcorner.BackgroundImage")));
            this.topleftcorner.Location = new System.Drawing.Point(0, 0);
            this.topleftcorner.Name = "topleftcorner";
            this.topleftcorner.Size = new System.Drawing.Size(4, 4);
            this.topleftcorner.TabIndex = 1;
            // 
            // left
            // 
            this.left.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("left.BackgroundImage")));
            this.left.Dock = System.Windows.Forms.DockStyle.Left;
            this.left.Location = new System.Drawing.Point(0, 4);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(4, 592);
            this.left.TabIndex = 3;
            // 
            // bottom
            // 
            this.bottom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bottom.BackgroundImage")));
            this.bottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bottom.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottom.Location = new System.Drawing.Point(0, 596);
            this.bottom.Name = "bottom";
            this.bottom.Size = new System.Drawing.Size(796, 4);
            this.bottom.TabIndex = 5;
            // 
            // right
            // 
            this.right.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("right.BackgroundImage")));
            this.right.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.right.Dock = System.Windows.Forms.DockStyle.Right;
            this.right.Location = new System.Drawing.Point(796, 4);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(4, 596);
            this.right.TabIndex = 7;
            // 
            // top
            // 
            this.top.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("top.BackgroundImage")));
            this.top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.top.Dock = System.Windows.Forms.DockStyle.Top;
            this.top.Location = new System.Drawing.Point(0, 0);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(800, 4);
            this.top.TabIndex = 8;
            // 
            // startmenu
            // 
            this.startmenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.startmenu.BackColor = System.Drawing.Color.Silver;
            this.startmenu.Controls.Add(this.startmenuitems);
            this.startmenu.Controls.Add(this.ossidestartmenu);
            this.startmenu.Location = new System.Drawing.Point(0, 257);
            this.startmenu.Name = "startmenu";
            this.startmenu.Size = new System.Drawing.Size(174, 290);
            this.startmenu.TabIndex = 11;
            // 
            // startmenuitems
            // 
            this.startmenuitems.BackColor = System.Drawing.Color.Silver;
            this.startmenuitems.Dock = System.Windows.Forms.DockStyle.None;
            this.startmenuitems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DocumentsToolStripMenuItem,
            this.ProgramsToolStripMenuItem,
            this.SettingsToolStripMenuItem,
            this.HelpToolStripMenuItem,
            this.ShutdownToolStripMenuItem});
            this.startmenuitems.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.startmenuitems.Location = new System.Drawing.Point(28, 2);
            this.startmenuitems.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.startmenuitems.Name = "startmenuitems";
            this.startmenuitems.Padding = new System.Windows.Forms.Padding(6, 2, 0, 0);
            this.startmenuitems.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.startmenuitems.Size = new System.Drawing.Size(145, 184);
            this.startmenuitems.TabIndex = 0;
            this.startmenuitems.Text = "StartMenu";
            // 
            // ProgramsToolStripMenuItem
            // 
            this.ProgramsToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.ProgramsToolStripMenuItem.BackgroundImage = global::TimeHACK.Properties.Resources.sliversilver;
            this.ProgramsToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ProgramsToolStripMenuItem.Image = global::TimeHACK.Properties.Resources.WinClassicPrograms;
            this.ProgramsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProgramsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ProgramsToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Silver;
            this.ProgramsToolStripMenuItem.Name = "ProgramsToolStripMenuItem";
            this.ProgramsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 25, 0);
            this.ProgramsToolStripMenuItem.Size = new System.Drawing.Size(138, 36);
            this.ProgramsToolStripMenuItem.Text = "Load Game";
            this.ProgramsToolStripMenuItem.Click += new System.EventHandler(this.LoadGame_Click);
            // 
            // DocumentsToolStripMenuItem
            // 
            this.DocumentsToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.DocumentsToolStripMenuItem.BackgroundImage = global::TimeHACK.Properties.Resources.sliversilver;
            this.DocumentsToolStripMenuItem.Image = global::TimeHACK.Properties.Resources.WinClassicDocuments;
            this.DocumentsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DocumentsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DocumentsToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Silver;
            this.DocumentsToolStripMenuItem.Name = "DocumentsToolStripMenuItem";
            this.DocumentsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 25, 0);
            this.DocumentsToolStripMenuItem.Size = new System.Drawing.Size(138, 36);
            this.DocumentsToolStripMenuItem.Text = "New Game";
            this.DocumentsToolStripMenuItem.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.SettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ControlPanelToolStripMenuItem,
            this.PrintersToolStripMenuItem,
            this.TaskbarToolStripMenuItem});
            this.SettingsToolStripMenuItem.Image = global::TimeHACK.Properties.Resources.WinClassicSettings;
            this.SettingsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SettingsToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Silver;
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 25, 0);
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(138, 36);
            this.SettingsToolStripMenuItem.Text = "Settings";
            // 
            // ControlPanelToolStripMenuItem
            // 
            this.ControlPanelToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.ControlPanelToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ControlPanelToolStripMenuItem.BackgroundImage")));
            this.ControlPanelToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ControlPanelToolStripMenuItem.Name = "ControlPanelToolStripMenuItem";
            this.ControlPanelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ControlPanelToolStripMenuItem.Text = "Control Panel";
            // 
            // PrintersToolStripMenuItem
            // 
            this.PrintersToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.PrintersToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PrintersToolStripMenuItem.BackgroundImage")));
            this.PrintersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.PrintersToolStripMenuItem.Name = "PrintersToolStripMenuItem";
            this.PrintersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.PrintersToolStripMenuItem.Text = "Printers";
            // 
            // TaskbarToolStripMenuItem
            // 
            this.TaskbarToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.TaskbarToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TaskbarToolStripMenuItem.BackgroundImage")));
            this.TaskbarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TaskbarToolStripMenuItem.Name = "TaskbarToolStripMenuItem";
            this.TaskbarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.TaskbarToolStripMenuItem.Text = "Taskbar";
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.HelpToolStripMenuItem.Image = global::TimeHACK.Properties.Resources.WinClassicHelp;
            this.HelpToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HelpToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.HelpToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Silver;
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 25, 0);
            this.HelpToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(138, 36);
            this.HelpToolStripMenuItem.Text = "Help";
            // 
            // ShutdownToolStripMenuItem
            // 
            this.ShutdownToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.ShutdownToolStripMenuItem.Image = global::TimeHACK.Properties.Resources.WinClassicShutdown;
            this.ShutdownToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShutdownToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShutdownToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Silver;
            this.ShutdownToolStripMenuItem.Name = "ShutdownToolStripMenuItem";
            this.ShutdownToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 25, 0);
            this.ShutdownToolStripMenuItem.Size = new System.Drawing.Size(138, 36);
            this.ShutdownToolStripMenuItem.Text = "Shut Down...";
            this.ShutdownToolStripMenuItem.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ossidestartmenu
            // 
            this.ossidestartmenu.Controls.Add(this.osimage);
            this.ossidestartmenu.Location = new System.Drawing.Point(0, 0);
            this.ossidestartmenu.Name = "ossidestartmenu";
            this.ossidestartmenu.Size = new System.Drawing.Size(26, 297);
            this.ossidestartmenu.TabIndex = 4;
            // 
            // osimage
            // 
            this.osimage.BackColor = System.Drawing.Color.Gray;
            this.osimage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.osimage.Location = new System.Drawing.Point(0, 0);
            this.osimage.Name = "osimage";
            this.osimage.Size = new System.Drawing.Size(26, 297);
            this.osimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.osimage.TabIndex = 0;
            this.osimage.TabStop = false;
            // 
            // TitleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.program);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TitleScreen";
            this.Tag = "ignoreFormOnTaskbar";
            this.Text = "TimeHACK Launcher";
            this.Load += new System.EventHandler(this.TitleScreen_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VM_Height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VM_Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startbutton)).EndInit();
            this.program.ResumeLayout(false);
            this.programContent.ResumeLayout(false);
            this.programtopbar.ResumeLayout(false);
            this.programtopbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximizebutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizebutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closebutton)).EndInit();
            this.startmenu.ResumeLayout(false);
            this.startmenu.PerformLayout();
            this.startmenuitems.ResumeLayout(false);
            this.startmenuitems.PerformLayout();
            this.ossidestartmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.osimage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label gameversion;
        private System.Windows.Forms.CheckBox vm_mode;
        private System.Windows.Forms.Timer vmModeTimer;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.PictureBox startbutton;
        internal System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown VM_Height;
        private System.Windows.Forms.NumericUpDown VM_Width;
        internal System.Windows.Forms.Panel program;
        public System.Windows.Forms.Panel programContent;
        public System.Windows.Forms.Panel programtopbar;
        public System.Windows.Forms.PictureBox maximizebutton;
        public System.Windows.Forms.PictureBox minimizebutton;
        internal System.Windows.Forms.Label Title;
        internal System.Windows.Forms.PictureBox closebutton;
        internal System.Windows.Forms.Panel toprightcorner;
        internal System.Windows.Forms.Panel bottomrightcorner;
        internal System.Windows.Forms.Panel bottomleftcorner;
        internal System.Windows.Forms.Panel topleftcorner;
        internal System.Windows.Forms.Panel left;
        internal System.Windows.Forms.Panel bottom;
        internal System.Windows.Forms.Panel right;
        internal System.Windows.Forms.Panel top;
        internal System.Windows.Forms.Panel startmenu;
        internal System.Windows.Forms.MenuStrip startmenuitems;
        internal System.Windows.Forms.ToolStripMenuItem ProgramsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem DocumentsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ControlPanelToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem PrintersToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem TaskbarToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ShutdownToolStripMenuItem;
        internal System.Windows.Forms.Panel ossidestartmenu;
        internal System.Windows.Forms.PictureBox osimage;
    }
}
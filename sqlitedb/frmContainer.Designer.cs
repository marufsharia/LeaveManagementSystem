namespace LeaveManagementSystem
{
    partial class frmContainer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemleaveStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemLeave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuadmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemleaveApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemabout = new System.Windows.Forms.ToolStripMenuItem();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.lbldatetime = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panelNotificationbar = new System.Windows.Forms.Panel();
            this.LInklblDetail = new System.Windows.Forms.LinkLabel();
            this.lblNotificationStatus = new System.Windows.Forms.Label();
            this.lblNotificationIcon = new System.Windows.Forms.Label();
            this.lblCloseNotification = new System.Windows.Forms.Label();
            this.panelPopUp = new System.Windows.Forms.Panel();
            this.txtApprovedBy = new System.Windows.Forms.TextBox();
            this.txtApprovedDate = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.txtLeaveTo = new System.Windows.Forms.TextBox();
            this.txtLeaveFrom = new System.Windows.Forms.TextBox();
            this.txtLeaveStatus = new System.Windows.Forms.TextBox();
            this.txtLeaveId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tm = new System.Windows.Forms.Timer(this.components);
            this.tm2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.panelNotificationbar.SuspendLayout();
            this.panelPopUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Font = new System.Drawing.Font("Poor Richard", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.applicationToolStripMenuItem,
            this.mnuadmin,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1007, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemLogout,
            this.mnuItemExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // mnuItemLogout
            // 
            this.mnuItemLogout.Name = "mnuItemLogout";
            this.mnuItemLogout.Size = new System.Drawing.Size(120, 22);
            this.mnuItemLogout.Text = "Log out";
            this.mnuItemLogout.Click += new System.EventHandler(this.mnuItemLogout_Click);
            // 
            // mnuItemExit
            // 
            this.mnuItemExit.Name = "mnuItemExit";
            this.mnuItemExit.Size = new System.Drawing.Size(120, 22);
            this.mnuItemExit.Text = "Exit";
            this.mnuItemExit.Click += new System.EventHandler(this.mnuItemExit_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemProfile,
            this.mnuItemleaveStatus});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // mnuItemProfile
            // 
            this.mnuItemProfile.Name = "mnuItemProfile";
            this.mnuItemProfile.Size = new System.Drawing.Size(151, 22);
            this.mnuItemProfile.Text = "Profile";
            this.mnuItemProfile.Click += new System.EventHandler(this.mnuItemProfile_Click);
            // 
            // mnuItemleaveStatus
            // 
            this.mnuItemleaveStatus.Name = "mnuItemleaveStatus";
            this.mnuItemleaveStatus.Size = new System.Drawing.Size(151, 22);
            this.mnuItemleaveStatus.Text = "Leave Status";
            this.mnuItemleaveStatus.Click += new System.EventHandler(this.mnuItemleaveStatus_Click);
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemLeave});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.applicationToolStripMenuItem.Text = "Application";
            // 
            // mnuItemLeave
            // 
            this.mnuItemLeave.Name = "mnuItemLeave";
            this.mnuItemLeave.Size = new System.Drawing.Size(112, 22);
            this.mnuItemLeave.Text = "Leave";
            this.mnuItemLeave.Click += new System.EventHandler(this.mnuItemLeave_Click);
            // 
            // mnuadmin
            // 
            this.mnuadmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemleaveApplication});
            this.mnuadmin.Name = "mnuadmin";
            this.mnuadmin.Size = new System.Drawing.Size(58, 20);
            this.mnuadmin.Text = "Admin";
            // 
            // mnuItemleaveApplication
            // 
            this.mnuItemleaveApplication.Name = "mnuItemleaveApplication";
            this.mnuItemleaveApplication.Size = new System.Drawing.Size(184, 22);
            this.mnuItemleaveApplication.Text = "Leave Application";
            this.mnuItemleaveApplication.Click += new System.EventHandler(this.mnuItemleaveApplication_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemabout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // mnuItemabout
            // 
            this.mnuItemabout.Name = "mnuItemabout";
            this.mnuItemabout.Size = new System.Drawing.Size(112, 22);
            this.mnuItemabout.Text = "About";
            this.mnuItemabout.Click += new System.EventHandler(this.mnuItemabout_Click);
            // 
            // panelStatus
            // 
            this.panelStatus.Controls.Add(this.lbldatetime);
            this.panelStatus.Controls.Add(this.lblStatus);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStatus.Location = new System.Drawing.Point(20, 704);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(1007, 25);
            this.panelStatus.TabIndex = 9;
            // 
            // lbldatetime
            // 
            this.lbldatetime.AutoSize = true;
            this.lbldatetime.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbldatetime.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatetime.Location = new System.Drawing.Point(933, 0);
            this.lbldatetime.Name = "lbldatetime";
            this.lbldatetime.Size = new System.Drawing.Size(74, 20);
            this.lbldatetime.TabIndex = 1;
            this.lbldatetime.Text = "DtaeTime";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(0, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 20);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "status";
            // 
            // panelNotificationbar
            // 
            this.panelNotificationbar.BackColor = System.Drawing.Color.Gainsboro;
            this.panelNotificationbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelNotificationbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNotificationbar.Controls.Add(this.LInklblDetail);
            this.panelNotificationbar.Controls.Add(this.lblNotificationStatus);
            this.panelNotificationbar.Controls.Add(this.lblNotificationIcon);
            this.panelNotificationbar.Controls.Add(this.lblCloseNotification);
            this.panelNotificationbar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelNotificationbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNotificationbar.Location = new System.Drawing.Point(20, 84);
            this.panelNotificationbar.Name = "panelNotificationbar";
            this.panelNotificationbar.Size = new System.Drawing.Size(1007, 40);
            this.panelNotificationbar.TabIndex = 10;
            this.panelNotificationbar.Visible = false;
            this.panelNotificationbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelNotificationbar_MouseMove);
            // 
            // LInklblDetail
            // 
            this.LInklblDetail.AutoSize = true;
            this.LInklblDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LInklblDetail.Dock = System.Windows.Forms.DockStyle.Right;
            this.LInklblDetail.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LInklblDetail.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LInklblDetail.Location = new System.Drawing.Point(896, 0);
            this.LInklblDetail.Name = "LInklblDetail";
            this.LInklblDetail.Size = new System.Drawing.Size(89, 20);
            this.LInklblDetail.TabIndex = 4;
            this.LInklblDetail.TabStop = true;
            this.LInklblDetail.Text = "view details";
            this.LInklblDetail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LInklblDetail_LinkClicked);
            this.LInklblDetail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LInklblDetail_MouseClick);
            this.LInklblDetail.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LInklblDetail_MouseMove);
            // 
            // lblNotificationStatus
            // 
            this.lblNotificationStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotificationStatus.AutoSize = true;
            this.lblNotificationStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificationStatus.Location = new System.Drawing.Point(63, 12);
            this.lblNotificationStatus.Name = "lblNotificationStatus";
            this.lblNotificationStatus.Size = new System.Drawing.Size(0, 20);
            this.lblNotificationStatus.TabIndex = 6;
            // 
            // lblNotificationIcon
            // 
            this.lblNotificationIcon.AutoSize = true;
            this.lblNotificationIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblNotificationIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNotificationIcon.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificationIcon.Image = global::LeaveManagementSystem.Properties.Resources.Comment;
            this.lblNotificationIcon.Location = new System.Drawing.Point(0, 0);
            this.lblNotificationIcon.Name = "lblNotificationIcon";
            this.lblNotificationIcon.Padding = new System.Windows.Forms.Padding(2);
            this.lblNotificationIcon.Size = new System.Drawing.Size(54, 35);
            this.lblNotificationIcon.TabIndex = 1;
            this.lblNotificationIcon.Text = "        ";
            this.lblNotificationIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNotificationIcon.UseCompatibleTextRendering = true;
            // 
            // lblCloseNotification
            // 
            this.lblCloseNotification.AutoSize = true;
            this.lblCloseNotification.BackColor = System.Drawing.Color.Transparent;
            this.lblCloseNotification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCloseNotification.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCloseNotification.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloseNotification.Location = new System.Drawing.Point(985, 0);
            this.lblCloseNotification.Name = "lblCloseNotification";
            this.lblCloseNotification.Size = new System.Drawing.Size(20, 21);
            this.lblCloseNotification.TabIndex = 0;
            this.lblCloseNotification.Text = "X";
            this.lblCloseNotification.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCloseNotification.Click += new System.EventHandler(this.lblCloseNotification_Click);
            this.lblCloseNotification.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblCloseNotification_MouseMove);
            // 
            // panelPopUp
            // 
            this.panelPopUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPopUp.BackColor = System.Drawing.Color.Gainsboro;
            this.panelPopUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPopUp.Controls.Add(this.txtApprovedBy);
            this.panelPopUp.Controls.Add(this.txtApprovedDate);
            this.panelPopUp.Controls.Add(this.txtComment);
            this.panelPopUp.Controls.Add(this.txtReason);
            this.panelPopUp.Controls.Add(this.txtLeaveTo);
            this.panelPopUp.Controls.Add(this.txtLeaveFrom);
            this.panelPopUp.Controls.Add(this.txtLeaveStatus);
            this.panelPopUp.Controls.Add(this.txtLeaveId);
            this.panelPopUp.Controls.Add(this.label8);
            this.panelPopUp.Controls.Add(this.label7);
            this.panelPopUp.Controls.Add(this.label6);
            this.panelPopUp.Controls.Add(this.label5);
            this.panelPopUp.Controls.Add(this.label4);
            this.panelPopUp.Controls.Add(this.label3);
            this.panelPopUp.Controls.Add(this.label2);
            this.panelPopUp.Controls.Add(this.label1);
            this.panelPopUp.Location = new System.Drawing.Point(619, 124);
            this.panelPopUp.Name = "panelPopUp";
            this.panelPopUp.Size = new System.Drawing.Size(408, 5);
            this.panelPopUp.TabIndex = 13;
            this.panelPopUp.Visible = false;
            // 
            // txtApprovedBy
            // 
            this.txtApprovedBy.BackColor = System.Drawing.Color.White;
            this.txtApprovedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApprovedBy.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApprovedBy.Location = new System.Drawing.Point(114, 150);
            this.txtApprovedBy.Name = "txtApprovedBy";
            this.txtApprovedBy.Size = new System.Drawing.Size(289, 27);
            this.txtApprovedBy.TabIndex = 15;
            // 
            // txtApprovedDate
            // 
            this.txtApprovedDate.BackColor = System.Drawing.Color.White;
            this.txtApprovedDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApprovedDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApprovedDate.Location = new System.Drawing.Point(114, 114);
            this.txtApprovedDate.Name = "txtApprovedDate";
            this.txtApprovedDate.Size = new System.Drawing.Size(289, 27);
            this.txtApprovedDate.TabIndex = 14;
            // 
            // txtComment
            // 
            this.txtComment.BackColor = System.Drawing.Color.White;
            this.txtComment.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComment.Location = new System.Drawing.Point(7, 286);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComment.Size = new System.Drawing.Size(396, 74);
            this.txtComment.TabIndex = 13;
            // 
            // txtReason
            // 
            this.txtReason.BackColor = System.Drawing.Color.White;
            this.txtReason.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReason.Location = new System.Drawing.Point(7, 198);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReason.Size = new System.Drawing.Size(396, 68);
            this.txtReason.TabIndex = 12;
            // 
            // txtLeaveTo
            // 
            this.txtLeaveTo.BackColor = System.Drawing.Color.White;
            this.txtLeaveTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLeaveTo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeaveTo.Location = new System.Drawing.Point(79, 81);
            this.txtLeaveTo.Name = "txtLeaveTo";
            this.txtLeaveTo.Size = new System.Drawing.Size(324, 27);
            this.txtLeaveTo.TabIndex = 11;
            // 
            // txtLeaveFrom
            // 
            this.txtLeaveFrom.BackColor = System.Drawing.Color.White;
            this.txtLeaveFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLeaveFrom.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeaveFrom.Location = new System.Drawing.Point(79, 48);
            this.txtLeaveFrom.Name = "txtLeaveFrom";
            this.txtLeaveFrom.Size = new System.Drawing.Size(324, 27);
            this.txtLeaveFrom.TabIndex = 10;
            // 
            // txtLeaveStatus
            // 
            this.txtLeaveStatus.BackColor = System.Drawing.Color.White;
            this.txtLeaveStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLeaveStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeaveStatus.Location = new System.Drawing.Point(259, 12);
            this.txtLeaveStatus.Name = "txtLeaveStatus";
            this.txtLeaveStatus.Size = new System.Drawing.Size(144, 27);
            this.txtLeaveStatus.TabIndex = 9;
            // 
            // txtLeaveId
            // 
            this.txtLeaveId.BackColor = System.Drawing.Color.White;
            this.txtLeaveId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLeaveId.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeaveId.Location = new System.Drawing.Point(79, 12);
            this.txtLeaveId.Name = "txtLeaveId";
            this.txtLeaveId.Size = new System.Drawing.Size(113, 27);
            this.txtLeaveId.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(198, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Status:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Comment:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-2, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Approved Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Approved By:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reason";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Leave Id:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::LeaveManagementSystem.Properties.Resources._46539f27ba5423d3789baabd925d7169;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 669);
            this.panel1.TabIndex = 14;
            // 
            // tm
            // 
            this.tm.Interval = 30;
            this.tm.Tick += new System.EventHandler(this.tm_Tick);
            // 
            // tm2
            // 
            this.tm2.Interval = 30;
            this.tm2.Tick += new System.EventHandler(this.tm2_Tick);
            // 
            // frmContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 749);
            this.Controls.Add(this.panelPopUp);
            this.Controls.Add(this.panelNotificationbar);
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(879, 646);
            this.Name = "frmContainer";
            this.Text = "Leave Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmContainer_FormClosing);
            this.Load += new System.EventHandler(this.frmContainer_Load);
            this.Resize += new System.EventHandler(this.frmContainer_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.panelNotificationbar.ResumeLayout(false);
            this.panelNotificationbar.PerformLayout();
            this.panelPopUp.ResumeLayout(false);
            this.panelPopUp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuItemExit;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuItemProfile;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Label lbldatetime;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ToolStripMenuItem mnuItemLogout;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuItemLeave;
        private System.Windows.Forms.ToolStripMenuItem mnuadmin;
        private System.Windows.Forms.ToolStripMenuItem mnuItemleaveApplication;
        private System.Windows.Forms.Panel panelNotificationbar;
        private System.Windows.Forms.Label lblCloseNotification;
        private System.Windows.Forms.ToolStripMenuItem mnuItemleaveStatus;
        private System.Windows.Forms.LinkLabel LInklblDetail;
        private System.Windows.Forms.Label lblNotificationIcon;
        private System.Windows.Forms.Label lblNotificationStatus;
        private System.Windows.Forms.Panel panelPopUp;
        private System.Windows.Forms.TextBox txtApprovedBy;
        private System.Windows.Forms.TextBox txtApprovedDate;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.TextBox txtLeaveTo;
        private System.Windows.Forms.TextBox txtLeaveFrom;
        private System.Windows.Forms.TextBox txtLeaveStatus;
        private System.Windows.Forms.TextBox txtLeaveId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuItemabout;
        private System.Windows.Forms.Timer tm;
        private System.Windows.Forms.Timer tm2;
    }
}
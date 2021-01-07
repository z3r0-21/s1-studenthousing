﻿namespace HousingSoftware
{
    partial class TenantForm
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
            this.MenuTenant = new System.Windows.Forms.TabControl();
            this.tabHomeTenant = new System.Windows.Forms.TabPage();
            this.lblDateTenant = new System.Windows.Forms.Label();
            this.lbTimeTenant = new System.Windows.Forms.Label();
            this.lblUnpaidGroceriesNotification = new System.Windows.Forms.Label();
            this.btnLogOutTenant = new System.Windows.Forms.Button();
            this.lbWelcomeMsgTenant = new System.Windows.Forms.Label();
            this.tabGroceriesTenant = new System.Windows.Forms.TabPage();
            this.gbxPayListGroceriesTenant = new System.Windows.Forms.GroupBox();
            this.lbxUnpaidGroceries = new System.Windows.Forms.ListBox();
            this.tabAnnouncementsTenant = new System.Windows.Forms.TabPage();
            this.gbxNewsFeedTenant = new System.Windows.Forms.GroupBox();
            this.lbxUserAllAnnouncements = new System.Windows.Forms.ListBox();
            this.lblAllAnnouncementTenant = new System.Windows.Forms.Label();
            this.tabAgreementsTenant = new System.Windows.Forms.TabPage();
            this.gbxSearchAgreementTenant = new System.Windows.Forms.GroupBox();
            this.btnShowAllAgreementsTenant = new System.Windows.Forms.Button();
            this.btnSearchAgreementTenant = new System.Windows.Forms.Button();
            this.tbxSearchAgreementsTenant = new System.Windows.Forms.TextBox();
            this.gbxAllAgreements = new System.Windows.Forms.GroupBox();
            this.btnDisagree = new System.Windows.Forms.Button();
            this.btnAgree = new System.Windows.Forms.Button();
            this.lbxAllAgreementsTenant = new System.Windows.Forms.ListBox();
            this.lblAllAgreementsTenant = new System.Windows.Forms.Label();
            this.gbxAddAgreement = new System.Windows.Forms.GroupBox();
            this.btnAddAgreement = new System.Windows.Forms.Button();
            this.tbxAddAgreement = new System.Windows.Forms.TextBox();
            this.lbWriteAgreement = new System.Windows.Forms.Label();
            this.tabHouseRulesTenant = new System.Windows.Forms.TabPage();
            this.gbxHouseRulseTenant = new System.Windows.Forms.GroupBox();
            this.lbxRulesTenant = new System.Windows.Forms.ListBox();
            this.tabComplaintsTenant = new System.Windows.Forms.TabPage();
            this.btnComplaint = new System.Windows.Forms.Button();
            this.tbxWriteComplaint = new System.Windows.Forms.TextBox();
            this.lbWriteComplaint = new System.Windows.Forms.Label();
            this.timerTenant = new System.Windows.Forms.Timer(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.MenuTenant.SuspendLayout();
            this.tabHomeTenant.SuspendLayout();
            this.tabGroceriesTenant.SuspendLayout();
            this.gbxPayListGroceriesTenant.SuspendLayout();
            this.tabAnnouncementsTenant.SuspendLayout();
            this.gbxNewsFeedTenant.SuspendLayout();
            this.tabAgreementsTenant.SuspendLayout();
            this.gbxSearchAgreementTenant.SuspendLayout();
            this.gbxAllAgreements.SuspendLayout();
            this.gbxAddAgreement.SuspendLayout();
            this.tabHouseRulesTenant.SuspendLayout();
            this.gbxHouseRulseTenant.SuspendLayout();
            this.tabComplaintsTenant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuTenant
            // 
            this.MenuTenant.Controls.Add(this.tabHomeTenant);
            this.MenuTenant.Controls.Add(this.tabGroceriesTenant);
            this.MenuTenant.Controls.Add(this.tabAnnouncementsTenant);
            this.MenuTenant.Controls.Add(this.tabAgreementsTenant);
            this.MenuTenant.Controls.Add(this.tabHouseRulesTenant);
            this.MenuTenant.Controls.Add(this.tabComplaintsTenant);
            this.MenuTenant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuTenant.Location = new System.Drawing.Point(13, 10);
            this.MenuTenant.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.MenuTenant.Name = "MenuTenant";
            this.MenuTenant.SelectedIndex = 0;
            this.MenuTenant.Size = new System.Drawing.Size(927, 503);
            this.MenuTenant.TabIndex = 2;
            // 
            // tabHomeTenant
            // 
            this.tabHomeTenant.Controls.Add(this.lblDateTenant);
            this.tabHomeTenant.Controls.Add(this.lbTimeTenant);
            this.tabHomeTenant.Controls.Add(this.lblUnpaidGroceriesNotification);
            this.tabHomeTenant.Controls.Add(this.btnLogOutTenant);
            this.tabHomeTenant.Controls.Add(this.lbWelcomeMsgTenant);
            this.tabHomeTenant.ImageKey = "(none)";
            this.tabHomeTenant.Location = new System.Drawing.Point(4, 22);
            this.tabHomeTenant.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.tabHomeTenant.Name = "tabHomeTenant";
            this.tabHomeTenant.Padding = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.tabHomeTenant.Size = new System.Drawing.Size(919, 477);
            this.tabHomeTenant.TabIndex = 0;
            this.tabHomeTenant.Text = "Home";
            this.tabHomeTenant.UseVisualStyleBackColor = true;
            // 
            // lblDateTenant
            // 
            this.lblDateTenant.AutoSize = true;
            this.lblDateTenant.Location = new System.Drawing.Point(169, 207);
            this.lblDateTenant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateTenant.Name = "lblDateTenant";
            this.lblDateTenant.Size = new System.Drawing.Size(30, 13);
            this.lblDateTenant.TabIndex = 7;
            this.lblDateTenant.Text = "Date";
            // 
            // lbTimeTenant
            // 
            this.lbTimeTenant.AutoSize = true;
            this.lbTimeTenant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeTenant.Location = new System.Drawing.Point(164, 182);
            this.lbTimeTenant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTimeTenant.Name = "lbTimeTenant";
            this.lbTimeTenant.Size = new System.Drawing.Size(47, 20);
            this.lbTimeTenant.TabIndex = 6;
            this.lbTimeTenant.Text = "Time";
            // 
            // lblUnpaidGroceriesNotification
            // 
            this.lblUnpaidGroceriesNotification.AutoSize = true;
            this.lblUnpaidGroceriesNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnpaidGroceriesNotification.Location = new System.Drawing.Point(122, 36);
            this.lblUnpaidGroceriesNotification.Name = "lblUnpaidGroceriesNotification";
            this.lblUnpaidGroceriesNotification.Size = new System.Drawing.Size(0, 17);
            this.lblUnpaidGroceriesNotification.TabIndex = 5;
            this.lblUnpaidGroceriesNotification.Click += new System.EventHandler(this.lblUnpaidGroceriesNotification_Click);
            // 
            // btnLogOutTenant
            // 
            this.btnLogOutTenant.Location = new System.Drawing.Point(82, 355);
            this.btnLogOutTenant.Margin = new System.Windows.Forms.Padding(5);
            this.btnLogOutTenant.Name = "btnLogOutTenant";
            this.btnLogOutTenant.Size = new System.Drawing.Size(139, 44);
            this.btnLogOutTenant.TabIndex = 4;
            this.btnLogOutTenant.Text = "Log out";
            this.btnLogOutTenant.UseVisualStyleBackColor = true;
            this.btnLogOutTenant.Click += new System.EventHandler(this.btnLogOutTenant_Click);
            // 
            // lbWelcomeMsgTenant
            // 
            this.lbWelcomeMsgTenant.AutoSize = true;
            this.lbWelcomeMsgTenant.Location = new System.Drawing.Point(119, 97);
            this.lbWelcomeMsgTenant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWelcomeMsgTenant.Name = "lbWelcomeMsgTenant";
            this.lbWelcomeMsgTenant.Size = new System.Drawing.Size(58, 13);
            this.lbWelcomeMsgTenant.TabIndex = 0;
            this.lbWelcomeMsgTenant.Text = "Welcome, ";
            // 
            // tabGroceriesTenant
            // 
            this.tabGroceriesTenant.Controls.Add(this.gbxPayListGroceriesTenant);
            this.tabGroceriesTenant.Location = new System.Drawing.Point(4, 22);
            this.tabGroceriesTenant.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.tabGroceriesTenant.Name = "tabGroceriesTenant";
            this.tabGroceriesTenant.Padding = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.tabGroceriesTenant.Size = new System.Drawing.Size(919, 477);
            this.tabGroceriesTenant.TabIndex = 1;
            this.tabGroceriesTenant.Text = "Groceries";
            this.tabGroceriesTenant.UseVisualStyleBackColor = true;
            // 
            // gbxPayListGroceriesTenant
            // 
            this.gbxPayListGroceriesTenant.Controls.Add(this.lbxUnpaidGroceries);
            this.gbxPayListGroceriesTenant.Location = new System.Drawing.Point(32, 25);
            this.gbxPayListGroceriesTenant.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.gbxPayListGroceriesTenant.Name = "gbxPayListGroceriesTenant";
            this.gbxPayListGroceriesTenant.Padding = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.gbxPayListGroceriesTenant.Size = new System.Drawing.Size(278, 320);
            this.gbxPayListGroceriesTenant.TabIndex = 4;
            this.gbxPayListGroceriesTenant.TabStop = false;
            this.gbxPayListGroceriesTenant.Text = "Pay list groceries";
            // 
            // lbxUnpaidGroceries
            // 
            this.lbxUnpaidGroceries.FormattingEnabled = true;
            this.lbxUnpaidGroceries.Location = new System.Drawing.Point(8, 28);
            this.lbxUnpaidGroceries.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.lbxUnpaidGroceries.Name = "lbxUnpaidGroceries";
            this.lbxUnpaidGroceries.Size = new System.Drawing.Size(259, 277);
            this.lbxUnpaidGroceries.TabIndex = 3;
            // 
            // tabAnnouncementsTenant
            // 
            this.tabAnnouncementsTenant.Controls.Add(this.gbxNewsFeedTenant);
            this.tabAnnouncementsTenant.Location = new System.Drawing.Point(4, 22);
            this.tabAnnouncementsTenant.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.tabAnnouncementsTenant.Name = "tabAnnouncementsTenant";
            this.tabAnnouncementsTenant.Size = new System.Drawing.Size(919, 477);
            this.tabAnnouncementsTenant.TabIndex = 2;
            this.tabAnnouncementsTenant.Text = "Announcements";
            this.tabAnnouncementsTenant.UseVisualStyleBackColor = true;
            // 
            // gbxNewsFeedTenant
            // 
            this.gbxNewsFeedTenant.Controls.Add(this.lbxUserAllAnnouncements);
            this.gbxNewsFeedTenant.Controls.Add(this.lblAllAnnouncementTenant);
            this.gbxNewsFeedTenant.Location = new System.Drawing.Point(24, 26);
            this.gbxNewsFeedTenant.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.gbxNewsFeedTenant.Name = "gbxNewsFeedTenant";
            this.gbxNewsFeedTenant.Padding = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.gbxNewsFeedTenant.Size = new System.Drawing.Size(385, 344);
            this.gbxNewsFeedTenant.TabIndex = 2;
            this.gbxNewsFeedTenant.TabStop = false;
            this.gbxNewsFeedTenant.Text = "News feed";
            // 
            // lbxUserAllAnnouncements
            // 
            this.lbxUserAllAnnouncements.FormattingEnabled = true;
            this.lbxUserAllAnnouncements.Location = new System.Drawing.Point(8, 49);
            this.lbxUserAllAnnouncements.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.lbxUserAllAnnouncements.Name = "lbxUserAllAnnouncements";
            this.lbxUserAllAnnouncements.Size = new System.Drawing.Size(364, 277);
            this.lbxUserAllAnnouncements.TabIndex = 0;
            // 
            // lblAllAnnouncementTenant
            // 
            this.lblAllAnnouncementTenant.AutoSize = true;
            this.lblAllAnnouncementTenant.Location = new System.Drawing.Point(144, 23);
            this.lblAllAnnouncementTenant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAllAnnouncementTenant.Name = "lblAllAnnouncementTenant";
            this.lblAllAnnouncementTenant.Size = new System.Drawing.Size(97, 13);
            this.lblAllAnnouncementTenant.TabIndex = 1;
            this.lblAllAnnouncementTenant.Text = "All announcements";
            // 
            // tabAgreementsTenant
            // 
            this.tabAgreementsTenant.Controls.Add(this.gbxSearchAgreementTenant);
            this.tabAgreementsTenant.Controls.Add(this.gbxAllAgreements);
            this.tabAgreementsTenant.Controls.Add(this.gbxAddAgreement);
            this.tabAgreementsTenant.Location = new System.Drawing.Point(4, 22);
            this.tabAgreementsTenant.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.tabAgreementsTenant.Name = "tabAgreementsTenant";
            this.tabAgreementsTenant.Size = new System.Drawing.Size(919, 477);
            this.tabAgreementsTenant.TabIndex = 3;
            this.tabAgreementsTenant.Text = "Agreements";
            this.tabAgreementsTenant.UseVisualStyleBackColor = true;
            // 
            // gbxSearchAgreementTenant
            // 
            this.gbxSearchAgreementTenant.Controls.Add(this.btnShowAllAgreementsTenant);
            this.gbxSearchAgreementTenant.Controls.Add(this.btnSearchAgreementTenant);
            this.gbxSearchAgreementTenant.Controls.Add(this.tbxSearchAgreementsTenant);
            this.gbxSearchAgreementTenant.Location = new System.Drawing.Point(22, 263);
            this.gbxSearchAgreementTenant.Margin = new System.Windows.Forms.Padding(5);
            this.gbxSearchAgreementTenant.Name = "gbxSearchAgreementTenant";
            this.gbxSearchAgreementTenant.Padding = new System.Windows.Forms.Padding(5);
            this.gbxSearchAgreementTenant.Size = new System.Drawing.Size(456, 194);
            this.gbxSearchAgreementTenant.TabIndex = 6;
            this.gbxSearchAgreementTenant.TabStop = false;
            this.gbxSearchAgreementTenant.Text = "Search for an agreement";
            // 
            // btnShowAllAgreementsTenant
            // 
            this.btnShowAllAgreementsTenant.Location = new System.Drawing.Point(88, 139);
            this.btnShowAllAgreementsTenant.Margin = new System.Windows.Forms.Padding(5);
            this.btnShowAllAgreementsTenant.Name = "btnShowAllAgreementsTenant";
            this.btnShowAllAgreementsTenant.Size = new System.Drawing.Size(276, 33);
            this.btnShowAllAgreementsTenant.TabIndex = 2;
            this.btnShowAllAgreementsTenant.Text = "Show all agreements";
            this.btnShowAllAgreementsTenant.UseVisualStyleBackColor = true;
            this.btnShowAllAgreementsTenant.Click += new System.EventHandler(this.btnShowAllAgreements_Click);
            // 
            // btnSearchAgreementTenant
            // 
            this.btnSearchAgreementTenant.Location = new System.Drawing.Point(88, 91);
            this.btnSearchAgreementTenant.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearchAgreementTenant.Name = "btnSearchAgreementTenant";
            this.btnSearchAgreementTenant.Size = new System.Drawing.Size(276, 33);
            this.btnSearchAgreementTenant.TabIndex = 1;
            this.btnSearchAgreementTenant.Text = "Search";
            this.btnSearchAgreementTenant.UseVisualStyleBackColor = true;
            this.btnSearchAgreementTenant.Click += new System.EventHandler(this.btnSearchAgreement_Click);
            // 
            // tbxSearchAgreementsTenant
            // 
            this.tbxSearchAgreementsTenant.Location = new System.Drawing.Point(11, 49);
            this.tbxSearchAgreementsTenant.Margin = new System.Windows.Forms.Padding(5);
            this.tbxSearchAgreementsTenant.Name = "tbxSearchAgreementsTenant";
            this.tbxSearchAgreementsTenant.Size = new System.Drawing.Size(431, 20);
            this.tbxSearchAgreementsTenant.TabIndex = 0;
            // 
            // gbxAllAgreements
            // 
            this.gbxAllAgreements.Controls.Add(this.btnDisagree);
            this.gbxAllAgreements.Controls.Add(this.btnAgree);
            this.gbxAllAgreements.Controls.Add(this.lbxAllAgreementsTenant);
            this.gbxAllAgreements.Controls.Add(this.lblAllAgreementsTenant);
            this.gbxAllAgreements.Location = new System.Drawing.Point(517, 17);
            this.gbxAllAgreements.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.gbxAllAgreements.Name = "gbxAllAgreements";
            this.gbxAllAgreements.Padding = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.gbxAllAgreements.Size = new System.Drawing.Size(355, 398);
            this.gbxAllAgreements.TabIndex = 5;
            this.gbxAllAgreements.TabStop = false;
            // 
            // btnDisagree
            // 
            this.btnDisagree.Location = new System.Drawing.Point(8, 349);
            this.btnDisagree.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.btnDisagree.Name = "btnDisagree";
            this.btnDisagree.Size = new System.Drawing.Size(341, 33);
            this.btnDisagree.TabIndex = 3;
            this.btnDisagree.Text = "Disagree with selected";
            this.btnDisagree.UseVisualStyleBackColor = true;
            this.btnDisagree.Click += new System.EventHandler(this.btnDisagree_Click);
            // 
            // btnAgree
            // 
            this.btnAgree.Location = new System.Drawing.Point(7, 304);
            this.btnAgree.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.btnAgree.Name = "btnAgree";
            this.btnAgree.Size = new System.Drawing.Size(341, 33);
            this.btnAgree.TabIndex = 2;
            this.btnAgree.Text = "Agree with selected";
            this.btnAgree.UseVisualStyleBackColor = true;
            this.btnAgree.Click += new System.EventHandler(this.btnAgree_Click);
            // 
            // lbxAllAgreementsTenant
            // 
            this.lbxAllAgreementsTenant.FormattingEnabled = true;
            this.lbxAllAgreementsTenant.HorizontalScrollbar = true;
            this.lbxAllAgreementsTenant.Location = new System.Drawing.Point(8, 52);
            this.lbxAllAgreementsTenant.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.lbxAllAgreementsTenant.Name = "lbxAllAgreementsTenant";
            this.lbxAllAgreementsTenant.Size = new System.Drawing.Size(340, 238);
            this.lbxAllAgreementsTenant.TabIndex = 0;
            // 
            // lblAllAgreementsTenant
            // 
            this.lblAllAgreementsTenant.AutoSize = true;
            this.lblAllAgreementsTenant.Location = new System.Drawing.Point(144, 22);
            this.lblAllAgreementsTenant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAllAgreementsTenant.Name = "lblAllAgreementsTenant";
            this.lblAllAgreementsTenant.Size = new System.Drawing.Size(76, 13);
            this.lblAllAgreementsTenant.TabIndex = 1;
            this.lblAllAgreementsTenant.Text = "All agreements";
            // 
            // gbxAddAgreement
            // 
            this.gbxAddAgreement.Controls.Add(this.btnAddAgreement);
            this.gbxAddAgreement.Controls.Add(this.tbxAddAgreement);
            this.gbxAddAgreement.Controls.Add(this.lbWriteAgreement);
            this.gbxAddAgreement.Location = new System.Drawing.Point(22, 17);
            this.gbxAddAgreement.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.gbxAddAgreement.Name = "gbxAddAgreement";
            this.gbxAddAgreement.Padding = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.gbxAddAgreement.Size = new System.Drawing.Size(456, 221);
            this.gbxAddAgreement.TabIndex = 4;
            this.gbxAddAgreement.TabStop = false;
            // 
            // btnAddAgreement
            // 
            this.btnAddAgreement.Location = new System.Drawing.Point(167, 166);
            this.btnAddAgreement.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.btnAddAgreement.Name = "btnAddAgreement";
            this.btnAddAgreement.Size = new System.Drawing.Size(126, 37);
            this.btnAddAgreement.TabIndex = 2;
            this.btnAddAgreement.Text = "Add";
            this.btnAddAgreement.UseVisualStyleBackColor = true;
            this.btnAddAgreement.Click += new System.EventHandler(this.btnAddAgreement_Click);
            // 
            // tbxAddAgreement
            // 
            this.tbxAddAgreement.Location = new System.Drawing.Point(8, 52);
            this.tbxAddAgreement.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.tbxAddAgreement.Multiline = true;
            this.tbxAddAgreement.Name = "tbxAddAgreement";
            this.tbxAddAgreement.Size = new System.Drawing.Size(434, 100);
            this.tbxAddAgreement.TabIndex = 1;
            // 
            // lbWriteAgreement
            // 
            this.lbWriteAgreement.AutoSize = true;
            this.lbWriteAgreement.Location = new System.Drawing.Point(164, 20);
            this.lbWriteAgreement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWriteAgreement.Name = "lbWriteAgreement";
            this.lbWriteAgreement.Size = new System.Drawing.Size(129, 13);
            this.lbWriteAgreement.TabIndex = 0;
            this.lbWriteAgreement.Text = "Write down your message";
            // 
            // tabHouseRulesTenant
            // 
            this.tabHouseRulesTenant.Controls.Add(this.gbxHouseRulseTenant);
            this.tabHouseRulesTenant.Location = new System.Drawing.Point(4, 22);
            this.tabHouseRulesTenant.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.tabHouseRulesTenant.Name = "tabHouseRulesTenant";
            this.tabHouseRulesTenant.Size = new System.Drawing.Size(919, 477);
            this.tabHouseRulesTenant.TabIndex = 4;
            this.tabHouseRulesTenant.Text = "House Rules";
            this.tabHouseRulesTenant.UseVisualStyleBackColor = true;
            // 
            // gbxHouseRulseTenant
            // 
            this.gbxHouseRulseTenant.Controls.Add(this.lbxRulesTenant);
            this.gbxHouseRulseTenant.Location = new System.Drawing.Point(329, 42);
            this.gbxHouseRulseTenant.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.gbxHouseRulseTenant.Name = "gbxHouseRulseTenant";
            this.gbxHouseRulseTenant.Padding = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.gbxHouseRulseTenant.Size = new System.Drawing.Size(382, 334);
            this.gbxHouseRulseTenant.TabIndex = 4;
            this.gbxHouseRulseTenant.TabStop = false;
            this.gbxHouseRulseTenant.Text = "House rules";
            // 
            // lbxRulesTenant
            // 
            this.lbxRulesTenant.FormattingEnabled = true;
            this.lbxRulesTenant.Location = new System.Drawing.Point(17, 27);
            this.lbxRulesTenant.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.lbxRulesTenant.Name = "lbxRulesTenant";
            this.lbxRulesTenant.Size = new System.Drawing.Size(349, 290);
            this.lbxRulesTenant.TabIndex = 0;
            // 
            // tabComplaintsTenant
            // 
            this.tabComplaintsTenant.Controls.Add(this.btnComplaint);
            this.tabComplaintsTenant.Controls.Add(this.tbxWriteComplaint);
            this.tabComplaintsTenant.Controls.Add(this.lbWriteComplaint);
            this.tabComplaintsTenant.Location = new System.Drawing.Point(4, 22);
            this.tabComplaintsTenant.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.tabComplaintsTenant.Name = "tabComplaintsTenant";
            this.tabComplaintsTenant.Size = new System.Drawing.Size(919, 477);
            this.tabComplaintsTenant.TabIndex = 5;
            this.tabComplaintsTenant.Text = "Complaints";
            this.tabComplaintsTenant.UseVisualStyleBackColor = true;
            // 
            // btnComplaint
            // 
            this.btnComplaint.Location = new System.Drawing.Point(422, 157);
            this.btnComplaint.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.btnComplaint.Name = "btnComplaint";
            this.btnComplaint.Size = new System.Drawing.Size(132, 37);
            this.btnComplaint.TabIndex = 2;
            this.btnComplaint.Text = "Send";
            this.btnComplaint.UseVisualStyleBackColor = true;
            this.btnComplaint.Click += new System.EventHandler(this.btnComplaint_Click);
            // 
            // tbxWriteComplaint
            // 
            this.tbxWriteComplaint.Location = new System.Drawing.Point(294, 67);
            this.tbxWriteComplaint.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.tbxWriteComplaint.Multiline = true;
            this.tbxWriteComplaint.Name = "tbxWriteComplaint";
            this.tbxWriteComplaint.Size = new System.Drawing.Size(374, 75);
            this.tbxWriteComplaint.TabIndex = 1;
            // 
            // lbWriteComplaint
            // 
            this.lbWriteComplaint.AutoSize = true;
            this.lbWriteComplaint.Location = new System.Drawing.Point(419, 38);
            this.lbWriteComplaint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWriteComplaint.Name = "lbWriteComplaint";
            this.lbWriteComplaint.Size = new System.Drawing.Size(135, 13);
            this.lbWriteComplaint.TabIndex = 0;
            this.lbWriteComplaint.Text = "Write down your complaint:";
            // 
            // timerTenant
            // 
            this.timerTenant.Interval = 1000;
            this.timerTenant.Tick += new System.EventHandler(this.timerTenant_Tick);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // TenantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 538);
            this.Controls.Add(this.MenuTenant);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TenantForm";
            this.Text = "Tenant";
            this.Load += new System.EventHandler(this.TenantForm_Load);
            this.MenuTenant.ResumeLayout(false);
            this.tabHomeTenant.ResumeLayout(false);
            this.tabHomeTenant.PerformLayout();
            this.tabGroceriesTenant.ResumeLayout(false);
            this.gbxPayListGroceriesTenant.ResumeLayout(false);
            this.tabAnnouncementsTenant.ResumeLayout(false);
            this.gbxNewsFeedTenant.ResumeLayout(false);
            this.gbxNewsFeedTenant.PerformLayout();
            this.tabAgreementsTenant.ResumeLayout(false);
            this.gbxSearchAgreementTenant.ResumeLayout(false);
            this.gbxSearchAgreementTenant.PerformLayout();
            this.gbxAllAgreements.ResumeLayout(false);
            this.gbxAllAgreements.PerformLayout();
            this.gbxAddAgreement.ResumeLayout(false);
            this.gbxAddAgreement.PerformLayout();
            this.tabHouseRulesTenant.ResumeLayout(false);
            this.gbxHouseRulseTenant.ResumeLayout(false);
            this.tabComplaintsTenant.ResumeLayout(false);
            this.tabComplaintsTenant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl MenuTenant;
        private System.Windows.Forms.TabPage tabHomeTenant;
        private System.Windows.Forms.Label lbWelcomeMsgTenant;
        private System.Windows.Forms.TabPage tabGroceriesTenant;
        private System.Windows.Forms.GroupBox gbxPayListGroceriesTenant;
        private System.Windows.Forms.ListBox lbxUnpaidGroceries;
        private System.Windows.Forms.TabPage tabAnnouncementsTenant;
        private System.Windows.Forms.GroupBox gbxNewsFeedTenant;
        private System.Windows.Forms.ListBox lbxUserAllAnnouncements;
        private System.Windows.Forms.Label lblAllAnnouncementTenant;
        private System.Windows.Forms.TabPage tabAgreementsTenant;
        private System.Windows.Forms.GroupBox gbxAllAgreements;
        private System.Windows.Forms.ListBox lbxAllAgreementsTenant;
        private System.Windows.Forms.Label lblAllAgreementsTenant;
        private System.Windows.Forms.GroupBox gbxAddAgreement;
        private System.Windows.Forms.Button btnAddAgreement;
        private System.Windows.Forms.TextBox tbxAddAgreement;
        private System.Windows.Forms.Label lbWriteAgreement;
        private System.Windows.Forms.TabPage tabHouseRulesTenant;
        private System.Windows.Forms.GroupBox gbxHouseRulseTenant;
        private System.Windows.Forms.ListBox lbxRulesTenant;
        private System.Windows.Forms.TabPage tabComplaintsTenant;
        private System.Windows.Forms.Button btnComplaint;
        private System.Windows.Forms.TextBox tbxWriteComplaint;
        private System.Windows.Forms.Label lbWriteComplaint;
        private System.Windows.Forms.Button btnLogOutTenant;
        private System.Windows.Forms.Timer timerTenant;
        private System.Windows.Forms.Button btnDisagree;
        private System.Windows.Forms.Button btnAgree;
        private System.Windows.Forms.GroupBox gbxSearchAgreementTenant;
        private System.Windows.Forms.Button btnShowAllAgreementsTenant;
        private System.Windows.Forms.Button btnSearchAgreementTenant;
        private System.Windows.Forms.TextBox tbxSearchAgreementsTenant;
        private System.Windows.Forms.Label lblUnpaidGroceriesNotification;
        private System.Windows.Forms.Label lblDateTenant;
        private System.Windows.Forms.Label lbTimeTenant;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}
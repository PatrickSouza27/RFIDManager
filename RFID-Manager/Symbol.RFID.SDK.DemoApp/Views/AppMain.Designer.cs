using System.ComponentModel;
using System.Windows.Forms;

namespace Symbol.RFID.SDK.DemoApp
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.Windows.Forms.TabControl tabContainer;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabRSM = new System.Windows.Forms.TabPage();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.txtAttribute = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSetAttribute = new System.Windows.Forms.Button();
            this.btnGetAttribute = new System.Windows.Forms.Button();
            this.tabTagLocate = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTL = new System.Windows.Forms.Label();
            this.btnTagLocateStop = new System.Windows.Forms.Button();
            this.tabInventory = new System.Windows.Forms.TabPage();
            this.tabReadWrite = new System.Windows.Forms.TabPage();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtOffset = new System.Windows.Forms.TextBox();
            this.cmbMemoryBank = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtTagPattern = new System.Windows.Forms.TextBox();
            this.labelData = new System.Windows.Forms.Label();
            this.labelLength = new System.Windows.Forms.Label();
            this.labelOffset = new System.Windows.Forms.Label();
            this.labelMemBank = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelTagPattern = new System.Windows.Forms.Label();
            this.tabLock = new System.Windows.Forms.TabPage();
            this.btnLock = new System.Windows.Forms.Button();
            this.cmbLockPrivilage = new System.Windows.Forms.ComboBox();
            this.cmbMemoryBankLock = new System.Windows.Forms.ComboBox();
            this.txtPasswordLock = new System.Windows.Forms.TextBox();
            this.txtTagPatternLock = new System.Windows.Forms.TextBox();
            this.labelLockPrivilege = new System.Windows.Forms.Label();
            this.labelMemBankACLock = new System.Windows.Forms.Label();
            this.labelPasswordACLock = new System.Windows.Forms.Label();
            this.labelTagPatternACLock = new System.Windows.Forms.Label();
            this.tabKill = new System.Windows.Forms.TabPage();
            this.btnKill = new System.Windows.Forms.Button();
            this.txtPasswordKill = new System.Windows.Forms.TextBox();
            this.txtTagPatternKill = new System.Windows.Forms.TextBox();
            this.labelKillPassword = new System.Windows.Forms.Label();
            this.labelTagPatternKill = new System.Windows.Forms.Label();
            this.txtTagId = new System.Windows.Forms.TextBox();
            this.btnTagLocateStart = new System.Windows.Forms.Button();
            this.proximityPrcentBar = new System.Windows.Forms.ProgressBar();
            this.btnInventoryStart = new System.Windows.Forms.Button();
            this.btnPurgeTags = new System.Windows.Forms.Button();
            this.btnInventoryStop = new System.Windows.Forms.Button();
            this.grdTags = new System.Windows.Forms.DataGridView();
            this.btnConnectDisconnect = new System.Windows.Forms.Button();
            this.lblReaders = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antennaConfiguration = new System.Windows.Forms.ToolStripMenuItem();
            this.capabilitiesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regulatory = new System.Windows.Forms.ToolStripMenuItem();
            this.preFilters = new System.Windows.Forms.ToolStripMenuItem();
            this.singulationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tagReportingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triggersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveConfigMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPairNew = new System.Windows.Forms.Button();
            this.btnManulConnect = new System.Windows.Forms.Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button9 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Button8 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CustomGradientPanel3 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2Panel10 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button26 = new Guna.UI2.WinForms.Guna2Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.guna2Button10 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel9 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel8 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button22 = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Button12 = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Button15 = new Guna.UI2.WinForms.Guna2Button();
            this.lblBatteryLevel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblPower = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2Button21 = new Guna.UI2.WinForms.Guna2Button();
            this.label14 = new System.Windows.Forms.Label();
            this.guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            this.comboBoxReaders = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button19 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button20 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button18 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button17 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button16 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button11 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button14 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button13 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2Button23 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button24 = new Guna.UI2.WinForms.Guna2Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.bluetoothComponent1 = new InTheHand.Net.Bluetooth.BluetoothComponent();
            tabContainer = new System.Windows.Forms.TabControl();
            tabContainer.SuspendLayout();
            this.tabRSM.SuspendLayout();
            this.tabTagLocate.SuspendLayout();
            this.tabReadWrite.SuspendLayout();
            this.tabLock.SuspendLayout();
            this.tabKill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTags)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel4.SuspendLayout();
            this.guna2CustomGradientPanel3.SuspendLayout();
            this.guna2Panel10.SuspendLayout();
            this.guna2Panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.guna2Panel8.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.guna2Panel7.SuspendLayout();
            this.guna2Panel6.SuspendLayout();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabContainer
            // 
            tabContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            tabContainer.Controls.Add(this.tabRSM);
            tabContainer.Controls.Add(this.tabTagLocate);
            tabContainer.Controls.Add(this.tabInventory);
            tabContainer.Controls.Add(this.tabReadWrite);
            tabContainer.Controls.Add(this.tabLock);
            tabContainer.Controls.Add(this.tabKill);
            tabContainer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tabContainer.Location = new System.Drawing.Point(806, 15);
            tabContainer.Name = "tabContainer";
            tabContainer.SelectedIndex = 0;
            tabContainer.Size = new System.Drawing.Size(130, 83);
            tabContainer.TabIndex = 45;
            tabContainer.Visible = false;
            tabContainer.SelectedIndexChanged += new System.EventHandler(this.tabContainer_SelectedIndexChanged);
            // 
            // tabRSM
            // 
            this.tabRSM.Controls.Add(this.txtType);
            this.tabRSM.Controls.Add(this.txtValue);
            this.tabRSM.Controls.Add(this.txtAttribute);
            this.tabRSM.Controls.Add(this.label4);
            this.tabRSM.Controls.Add(this.label7);
            this.tabRSM.Controls.Add(this.label8);
            this.tabRSM.Controls.Add(this.btnSetAttribute);
            this.tabRSM.Controls.Add(this.btnGetAttribute);
            this.tabRSM.Location = new System.Drawing.Point(4, 24);
            this.tabRSM.Margin = new System.Windows.Forms.Padding(2);
            this.tabRSM.Name = "tabRSM";
            this.tabRSM.Padding = new System.Windows.Forms.Padding(2);
            this.tabRSM.Size = new System.Drawing.Size(122, 55);
            this.tabRSM.TabIndex = 5;
            this.tabRSM.Text = "RSM";
            this.tabRSM.UseVisualStyleBackColor = true;
            // 
            // txtType
            // 
            this.txtType.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtType.Location = new System.Drawing.Point(107, 54);
            this.txtType.Margin = new System.Windows.Forms.Padding(2);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(200, 23);
            this.txtType.TabIndex = 37;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(107, 84);
            this.txtValue.Margin = new System.Windows.Forms.Padding(2);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(200, 23);
            this.txtValue.TabIndex = 36;
            // 
            // txtAttribute
            // 
            this.txtAttribute.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtAttribute.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtAttribute.Location = new System.Drawing.Point(107, 26);
            this.txtAttribute.Margin = new System.Windows.Forms.Padding(2);
            this.txtAttribute.Name = "txtAttribute";
            this.txtAttribute.Size = new System.Drawing.Size(200, 23);
            this.txtAttribute.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(16, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "Value";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(16, 58);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 33;
            this.label7.Text = "Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(16, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 15);
            this.label8.TabIndex = 32;
            this.label8.Text = "Attribute";
            // 
            // btnSetAttribute
            // 
            this.btnSetAttribute.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSetAttribute.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSetAttribute.BackgroundImage")));
            this.btnSetAttribute.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSetAttribute.FlatAppearance.BorderSize = 0;
            this.btnSetAttribute.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSetAttribute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSetAttribute.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSetAttribute.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetAttribute.ForeColor = System.Drawing.Color.White;
            this.btnSetAttribute.Location = new System.Drawing.Point(525, 141);
            this.btnSetAttribute.Name = "btnSetAttribute";
            this.btnSetAttribute.Size = new System.Drawing.Size(123, 28);
            this.btnSetAttribute.TabIndex = 31;
            this.btnSetAttribute.Text = "SET";
            this.btnSetAttribute.UseVisualStyleBackColor = false;
            this.btnSetAttribute.Click += new System.EventHandler(this.btnSetAttribute_Click);
            // 
            // btnGetAttribute
            // 
            this.btnGetAttribute.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGetAttribute.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGetAttribute.BackgroundImage")));
            this.btnGetAttribute.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGetAttribute.FlatAppearance.BorderSize = 0;
            this.btnGetAttribute.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGetAttribute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGetAttribute.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGetAttribute.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetAttribute.ForeColor = System.Drawing.Color.White;
            this.btnGetAttribute.Location = new System.Drawing.Point(396, 141);
            this.btnGetAttribute.Name = "btnGetAttribute";
            this.btnGetAttribute.Size = new System.Drawing.Size(123, 28);
            this.btnGetAttribute.TabIndex = 30;
            this.btnGetAttribute.Text = "GET";
            this.btnGetAttribute.UseVisualStyleBackColor = false;
            this.btnGetAttribute.Click += new System.EventHandler(this.btnGetAttribute_Click);
            // 
            // tabTagLocate
            // 
            this.tabTagLocate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabTagLocate.Controls.Add(this.label2);
            this.tabTagLocate.Controls.Add(this.lblTL);
            this.tabTagLocate.Controls.Add(this.btnTagLocateStop);
            this.tabTagLocate.Location = new System.Drawing.Point(4, 24);
            this.tabTagLocate.Name = "tabTagLocate";
            this.tabTagLocate.Padding = new System.Windows.Forms.Padding(3);
            this.tabTagLocate.Size = new System.Drawing.Size(122, 55);
            this.tabTagLocate.TabIndex = 1;
            this.tabTagLocate.Text = "Tag Locate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(16, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 46;
            this.label2.Text = "Tag Id";
            // 
            // lblTL
            // 
            this.lblTL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTL.AutoSize = true;
            this.lblTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTL.Location = new System.Drawing.Point(556, 89);
            this.lblTL.Name = "lblTL";
            this.lblTL.Size = new System.Drawing.Size(24, 25);
            this.lblTL.TabIndex = 4;
            this.lblTL.Text = "0";
            this.lblTL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTagLocateStop
            // 
            this.btnTagLocateStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTagLocateStop.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTagLocateStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTagLocateStop.BackgroundImage")));
            this.btnTagLocateStop.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTagLocateStop.FlatAppearance.BorderSize = 0;
            this.btnTagLocateStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTagLocateStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTagLocateStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTagLocateStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTagLocateStop.ForeColor = System.Drawing.Color.White;
            this.btnTagLocateStop.Location = new System.Drawing.Point(987, 141);
            this.btnTagLocateStop.Name = "btnTagLocateStop";
            this.btnTagLocateStop.Size = new System.Drawing.Size(123, 28);
            this.btnTagLocateStop.TabIndex = 2;
            this.btnTagLocateStop.Text = "STOP";
            this.btnTagLocateStop.UseVisualStyleBackColor = false;
            this.btnTagLocateStop.Click += new System.EventHandler(this.BtnTagLocateStop_Click);
            // 
            // tabInventory
            // 
            this.tabInventory.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabInventory.Location = new System.Drawing.Point(4, 24);
            this.tabInventory.Name = "tabInventory";
            this.tabInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabInventory.Size = new System.Drawing.Size(122, 55);
            this.tabInventory.TabIndex = 0;
            this.tabInventory.Text = "Inventory";
            // 
            // tabReadWrite
            // 
            this.tabReadWrite.Controls.Add(this.btnWrite);
            this.tabReadWrite.Controls.Add(this.btnRead);
            this.tabReadWrite.Controls.Add(this.txtData);
            this.tabReadWrite.Controls.Add(this.txtLength);
            this.tabReadWrite.Controls.Add(this.txtOffset);
            this.tabReadWrite.Controls.Add(this.cmbMemoryBank);
            this.tabReadWrite.Controls.Add(this.txtPassword);
            this.tabReadWrite.Controls.Add(this.txtTagPattern);
            this.tabReadWrite.Controls.Add(this.labelData);
            this.tabReadWrite.Controls.Add(this.labelLength);
            this.tabReadWrite.Controls.Add(this.labelOffset);
            this.tabReadWrite.Controls.Add(this.labelMemBank);
            this.tabReadWrite.Controls.Add(this.labelPassword);
            this.tabReadWrite.Controls.Add(this.labelTagPattern);
            this.tabReadWrite.Location = new System.Drawing.Point(4, 24);
            this.tabReadWrite.Margin = new System.Windows.Forms.Padding(2);
            this.tabReadWrite.Name = "tabReadWrite";
            this.tabReadWrite.Padding = new System.Windows.Forms.Padding(2);
            this.tabReadWrite.Size = new System.Drawing.Size(122, 55);
            this.tabReadWrite.TabIndex = 2;
            this.tabReadWrite.Text = "Read / Write";
            this.tabReadWrite.UseVisualStyleBackColor = true;
            // 
            // btnWrite
            // 
            this.btnWrite.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnWrite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWrite.BackgroundImage")));
            this.btnWrite.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnWrite.FlatAppearance.BorderSize = 0;
            this.btnWrite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnWrite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnWrite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWrite.ForeColor = System.Drawing.Color.White;
            this.btnWrite.Location = new System.Drawing.Point(525, 141);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(123, 28);
            this.btnWrite.TabIndex = 29;
            this.btnWrite.Text = "WRITE";
            this.btnWrite.UseVisualStyleBackColor = false;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRead.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRead.BackgroundImage")));
            this.btnRead.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRead.FlatAppearance.BorderSize = 0;
            this.btnRead.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRead.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRead.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.ForeColor = System.Drawing.Color.White;
            this.btnRead.Location = new System.Drawing.Point(396, 141);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(123, 28);
            this.btnRead.TabIndex = 28;
            this.btnRead.Text = "READ";
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // txtData
            // 
            this.txtData.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtData.Location = new System.Drawing.Point(396, 26);
            this.txtData.Margin = new System.Windows.Forms.Padding(2);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(252, 23);
            this.txtData.TabIndex = 27;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(107, 84);
            this.txtLength.Margin = new System.Windows.Forms.Padding(2);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(200, 23);
            this.txtLength.TabIndex = 26;
            this.txtLength.Text = "0";
            // 
            // txtOffset
            // 
            this.txtOffset.Location = new System.Drawing.Point(107, 54);
            this.txtOffset.Margin = new System.Windows.Forms.Padding(2);
            this.txtOffset.Name = "txtOffset";
            this.txtOffset.Size = new System.Drawing.Size(200, 23);
            this.txtOffset.TabIndex = 25;
            this.txtOffset.Text = "2";
            // 
            // cmbMemoryBank
            // 
            this.cmbMemoryBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMemoryBank.FormattingEnabled = true;
            this.cmbMemoryBank.Location = new System.Drawing.Point(107, 141);
            this.cmbMemoryBank.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMemoryBank.Name = "cmbMemoryBank";
            this.cmbMemoryBank.Size = new System.Drawing.Size(200, 23);
            this.cmbMemoryBank.TabIndex = 24;
            // 
            // txtPassword
            // 
            this.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPassword.Location = new System.Drawing.Point(107, 110);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 23);
            this.txtPassword.TabIndex = 23;
            this.txtPassword.Text = "00";
            // 
            // txtTagPattern
            // 
            this.txtTagPattern.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTagPattern.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTagPattern.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTagPattern.Location = new System.Drawing.Point(107, 26);
            this.txtTagPattern.Margin = new System.Windows.Forms.Padding(2);
            this.txtTagPattern.Name = "txtTagPattern";
            this.txtTagPattern.Size = new System.Drawing.Size(200, 23);
            this.txtTagPattern.TabIndex = 22;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(352, 28);
            this.labelData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(31, 15);
            this.labelData.TabIndex = 21;
            this.labelData.Text = "Data";
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelLength.Location = new System.Drawing.Point(16, 87);
            this.labelLength.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(87, 15);
            this.labelLength.TabIndex = 20;
            this.labelLength.Text = "Length (words)";
            // 
            // labelOffset
            // 
            this.labelOffset.AutoSize = true;
            this.labelOffset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelOffset.Location = new System.Drawing.Point(16, 58);
            this.labelOffset.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOffset.Name = "labelOffset";
            this.labelOffset.Size = new System.Drawing.Size(82, 15);
            this.labelOffset.TabIndex = 19;
            this.labelOffset.Text = "Offset (words)";
            // 
            // labelMemBank
            // 
            this.labelMemBank.AutoSize = true;
            this.labelMemBank.Location = new System.Drawing.Point(17, 145);
            this.labelMemBank.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMemBank.Name = "labelMemBank";
            this.labelMemBank.Size = new System.Drawing.Size(81, 15);
            this.labelMemBank.TabIndex = 18;
            this.labelMemBank.Text = "Memory Bank";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPassword.Location = new System.Drawing.Point(17, 115);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(57, 15);
            this.labelPassword.TabIndex = 17;
            this.labelPassword.Text = "Password";
            // 
            // labelTagPattern
            // 
            this.labelTagPattern.AutoSize = true;
            this.labelTagPattern.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTagPattern.Location = new System.Drawing.Point(16, 28);
            this.labelTagPattern.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTagPattern.Name = "labelTagPattern";
            this.labelTagPattern.Size = new System.Drawing.Size(66, 15);
            this.labelTagPattern.TabIndex = 16;
            this.labelTagPattern.Text = "Tag Pattern";
            // 
            // tabLock
            // 
            this.tabLock.Controls.Add(this.btnLock);
            this.tabLock.Controls.Add(this.cmbLockPrivilage);
            this.tabLock.Controls.Add(this.cmbMemoryBankLock);
            this.tabLock.Controls.Add(this.txtPasswordLock);
            this.tabLock.Controls.Add(this.txtTagPatternLock);
            this.tabLock.Controls.Add(this.labelLockPrivilege);
            this.tabLock.Controls.Add(this.labelMemBankACLock);
            this.tabLock.Controls.Add(this.labelPasswordACLock);
            this.tabLock.Controls.Add(this.labelTagPatternACLock);
            this.tabLock.Location = new System.Drawing.Point(4, 24);
            this.tabLock.Margin = new System.Windows.Forms.Padding(2);
            this.tabLock.Name = "tabLock";
            this.tabLock.Padding = new System.Windows.Forms.Padding(2);
            this.tabLock.Size = new System.Drawing.Size(122, 55);
            this.tabLock.TabIndex = 3;
            this.tabLock.Text = "Lock";
            this.tabLock.UseVisualStyleBackColor = true;
            // 
            // btnLock
            // 
            this.btnLock.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLock.BackgroundImage")));
            this.btnLock.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLock.FlatAppearance.BorderSize = 0;
            this.btnLock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLock.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLock.ForeColor = System.Drawing.Color.White;
            this.btnLock.Location = new System.Drawing.Point(525, 141);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(123, 28);
            this.btnLock.TabIndex = 25;
            this.btnLock.Text = "LOCK";
            this.btnLock.UseVisualStyleBackColor = false;
            // 
            // cmbLockPrivilage
            // 
            this.cmbLockPrivilage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLockPrivilage.FormattingEnabled = true;
            this.cmbLockPrivilage.Location = new System.Drawing.Point(107, 110);
            this.cmbLockPrivilage.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLockPrivilage.Name = "cmbLockPrivilage";
            this.cmbLockPrivilage.Size = new System.Drawing.Size(200, 23);
            this.cmbLockPrivilage.TabIndex = 24;
            // 
            // cmbMemoryBankLock
            // 
            this.cmbMemoryBankLock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMemoryBankLock.FormattingEnabled = true;
            this.cmbMemoryBankLock.Location = new System.Drawing.Point(107, 84);
            this.cmbMemoryBankLock.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMemoryBankLock.Name = "cmbMemoryBankLock";
            this.cmbMemoryBankLock.Size = new System.Drawing.Size(200, 23);
            this.cmbMemoryBankLock.TabIndex = 23;
            // 
            // txtPasswordLock
            // 
            this.txtPasswordLock.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPasswordLock.Location = new System.Drawing.Point(107, 54);
            this.txtPasswordLock.Margin = new System.Windows.Forms.Padding(2);
            this.txtPasswordLock.Name = "txtPasswordLock";
            this.txtPasswordLock.Size = new System.Drawing.Size(200, 23);
            this.txtPasswordLock.TabIndex = 22;
            this.txtPasswordLock.Text = "00";
            // 
            // txtTagPatternLock
            // 
            this.txtTagPatternLock.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTagPatternLock.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTagPatternLock.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTagPatternLock.Location = new System.Drawing.Point(107, 26);
            this.txtTagPatternLock.Margin = new System.Windows.Forms.Padding(2);
            this.txtTagPatternLock.Name = "txtTagPatternLock";
            this.txtTagPatternLock.Size = new System.Drawing.Size(200, 23);
            this.txtTagPatternLock.TabIndex = 21;
            // 
            // labelLockPrivilege
            // 
            this.labelLockPrivilege.AutoSize = true;
            this.labelLockPrivilege.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelLockPrivilege.Location = new System.Drawing.Point(17, 115);
            this.labelLockPrivilege.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLockPrivilege.Name = "labelLockPrivilege";
            this.labelLockPrivilege.Size = new System.Drawing.Size(80, 15);
            this.labelLockPrivilege.TabIndex = 20;
            this.labelLockPrivilege.Text = "Lock Privilege";
            // 
            // labelMemBankACLock
            // 
            this.labelMemBankACLock.AutoSize = true;
            this.labelMemBankACLock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelMemBankACLock.Location = new System.Drawing.Point(16, 87);
            this.labelMemBankACLock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMemBankACLock.Name = "labelMemBankACLock";
            this.labelMemBankACLock.Size = new System.Drawing.Size(81, 15);
            this.labelMemBankACLock.TabIndex = 19;
            this.labelMemBankACLock.Text = "Memory Bank";
            // 
            // labelPasswordACLock
            // 
            this.labelPasswordACLock.AutoSize = true;
            this.labelPasswordACLock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPasswordACLock.Location = new System.Drawing.Point(16, 58);
            this.labelPasswordACLock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPasswordACLock.Name = "labelPasswordACLock";
            this.labelPasswordACLock.Size = new System.Drawing.Size(57, 15);
            this.labelPasswordACLock.TabIndex = 18;
            this.labelPasswordACLock.Text = "Password";
            // 
            // labelTagPatternACLock
            // 
            this.labelTagPatternACLock.AutoSize = true;
            this.labelTagPatternACLock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTagPatternACLock.Location = new System.Drawing.Point(16, 28);
            this.labelTagPatternACLock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTagPatternACLock.Name = "labelTagPatternACLock";
            this.labelTagPatternACLock.Size = new System.Drawing.Size(66, 15);
            this.labelTagPatternACLock.TabIndex = 17;
            this.labelTagPatternACLock.Text = "Tag Pattern";
            // 
            // tabKill
            // 
            this.tabKill.Controls.Add(this.btnKill);
            this.tabKill.Controls.Add(this.txtPasswordKill);
            this.tabKill.Controls.Add(this.txtTagPatternKill);
            this.tabKill.Controls.Add(this.labelKillPassword);
            this.tabKill.Controls.Add(this.labelTagPatternKill);
            this.tabKill.Location = new System.Drawing.Point(4, 24);
            this.tabKill.Margin = new System.Windows.Forms.Padding(2);
            this.tabKill.Name = "tabKill";
            this.tabKill.Padding = new System.Windows.Forms.Padding(2);
            this.tabKill.Size = new System.Drawing.Size(122, 55);
            this.tabKill.TabIndex = 4;
            this.tabKill.Text = "Kill";
            this.tabKill.UseVisualStyleBackColor = true;
            // 
            // btnKill
            // 
            this.btnKill.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKill.BackgroundImage")));
            this.btnKill.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnKill.FlatAppearance.BorderSize = 0;
            this.btnKill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnKill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnKill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKill.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKill.ForeColor = System.Drawing.Color.White;
            this.btnKill.Location = new System.Drawing.Point(525, 141);
            this.btnKill.Name = "btnKill";
            this.btnKill.Size = new System.Drawing.Size(123, 28);
            this.btnKill.TabIndex = 22;
            this.btnKill.Text = "KILL";
            this.btnKill.UseVisualStyleBackColor = false;
            // 
            // txtPasswordKill
            // 
            this.txtPasswordKill.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPasswordKill.Location = new System.Drawing.Point(107, 54);
            this.txtPasswordKill.Margin = new System.Windows.Forms.Padding(2);
            this.txtPasswordKill.Name = "txtPasswordKill";
            this.txtPasswordKill.Size = new System.Drawing.Size(200, 23);
            this.txtPasswordKill.TabIndex = 21;
            this.txtPasswordKill.Text = "00";
            // 
            // txtTagPatternKill
            // 
            this.txtTagPatternKill.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTagPatternKill.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTagPatternKill.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTagPatternKill.Location = new System.Drawing.Point(107, 26);
            this.txtTagPatternKill.Margin = new System.Windows.Forms.Padding(2);
            this.txtTagPatternKill.Name = "txtTagPatternKill";
            this.txtTagPatternKill.Size = new System.Drawing.Size(200, 23);
            this.txtTagPatternKill.TabIndex = 20;
            // 
            // labelKillPassword
            // 
            this.labelKillPassword.AutoSize = true;
            this.labelKillPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelKillPassword.Location = new System.Drawing.Point(16, 58);
            this.labelKillPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelKillPassword.Name = "labelKillPassword";
            this.labelKillPassword.Size = new System.Drawing.Size(76, 15);
            this.labelKillPassword.TabIndex = 19;
            this.labelKillPassword.Text = "Kill Password";
            // 
            // labelTagPatternKill
            // 
            this.labelTagPatternKill.AutoSize = true;
            this.labelTagPatternKill.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTagPatternKill.Location = new System.Drawing.Point(16, 28);
            this.labelTagPatternKill.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTagPatternKill.Name = "labelTagPatternKill";
            this.labelTagPatternKill.Size = new System.Drawing.Size(66, 15);
            this.labelTagPatternKill.TabIndex = 18;
            this.labelTagPatternKill.Text = "Tag Pattern";
            // 
            // txtTagId
            // 
            this.txtTagId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTagId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTagId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            this.txtTagId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTagId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTagId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTagId.Location = new System.Drawing.Point(193, 98);
            this.txtTagId.Name = "txtTagId";
            this.txtTagId.Size = new System.Drawing.Size(308, 20);
            this.txtTagId.TabIndex = 5;
            this.txtTagId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HexInput_KeyPress);
            // 
            // btnTagLocateStart
            // 
            this.btnTagLocateStart.BackColor = System.Drawing.Color.SlateBlue;
            this.btnTagLocateStart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTagLocateStart.FlatAppearance.BorderSize = 0;
            this.btnTagLocateStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTagLocateStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTagLocateStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTagLocateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTagLocateStart.ForeColor = System.Drawing.Color.White;
            this.btnTagLocateStart.Location = new System.Drawing.Point(287, 155);
            this.btnTagLocateStart.Name = "btnTagLocateStart";
            this.btnTagLocateStart.Size = new System.Drawing.Size(123, 28);
            this.btnTagLocateStart.TabIndex = 3;
            this.btnTagLocateStart.Text = "START";
            this.btnTagLocateStart.UseVisualStyleBackColor = false;
            this.btnTagLocateStart.Click += new System.EventHandler(this.BtnTagLocateStart_Click);
            // 
            // proximityPrcentBar
            // 
            this.proximityPrcentBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.proximityPrcentBar.Location = new System.Drawing.Point(193, 258);
            this.proximityPrcentBar.Name = "proximityPrcentBar";
            this.proximityPrcentBar.Size = new System.Drawing.Size(450, 23);
            this.proximityPrcentBar.TabIndex = 0;
            // 
            // btnInventoryStart
            // 
            this.btnInventoryStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInventoryStart.BackColor = System.Drawing.Color.SlateBlue;
            this.btnInventoryStart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnInventoryStart.FlatAppearance.BorderSize = 0;
            this.btnInventoryStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInventoryStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventoryStart.ForeColor = System.Drawing.Color.White;
            this.btnInventoryStart.Location = new System.Drawing.Point(-193, 20);
            this.btnInventoryStart.Name = "btnInventoryStart";
            this.btnInventoryStart.Size = new System.Drawing.Size(123, 28);
            this.btnInventoryStart.TabIndex = 3;
            this.btnInventoryStart.Text = "START";
            this.btnInventoryStart.UseVisualStyleBackColor = false;
            this.btnInventoryStart.Click += new System.EventHandler(this.BtnInventoryStart_Click);
            // 
            // btnPurgeTags
            // 
            this.btnPurgeTags.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPurgeTags.BackColor = System.Drawing.Color.SlateBlue;
            this.btnPurgeTags.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPurgeTags.FlatAppearance.BorderSize = 0;
            this.btnPurgeTags.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPurgeTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurgeTags.ForeColor = System.Drawing.Color.White;
            this.btnPurgeTags.Location = new System.Drawing.Point(-451, 20);
            this.btnPurgeTags.Name = "btnPurgeTags";
            this.btnPurgeTags.Size = new System.Drawing.Size(123, 28);
            this.btnPurgeTags.TabIndex = 44;
            this.btnPurgeTags.Text = "LIMPAR TAGS";
            this.btnPurgeTags.UseVisualStyleBackColor = false;
            this.btnPurgeTags.Click += new System.EventHandler(this.BtnPurgeTags_Click);
            // 
            // btnInventoryStop
            // 
            this.btnInventoryStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInventoryStop.BackColor = System.Drawing.Color.SlateBlue;
            this.btnInventoryStop.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnInventoryStop.FlatAppearance.BorderSize = 0;
            this.btnInventoryStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInventoryStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventoryStop.ForeColor = System.Drawing.Color.White;
            this.btnInventoryStop.Location = new System.Drawing.Point(-322, 20);
            this.btnInventoryStop.Name = "btnInventoryStop";
            this.btnInventoryStop.Size = new System.Drawing.Size(123, 28);
            this.btnInventoryStop.TabIndex = 4;
            this.btnInventoryStop.Text = "STOP";
            this.btnInventoryStop.UseVisualStyleBackColor = false;
            this.btnInventoryStop.Click += new System.EventHandler(this.BtnInventoryStop_Click);
            // 
            // grdTags
            // 
            this.grdTags.AllowUserToAddRows = false;
            this.grdTags.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grdTags.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            this.grdTags.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdTags.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdTags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdTags.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdTags.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdTags.Location = new System.Drawing.Point(-326, -72);
            this.grdTags.Margin = new System.Windows.Forms.Padding(2);
            this.grdTags.Name = "grdTags";
            this.grdTags.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdTags.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdTags.RowHeadersVisible = false;
            this.grdTags.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdTags.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grdTags.RowTemplate.Height = 24;
            this.grdTags.Size = new System.Drawing.Size(692, 245);
            this.grdTags.TabIndex = 22;
            // 
            // btnConnectDisconnect
            // 
            this.btnConnectDisconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnectDisconnect.BackColor = System.Drawing.Color.SlateBlue;
            this.btnConnectDisconnect.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConnectDisconnect.FlatAppearance.BorderSize = 0;
            this.btnConnectDisconnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConnectDisconnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnConnectDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConnectDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectDisconnect.ForeColor = System.Drawing.Color.White;
            this.btnConnectDisconnect.Location = new System.Drawing.Point(305, 9);
            this.btnConnectDisconnect.Name = "btnConnectDisconnect";
            this.btnConnectDisconnect.Size = new System.Drawing.Size(94, 28);
            this.btnConnectDisconnect.TabIndex = 1;
            this.btnConnectDisconnect.Text = "CONNECT";
            this.btnConnectDisconnect.UseVisualStyleBackColor = false;
            this.btnConnectDisconnect.Click += new System.EventHandler(this.BtnConnectDisconnect_Click);
            // 
            // lblReaders
            // 
            this.lblReaders.AutoSize = true;
            this.lblReaders.BackColor = System.Drawing.Color.Transparent;
            this.lblReaders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReaders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(242)))));
            this.lblReaders.Location = new System.Drawing.Point(46, 33);
            this.lblReaders.Margin = new System.Windows.Forms.Padding(0);
            this.lblReaders.Name = "lblReaders";
            this.lblReaders.Size = new System.Drawing.Size(71, 15);
            this.lblReaders.TabIndex = 10;
            this.lblReaders.Text = "Selecione";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsMenuItem,
            this.helpMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(291, 155);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(111, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsMenuItem
            // 
            this.settingsMenuItem.Checked = true;
            this.settingsMenuItem.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.settingsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.antennaConfiguration,
            this.capabilitiesMenuItem,
            this.configurationMenuItem,
            this.regulatory,
            this.preFilters,
            this.singulationMenuItem,
            this.tagReportingMenuItem,
            this.triggersMenuItem,
            this.versionMenuItem,
            this.toolStripSeparator1,
            this.toolStripMenuItem1,
            this.saveConfigMenuItem});
            this.settingsMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            this.settingsMenuItem.Name = "settingsMenuItem";
            this.settingsMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsMenuItem.Text = "&Settings";
            // 
            // antennaConfiguration
            // 
            this.antennaConfiguration.Name = "antennaConfiguration";
            this.antennaConfiguration.Size = new System.Drawing.Size(180, 22);
            this.antennaConfiguration.Text = "&Antenna";
            this.antennaConfiguration.Click += new System.EventHandler(this.antennaConfiguration_Click);
            // 
            // capabilitiesMenuItem
            // 
            this.capabilitiesMenuItem.Name = "capabilitiesMenuItem";
            this.capabilitiesMenuItem.Size = new System.Drawing.Size(180, 22);
            this.capabilitiesMenuItem.Text = "&Capabilities";
            this.capabilitiesMenuItem.Click += new System.EventHandler(this.CapabilitiesToolStripMenuItem_Click);
            // 
            // configurationMenuItem
            // 
            this.configurationMenuItem.Name = "configurationMenuItem";
            this.configurationMenuItem.Size = new System.Drawing.Size(180, 22);
            this.configurationMenuItem.Text = "C&onfiguration";
            this.configurationMenuItem.Click += new System.EventHandler(this.Configurations_Click);
            // 
            // regulatory
            // 
            this.regulatory.Name = "regulatory";
            this.regulatory.Size = new System.Drawing.Size(180, 22);
            this.regulatory.Text = "&Regulatory";
            this.regulatory.Click += new System.EventHandler(this.regulatory_Click);
            // 
            // preFilters
            // 
            this.preFilters.Name = "preFilters";
            this.preFilters.Size = new System.Drawing.Size(180, 22);
            this.preFilters.Text = "&Pre Filters";
            this.preFilters.Click += new System.EventHandler(this.preFilters_Click);
            // 
            // singulationMenuItem
            // 
            this.singulationMenuItem.Name = "singulationMenuItem";
            this.singulationMenuItem.Size = new System.Drawing.Size(180, 22);
            this.singulationMenuItem.Text = "&Singulation";
            this.singulationMenuItem.Click += new System.EventHandler(this.SingulationToolStripMenuItem_Click);
            // 
            // tagReportingMenuItem
            // 
            this.tagReportingMenuItem.Name = "tagReportingMenuItem";
            this.tagReportingMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tagReportingMenuItem.Text = "&Tag Reporting";
            this.tagReportingMenuItem.Click += new System.EventHandler(this.TagReportingMenuItem_Click);
            // 
            // triggersMenuItem
            // 
            this.triggersMenuItem.Name = "triggersMenuItem";
            this.triggersMenuItem.Size = new System.Drawing.Size(180, 22);
            this.triggersMenuItem.Text = "Tr&iggers";
            this.triggersMenuItem.Click += new System.EventHandler(this.TriggersToolStripMenuItem_Click);
            // 
            // versionMenuItem
            // 
            this.versionMenuItem.Name = "versionMenuItem";
            this.versionMenuItem.Size = new System.Drawing.Size(180, 22);
            this.versionMenuItem.Text = "&Version Info";
            this.versionMenuItem.Click += new System.EventHandler(this.versionMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "&Restore Default";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.BtnRestoreDefaults_Click);
            // 
            // saveConfigMenuItem
            // 
            this.saveConfigMenuItem.Name = "saveConfigMenuItem";
            this.saveConfigMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveConfigMenuItem.Text = "&Save Configuration";
            this.saveConfigMenuItem.Click += new System.EventHandler(this.BtnSaveConfig_Click);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // btnPairNew
            // 
            this.btnPairNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPairNew.BackColor = System.Drawing.Color.SlateBlue;
            this.btnPairNew.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPairNew.FlatAppearance.BorderSize = 0;
            this.btnPairNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPairNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPairNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPairNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPairNew.ForeColor = System.Drawing.Color.White;
            this.btnPairNew.Location = new System.Drawing.Point(168, 9);
            this.btnPairNew.Name = "btnPairNew";
            this.btnPairNew.Size = new System.Drawing.Size(57, 28);
            this.btnPairNew.TabIndex = 31;
            this.btnPairNew.Text = "PAIR";
            this.btnPairNew.UseVisualStyleBackColor = false;
            this.btnPairNew.Click += new System.EventHandler(this.BtnPairNew_Click);
            // 
            // btnManulConnect
            // 
            this.btnManulConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManulConnect.BackColor = System.Drawing.Color.SlateBlue;
            this.btnManulConnect.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnManulConnect.FlatAppearance.BorderSize = 0;
            this.btnManulConnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnManulConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnManulConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManulConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManulConnect.ForeColor = System.Drawing.Color.White;
            this.btnManulConnect.Location = new System.Drawing.Point(231, 9);
            this.btnManulConnect.Name = "btnManulConnect";
            this.btnManulConnect.Size = new System.Drawing.Size(68, 28);
            this.btnManulConnect.TabIndex = 52;
            this.btnManulConnect.Text = "IP / COM";
            this.btnManulConnect.UseVisualStyleBackColor = false;
            this.btnManulConnect.Click += new System.EventHandler(this.btnManulConnect_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            this.guna2Panel1.Controls.Add(this.guna2Panel3);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.guna2Panel4);
            this.guna2Panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 39);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1086, 649);
            this.guna2Panel1.TabIndex = 53;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(242)))));
            this.guna2Panel3.BorderRadius = 35;
            this.guna2Panel3.BorderThickness = 3;
            this.guna2Panel3.Controls.Add(this.label10);
            this.guna2Panel3.Controls.Add(this.guna2Button3);
            this.guna2Panel3.Controls.Add(this.guna2TextBox1);
            this.guna2Panel3.Controls.Add(this.guna2Button6);
            this.guna2Panel3.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            this.guna2Panel3.Location = new System.Drawing.Point(226, 0);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(860, 75);
            this.guna2Panel3.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(242)))));
            this.label10.Location = new System.Drawing.Point(33, 21);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 30);
            this.label10.TabIndex = 59;
            this.label10.Text = "Session RFID";
            // 
            // guna2Button3
            // 
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderRadius = 13;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(133)))), ((int)(((byte)(125)))));
            this.guna2Button3.HoverState.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.guna2Button3.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(242)))));
            this.guna2Button3.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button3.Image")));
            this.guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button3.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button3.Location = new System.Drawing.Point(197, 13);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(154, 46);
            this.guna2Button3.TabIndex = 55;
            this.guna2Button3.Text = "QR/Bar-Code";
            this.guna2Button3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(133)))), ((int)(((byte)(125)))));
            this.guna2TextBox1.BorderRadius = 14;
            this.guna2TextBox1.BorderThickness = 3;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2TextBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBox1.IconLeft")));
            this.guna2TextBox1.IconLeftSize = new System.Drawing.Size(29, 29);
            this.guna2TextBox1.Location = new System.Drawing.Point(521, 17);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "Seach";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(294, 41);
            this.guna2TextBox1.TabIndex = 0;
            // 
            // guna2Button6
            // 
            this.guna2Button6.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button6.BorderRadius = 13;
            this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button6.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(133)))), ((int)(((byte)(125)))));
            this.guna2Button6.HoverState.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.guna2Button6.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(242)))));
            this.guna2Button6.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button6.Image")));
            this.guna2Button6.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button6.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button6.Location = new System.Drawing.Point(369, 13);
            this.guna2Button6.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.Size = new System.Drawing.Size(144, 46);
            this.guna2Button6.TabIndex = 58;
            this.guna2Button6.Text = "Produtos";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(242)))));
            this.guna2Panel2.BorderRadius = 3;
            this.guna2Panel2.BorderThickness = 2;
            this.guna2Panel2.Controls.Add(this.guna2Button9);
            this.guna2Panel2.Controls.Add(this.guna2Separator1);
            this.guna2Panel2.Controls.Add(this.label9);
            this.guna2Panel2.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel2.Controls.Add(this.guna2Button8);
            this.guna2Panel2.Controls.Add(this.guna2Button7);
            this.guna2Panel2.Controls.Add(this.guna2Button5);
            this.guna2Panel2.Controls.Add(this.guna2Button4);
            this.guna2Panel2.Controls.Add(this.guna2Button1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(46)))));
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(226, 649);
            this.guna2Panel2.TabIndex = 55;
            // 
            // guna2Button9
            // 
            this.guna2Button9.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button9.BorderRadius = 13;
            this.guna2Button9.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button9.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button9.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button9.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button9.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(133)))), ((int)(((byte)(125)))));
            this.guna2Button9.HoverState.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.guna2Button9.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(242)))));
            this.guna2Button9.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button9.Image")));
            this.guna2Button9.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button9.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button9.Location = new System.Drawing.Point(9, 420);
            this.guna2Button9.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button9.Name = "guna2Button9";
            this.guna2Button9.Size = new System.Drawing.Size(206, 46);
            this.guna2Button9.TabIndex = 56;
            this.guna2Button9.Text = "Analytics";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.Location = new System.Drawing.Point(28, 162);
            this.guna2Separator1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(166, 8);
            this.guna2Separator1.TabIndex = 63;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(242)))));
            this.label9.Location = new System.Drawing.Point(50, 121);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 22);
            this.label9.TabIndex = 62;
            this.label9.Text = "User {Usuário}";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(52, 17);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(118, 84);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 61;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Button8
            // 
            this.guna2Button8.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button8.BorderRadius = 13;
            this.guna2Button8.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button8.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(133)))), ((int)(((byte)(125)))));
            this.guna2Button8.HoverState.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.guna2Button8.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(242)))));
            this.guna2Button8.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button8.Image")));
            this.guna2Button8.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button8.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button8.Location = new System.Drawing.Point(11, 575);
            this.guna2Button8.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button8.Name = "guna2Button8";
            this.guna2Button8.Size = new System.Drawing.Size(206, 46);
            this.guna2Button8.TabIndex = 60;
            this.guna2Button8.Text = "Configurações";
            // 
            // guna2Button7
            // 
            this.guna2Button7.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button7.BorderRadius = 13;
            this.guna2Button7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button7.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(133)))), ((int)(((byte)(125)))));
            this.guna2Button7.HoverState.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.guna2Button7.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(242)))));
            this.guna2Button7.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button7.Image")));
            this.guna2Button7.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button7.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button7.Location = new System.Drawing.Point(12, 504);
            this.guna2Button7.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.Size = new System.Drawing.Size(206, 46);
            this.guna2Button7.TabIndex = 59;
            this.guna2Button7.Text = "Perfil";
            // 
            // guna2Button5
            // 
            this.guna2Button5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button5.BorderRadius = 13;
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(133)))), ((int)(((byte)(125)))));
            this.guna2Button5.HoverState.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.guna2Button5.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(242)))));
            this.guna2Button5.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button5.Image")));
            this.guna2Button5.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button5.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button5.Location = new System.Drawing.Point(9, 337);
            this.guna2Button5.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(206, 46);
            this.guna2Button5.TabIndex = 57;
            this.guna2Button5.Text = "Impressora";
            // 
            // guna2Button4
            // 
            this.guna2Button4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button4.BorderRadius = 13;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(133)))), ((int)(((byte)(125)))));
            this.guna2Button4.HoverState.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.guna2Button4.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(242)))));
            this.guna2Button4.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button4.Image")));
            this.guna2Button4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button4.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button4.Location = new System.Drawing.Point(9, 266);
            this.guna2Button4.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(206, 46);
            this.guna2Button4.TabIndex = 56;
            this.guna2Button4.Text = "RFID";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 13;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(133)))), ((int)(((byte)(125)))));
            this.guna2Button1.HoverState.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(242)))));
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button1.Location = new System.Drawing.Point(9, 190);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(206, 46);
            this.guna2Button1.TabIndex = 54;
            this.guna2Button1.Text = "Inicio Menu";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2Panel4.BorderRadius = 12;
            this.guna2Panel4.BorderThickness = 3;
            this.guna2Panel4.Controls.Add(this.guna2CustomGradientPanel3);
            this.guna2Panel4.Controls.Add(this.guna2Panel9);
            this.guna2Panel4.Controls.Add(this.guna2Panel8);
            this.guna2Panel4.Controls.Add(this.guna2CustomGradientPanel1);
            this.guna2Panel4.Controls.Add(this.guna2Panel7);
            this.guna2Panel4.Controls.Add(this.guna2Panel6);
            this.guna2Panel4.Controls.Add(this.guna2CustomGradientPanel2);
            this.guna2Panel4.Controls.Add(this.guna2Panel5);
            this.guna2Panel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            this.guna2Panel4.Location = new System.Drawing.Point(241, 89);
            this.guna2Panel4.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(824, 543);
            this.guna2Panel4.TabIndex = 57;
            // 
            // guna2CustomGradientPanel3
            // 
            this.guna2CustomGradientPanel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(133)))), ((int)(((byte)(125)))));
            this.guna2CustomGradientPanel3.BorderRadius = 22;
            this.guna2CustomGradientPanel3.BorderThickness = 2;
            this.guna2CustomGradientPanel3.Controls.Add(this.guna2Panel10);
            this.guna2CustomGradientPanel3.Controls.Add(this.label12);
            this.guna2CustomGradientPanel3.Controls.Add(this.guna2Button10);
            this.guna2CustomGradientPanel3.Controls.Add(this.proximityPrcentBar);
            this.guna2CustomGradientPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2CustomGradientPanel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            this.guna2CustomGradientPanel3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            this.guna2CustomGradientPanel3.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            this.guna2CustomGradientPanel3.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            this.guna2CustomGradientPanel3.Location = new System.Drawing.Point(0, 246);
            this.guna2CustomGradientPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2CustomGradientPanel3.Name = "guna2CustomGradientPanel3";
            this.guna2CustomGradientPanel3.Size = new System.Drawing.Size(824, 297);
            this.guna2CustomGradientPanel3.TabIndex = 70;
            // 
            // guna2Panel10
            // 
            this.guna2Panel10.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.guna2Panel10.BorderRadius = 28;
            this.guna2Panel10.BorderThickness = 2;
            this.guna2Panel10.Controls.Add(this.guna2Button26);
            this.guna2Panel10.Controls.Add(this.label15);
            this.guna2Panel10.Controls.Add(this.txtTagId);
            this.guna2Panel10.Controls.Add(this.label11);
            this.guna2Panel10.Controls.Add(this.btnTagLocateStart);
            this.guna2Panel10.Controls.Add(this.menuStrip1);
            this.guna2Panel10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            this.guna2Panel10.Location = new System.Drawing.Point(71, 14);
            this.guna2Panel10.Name = "guna2Panel10";
            this.guna2Panel10.Size = new System.Drawing.Size(691, 222);
            this.guna2Panel10.TabIndex = 65;
            // 
            // guna2Button26
            // 
            this.guna2Button26.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button26.BorderRadius = 19;
            this.guna2Button26.BorderThickness = 1;
            this.guna2Button26.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button26.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button26.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button26.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button26.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            this.guna2Button26.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.guna2Button26.ForeColor = System.Drawing.Color.White;
            this.guna2Button26.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button26.Image")));
            this.guna2Button26.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button26.Location = new System.Drawing.Point(517, 88);
            this.guna2Button26.Name = "guna2Button26";
            this.guna2Button26.Size = new System.Drawing.Size(42, 42);
            this.guna2Button26.TabIndex = 61;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(279, 71);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(133, 18);
            this.label15.TabIndex = 17;
            this.label15.Text = "Tag Identificador";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(35, 15);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 25);
            this.label11.TabIndex = 16;
            this.label11.Text = "Localizador: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(347, 239);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(151, 15);
            this.label12.TabIndex = 6;
            this.label12.Text = "Localizador Progresso";
            // 
            // guna2Button10
            // 
            this.guna2Button10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button10.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button10.BorderRadius = 5;
            this.guna2Button10.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button10.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button10.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button10.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button10.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button10.ForeColor = System.Drawing.Color.White;
            this.guna2Button10.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2Button10.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button10.Image")));
            this.guna2Button10.ImageSize = new System.Drawing.Size(23, 23);
            this.guna2Button10.Location = new System.Drawing.Point(771, 2);
            this.guna2Button10.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button10.Name = "guna2Button10";
            this.guna2Button10.Size = new System.Drawing.Size(38, 37);
            this.guna2Button10.TabIndex = 64;
            this.guna2Button10.Click += new System.EventHandler(this.guna2Button10_Click);
            // 
            // guna2Panel9
            // 
            this.guna2Panel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(133)))), ((int)(((byte)(125)))));
            this.guna2Panel9.BorderRadius = 26;
            this.guna2Panel9.BorderThickness = 2;
            this.guna2Panel9.Controls.Add(this.guna2PictureBox3);
            this.guna2Panel9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(46)))));
            this.guna2Panel9.Location = new System.Drawing.Point(14, 15);
            this.guna2Panel9.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel9.Name = "guna2Panel9";
            this.guna2Panel9.Size = new System.Drawing.Size(185, 157);
            this.guna2Panel9.TabIndex = 69;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(18, 12);
            this.guna2PictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(150, 128);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox3.TabIndex = 0;
            this.guna2PictureBox3.TabStop = false;
            // 
            // guna2Panel8
            // 
            this.guna2Panel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel8.BorderRadius = 17;
            this.guna2Panel8.Controls.Add(this.guna2Button22);
            this.guna2Panel8.Controls.Add(this.label5);
            this.guna2Panel8.Controls.Add(this.guna2Button12);
            this.guna2Panel8.Controls.Add(this.label3);
            this.guna2Panel8.Controls.Add(this.guna2Button15);
            this.guna2Panel8.Controls.Add(this.lblBatteryLevel);
            this.guna2Panel8.Controls.Add(this.label6);
            this.guna2Panel8.Controls.Add(this.lblTemperature);
            this.guna2Panel8.Controls.Add(this.lblPower);
            this.guna2Panel8.FillColor = System.Drawing.Color.SlateBlue;
            this.guna2Panel8.Location = new System.Drawing.Point(204, 110);
            this.guna2Panel8.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel8.Name = "guna2Panel8";
            this.guna2Panel8.Size = new System.Drawing.Size(414, 67);
            this.guna2Panel8.TabIndex = 67;
            // 
            // guna2Button22
            // 
            this.guna2Button22.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button22.BorderRadius = 5;
            this.guna2Button22.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button22.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button22.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button22.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button22.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button22.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button22.ForeColor = System.Drawing.Color.White;
            this.guna2Button22.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Button22.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button22.Image")));
            this.guna2Button22.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button22.Location = new System.Drawing.Point(286, 6);
            this.guna2Button22.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button22.Name = "guna2Button22";
            this.guna2Button22.Size = new System.Drawing.Size(38, 37);
            this.guna2Button22.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(155, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 15);
            this.label5.TabIndex = 48;
            this.label5.Text = "Radio Temperature :";
            // 
            // guna2Button12
            // 
            this.guna2Button12.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button12.BorderRadius = 5;
            this.guna2Button12.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button12.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button12.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button12.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button12.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button12.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button12.ForeColor = System.Drawing.Color.White;
            this.guna2Button12.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Button12.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button12.Image")));
            this.guna2Button12.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button12.Location = new System.Drawing.Point(158, 6);
            this.guna2Button12.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button12.Name = "guna2Button12";
            this.guna2Button12.Size = new System.Drawing.Size(38, 37);
            this.guna2Button12.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(27, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 46;
            this.label3.Text = "Battery Level :";
            // 
            // guna2Button15
            // 
            this.guna2Button15.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button15.BorderRadius = 5;
            this.guna2Button15.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button15.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button15.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button15.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button15.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button15.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button15.ForeColor = System.Drawing.Color.White;
            this.guna2Button15.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Button15.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button15.Image")));
            this.guna2Button15.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button15.Location = new System.Drawing.Point(37, 6);
            this.guna2Button15.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button15.Name = "guna2Button15";
            this.guna2Button15.Size = new System.Drawing.Size(38, 37);
            this.guna2Button15.TabIndex = 58;
            // 
            // lblBatteryLevel
            // 
            this.lblBatteryLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBatteryLevel.AutoSize = true;
            this.lblBatteryLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblBatteryLevel.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatteryLevel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBatteryLevel.Location = new System.Drawing.Point(77, 11);
            this.lblBatteryLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBatteryLevel.Name = "lblBatteryLevel";
            this.lblBatteryLevel.Size = new System.Drawing.Size(37, 25);
            this.lblBatteryLevel.TabIndex = 49;
            this.lblBatteryLevel.Text = "0%";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(318, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 51;
            this.label6.Text = "Power :";
            // 
            // lblTemperature
            // 
            this.lblTemperature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.BackColor = System.Drawing.Color.Transparent;
            this.lblTemperature.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Bold);
            this.lblTemperature.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTemperature.Location = new System.Drawing.Point(200, 11);
            this.lblTemperature.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(40, 25);
            this.lblTemperature.TabIndex = 47;
            this.lblTemperature.Text = "0 C";
            // 
            // lblPower
            // 
            this.lblPower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPower.AutoSize = true;
            this.lblPower.BackColor = System.Drawing.Color.Transparent;
            this.lblPower.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Bold);
            this.lblPower.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPower.Location = new System.Drawing.Point(326, 12);
            this.lblPower.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(37, 25);
            this.lblPower.TabIndex = 50;
            this.lblPower.Text = "0 v";
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(133)))), ((int)(((byte)(125)))));
            this.guna2CustomGradientPanel1.BorderRadius = 22;
            this.guna2CustomGradientPanel1.BorderThickness = 2;
            this.guna2CustomGradientPanel1.Controls.Add(this.btnPurgeTags);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnInventoryStart);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnInventoryStop);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2Button21);
            this.guna2CustomGradientPanel1.Controls.Add(this.grdTags);
            this.guna2CustomGradientPanel1.Controls.Add(this.label14);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.SlateBlue;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.SlateBlue;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(809, 110);
            this.guna2CustomGradientPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(11, 48);
            this.guna2CustomGradientPanel1.TabIndex = 66;
            // 
            // guna2Button21
            // 
            this.guna2Button21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button21.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button21.BorderRadius = 5;
            this.guna2Button21.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button21.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button21.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button21.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button21.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button21.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button21.ForeColor = System.Drawing.Color.White;
            this.guna2Button21.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2Button21.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button21.Image")));
            this.guna2Button21.ImageSize = new System.Drawing.Size(23, 23);
            this.guna2Button21.Location = new System.Drawing.Point(-43, 2);
            this.guna2Button21.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button21.Name = "guna2Button21";
            this.guna2Button21.Size = new System.Drawing.Size(38, 37);
            this.guna2Button21.TabIndex = 64;
            this.guna2Button21.Click += new System.EventHandler(this.guna2Button21_Click);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(-721, 15);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 25);
            this.label14.TabIndex = 16;
            this.label14.Text = "Inventário";
            // 
            // guna2Panel7
            // 
            this.guna2Panel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel7.BorderRadius = 17;
            this.guna2Panel7.Controls.Add(this.lblReaders);
            this.guna2Panel7.Controls.Add(this.comboBoxReaders);
            this.guna2Panel7.Controls.Add(this.btnConnectDisconnect);
            this.guna2Panel7.Controls.Add(this.btnManulConnect);
            this.guna2Panel7.Controls.Add(this.btnPairNew);
            this.guna2Panel7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            this.guna2Panel7.Location = new System.Drawing.Point(204, 15);
            this.guna2Panel7.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel7.Name = "guna2Panel7";
            this.guna2Panel7.Size = new System.Drawing.Size(414, 86);
            this.guna2Panel7.TabIndex = 64;
            // 
            // comboBoxReaders
            // 
            this.comboBoxReaders.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxReaders.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(133)))), ((int)(((byte)(125)))));
            this.comboBoxReaders.BorderRadius = 12;
            this.comboBoxReaders.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxReaders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReaders.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            this.comboBoxReaders.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxReaders.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxReaders.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.comboBoxReaders.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.comboBoxReaders.HoverState.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxReaders.HoverState.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBoxReaders.ItemHeight = 23;
            this.comboBoxReaders.Location = new System.Drawing.Point(48, 50);
            this.comboBoxReaders.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxReaders.Name = "comboBoxReaders";
            this.comboBoxReaders.Size = new System.Drawing.Size(294, 29);
            this.comboBoxReaders.TabIndex = 55;
            this.comboBoxReaders.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(133)))), ((int)(((byte)(125)))));
            this.guna2Panel6.BorderRadius = 18;
            this.guna2Panel6.BorderThickness = 2;
            this.guna2Panel6.Controls.Add(this.guna2Button19);
            this.guna2Panel6.Controls.Add(this.guna2Button20);
            this.guna2Panel6.Controls.Add(this.guna2Button18);
            this.guna2Panel6.Controls.Add(this.guna2Button17);
            this.guna2Panel6.Controls.Add(this.guna2Button16);
            this.guna2Panel6.Controls.Add(this.guna2Button11);
            this.guna2Panel6.Controls.Add(this.guna2Button14);
            this.guna2Panel6.Controls.Add(this.guna2Button13);
            this.guna2Panel6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(46)))));
            this.guna2Panel6.Location = new System.Drawing.Point(14, 184);
            this.guna2Panel6.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Size = new System.Drawing.Size(801, 44);
            this.guna2Panel6.TabIndex = 55;
            // 
            // guna2Button19
            // 
            this.guna2Button19.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button19.BorderRadius = 5;
            this.guna2Button19.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button19.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button19.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button19.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button19.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button19.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button19.ForeColor = System.Drawing.Color.White;
            this.guna2Button19.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Button19.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button19.Image")));
            this.guna2Button19.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button19.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button19.Location = new System.Drawing.Point(551, 3);
            this.guna2Button19.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button19.Name = "guna2Button19";
            this.guna2Button19.Size = new System.Drawing.Size(78, 37);
            this.guna2Button19.TabIndex = 62;
            this.guna2Button19.Text = "Kill";
            this.guna2Button19.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // guna2Button20
            // 
            this.guna2Button20.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button20.BorderRadius = 5;
            this.guna2Button20.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button20.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button20.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button20.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button20.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button20.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button20.ForeColor = System.Drawing.Color.White;
            this.guna2Button20.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Button20.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button20.Image")));
            this.guna2Button20.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button20.Location = new System.Drawing.Point(752, 3);
            this.guna2Button20.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button20.Name = "guna2Button20";
            this.guna2Button20.Size = new System.Drawing.Size(38, 37);
            this.guna2Button20.TabIndex = 68;
            // 
            // guna2Button18
            // 
            this.guna2Button18.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button18.BorderRadius = 5;
            this.guna2Button18.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button18.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button18.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button18.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button18.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button18.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button18.ForeColor = System.Drawing.Color.White;
            this.guna2Button18.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Button18.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button18.Image")));
            this.guna2Button18.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button18.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button18.Location = new System.Drawing.Point(442, 3);
            this.guna2Button18.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button18.Name = "guna2Button18";
            this.guna2Button18.Size = new System.Drawing.Size(105, 37);
            this.guna2Button18.TabIndex = 61;
            this.guna2Button18.Text = "Locked";
            this.guna2Button18.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // guna2Button17
            // 
            this.guna2Button17.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button17.BorderRadius = 5;
            this.guna2Button17.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button17.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button17.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button17.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button17.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button17.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button17.ForeColor = System.Drawing.Color.White;
            this.guna2Button17.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Button17.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button17.Image")));
            this.guna2Button17.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button17.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button17.Location = new System.Drawing.Point(326, 3);
            this.guna2Button17.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button17.Name = "guna2Button17";
            this.guna2Button17.Size = new System.Drawing.Size(120, 37);
            this.guna2Button17.TabIndex = 60;
            this.guna2Button17.Text = "Read / Write";
            this.guna2Button17.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // guna2Button16
            // 
            this.guna2Button16.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button16.BorderRadius = 5;
            this.guna2Button16.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button16.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button16.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button16.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button16.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button16.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button16.ForeColor = System.Drawing.Color.White;
            this.guna2Button16.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Button16.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button16.Image")));
            this.guna2Button16.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button16.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button16.Location = new System.Drawing.Point(204, 3);
            this.guna2Button16.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button16.Name = "guna2Button16";
            this.guna2Button16.Size = new System.Drawing.Size(118, 37);
            this.guna2Button16.TabIndex = 59;
            this.guna2Button16.Text = "Localizador";
            this.guna2Button16.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button16.Click += new System.EventHandler(this.guna2Button16_Click);
            // 
            // guna2Button11
            // 
            this.guna2Button11.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button11.BorderRadius = 5;
            this.guna2Button11.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button11.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button11.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button11.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button11.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button11.ForeColor = System.Drawing.Color.White;
            this.guna2Button11.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Button11.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button11.Image")));
            this.guna2Button11.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button11.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button11.Location = new System.Drawing.Point(93, 2);
            this.guna2Button11.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button11.Name = "guna2Button11";
            this.guna2Button11.Size = new System.Drawing.Size(120, 37);
            this.guna2Button11.TabIndex = 58;
            this.guna2Button11.Text = "Inventario";
            this.guna2Button11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button11.Click += new System.EventHandler(this.guna2Button11_Click);
            // 
            // guna2Button14
            // 
            this.guna2Button14.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button14.BorderRadius = 5;
            this.guna2Button14.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button14.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button14.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button14.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button14.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button14.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button14.ForeColor = System.Drawing.Color.White;
            this.guna2Button14.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Button14.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button14.Image")));
            this.guna2Button14.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button14.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button14.Location = new System.Drawing.Point(643, 3);
            this.guna2Button14.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button14.Name = "guna2Button14";
            this.guna2Button14.Size = new System.Drawing.Size(90, 37);
            this.guna2Button14.TabIndex = 57;
            this.guna2Button14.Text = "Ajuda";
            this.guna2Button14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // guna2Button13
            // 
            this.guna2Button13.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button13.BorderRadius = 5;
            this.guna2Button13.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button13.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button13.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button13.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button13.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button13.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button13.ForeColor = System.Drawing.Color.White;
            this.guna2Button13.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Button13.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button13.Image")));
            this.guna2Button13.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button13.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button13.Location = new System.Drawing.Point(9, 2);
            this.guna2Button13.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button13.Name = "guna2Button13";
            this.guna2Button13.Size = new System.Drawing.Size(83, 37);
            this.guna2Button13.TabIndex = 56;
            this.guna2Button13.Text = "Logs";
            this.guna2Button13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button13.Click += new System.EventHandler(this.guna2Button13_Click);
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(133)))), ((int)(((byte)(125)))));
            this.guna2CustomGradientPanel2.BorderRadius = 22;
            this.guna2CustomGradientPanel2.BorderThickness = 2;
            this.guna2CustomGradientPanel2.Controls.Add(this.guna2Button23);
            this.guna2CustomGradientPanel2.Controls.Add(this.guna2Button24);
            this.guna2CustomGradientPanel2.Controls.Add(this.txtOutput);
            this.guna2CustomGradientPanel2.Controls.Add(this.label13);
            this.guna2CustomGradientPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(46)))));
            this.guna2CustomGradientPanel2.FillColor2 = System.Drawing.SystemColors.ActiveCaption;
            this.guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            this.guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(805, 172);
            this.guna2CustomGradientPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(10, 11);
            this.guna2CustomGradientPanel2.TabIndex = 65;
            this.guna2CustomGradientPanel2.Visible = false;
            // 
            // guna2Button23
            // 
            this.guna2Button23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button23.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button23.BorderRadius = 5;
            this.guna2Button23.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button23.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button23.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button23.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button23.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button23.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button23.ForeColor = System.Drawing.Color.White;
            this.guna2Button23.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2Button23.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button23.Image")));
            this.guna2Button23.ImageSize = new System.Drawing.Size(23, 23);
            this.guna2Button23.Location = new System.Drawing.Point(-43, 2);
            this.guna2Button23.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button23.Name = "guna2Button23";
            this.guna2Button23.Size = new System.Drawing.Size(38, 37);
            this.guna2Button23.TabIndex = 64;
            this.guna2Button23.Click += new System.EventHandler(this.guna2Button23_Click);
            // 
            // guna2Button24
            // 
            this.guna2Button24.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button24.BorderRadius = 5;
            this.guna2Button24.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button24.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button24.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button24.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button24.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button24.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button24.ForeColor = System.Drawing.Color.White;
            this.guna2Button24.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Button24.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button24.Image")));
            this.guna2Button24.ImageSize = new System.Drawing.Size(100, 100);
            this.guna2Button24.Location = new System.Drawing.Point(40, 15);
            this.guna2Button24.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button24.Name = "guna2Button24";
            this.guna2Button24.Size = new System.Drawing.Size(82, 85);
            this.guna2Button24.TabIndex = 64;
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            this.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOutput.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtOutput.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtOutput.Location = new System.Drawing.Point(-610, -90);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(601, 220);
            this.txtOutput.TabIndex = 5;
            this.txtOutput.TabStop = false;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(-588, 15);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 25);
            this.label13.TabIndex = 16;
            this.label13.Text = "Logs:";
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(133)))), ((int)(((byte)(125)))));
            this.guna2Panel5.BorderRadius = 26;
            this.guna2Panel5.BorderThickness = 2;
            this.guna2Panel5.Controls.Add(this.guna2PictureBox2);
            this.guna2Panel5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(46)))));
            this.guna2Panel5.Location = new System.Drawing.Point(622, 15);
            this.guna2Panel5.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(185, 156);
            this.guna2Panel5.TabIndex = 53;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(14, 9);
            this.guna2PictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(158, 128);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 0;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(242)))));
            this.label1.Location = new System.Drawing.Point(46, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 55;
            this.label1.Text = "RFID {Manager}";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BorderRadius = 9;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1046, 7);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(34, 24);
            this.guna2ControlBox1.TabIndex = 56;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BorderRadius = 9;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1007, 7);
            this.guna2ControlBox2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(34, 24);
            this.guna2ControlBox2.TabIndex = 57;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.BorderRadius = 9;
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(969, 7);
            this.guna2ControlBox3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(34, 24);
            this.guna2ControlBox3.TabIndex = 58;
            // 
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
            this.guna2Button2.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2Button2.Location = new System.Drawing.Point(9, 2);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(33, 32);
            this.guna2Button2.TabIndex = 55;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1088, 691);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(tabContainer);
            this.Controls.Add(this.guna2ControlBox3);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2Panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(716, 531);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAppMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmAppMain_Load);
            tabContainer.ResumeLayout(false);
            this.tabRSM.ResumeLayout(false);
            this.tabRSM.PerformLayout();
            this.tabTagLocate.ResumeLayout(false);
            this.tabTagLocate.PerformLayout();
            this.tabReadWrite.ResumeLayout(false);
            this.tabReadWrite.PerformLayout();
            this.tabLock.ResumeLayout(false);
            this.tabLock.PerformLayout();
            this.tabKill.ResumeLayout(false);
            this.tabKill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTags)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2CustomGradientPanel3.ResumeLayout(false);
            this.guna2CustomGradientPanel3.PerformLayout();
            this.guna2Panel10.ResumeLayout(false);
            this.guna2Panel10.PerformLayout();
            this.guna2Panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.guna2Panel8.ResumeLayout(false);
            this.guna2Panel8.PerformLayout();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.guna2Panel7.ResumeLayout(false);
            this.guna2Panel7.PerformLayout();
            this.guna2Panel6.ResumeLayout(false);
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.guna2CustomGradientPanel2.PerformLayout();
            this.guna2Panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnConnectDisconnect;
        private Button btnInventoryStart;
        private Button btnInventoryStop;
        private Label lblReaders;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem settingsMenuItem;
        private ToolStripMenuItem configurationMenuItem;
        private DataGridView grdTags;
        private Button btnPairNew;
        private Button btnPurgeTags;
        private ToolStripMenuItem capabilitiesMenuItem;
        private ToolStripMenuItem singulationMenuItem;
        private ToolStripMenuItem triggersMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem saveConfigMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem tagReportingMenuItem;
        private TabPage tabInventory;
        private TabPage tabTagLocate;
        private Button btnTagLocateStart;
        private Button btnTagLocateStop;
        private ProgressBar proximityPrcentBar;
        private Label lblTL;
        private Label label2;
        private TextBox txtTagId;
        private ToolStripMenuItem antennaConfiguration;
        private ToolStripMenuItem regulatory;
        private ToolStripMenuItem preFilters;
        private TabPage tabReadWrite;
        private ToolStripMenuItem versionMenuItem;
        private Button btnManulConnect;
        private TabPage tabLock;
        private TabPage tabKill;
        private TabPage tabRSM;
        private Button btnWrite;
        private Button btnRead;
        private TextBox txtData;
        private TextBox txtLength;
        private TextBox txtOffset;
        private ComboBox cmbMemoryBank;
        private TextBox txtPassword;
        private TextBox txtTagPattern;
        private Label labelData;
        private Label labelLength;
        private Label labelOffset;
        private Label labelMemBank;
        private Label labelPassword;
        private Label labelTagPattern;
        private Button btnLock;
        private ComboBox cmbLockPrivilage;
        private ComboBox cmbMemoryBankLock;
        private TextBox txtPasswordLock;
        private TextBox txtTagPatternLock;
        private Label labelLockPrivilege;
        private Label labelMemBankACLock;
        private Label labelPasswordACLock;
        private Label labelTagPatternACLock;
        private Button btnKill;
        private TextBox txtPasswordKill;
        private TextBox txtTagPatternKill;
        private Label labelKillPassword;
        private Label labelTagPatternKill;
        private Button btnSetAttribute;
        private Button btnGetAttribute;
        private TextBox txtValue;
        private TextBox txtAttribute;
        private Label label4;
        private Label label7;
        private Label label8;
        private TextBox txtType;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button8;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Label label9;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Button guna2Button9;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private InTheHand.Net.Bluetooth.BluetoothComponent bluetoothComponent1;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxReaders;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private Guna.UI2.WinForms.Guna2Button guna2Button13;
        private Guna.UI2.WinForms.Guna2Button guna2Button14;
        private Guna.UI2.WinForms.Guna2Button guna2Button15;
        private Guna.UI2.WinForms.Guna2Button guna2Button11;
        private Guna.UI2.WinForms.Guna2Button guna2Button19;
        private Guna.UI2.WinForms.Guna2Button guna2Button18;
        private Guna.UI2.WinForms.Guna2Button guna2Button17;
        private Guna.UI2.WinForms.Guna2Button guna2Button16;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Guna.UI2.WinForms.Guna2Button guna2Button23;
        private Guna.UI2.WinForms.Guna2Button guna2Button24;
        private TextBox txtOutput;
        private Label label13;
        private Label label5;
        private Label label3;
        private Label lblBatteryLevel;
        private Label lblTemperature;
        private Label label6;
        private Label lblPower;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button21;
        private Label label14;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel8;
        private Guna.UI2.WinForms.Guna2Button guna2Button22;
        private Guna.UI2.WinForms.Guna2Button guna2Button12;
        private Guna.UI2.WinForms.Guna2Button guna2Button20;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel9;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Label label10;
        private ToolStripMenuItem helpMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel3;
        private Guna.UI2.WinForms.Guna2Button guna2Button10;
        private Label label11;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel10;
        private Label label15;
        private Label label12;
        private Guna.UI2.WinForms.Guna2Button guna2Button26;
    }
}


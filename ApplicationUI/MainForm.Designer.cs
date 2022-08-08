namespace ApplicationUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.titlePicture = new System.Windows.Forms.PictureBox();
            this.inventoryButton = new System.Windows.Forms.Button();
            this.manageButton = new System.Windows.Forms.Button();
            this.roadmapButton = new System.Windows.Forms.Button();
            this.roadmapPanel = new System.Windows.Forms.Panel();
            this.advancedFilterCombo = new System.Windows.Forms.ComboBox();
            this.filterCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.highestPriorityList = new System.Windows.Forms.ListBox();
            this.mostDemandedList = new System.Windows.Forms.ListBox();
            this.thisWeekTopicsList = new System.Windows.Forms.ListBox();
            this.closeButtonPicture = new System.Windows.Forms.PictureBox();
            this.minimizePictureButton = new System.Windows.Forms.PictureBox();
            this.inventoryPanel = new System.Windows.Forms.Panel();
            this.selectedNameText = new System.Windows.Forms.TextBox();
            this.addDemandNum = new System.Windows.Forms.NumericUpDown();
            this.changePriorityCombo = new System.Windows.Forms.ComboBox();
            this.selectTypeInventoryCombo = new System.Windows.Forms.ComboBox();
            this.changeCategoryCombo = new System.Windows.Forms.ComboBox();
            this.addDemandButton = new System.Windows.Forms.Button();
            this.changeNameButton = new System.Windows.Forms.Button();
            this.deleteItemButton = new System.Windows.Forms.Button();
            this.addDemandLabel = new System.Windows.Forms.Label();
            this.changePriorityLevelLabel = new System.Windows.Forms.Label();
            this.changeCategoryLabel = new System.Windows.Forms.Label();
            this.inventoryList = new System.Windows.Forms.ListBox();
            this.managementPanel = new System.Windows.Forms.Panel();
            this.descriptionText = new System.Windows.Forms.TextBox();
            this.priorityCombo = new System.Windows.Forms.ComboBox();
            this.addNewButton = new System.Windows.Forms.Button();
            this.categoryCombo = new System.Windows.Forms.ComboBox();
            this.chooseTypeCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.priorityNewTopicLabel = new System.Windows.Forms.Label();
            this.categoryNewTopicLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.priorityList = new System.Windows.Forms.ListBox();
            this.categoryList = new System.Windows.Forms.ListBox();
            this.weightLabel = new System.Windows.Forms.Label();
            this.weightNum = new System.Windows.Forms.NumericUpDown();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titlePicture)).BeginInit();
            this.roadmapPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButtonPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureButton)).BeginInit();
            this.inventoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addDemandNum)).BeginInit();
            this.managementPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weightNum)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.SlateBlue;
            this.mainPanel.Controls.Add(this.titlePicture);
            this.mainPanel.Controls.Add(this.inventoryButton);
            this.mainPanel.Controls.Add(this.manageButton);
            this.mainPanel.Controls.Add(this.roadmapButton);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(193, 683);
            this.mainPanel.TabIndex = 0;
            // 
            // titlePicture
            // 
            this.titlePicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titlePicture.Image = ((System.Drawing.Image)(resources.GetObject("titlePicture.Image")));
            this.titlePicture.Location = new System.Drawing.Point(29, 31);
            this.titlePicture.Name = "titlePicture";
            this.titlePicture.Size = new System.Drawing.Size(134, 80);
            this.titlePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.titlePicture.TabIndex = 2;
            this.titlePicture.TabStop = false;
            // 
            // inventoryButton
            // 
            this.inventoryButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.inventoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryButton.Location = new System.Drawing.Point(29, 407);
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.Size = new System.Drawing.Size(134, 44);
            this.inventoryButton.TabIndex = 1;
            this.inventoryButton.Text = "Inventory";
            this.inventoryButton.UseVisualStyleBackColor = false;
            this.inventoryButton.Click += new System.EventHandler(this.inventoryButton_Click);
            // 
            // manageButton
            // 
            this.manageButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.manageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageButton.Location = new System.Drawing.Point(29, 298);
            this.manageButton.Name = "manageButton";
            this.manageButton.Size = new System.Drawing.Size(134, 44);
            this.manageButton.TabIndex = 1;
            this.manageButton.Text = "Manage";
            this.manageButton.UseVisualStyleBackColor = false;
            this.manageButton.Click += new System.EventHandler(this.manageButton_Click);
            // 
            // roadmapButton
            // 
            this.roadmapButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.roadmapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roadmapButton.Location = new System.Drawing.Point(29, 196);
            this.roadmapButton.Name = "roadmapButton";
            this.roadmapButton.Size = new System.Drawing.Size(134, 44);
            this.roadmapButton.TabIndex = 1;
            this.roadmapButton.Text = "Roadmap";
            this.roadmapButton.UseVisualStyleBackColor = false;
            this.roadmapButton.Click += new System.EventHandler(this.roadmapButton_Click);
            // 
            // roadmapPanel
            // 
            this.roadmapPanel.Controls.Add(this.advancedFilterCombo);
            this.roadmapPanel.Controls.Add(this.filterCombo);
            this.roadmapPanel.Controls.Add(this.label3);
            this.roadmapPanel.Controls.Add(this.label2);
            this.roadmapPanel.Controls.Add(this.label9);
            this.roadmapPanel.Controls.Add(this.label1);
            this.roadmapPanel.Controls.Add(this.highestPriorityList);
            this.roadmapPanel.Controls.Add(this.mostDemandedList);
            this.roadmapPanel.Controls.Add(this.thisWeekTopicsList);
            this.roadmapPanel.Location = new System.Drawing.Point(199, 69);
            this.roadmapPanel.Name = "roadmapPanel";
            this.roadmapPanel.Size = new System.Drawing.Size(892, 613);
            this.roadmapPanel.TabIndex = 1;
            this.roadmapPanel.Visible = false;
            // 
            // advancedFilterCombo
            // 
            this.advancedFilterCombo.BackColor = System.Drawing.Color.SlateBlue;
            this.advancedFilterCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advancedFilterCombo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.advancedFilterCombo.FormattingEnabled = true;
            this.advancedFilterCombo.Location = new System.Drawing.Point(442, 33);
            this.advancedFilterCombo.Name = "advancedFilterCombo";
            this.advancedFilterCombo.Size = new System.Drawing.Size(242, 28);
            this.advancedFilterCombo.TabIndex = 2;
            this.advancedFilterCombo.Visible = false;
            this.advancedFilterCombo.SelectedIndexChanged += new System.EventHandler(this.advancedFilterCombo_SelectedIndexChanged);
            // 
            // filterCombo
            // 
            this.filterCombo.BackColor = System.Drawing.Color.SlateBlue;
            this.filterCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterCombo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.filterCombo.FormattingEnabled = true;
            this.filterCombo.Items.AddRange(new object[] {
            "None",
            "Category",
            "Priority level"});
            this.filterCombo.Location = new System.Drawing.Point(191, 32);
            this.filterCombo.Name = "filterCombo";
            this.filterCombo.Size = new System.Drawing.Size(199, 28);
            this.filterCombo.TabIndex = 2;
            this.filterCombo.SelectedIndexChanged += new System.EventHandler(this.filterCombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(472, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "Highest Priority";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Most Demanded";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 37);
            this.label9.TabIndex = 1;
            this.label9.Text = "Filter By";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(472, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "What to Learn this Week";
            // 
            // highestPriorityList
            // 
            this.highestPriorityList.BackColor = System.Drawing.Color.SlateBlue;
            this.highestPriorityList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highestPriorityList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.highestPriorityList.FormattingEnabled = true;
            this.highestPriorityList.ItemHeight = 25;
            this.highestPriorityList.Location = new System.Drawing.Point(479, 406);
            this.highestPriorityList.Name = "highestPriorityList";
            this.highestPriorityList.Size = new System.Drawing.Size(361, 179);
            this.highestPriorityList.TabIndex = 0;
            // 
            // mostDemandedList
            // 
            this.mostDemandedList.BackColor = System.Drawing.Color.SlateBlue;
            this.mostDemandedList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostDemandedList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mostDemandedList.FormattingEnabled = true;
            this.mostDemandedList.ItemHeight = 25;
            this.mostDemandedList.Location = new System.Drawing.Point(32, 148);
            this.mostDemandedList.Name = "mostDemandedList";
            this.mostDemandedList.Size = new System.Drawing.Size(403, 429);
            this.mostDemandedList.TabIndex = 0;
            // 
            // thisWeekTopicsList
            // 
            this.thisWeekTopicsList.BackColor = System.Drawing.Color.SlateBlue;
            this.thisWeekTopicsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thisWeekTopicsList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.thisWeekTopicsList.FormattingEnabled = true;
            this.thisWeekTopicsList.ItemHeight = 25;
            this.thisWeekTopicsList.Location = new System.Drawing.Point(479, 148);
            this.thisWeekTopicsList.Name = "thisWeekTopicsList";
            this.thisWeekTopicsList.Size = new System.Drawing.Size(361, 179);
            this.thisWeekTopicsList.TabIndex = 0;
            // 
            // closeButtonPicture
            // 
            this.closeButtonPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButtonPicture.Image = global::ApplicationUI.Properties.Resources.cross_icon;
            this.closeButtonPicture.Location = new System.Drawing.Point(1058, 12);
            this.closeButtonPicture.Name = "closeButtonPicture";
            this.closeButtonPicture.Size = new System.Drawing.Size(22, 21);
            this.closeButtonPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButtonPicture.TabIndex = 2;
            this.closeButtonPicture.TabStop = false;
            this.closeButtonPicture.Click += new System.EventHandler(this.closeButtonPicture_Click);
            // 
            // minimizePictureButton
            // 
            this.minimizePictureButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizePictureButton.Image = global::ApplicationUI.Properties.Resources.minimize_icon;
            this.minimizePictureButton.Location = new System.Drawing.Point(1016, 11);
            this.minimizePictureButton.Name = "minimizePictureButton";
            this.minimizePictureButton.Size = new System.Drawing.Size(23, 21);
            this.minimizePictureButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizePictureButton.TabIndex = 2;
            this.minimizePictureButton.TabStop = false;
            this.minimizePictureButton.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // inventoryPanel
            // 
            this.inventoryPanel.Controls.Add(this.selectedNameText);
            this.inventoryPanel.Controls.Add(this.addDemandNum);
            this.inventoryPanel.Controls.Add(this.changePriorityCombo);
            this.inventoryPanel.Controls.Add(this.selectTypeInventoryCombo);
            this.inventoryPanel.Controls.Add(this.changeCategoryCombo);
            this.inventoryPanel.Controls.Add(this.addDemandButton);
            this.inventoryPanel.Controls.Add(this.changeNameButton);
            this.inventoryPanel.Controls.Add(this.deleteItemButton);
            this.inventoryPanel.Controls.Add(this.addDemandLabel);
            this.inventoryPanel.Controls.Add(this.changePriorityLevelLabel);
            this.inventoryPanel.Controls.Add(this.changeCategoryLabel);
            this.inventoryPanel.Controls.Add(this.inventoryList);
            this.inventoryPanel.Location = new System.Drawing.Point(199, 69);
            this.inventoryPanel.Name = "inventoryPanel";
            this.inventoryPanel.Size = new System.Drawing.Size(892, 613);
            this.inventoryPanel.TabIndex = 3;
            this.inventoryPanel.Visible = false;
            // 
            // selectedNameText
            // 
            this.selectedNameText.BackColor = System.Drawing.Color.SlateBlue;
            this.selectedNameText.Enabled = false;
            this.selectedNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedNameText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.selectedNameText.Location = new System.Drawing.Point(462, 46);
            this.selectedNameText.Name = "selectedNameText";
            this.selectedNameText.Size = new System.Drawing.Size(298, 29);
            this.selectedNameText.TabIndex = 5;
            // 
            // addDemandNum
            // 
            this.addDemandNum.BackColor = System.Drawing.Color.SlateBlue;
            this.addDemandNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDemandNum.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addDemandNum.Location = new System.Drawing.Point(462, 496);
            this.addDemandNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.addDemandNum.Name = "addDemandNum";
            this.addDemandNum.Size = new System.Drawing.Size(197, 31);
            this.addDemandNum.TabIndex = 4;
            this.addDemandNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.addDemandNum.Visible = false;
            // 
            // changePriorityCombo
            // 
            this.changePriorityCombo.BackColor = System.Drawing.Color.SlateBlue;
            this.changePriorityCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePriorityCombo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.changePriorityCombo.FormattingEnabled = true;
            this.changePriorityCombo.Location = new System.Drawing.Point(462, 350);
            this.changePriorityCombo.Name = "changePriorityCombo";
            this.changePriorityCombo.Size = new System.Drawing.Size(277, 32);
            this.changePriorityCombo.TabIndex = 3;
            this.changePriorityCombo.Visible = false;
            // 
            // selectTypeInventoryCombo
            // 
            this.selectTypeInventoryCombo.BackColor = System.Drawing.Color.SlateBlue;
            this.selectTypeInventoryCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTypeInventoryCombo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.selectTypeInventoryCombo.FormattingEnabled = true;
            this.selectTypeInventoryCombo.Items.AddRange(new object[] {
            "Topics",
            "Categories",
            "Priority Levels"});
            this.selectTypeInventoryCombo.Location = new System.Drawing.Point(32, 38);
            this.selectTypeInventoryCombo.Name = "selectTypeInventoryCombo";
            this.selectTypeInventoryCombo.Size = new System.Drawing.Size(277, 32);
            this.selectTypeInventoryCombo.TabIndex = 3;
            this.selectTypeInventoryCombo.SelectedIndexChanged += new System.EventHandler(this.selectTypeInventoryCombo_SelectedIndexChanged);
            // 
            // changeCategoryCombo
            // 
            this.changeCategoryCombo.BackColor = System.Drawing.Color.SlateBlue;
            this.changeCategoryCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeCategoryCombo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.changeCategoryCombo.FormattingEnabled = true;
            this.changeCategoryCombo.Location = new System.Drawing.Point(462, 229);
            this.changeCategoryCombo.Name = "changeCategoryCombo";
            this.changeCategoryCombo.Size = new System.Drawing.Size(277, 32);
            this.changeCategoryCombo.TabIndex = 3;
            this.changeCategoryCombo.Visible = false;
            // 
            // addDemandButton
            // 
            this.addDemandButton.BackColor = System.Drawing.Color.SlateBlue;
            this.addDemandButton.Enabled = false;
            this.addDemandButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDemandButton.Location = new System.Drawing.Point(694, 496);
            this.addDemandButton.Name = "addDemandButton";
            this.addDemandButton.Size = new System.Drawing.Size(88, 44);
            this.addDemandButton.TabIndex = 2;
            this.addDemandButton.Text = "Add";
            this.addDemandButton.UseVisualStyleBackColor = false;
            this.addDemandButton.Visible = false;
            // 
            // changeNameButton
            // 
            this.changeNameButton.BackColor = System.Drawing.Color.SlateBlue;
            this.changeNameButton.Enabled = false;
            this.changeNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeNameButton.Location = new System.Drawing.Point(462, 98);
            this.changeNameButton.Name = "changeNameButton";
            this.changeNameButton.Size = new System.Drawing.Size(208, 44);
            this.changeNameButton.TabIndex = 2;
            this.changeNameButton.Text = "Change Name";
            this.changeNameButton.UseVisualStyleBackColor = false;
            // 
            // deleteItemButton
            // 
            this.deleteItemButton.BackColor = System.Drawing.Color.SlateBlue;
            this.deleteItemButton.Enabled = false;
            this.deleteItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteItemButton.Location = new System.Drawing.Point(721, 98);
            this.deleteItemButton.Name = "deleteItemButton";
            this.deleteItemButton.Size = new System.Drawing.Size(134, 44);
            this.deleteItemButton.TabIndex = 2;
            this.deleteItemButton.Text = "Delete";
            this.deleteItemButton.UseVisualStyleBackColor = false;
            // 
            // addDemandLabel
            // 
            this.addDemandLabel.AutoSize = true;
            this.addDemandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDemandLabel.Location = new System.Drawing.Point(466, 430);
            this.addDemandLabel.Name = "addDemandLabel";
            this.addDemandLabel.Size = new System.Drawing.Size(171, 31);
            this.addDemandLabel.TabIndex = 1;
            this.addDemandLabel.Text = "Add Demand";
            this.addDemandLabel.Visible = false;
            // 
            // changePriorityLevelLabel
            // 
            this.changePriorityLevelLabel.AutoSize = true;
            this.changePriorityLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePriorityLevelLabel.Location = new System.Drawing.Point(466, 302);
            this.changePriorityLevelLabel.Name = "changePriorityLevelLabel";
            this.changePriorityLevelLabel.Size = new System.Drawing.Size(273, 31);
            this.changePriorityLevelLabel.TabIndex = 1;
            this.changePriorityLevelLabel.Text = "Change Priority Level";
            this.changePriorityLevelLabel.Visible = false;
            // 
            // changeCategoryLabel
            // 
            this.changeCategoryLabel.AutoSize = true;
            this.changeCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeCategoryLabel.Location = new System.Drawing.Point(472, 182);
            this.changeCategoryLabel.Name = "changeCategoryLabel";
            this.changeCategoryLabel.Size = new System.Drawing.Size(227, 31);
            this.changeCategoryLabel.TabIndex = 1;
            this.changeCategoryLabel.Text = "Change Category";
            this.changeCategoryLabel.Visible = false;
            // 
            // inventoryList
            // 
            this.inventoryList.BackColor = System.Drawing.Color.SlateBlue;
            this.inventoryList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.inventoryList.FormattingEnabled = true;
            this.inventoryList.ItemHeight = 25;
            this.inventoryList.Location = new System.Drawing.Point(32, 98);
            this.inventoryList.Name = "inventoryList";
            this.inventoryList.Size = new System.Drawing.Size(403, 479);
            this.inventoryList.TabIndex = 0;
            // 
            // managementPanel
            // 
            this.managementPanel.Controls.Add(this.weightNum);
            this.managementPanel.Controls.Add(this.descriptionText);
            this.managementPanel.Controls.Add(this.priorityCombo);
            this.managementPanel.Controls.Add(this.addNewButton);
            this.managementPanel.Controls.Add(this.categoryCombo);
            this.managementPanel.Controls.Add(this.chooseTypeCombo);
            this.managementPanel.Controls.Add(this.label4);
            this.managementPanel.Controls.Add(this.label7);
            this.managementPanel.Controls.Add(this.priorityNewTopicLabel);
            this.managementPanel.Controls.Add(this.weightLabel);
            this.managementPanel.Controls.Add(this.categoryNewTopicLabel);
            this.managementPanel.Controls.Add(this.label5);
            this.managementPanel.Controls.Add(this.label6);
            this.managementPanel.Controls.Add(this.priorityList);
            this.managementPanel.Controls.Add(this.categoryList);
            this.managementPanel.Location = new System.Drawing.Point(199, 69);
            this.managementPanel.Name = "managementPanel";
            this.managementPanel.Size = new System.Drawing.Size(892, 613);
            this.managementPanel.TabIndex = 2;
            this.managementPanel.Visible = false;
            // 
            // descriptionText
            // 
            this.descriptionText.BackColor = System.Drawing.Color.SlateBlue;
            this.descriptionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.descriptionText.Location = new System.Drawing.Point(307, 229);
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(423, 38);
            this.descriptionText.TabIndex = 3;
            // 
            // priorityCombo
            // 
            this.priorityCombo.BackColor = System.Drawing.Color.SlateBlue;
            this.priorityCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priorityCombo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.priorityCombo.FormattingEnabled = true;
            this.priorityCombo.Location = new System.Drawing.Point(509, 495);
            this.priorityCombo.Name = "priorityCombo";
            this.priorityCombo.Size = new System.Drawing.Size(322, 32);
            this.priorityCombo.TabIndex = 2;
            this.priorityCombo.Visible = false;
            // 
            // addNewButton
            // 
            this.addNewButton.BackColor = System.Drawing.Color.SlateBlue;
            this.addNewButton.Enabled = false;
            this.addNewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewButton.Location = new System.Drawing.Point(322, 353);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(134, 108);
            this.addNewButton.TabIndex = 1;
            this.addNewButton.Text = "Add";
            this.addNewButton.UseVisualStyleBackColor = false;
            this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
            // 
            // categoryCombo
            // 
            this.categoryCombo.BackColor = System.Drawing.Color.SlateBlue;
            this.categoryCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryCombo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.categoryCombo.FormattingEnabled = true;
            this.categoryCombo.Location = new System.Drawing.Point(500, 353);
            this.categoryCombo.Name = "categoryCombo";
            this.categoryCombo.Size = new System.Drawing.Size(331, 32);
            this.categoryCombo.TabIndex = 2;
            this.categoryCombo.Visible = false;
            // 
            // chooseTypeCombo
            // 
            this.chooseTypeCombo.BackColor = System.Drawing.Color.SlateBlue;
            this.chooseTypeCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseTypeCombo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chooseTypeCombo.FormattingEnabled = true;
            this.chooseTypeCombo.Items.AddRange(new object[] {
            "Topic",
            "Category",
            "Priority Level"});
            this.chooseTypeCombo.Location = new System.Drawing.Point(307, 98);
            this.chooseTypeCombo.Name = "chooseTypeCombo";
            this.chooseTypeCombo.Size = new System.Drawing.Size(276, 32);
            this.chooseTypeCombo.TabIndex = 2;
            this.chooseTypeCombo.SelectedIndexChanged += new System.EventHandler(this.chooseTypeCombo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 37);
            this.label4.TabIndex = 1;
            this.label4.Text = "Priority Levels";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(309, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 37);
            this.label7.TabIndex = 1;
            this.label7.Text = "Description";
            // 
            // priorityNewTopicLabel
            // 
            this.priorityNewTopicLabel.AutoSize = true;
            this.priorityNewTopicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priorityNewTopicLabel.Location = new System.Drawing.Point(502, 441);
            this.priorityNewTopicLabel.Name = "priorityNewTopicLabel";
            this.priorityNewTopicLabel.Size = new System.Drawing.Size(116, 37);
            this.priorityNewTopicLabel.TabIndex = 1;
            this.priorityNewTopicLabel.Text = "Priority";
            this.priorityNewTopicLabel.Visible = false;
            // 
            // categoryNewTopicLabel
            // 
            this.categoryNewTopicLabel.AutoSize = true;
            this.categoryNewTopicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryNewTopicLabel.Location = new System.Drawing.Point(502, 297);
            this.categoryNewTopicLabel.Name = "categoryNewTopicLabel";
            this.categoryNewTopicLabel.Size = new System.Drawing.Size(146, 37);
            this.categoryNewTopicLabel.TabIndex = 1;
            this.categoryNewTopicLabel.Text = "Category";
            this.categoryNewTopicLabel.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(300, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 37);
            this.label5.TabIndex = 1;
            this.label5.Text = "Add New";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 37);
            this.label6.TabIndex = 1;
            this.label6.Text = "Categories";
            // 
            // priorityList
            // 
            this.priorityList.BackColor = System.Drawing.Color.SlateBlue;
            this.priorityList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priorityList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.priorityList.FormattingEnabled = true;
            this.priorityList.ItemHeight = 25;
            this.priorityList.Location = new System.Drawing.Point(36, 356);
            this.priorityList.Name = "priorityList";
            this.priorityList.Size = new System.Drawing.Size(255, 229);
            this.priorityList.TabIndex = 0;
            // 
            // categoryList
            // 
            this.categoryList.BackColor = System.Drawing.Color.SlateBlue;
            this.categoryList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.categoryList.FormattingEnabled = true;
            this.categoryList.ItemHeight = 25;
            this.categoryList.Location = new System.Drawing.Point(34, 94);
            this.categoryList.Name = "categoryList";
            this.categoryList.Size = new System.Drawing.Size(257, 179);
            this.categoryList.TabIndex = 0;
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightLabel.Location = new System.Drawing.Point(502, 297);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(117, 37);
            this.weightLabel.TabIndex = 1;
            this.weightLabel.Text = "Weight";
            this.weightLabel.Visible = false;
            // 
            // weightNum
            // 
            this.weightNum.BackColor = System.Drawing.Color.SlateBlue;
            this.weightNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightNum.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.weightNum.Location = new System.Drawing.Point(500, 353);
            this.weightNum.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.weightNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.weightNum.Name = "weightNum";
            this.weightNum.Size = new System.Drawing.Size(148, 29);
            this.weightNum.TabIndex = 4;
            this.weightNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.weightNum.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1092, 683);
            this.Controls.Add(this.closeButtonPicture);
            this.Controls.Add(this.minimizePictureButton);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.managementPanel);
            this.Controls.Add(this.inventoryPanel);
            this.Controls.Add(this.roadmapPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.titlePicture)).EndInit();
            this.roadmapPanel.ResumeLayout(false);
            this.roadmapPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButtonPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureButton)).EndInit();
            this.inventoryPanel.ResumeLayout(false);
            this.inventoryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addDemandNum)).EndInit();
            this.managementPanel.ResumeLayout(false);
            this.managementPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weightNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button inventoryButton;
        private System.Windows.Forms.Button manageButton;
        private System.Windows.Forms.Button roadmapButton;
        private System.Windows.Forms.PictureBox titlePicture;
        private System.Windows.Forms.Panel roadmapPanel;
        private System.Windows.Forms.PictureBox closeButtonPicture;
        private System.Windows.Forms.PictureBox minimizePictureButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox thisWeekTopicsList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox highestPriorityList;
        private System.Windows.Forms.ListBox mostDemandedList;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox advancedFilterCombo;
        private System.Windows.Forms.ComboBox filterCombo;
        private System.Windows.Forms.Panel inventoryPanel;
        private System.Windows.Forms.ListBox inventoryList;
        private System.Windows.Forms.Panel managementPanel;
        private System.Windows.Forms.TextBox descriptionText;
        private System.Windows.Forms.ComboBox priorityCombo;
        private System.Windows.Forms.ComboBox categoryCombo;
        private System.Windows.Forms.ComboBox chooseTypeCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label priorityNewTopicLabel;
        private System.Windows.Forms.Label categoryNewTopicLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox priorityList;
        private System.Windows.Forms.ListBox categoryList;
        private System.Windows.Forms.ComboBox changePriorityCombo;
        private System.Windows.Forms.ComboBox changeCategoryCombo;
        private System.Windows.Forms.Button deleteItemButton;
        private System.Windows.Forms.Label changePriorityLevelLabel;
        private System.Windows.Forms.Label changeCategoryLabel;
        private System.Windows.Forms.Button addNewButton;
        private System.Windows.Forms.NumericUpDown addDemandNum;
        private System.Windows.Forms.Button addDemandButton;
        private System.Windows.Forms.Label addDemandLabel;
        private System.Windows.Forms.TextBox selectedNameText;
        private System.Windows.Forms.ComboBox selectTypeInventoryCombo;
        private System.Windows.Forms.Button changeNameButton;
        private System.Windows.Forms.NumericUpDown weightNum;
        private System.Windows.Forms.Label weightLabel;
    }
}


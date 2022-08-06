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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.highestPriorityList = new System.Windows.Forms.ListBox();
            this.mostDemandedList = new System.Windows.Forms.ListBox();
            this.thisWeekTopicsList = new System.Windows.Forms.ListBox();
            this.closeButtonPicture = new System.Windows.Forms.PictureBox();
            this.minimizePictureButton = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.filterCombo = new System.Windows.Forms.ComboBox();
            this.advancedFilterCombo = new System.Windows.Forms.ComboBox();
            this.inventoryPanel = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.topicsList = new System.Windows.Forms.ListBox();
            this.managementPanel = new System.Windows.Forms.Panel();
            this.categoryList = new System.Windows.Forms.ListBox();
            this.priorityList = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.categoryNewTopicLabel = new System.Windows.Forms.Label();
            this.priorityNewTopicLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chooseTypeCombo = new System.Windows.Forms.ComboBox();
            this.categoryCombo = new System.Windows.Forms.ComboBox();
            this.priorityCombo = new System.Windows.Forms.ComboBox();
            this.descriptionText = new System.Windows.Forms.TextBox();
            this.deleteTopicButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.addNewButton = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titlePicture)).BeginInit();
            this.roadmapPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButtonPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureButton)).BeginInit();
            this.inventoryPanel.SuspendLayout();
            this.managementPanel.SuspendLayout();
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
            // filterCombo
            // 
            this.filterCombo.BackColor = System.Drawing.Color.SlateBlue;
            this.filterCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterCombo.FormattingEnabled = true;
            this.filterCombo.Location = new System.Drawing.Point(191, 32);
            this.filterCombo.Name = "filterCombo";
            this.filterCombo.Size = new System.Drawing.Size(199, 28);
            this.filterCombo.TabIndex = 2;
            // 
            // advancedFilterCombo
            // 
            this.advancedFilterCombo.BackColor = System.Drawing.Color.SlateBlue;
            this.advancedFilterCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advancedFilterCombo.FormattingEnabled = true;
            this.advancedFilterCombo.Location = new System.Drawing.Point(442, 33);
            this.advancedFilterCombo.Name = "advancedFilterCombo";
            this.advancedFilterCombo.Size = new System.Drawing.Size(242, 28);
            this.advancedFilterCombo.TabIndex = 2;
            this.advancedFilterCombo.Visible = false;
            // 
            // inventoryPanel
            // 
            this.inventoryPanel.Controls.Add(this.comboBox2);
            this.inventoryPanel.Controls.Add(this.comboBox1);
            this.inventoryPanel.Controls.Add(this.deleteTopicButton);
            this.inventoryPanel.Controls.Add(this.label11);
            this.inventoryPanel.Controls.Add(this.label10);
            this.inventoryPanel.Controls.Add(this.label17);
            this.inventoryPanel.Controls.Add(this.topicsList);
            this.inventoryPanel.Location = new System.Drawing.Point(199, 69);
            this.inventoryPanel.Name = "inventoryPanel";
            this.inventoryPanel.Size = new System.Drawing.Size(892, 613);
            this.inventoryPanel.TabIndex = 3;
            this.inventoryPanel.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(25, 24);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(112, 37);
            this.label17.TabIndex = 1;
            this.label17.Text = "Topics";
            // 
            // topicsList
            // 
            this.topicsList.BackColor = System.Drawing.Color.SlateBlue;
            this.topicsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topicsList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.topicsList.FormattingEnabled = true;
            this.topicsList.ItemHeight = 25;
            this.topicsList.Location = new System.Drawing.Point(32, 98);
            this.topicsList.Name = "topicsList";
            this.topicsList.Size = new System.Drawing.Size(403, 479);
            this.topicsList.TabIndex = 0;
            // 
            // managementPanel
            // 
            this.managementPanel.Controls.Add(this.descriptionText);
            this.managementPanel.Controls.Add(this.priorityCombo);
            this.managementPanel.Controls.Add(this.addNewButton);
            this.managementPanel.Controls.Add(this.categoryCombo);
            this.managementPanel.Controls.Add(this.chooseTypeCombo);
            this.managementPanel.Controls.Add(this.label4);
            this.managementPanel.Controls.Add(this.label7);
            this.managementPanel.Controls.Add(this.priorityNewTopicLabel);
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
            // chooseTypeCombo
            // 
            this.chooseTypeCombo.BackColor = System.Drawing.Color.SlateBlue;
            this.chooseTypeCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseTypeCombo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chooseTypeCombo.FormattingEnabled = true;
            this.chooseTypeCombo.Items.AddRange(new object[] {
            "Topic",
            "Category",
            "Priority Level"});
            this.chooseTypeCombo.Location = new System.Drawing.Point(307, 98);
            this.chooseTypeCombo.Name = "chooseTypeCombo";
            this.chooseTypeCombo.Size = new System.Drawing.Size(276, 41);
            this.chooseTypeCombo.TabIndex = 2;
            this.chooseTypeCombo.SelectedIndexChanged += new System.EventHandler(this.chooseTypeCombo_SelectedIndexChanged);
            // 
            // categoryCombo
            // 
            this.categoryCombo.BackColor = System.Drawing.Color.SlateBlue;
            this.categoryCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryCombo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.categoryCombo.FormattingEnabled = true;
            this.categoryCombo.Location = new System.Drawing.Point(500, 353);
            this.categoryCombo.Name = "categoryCombo";
            this.categoryCombo.Size = new System.Drawing.Size(331, 41);
            this.categoryCombo.TabIndex = 2;
            this.categoryCombo.Visible = false;
            // 
            // priorityCombo
            // 
            this.priorityCombo.BackColor = System.Drawing.Color.SlateBlue;
            this.priorityCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priorityCombo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.priorityCombo.FormattingEnabled = true;
            this.priorityCombo.Location = new System.Drawing.Point(500, 496);
            this.priorityCombo.Name = "priorityCombo";
            this.priorityCombo.Size = new System.Drawing.Size(331, 41);
            this.priorityCombo.TabIndex = 2;
            this.priorityCombo.Visible = false;
            // 
            // descriptionText
            // 
            this.descriptionText.BackColor = System.Drawing.Color.SlateBlue;
            this.descriptionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.descriptionText.Location = new System.Drawing.Point(316, 229);
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(423, 38);
            this.descriptionText.TabIndex = 3;
            // 
            // deleteTopicButton
            // 
            this.deleteTopicButton.BackColor = System.Drawing.Color.SlateBlue;
            this.deleteTopicButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteTopicButton.Location = new System.Drawing.Point(462, 98);
            this.deleteTopicButton.Name = "deleteTopicButton";
            this.deleteTopicButton.Size = new System.Drawing.Size(134, 44);
            this.deleteTopicButton.TabIndex = 2;
            this.deleteTopicButton.Text = "Delete";
            this.deleteTopicButton.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(472, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(267, 37);
            this.label10.TabIndex = 1;
            this.label10.Text = "Change Category";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(472, 341);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(320, 37);
            this.label11.TabIndex = 1;
            this.label11.Text = "Change Priority Level";
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(462, 270);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(277, 32);
            this.comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.Enabled = false;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(462, 406);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(277, 32);
            this.comboBox2.TabIndex = 3;
            // 
            // addNewButton
            // 
            this.addNewButton.BackColor = System.Drawing.Color.SlateBlue;
            this.addNewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewButton.Location = new System.Drawing.Point(322, 353);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(134, 108);
            this.addNewButton.TabIndex = 1;
            this.addNewButton.Text = "Add";
            this.addNewButton.UseVisualStyleBackColor = false;
            this.addNewButton.Click += new System.EventHandler(this.manageButton_Click);
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
            this.managementPanel.ResumeLayout(false);
            this.managementPanel.PerformLayout();
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
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ListBox topicsList;
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
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button deleteTopicButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button addNewButton;
    }
}


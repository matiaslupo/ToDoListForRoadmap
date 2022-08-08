using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoList_Library;

namespace ApplicationUI
{
    public partial class MainForm : Form
    {
        private ToDoListController controller = new ToDoListController();

        public MainForm()
        {
            InitializeComponent();

            roadmapPanel.Visible = true;
            managementPanel.Visible = false;
            inventoryPanel.Visible = false;

            WireUpRoadmapLists();
            WireUpManagementLists();
            WireUpInventoryList();
        }

        private void WireUpRoadmapLists()
        {
            mostDemandedList.DataSource = null;
            mostDemandedList.DataSource = controller.RequestTopics();
            mostDemandedList.DisplayMember = "DemandDisplay";
        }

        private void WireUpManagementLists()
        {
            categoryList.DataSource = null;
            categoryList.DataSource = controller.RequestCategories();
            categoryList.DisplayMember = "Name";

            priorityList.DataSource = null;
            priorityList.DataSource= controller.RequestPriorityLevels();
            priorityList.DisplayMember = "Name";

        }

        private void WireUpInventoryList(string filter = "None")
        {
            if (filter == "None")
                return;
            inventoryList.DataSource = null;
            if (filter == "Topics")
            {
                inventoryList.DataSource = controller.RequestTopics();
                inventoryList.DisplayMember = "Description";
                return;
            }
            if (filter == "Categories")
            {
                inventoryList.DataSource = controller.RequestCategories();
                inventoryList.DisplayMember = "Name";
                return;
            }
            if (filter == "Priority Levels")
            {
                inventoryList.DataSource = controller.RequestPriorityLevels();
                inventoryList.DisplayMember = "Name";
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeButtonPicture_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void roadmapButton_Click(object sender, EventArgs e)
        {
            roadmapPanel.Visible = true;
            roadmapPanel.Enabled = true;
            managementPanel.Visible = false;
            managementPanel.Enabled = false;
            inventoryPanel.Visible = false;
            inventoryPanel.Enabled = false;
        }

        private void manageButton_Click(object sender, EventArgs e)
        {
            managementPanel.Visible = true;
            managementPanel.Enabled = true;
            roadmapPanel.Visible = false;
            roadmapPanel.Enabled = false;
            inventoryPanel.Visible =false;
            inventoryPanel.Enabled = false;
            chooseTypeCombo.SelectedIndex = 0;
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            inventoryPanel.Visible = true;
            inventoryPanel.Enabled = true;
            roadmapPanel.Visible = false;
            roadmapPanel.Enabled = false;
            managementPanel.Visible = false;
            managementPanel.Enabled = false;
        }

        private void chooseTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chooseTypeCombo.SelectedIndex < 0)
            {
                addNewButton.Enabled = false;
                categoryNewTopicLabel.Visible = false;
                priorityNewTopicLabel.Visible = false;
                categoryCombo.Visible = false;
                priorityCombo.Visible = false;
                weightLabel.Visible = false;
                weightNum.Visible = false;
                return;
            }
            addNewButton.Enabled = true;

            if (chooseTypeCombo.SelectedIndex == 0)
            {
                categoryNewTopicLabel.Visible = true;
                priorityNewTopicLabel.Visible = true;
                categoryCombo.Visible = true;
                priorityCombo.Visible = true;

                categoryCombo.DataSource = null;
                categoryCombo.DataSource = controller.RequestCategories();
                categoryCombo.SelectedIndex = 0;
                categoryCombo.DisplayMember = "Name";

                priorityCombo.DataSource = null;
                priorityCombo.DataSource= controller.RequestPriorityLevels();
                priorityCombo.SelectedIndex = 0;
                priorityCombo.DisplayMember = "Name";

                weightLabel.Visible = false;
                weightNum.Visible = false;
                return;
            }
            categoryNewTopicLabel.Visible = false;
            priorityNewTopicLabel.Visible = false;
            categoryCombo.Visible = false;
            priorityCombo.Visible = false;

            if (chooseTypeCombo.SelectedIndex == 1)
            {
                weightLabel.Visible = false;
                weightNum.Visible = false;
                return ;
            }
            weightLabel.Visible = true;
            weightNum.Visible = true;
        }

        private void filterCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filterCombo.SelectedIndex <= 0)
            {
                advancedFilterCombo.Visible = false;
                return;
            }
            advancedFilterCombo.Visible = true;

            advancedFilterCombo.DataSource = null;
            if (filterCombo.SelectedIndex == 1)
            {
                advancedFilterCombo.DataSource = controller.RequestCategories();
                advancedFilterCombo.DisplayMember = "Name";
                advancedFilterCombo.SelectedIndex = -1;
                return;
            }
            if (filterCombo.SelectedIndex == 2)
            {
                advancedFilterCombo.DataSource = controller.RequestPriorityLevels();
                advancedFilterCombo.DisplayMember = "Name";
                advancedFilterCombo.SelectedIndex = -1;
            }
        }

        private void selectTypeInventoryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectTypeInventoryCombo.SelectedIndex < 0)
            {
                selectedNameText.Enabled = false;
                changeNameButton.Enabled = false;
                deleteItemButton.Enabled = false;
                
                changeCategoryLabel.Visible = false;
                changeCategoryCombo.Visible = false;

                changePriorityLevelLabel.Visible = false ;
                changePriorityCombo.Visible = false;

                addDemandLabel.Visible = false;
                addDemandNum.Visible = false;
                addDemandButton.Visible = false;

                WireUpInventoryList();
                return;
            }
            if (selectTypeInventoryCombo.SelectedIndex == 0)
            {
                selectedNameText.Enabled = true;
                changeNameButton.Enabled = true;
                deleteItemButton.Enabled = true;

                changeCategoryLabel.Visible = true;
                changeCategoryCombo.Visible = true;

                changePriorityLevelLabel.Visible = true;
                changePriorityCombo.Visible = true;

                addDemandLabel.Visible = true;
                addDemandNum.Visible = true;
                addDemandButton.Visible = true;

                WireUpInventoryList("Topics");
                return;
            }
            if (selectTypeInventoryCombo.SelectedIndex > 0)
            {
                selectedNameText.Enabled = true;
                changeNameButton.Enabled = true;
                deleteItemButton.Enabled = true;

                changeCategoryLabel.Visible = false;
                changeCategoryCombo.Visible = false;

                changePriorityLevelLabel.Visible = false;
                changePriorityCombo.Visible = false;

                addDemandLabel.Visible = false;
                addDemandNum.Visible = false;
                addDemandButton.Visible = false;

                if (selectTypeInventoryCombo.SelectedIndex == 1)
                    WireUpInventoryList("Categories");
                else if (selectTypeInventoryCombo.SelectedIndex == 2)
                    WireUpInventoryList("Priority Levels");
            }

        }

        private void advancedFilterCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            int typeSelect = chooseTypeCombo.SelectedIndex;
            if (typeSelect < 0)
                return;
            string result = "";
            switch (typeSelect)
            {
                case 0:
                    result = controller.AddTopic(descriptionText.Text, categoryCombo.SelectedIndex, priorityCombo.SelectedIndex);
                    break;
                case 1:
                    result = controller.AddCategory(descriptionText.Text);
                    break;
                case 2:
                    result = controller.AddLevel(descriptionText.Text, (int)weightNum.Value);
                    break;
                default:
                    result = "Something weird has happened..."; break;
            }
            MessageBox.Show(result, "Add New", MessageBoxButtons.OK, MessageBoxIcon.Information);
            controller.RefreshLists();
            RefreshViews();
        }

        private void RefreshViews()
        {
            WireUpRoadmapLists();
            WireUpManagementLists();
            WireUpInventoryList();
        }
    }
}

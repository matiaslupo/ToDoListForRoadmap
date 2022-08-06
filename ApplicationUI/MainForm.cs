using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationUI
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            roadmapPanel.Location = new Point(199, 69);
            managementPanel.Location = new Point(199, 69);
            inventoryPanel.Location = new Point(199, 69);

            roadmapPanel.Visible = true;
            managementPanel.Visible = false;
            inventoryPanel.Visible = false;
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
                return;
            }
            if (chooseTypeCombo.SelectedIndex == 0)
            {
                addNewButton.Enabled = true;
                categoryNewTopicLabel.Visible = true;
                priorityNewTopicLabel.Visible = true;
                categoryCombo.Visible = true;
                priorityCombo.Visible = true;
                return;
            }
            if (chooseTypeCombo.SelectedIndex > 0)
            {
                addNewButton.Enabled = true;
                categoryNewTopicLabel.Visible = false;
                priorityNewTopicLabel.Visible = false;
                categoryCombo.Visible = false;
                priorityCombo.Visible = false;
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        bool IsInputValid()
        {
            return (txtInput.Text != "");
        }


        void ShowMessage(string message, string title)
        {
            MessageBox.Show(
                               message,
                               title,
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
        }

        void ChangeTxtColor(TextBox text, Color color)
        {
            text.BackColor = color;
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            if (!IsInputValid())
            {
                ShowMessage("Please enter a category name first.", "Missing Category Name");

                ChangeTxtColor(txtInput, Color.Red);
            }
            else
            {
                TreeTasks.Nodes.Add(txtInput.Text);
                ChangeTxtColor(txtInput, Color.White);
                txtInput.Clear();

                ShowNotification(
                           "Category Added",
                           "A new category has been added successfully.");
            }
            txtInput.Focus();

           
        }


        bool IsCategorySelected()
        {
            return (TreeTasks.SelectedNode != null && TreeTasks.SelectedNode.Parent == null);
        }

        bool IsCategoryOrTaskSelected()
        {
            return TreeTasks.SelectedNode != null;
        }

        bool IsTreeEmpty()
        {
            return TreeTasks.Nodes.Count == 0;
        }


        void ShowNotification(string Title,string Message)
        {
            notifyIcon1.Icon = SystemIcons.Information;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = Title;
            notifyIcon1.BalloonTipText = Message;
            notifyIcon1.ShowBalloonTip(3000);
        }


        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (!IsInputValid())
            {
                ShowMessage("Please enter a task name first.", "Missing Task");

                ChangeTxtColor(txtInput, Color.Red);
                txtInput.Focus();
                return;
            }
            else
            {
                ChangeTxtColor(txtInput, Color.White);
            }



            if (!IsCategorySelected())
            {
                ShowMessage("Please select a category first.", "No Category Selected");
                return;
            }
            else
            {
                TreeTasks.SelectedNode.Nodes.Add(txtInput.Text);
            }

            txtInput.Clear();
            txtInput.Focus();



            ShowNotification("Task Added", "Your task has been added successfully.");

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!IsInputValid())
            {
                ShowMessage("Please enter a task name to Rename it first.", "Missing Task");

                ChangeTxtColor(txtInput, Color.Red);
                return;
            }
            else
            {
                ChangeTxtColor(txtInput, Color.White);
            }



            if (!IsCategoryOrTaskSelected())
            {
                ShowMessage("Please select a category or task first.", "Nothing Selected");
                return;
            }


            TreeTasks.SelectedNode.Text = txtInput.Text;

            txtInput.Focus();
            txtInput.Clear();



            ShowNotification("Task Updated", "The selected category or task has been renamed successfully.");
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (IsTreeEmpty())
            {
                ShowMessage("There are no categories or tasks to delete yet.\nPlease add a category first."
                    , "Tree is Empty");
                txtInput.Focus();
                return;
            }



            if (!IsCategoryOrTaskSelected())
            {
                ShowMessage("Please select a category or task to delete it first.", "Nothing Selected");
                return;
            }

            TreeTasks.SelectedNode.Remove();
            txtInput.Clear();
            txtInput.Focus();



            UpdateProgress();


            ShowNotification("Task Deleted", "The selected category or task has been deleted.");

        }

        private void btnMarkAllDone_Click(object sender, EventArgs e)
        {

            if (IsTreeEmpty())
            {
                ShowMessage("There are no tasks to mark as completed.",
                                "Tree is Empty");
                txtInput.Focus();
                return;
            }


            CheckAllTasks(TreeTasks);

            ShowNotification("All Tasks Completed", "Every task has been marked as completed.");
        }


        void CheckAllTasks(TreeView tree)
        {
            foreach (TreeNode Root in tree.Nodes)
            {
                CheckTask(Root);
            }
        }


        void CheckTask(TreeNode Node)
        {
            foreach (TreeNode child in Node.Nodes)
            {

                child.Checked = true;
            }


        }


        int TotalTasks, CompletedTasks;

        private void TreeTasks_AfterCheck(object sender, TreeViewEventArgs e)
        {
            UpdateProgress();
        }

        void UpdateProgress()
        {
            TotalTasks = 0;
            CompletedTasks = 0;

            WalkOnTree(TreeTasks);


            if (TotalTasks == 0)
            {
                progressBar1.Value = 0;
                lblPercent.Text = "0%";
                lblCompletedTasks.Text = "0";
                lblTotalTasks.Text = "0";
                return;
            }



            int Percentage = (CompletedTasks * 100) / TotalTasks;
            lblPercent.Text = Percentage.ToString() + "%";
            progressBar1.Value= Percentage;

            lblCompletedTasks.Text= CompletedTasks.ToString();
            lblTotalTasks.Text= TotalTasks.ToString();


            if(TotalTasks== CompletedTasks)
            {
                ShowNotification("Congratulations!", "All tasks have been completed successfully.\r\nGreat job!");
            }

        }


        void WalkOnTree(TreeView tree)
        {
            foreach (TreeNode Root in tree.Nodes)
            {
                WalkOnEachTreeNode(Root);
            }

        }

        void WalkOnEachTreeNode(TreeNode node)
        {
            foreach (TreeNode child in node.Nodes)
            {
                TotalTasks++;

                if(child.Checked)
                {
                    CompletedTasks++;
                }

            }

            
        }
            


      
        private void btnClearAllTasks_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                                     "Are you sure you want to delete all tasks?",
                                     "Confirm Delete",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                foreach (TreeNode Root in TreeTasks.Nodes)
                {
                    Root.Nodes.Clear();
                }
                UpdateProgress();

                ShowNotification("Tasks Cleared", "All tasks have been removed from every category.");
            }


           

        }

        private void btnUnCheckAll_Click(object sender, EventArgs e)
        {
            if (IsTreeEmpty())
            {
                ShowMessage("There are no tasks available."
                    , "Tree is Empty");
                txtInput.Focus();
                return;
            }


            UnCheckAllTasks(TreeTasks);

            ShowNotification("Tasks Reset", "All tasks have been marked as not completed.");
        }

        void UnCheckAllTasks(TreeView tree)
        {
            foreach (TreeNode Root in tree.Nodes)
            {
                UnCheckTask(Root);
            }
        }

      
        void UnCheckTask(TreeNode node)
        {
            foreach(TreeNode child in node.Nodes)
            {
                child.Checked = false;
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Explorer_TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExpandAll_Click(object sender, EventArgs e)
        {
            MyComputerTree.ExpandAll();
        }

        private void btnCollapseAll_Click(object sender, EventArgs e)
        {
            MyComputerTree.CollapseAll();
        }

        private void btnExpandChecked_Click(object sender, EventArgs e)
        {
            bool hasCheckedNode = false;

            // التأكد أن فيه Node معمولها Check
            foreach (TreeNode tn1 in MyComputerTree.Nodes)
            {
                if (tn1.Checked)
                {
                    hasCheckedNode = true;
                    break;
                }
            }

            if (!hasCheckedNode)
            {
                MessageBox.Show("Please check at least one item first.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Do you want to expand all selected items, including their sub-items?",
                "Expand Items",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            bool expandedAnyNode = false;

            foreach (TreeNode tn1 in MyComputerTree.Nodes)
            {
                if (tn1.Checked && !tn1.IsExpanded)
                {
                    if (result == DialogResult.Yes)
                        tn1.ExpandAll();
                    else
                        tn1.Expand();

                    expandedAnyNode = true;
                }
            }

            if (!expandedAnyNode)
            {
                MessageBox.Show("All checked items are already expanded.");
            }
        }

        private void btnCollapseChecked_Click(object sender, EventArgs e)
        {

            bool Collapse = false;

            foreach (TreeNode tn1 in MyComputerTree.Nodes)
            {
                

                if (tn1.Checked && tn1.IsExpanded)
                {
                    tn1.Collapse();
                    Collapse = true;
                }
                 
            }

            if (!Collapse)
            {
                MessageBox.Show("All checked items are already collapsed.");
            }
        }

        private void MyComputerTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lblShowSeletedFolder.Text = MyComputerTree.SelectedNode.Text;

            if (MyComputerTree.SelectedNode.Parent != null)
            {
                lblShowFolderName.Text = MyComputerTree.SelectedNode.Parent.Text;
            }
            else
            {
                lblShowFolderName.Text = "None";
            }

        }

        private void btnCheckAll_Click(object sender, EventArgs e)
        {
          foreach(TreeNode tn1 in MyComputerTree.Nodes)
          {
                tn1.Checked = true;

                if(tn1.Nodes.Count>0)
                {
                    foreach(TreeNode tn2 in tn1.Nodes)
                    {
                        tn2.Checked = true;

                        if(tn2.Nodes.Count>0)
                        {
                            foreach(TreeNode tn3 in tn2.Nodes)
                            {
                                tn3.Checked = true;
                            }
                        }

                    }
                }



          }
        }

        private void btnUncheckAll_Click(object sender, EventArgs e)
        {
            foreach(TreeNode tn1 in MyComputerTree.Nodes)
            {
                tn1.Checked = false;

                if(tn1.Nodes.Count>0)
                {
                    foreach(TreeNode tn2 in tn1.Nodes)
                    {
                        tn2.Checked = false;

                        if(tn2.Nodes.Count>0)
                        {
                            foreach(TreeNode tn3 in tn2.Nodes)
                            {
                                tn3.Checked = false;
                            }
                        }

                    }
                }

            }
        }

        private void btnCopyChecked_Click(object sender, EventArgs e)
        {

            txtSelectedItems.Clear();

            foreach (TreeNode tn1 in MyComputerTree.Nodes)
            {
                if(tn1.Checked)
                    txtSelectedItems.Text += tn1.Text + txtNewLine.Text;

                    if(tn1.Nodes.Count>0)
                    {

                        foreach(TreeNode tn2 in tn1.Nodes)
                        {
                        if (tn2.Checked)
                            txtSelectedItems.Text += "    " + tn2.Text + txtNewLine.Text;


                            if(tn2.Nodes.Count>0)
                            {
                                foreach (TreeNode tn3 in tn2.Nodes)
                                {
                                if (tn3.Checked)
                                    txtSelectedItems.Text += "       " + tn3.Text + txtNewLine.Text;
                                }
                            }

                        }

                    

                }
            }

        }

        private void btnClearOutput_Click(object sender, EventArgs e)
        {
            txtSelectedItems.Clear();
        }
    }
}

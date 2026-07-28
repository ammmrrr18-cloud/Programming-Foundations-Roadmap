using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_TreeView_File_Explorer_Recursive_Direct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            CheckAllNodes(MyComputerTree);
        }

        void CheckAllNodes(TreeView tree)
        {
            foreach (TreeNode child in tree.Nodes)
            {
                CheckNode(child);
            }
        }

        void CheckNode(TreeNode node)
        {
            node.Checked = true;

            foreach (TreeNode child in node.Nodes)
            {
                CheckNode(child);
            }
        }

        private void btnUncheckAll_Click(object sender, EventArgs e)
        {
            UnCheckAll(MyComputerTree);
        }


        void UnCheckAll(TreeView tree)
        {
            foreach (TreeNode Root in tree.Nodes)
            {
                UnCheckNode(Root);
            }
        }

        void UnCheckNode(TreeNode node)
        {
            node.Checked = false;

            foreach (TreeNode child in node.Nodes)
            {
                UnCheckNode(child);
            }

        }

        private void btnCopyChecked_Click(object sender, EventArgs e)
        {
            txtSelectedItems.Clear();
            CopyCheckAll(MyComputerTree);
        }

        void CopyCheckAll(TreeView tree)
        {
            foreach (TreeNode Root in tree.Nodes)
            {
                CopyCheckNode(Root);
            }
        }

        void CopyCheckNode(TreeNode node)
        {
            if (node.Checked)
            {
                txtSelectedItems.Text += node.Text + txtNewLine.Text;
            }

            foreach (TreeNode child in node.Nodes)
            {
                CopyCheckNode(child);
            }

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
            ExpandCheckedItems(MyComputerTree);
        }


        void ExpandCheckedItems(TreeView tree)
        {
            foreach (TreeNode Root in tree.Nodes)
            {
                ExpandCheckedNode(Root);
            }
        }


        void ExpandCheckedNode(TreeNode node)
        {
            if (node.Checked)
            {
                node.Expand();
            }

            foreach (TreeNode child in node.Nodes)
            {
                ExpandCheckedNode(child);
            }

        }

        private void btnCollapseChecked_Click(object sender, EventArgs e)
        {
            CollapseCheckedItems(MyComputerTree);
        }

        void CollapseCheckedItems(TreeView tree)
        {
            foreach(TreeNode Root in tree.Nodes)
            {
                CollapseCheckedNode(Root);
            }
        }

        void CollapseCheckedNode(TreeNode node)
        {

            if (node.Checked)
            {
                node.Collapse();
            }

            foreach (TreeNode child in node.Nodes)
            {
                CollapseCheckedNode(child);
            }


        }

        private void btnClearOutput_Click(object sender, EventArgs e)
        {
            txtSelectedItems.Clear();
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

        private void MyComputerTree_AfterCheck(object sender, TreeViewEventArgs e)
        {
            Check_UnCheckAllMySeletedNode(e.Node,e.Node.Checked);
        }

        void Check_UnCheckAllMySeletedNode(TreeNode node,bool isChecked)
        {
            foreach(TreeNode child in node.Nodes)
            {
                child.Checked = isChecked;

                Check_UnCheckAllMySeletedNode(child,isChecked);

            }
        }

    }
}

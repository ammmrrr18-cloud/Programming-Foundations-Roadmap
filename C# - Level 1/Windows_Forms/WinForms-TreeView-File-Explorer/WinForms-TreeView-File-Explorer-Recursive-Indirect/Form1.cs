using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_TreeView_File_Explorer_Recursive
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



        void CheckAllNodes(TreeView treeName)
        {
            TraverseNodeCollectionCheck(treeName.Nodes);
        }

        void TraverseNodeCollectionCheck(TreeNodeCollection nodesCollection)
        {
            foreach (TreeNode child in nodesCollection)
            {
                CheckNode(child);
            }
        }
        void CheckNode(TreeNode Child)
        {
            Child.Checked = true;

            if (Child.Nodes.Count > 0)
            {
                TraverseNodeCollectionCheck(Child.Nodes);
            }


        }

        private void btnUncheckAll_Click(object sender, EventArgs e)
        {
            UncheckAllNodes(MyComputerTree);
        }


        void UncheckAllNodes(TreeView tree)
        {
            TraverseNodeCollectionUncheck(tree.Nodes);
        }

        void TraverseNodeCollectionUncheck(TreeNodeCollection nodesCollection)
        {
            foreach (TreeNode child in nodesCollection)
            {
                UncheckNode(child);
            }
        }

        void UncheckNode(TreeNode child)
        {
            child.Checked = false;

            if (child.Nodes.Count > 0)
            {
                TraverseNodeCollectionUncheck(child.Nodes);
            }

        }



        private void btnCopyChecked_Click(object sender, EventArgs e)
        {
            txtSelectedItems.Clear();
            CopyCheckedItems(MyComputerTree);
        }

        void CopyCheckedItems(TreeView tree)
        {
            TraverseNodeCollectionCopy(tree.Nodes);
        }

        void TraverseNodeCollectionCopy(TreeNodeCollection nodeCollection)
        {
            foreach (TreeNode child in nodeCollection)
            {
                CopyCheckedNode(child);
            }
        }
        void CopyCheckedNode(TreeNode child)
        {
            if (child.Checked)
            {
                txtSelectedItems.Text += child.Text + txtNewLine.Text;
            }

            if (child.Nodes.Count > 0)
            {
                TraverseNodeCollectionCopy(child.Nodes);
            }

        }

        private void btnClearOutput_Click(object sender, EventArgs e)
        {
            txtSelectedItems.Clear();
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
            TraverseNodeCollectionExpand(tree.Nodes);
        }

        void TraverseNodeCollectionExpand(TreeNodeCollection nodeCollection)
        {
            foreach (TreeNode child in nodeCollection)
            {
                ExpandCheckedNode(child);
            }
        }

        void ExpandCheckedNode(TreeNode node)
        {
            if (node.Checked)
            {
                node.Expand();
            }


            if (node.Nodes.Count > 0)
            {
                TraverseNodeCollectionExpand(node.Nodes);
            }

        }

        private void btnCollapseChecked_Click(object sender, EventArgs e)
        {
            CollapseCheckedItems(MyComputerTree);
        }

        void CollapseCheckedItems(TreeView tree)
        {
            TraverseNodeCollectionCollapse(tree.Nodes);
        }

        void TraverseNodeCollectionCollapse(TreeNodeCollection nodeCollection)
        {
            foreach (TreeNode child in nodeCollection)
            {
                CollapseCheckedNode(child);
            }
        }

        void CollapseCheckedNode(TreeNode node)
        {
            if (node.Checked)
            {
              node.Collapse();
            }


            if(node.Nodes.Count > 0)
            {
                TraverseNodeCollectionCollapse(node.Nodes);
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

        private void MyComputerTree_AfterCheck(object sender, TreeViewEventArgs e)
        {
            Check_UnCheckAllMySeletedNode(e.Node,e.Node.Checked);
        }

        void Check_UnCheckAllMySeletedNode(TreeNode node, bool isChecked)
        {

         foreach (TreeNode child in node.Nodes)
         {
             child.Checked = isChecked;
         
             Check_UnCheckAllMySeletedNode(child, isChecked);
         
         }

        }

        }



    }


namespace WinForms_TreeView_File_Explorer_Recursive_Direct
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("My Computer", 2, 2);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Fonts", 3, 3);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Logs", 4, 4);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Windows   ", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Users     ", 1, 1);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Program   ", 1, 1);
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode(" Local Disk C", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Movies    ", 1, 1);
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Games     ", 1, 1);
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Local Disk D", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode(" Recycle Bin", 0, 0);
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewLine = new System.Windows.Forms.TextBox();
            this.btnCollapseChecked = new System.Windows.Forms.Button();
            this.lblShowSeletedFolder = new System.Windows.Forms.Label();
            this.lblFolderName = new System.Windows.Forms.Label();
            this.lblSelectedFolder = new System.Windows.Forms.Label();
            this.btnCopyChecked = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExpandChecked = new System.Windows.Forms.Button();
            this.btnClearOutput = new System.Windows.Forms.Button();
            this.btnUncheckAll = new System.Windows.Forms.Button();
            this.btnCheckAll = new System.Windows.Forms.Button();
            this.btnCollapseAll = new System.Windows.Forms.Button();
            this.btnExpandAll = new System.Windows.Forms.Button();
            this.lblShowFolderName = new System.Windows.Forms.Label();
            this.txtSelectedItems = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.MyComputerTree = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(1176, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 29);
            this.label2.TabIndex = 51;
            this.label2.Text = "Checked Items";
            // 
            // txtNewLine
            // 
            this.txtNewLine.Location = new System.Drawing.Point(1616, 46);
            this.txtNewLine.Name = "txtNewLine";
            this.txtNewLine.Size = new System.Drawing.Size(102, 22);
            this.txtNewLine.TabIndex = 50;
            this.txtNewLine.Text = "\r\n";
            this.txtNewLine.Visible = false;
            // 
            // btnCollapseChecked
            // 
            this.btnCollapseChecked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCollapseChecked.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCollapseChecked.ForeColor = System.Drawing.Color.Orange;
            this.btnCollapseChecked.Location = new System.Drawing.Point(1241, 552);
            this.btnCollapseChecked.Name = "btnCollapseChecked";
            this.btnCollapseChecked.Size = new System.Drawing.Size(174, 66);
            this.btnCollapseChecked.TabIndex = 49;
            this.btnCollapseChecked.Text = "Collapse Checked";
            this.btnCollapseChecked.UseVisualStyleBackColor = false;
            this.btnCollapseChecked.Click += new System.EventHandler(this.btnCollapseChecked_Click);
            // 
            // lblShowSeletedFolder
            // 
            this.lblShowSeletedFolder.AutoSize = true;
            this.lblShowSeletedFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowSeletedFolder.ForeColor = System.Drawing.Color.White;
            this.lblShowSeletedFolder.Location = new System.Drawing.Point(274, 696);
            this.lblShowSeletedFolder.Name = "lblShowSeletedFolder";
            this.lblShowSeletedFolder.Size = new System.Drawing.Size(85, 29);
            this.lblShowSeletedFolder.TabIndex = 41;
            this.lblShowSeletedFolder.Text = "label4";
            // 
            // lblFolderName
            // 
            this.lblFolderName.AutoSize = true;
            this.lblFolderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolderName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFolderName.Location = new System.Drawing.Point(50, 587);
            this.lblFolderName.Name = "lblFolderName";
            this.lblFolderName.Size = new System.Drawing.Size(201, 29);
            this.lblFolderName.TabIndex = 40;
            this.lblFolderName.Text = "Folder Name    :";
            // 
            // lblSelectedFolder
            // 
            this.lblSelectedFolder.AutoSize = true;
            this.lblSelectedFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSelectedFolder.Location = new System.Drawing.Point(36, 696);
            this.lblSelectedFolder.Name = "lblSelectedFolder";
            this.lblSelectedFolder.Size = new System.Drawing.Size(215, 29);
            this.lblSelectedFolder.TabIndex = 39;
            this.lblSelectedFolder.Text = "Selected Folder :";
            // 
            // btnCopyChecked
            // 
            this.btnCopyChecked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCopyChecked.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyChecked.ForeColor = System.Drawing.Color.Orange;
            this.btnCopyChecked.Location = new System.Drawing.Point(527, 678);
            this.btnCopyChecked.Name = "btnCopyChecked";
            this.btnCopyChecked.Size = new System.Drawing.Size(168, 66);
            this.btnCopyChecked.TabIndex = 38;
            this.btnCopyChecked.Text = "Copy Checked";
            this.btnCopyChecked.UseVisualStyleBackColor = false;
            this.btnCopyChecked.Click += new System.EventHandler(this.btnCopyChecked_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(792, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 38);
            this.label1.TabIndex = 37;
            this.label1.Text = "File Explorer";
            // 
            // btnExpandChecked
            // 
            this.btnExpandChecked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExpandChecked.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpandChecked.ForeColor = System.Drawing.Color.Orange;
            this.btnExpandChecked.Location = new System.Drawing.Point(1001, 552);
            this.btnExpandChecked.Name = "btnExpandChecked";
            this.btnExpandChecked.Size = new System.Drawing.Size(174, 66);
            this.btnExpandChecked.TabIndex = 48;
            this.btnExpandChecked.Text = "Expand Checked";
            this.btnExpandChecked.UseVisualStyleBackColor = false;
            this.btnExpandChecked.Click += new System.EventHandler(this.btnExpandChecked_Click);
            // 
            // btnClearOutput
            // 
            this.btnClearOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClearOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearOutput.ForeColor = System.Drawing.Color.Orange;
            this.btnClearOutput.Location = new System.Drawing.Point(1001, 678);
            this.btnClearOutput.Name = "btnClearOutput";
            this.btnClearOutput.Size = new System.Drawing.Size(174, 66);
            this.btnClearOutput.TabIndex = 47;
            this.btnClearOutput.Text = "Clear Output";
            this.btnClearOutput.UseVisualStyleBackColor = false;
            this.btnClearOutput.Click += new System.EventHandler(this.btnClearOutput_Click);
            // 
            // btnUncheckAll
            // 
            this.btnUncheckAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUncheckAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUncheckAll.ForeColor = System.Drawing.Color.Orange;
            this.btnUncheckAll.Location = new System.Drawing.Point(761, 678);
            this.btnUncheckAll.Name = "btnUncheckAll";
            this.btnUncheckAll.Size = new System.Drawing.Size(174, 66);
            this.btnUncheckAll.TabIndex = 46;
            this.btnUncheckAll.Text = "Uncheck All";
            this.btnUncheckAll.UseVisualStyleBackColor = false;
            this.btnUncheckAll.Click += new System.EventHandler(this.btnUncheckAll_Click);
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCheckAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckAll.ForeColor = System.Drawing.Color.Orange;
            this.btnCheckAll.Location = new System.Drawing.Point(1241, 678);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(174, 66);
            this.btnCheckAll.TabIndex = 45;
            this.btnCheckAll.Text = "Check All";
            this.btnCheckAll.UseVisualStyleBackColor = false;
            this.btnCheckAll.Click += new System.EventHandler(this.btnCheckAll_Click);
            // 
            // btnCollapseAll
            // 
            this.btnCollapseAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCollapseAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCollapseAll.ForeColor = System.Drawing.Color.Orange;
            this.btnCollapseAll.Location = new System.Drawing.Point(761, 552);
            this.btnCollapseAll.Name = "btnCollapseAll";
            this.btnCollapseAll.Size = new System.Drawing.Size(174, 66);
            this.btnCollapseAll.TabIndex = 44;
            this.btnCollapseAll.Text = "Collapse All";
            this.btnCollapseAll.UseVisualStyleBackColor = false;
            this.btnCollapseAll.Click += new System.EventHandler(this.btnCollapseAll_Click);
            // 
            // btnExpandAll
            // 
            this.btnExpandAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExpandAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpandAll.ForeColor = System.Drawing.Color.Orange;
            this.btnExpandAll.Location = new System.Drawing.Point(521, 552);
            this.btnExpandAll.Name = "btnExpandAll";
            this.btnExpandAll.Size = new System.Drawing.Size(174, 66);
            this.btnExpandAll.TabIndex = 43;
            this.btnExpandAll.Text = "Expand All";
            this.btnExpandAll.UseVisualStyleBackColor = false;
            this.btnExpandAll.Click += new System.EventHandler(this.btnExpandAll_Click);
            // 
            // lblShowFolderName
            // 
            this.lblShowFolderName.AutoSize = true;
            this.lblShowFolderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowFolderName.ForeColor = System.Drawing.Color.White;
            this.lblShowFolderName.Location = new System.Drawing.Point(274, 589);
            this.lblShowFolderName.Name = "lblShowFolderName";
            this.lblShowFolderName.Size = new System.Drawing.Size(85, 29);
            this.lblShowFolderName.TabIndex = 42;
            this.lblShowFolderName.Text = "label5";
            // 
            // txtSelectedItems
            // 
            this.txtSelectedItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelectedItems.Location = new System.Drawing.Point(1120, 155);
            this.txtSelectedItems.Multiline = true;
            this.txtSelectedItems.Name = "txtSelectedItems";
            this.txtSelectedItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSelectedItems.Size = new System.Drawing.Size(295, 317);
            this.txtSelectedItems.TabIndex = 36;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "135ea817a4200d12a6a965f79b4fea55.png");
            this.imageList1.Images.SetKeyName(1, "Document.png");
            this.imageList1.Images.SetKeyName(2, "laptop-wooden-table.png");
            this.imageList1.Images.SetKeyName(3, "73900bbe05e578338e261011e445a8e9.png");
            this.imageList1.Images.SetKeyName(4, "ebf26168acfc2a3b0ea0da21e7386d13.png");
            // 
            // MyComputerTree
            // 
            this.MyComputerTree.CheckBoxes = true;
            this.MyComputerTree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MyComputerTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyComputerTree.ImageIndex = 0;
            this.MyComputerTree.ImageList = this.imageList1;
            this.MyComputerTree.Location = new System.Drawing.Point(430, 103);
            this.MyComputerTree.Name = "MyComputerTree";
            treeNode1.ImageIndex = 2;
            treeNode1.Name = "Node0";
            treeNode1.SelectedImageIndex = 2;
            treeNode1.Text = "My Computer";
            treeNode2.ImageIndex = 3;
            treeNode2.Name = "Node0";
            treeNode2.SelectedImageIndex = 3;
            treeNode2.Text = "Fonts";
            treeNode3.ImageIndex = 4;
            treeNode3.Name = "Node2";
            treeNode3.SelectedImageIndex = 4;
            treeNode3.Text = "Logs";
            treeNode4.ImageIndex = 1;
            treeNode4.Name = "Node6";
            treeNode4.SelectedImageIndex = 1;
            treeNode4.Text = "Windows   ";
            treeNode5.ImageIndex = 1;
            treeNode5.Name = "Node7";
            treeNode5.SelectedImageIndex = 1;
            treeNode5.Text = "Users     ";
            treeNode6.ImageIndex = 1;
            treeNode6.Name = "Node8";
            treeNode6.SelectedImageIndex = 1;
            treeNode6.Text = "Program   ";
            treeNode7.ImageIndex = 1;
            treeNode7.Name = "Node1";
            treeNode7.SelectedImageIndex = 1;
            treeNode7.Text = " Local Disk C";
            treeNode8.ImageIndex = 1;
            treeNode8.Name = "Node11";
            treeNode8.SelectedImageIndex = 1;
            treeNode8.Text = "Movies    ";
            treeNode9.ImageIndex = 1;
            treeNode9.Name = "Node12";
            treeNode9.SelectedImageIndex = 1;
            treeNode9.Text = "Games     ";
            treeNode10.ImageIndex = 1;
            treeNode10.Name = "Node10";
            treeNode10.SelectedImageIndex = 1;
            treeNode10.Text = "Local Disk D";
            treeNode11.ImageIndex = 0;
            treeNode11.Name = "Node13";
            treeNode11.SelectedImageIndex = 0;
            treeNode11.Text = " Recycle Bin";
            this.MyComputerTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode7,
            treeNode10,
            treeNode11});
            this.MyComputerTree.SelectedImageIndex = 0;
            this.MyComputerTree.Size = new System.Drawing.Size(457, 387);
            this.MyComputerTree.TabIndex = 35;
            this.MyComputerTree.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.MyComputerTree_AfterCheck);
            this.MyComputerTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.MyComputerTree_AfterSelect);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1814, 796);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNewLine);
            this.Controls.Add(this.btnCollapseChecked);
            this.Controls.Add(this.lblShowSeletedFolder);
            this.Controls.Add(this.lblFolderName);
            this.Controls.Add(this.lblSelectedFolder);
            this.Controls.Add(this.btnCopyChecked);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExpandChecked);
            this.Controls.Add(this.btnClearOutput);
            this.Controls.Add(this.btnUncheckAll);
            this.Controls.Add(this.btnCheckAll);
            this.Controls.Add(this.btnCollapseAll);
            this.Controls.Add(this.btnExpandAll);
            this.Controls.Add(this.lblShowFolderName);
            this.Controls.Add(this.txtSelectedItems);
            this.Controls.Add(this.MyComputerTree);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewLine;
        private System.Windows.Forms.Button btnCollapseChecked;
        private System.Windows.Forms.Label lblShowSeletedFolder;
        private System.Windows.Forms.Label lblFolderName;
        private System.Windows.Forms.Label lblSelectedFolder;
        private System.Windows.Forms.Button btnCopyChecked;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExpandChecked;
        private System.Windows.Forms.Button btnClearOutput;
        private System.Windows.Forms.Button btnUncheckAll;
        private System.Windows.Forms.Button btnCheckAll;
        private System.Windows.Forms.Button btnCollapseAll;
        private System.Windows.Forms.Button btnExpandAll;
        private System.Windows.Forms.Label lblShowFolderName;
        private System.Windows.Forms.TextBox txtSelectedItems;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TreeView MyComputerTree;
    }
}


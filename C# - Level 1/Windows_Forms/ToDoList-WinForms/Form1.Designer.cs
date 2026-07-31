namespace To_Do_List_Project
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
            this.label2 = new System.Windows.Forms.Label();
            this.TreeTasks = new System.Windows.Forms.TreeView();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.btnClearAllTasks = new System.Windows.Forms.Button();
            this.btnMarkAllDone = new System.Windows.Forms.Button();
            this.btnUnCheckAll = new System.Windows.Forms.Button();
            this.lblTotalTasks = new System.Windows.Forms.Label();
            this.lblCompletedTasks = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(634, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(571, 69);
            this.label2.TabIndex = 1;
            this.label2.Text = "YOUR TO-DO LIST";
            // 
            // TreeTasks
            // 
            this.TreeTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.TreeTasks.CheckBoxes = true;
            this.TreeTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TreeTasks.Location = new System.Drawing.Point(21, 165);
            this.TreeTasks.Name = "TreeTasks";
            this.TreeTasks.Size = new System.Drawing.Size(455, 378);
            this.TreeTasks.TabIndex = 2;
            this.TreeTasks.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.TreeTasks_AfterCheck);
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(688, 280);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(340, 40);
            this.txtInput.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(640, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "What do you want to do today?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(196, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tasks";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(1276, 289);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(425, 56);
            this.progressBar1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(1437, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Progress";
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercent.ForeColor = System.Drawing.Color.Yellow;
            this.lblPercent.Location = new System.Drawing.Point(1739, 303);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(31, 32);
            this.lblPercent.TabIndex = 8;
            this.lblPercent.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(1340, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "Completed :";
            // 
            // btnAddTask
            // 
            this.btnAddTask.BackColor = System.Drawing.Color.Black;
            this.btnAddTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTask.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnAddTask.Location = new System.Drawing.Point(561, 706);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(177, 74);
            this.btnAddTask.TabIndex = 10;
            this.btnAddTask.Text = "Add Task ";
            this.btnAddTask.UseVisualStyleBackColor = false;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.Black;
            this.btnCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnCategory.Location = new System.Drawing.Point(554, 588);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(184, 74);
            this.btnCategory.TabIndex = 11;
            this.btnCategory.Text = "Add Category";
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Black;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnEdit.Location = new System.Drawing.Point(812, 588);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(177, 74);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.BackColor = System.Drawing.Color.Black;
            this.btnDeleteTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTask.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnDeleteTask.Location = new System.Drawing.Point(812, 706);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(177, 74);
            this.btnDeleteTask.TabIndex = 13;
            this.btnDeleteTask.Text = "Delete Task";
            this.btnDeleteTask.UseVisualStyleBackColor = false;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // btnClearAllTasks
            // 
            this.btnClearAllTasks.BackColor = System.Drawing.Color.Black;
            this.btnClearAllTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAllTasks.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnClearAllTasks.Location = new System.Drawing.Point(1068, 706);
            this.btnClearAllTasks.Name = "btnClearAllTasks";
            this.btnClearAllTasks.Size = new System.Drawing.Size(205, 74);
            this.btnClearAllTasks.TabIndex = 14;
            this.btnClearAllTasks.Text = "Clear All Tasks";
            this.btnClearAllTasks.UseVisualStyleBackColor = false;
            this.btnClearAllTasks.Click += new System.EventHandler(this.btnClearAllTasks_Click);
            // 
            // btnMarkAllDone
            // 
            this.btnMarkAllDone.BackColor = System.Drawing.Color.Black;
            this.btnMarkAllDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarkAllDone.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnMarkAllDone.Location = new System.Drawing.Point(1068, 588);
            this.btnMarkAllDone.Name = "btnMarkAllDone";
            this.btnMarkAllDone.Size = new System.Drawing.Size(192, 74);
            this.btnMarkAllDone.TabIndex = 15;
            this.btnMarkAllDone.Text = "Mark All Done";
            this.btnMarkAllDone.UseVisualStyleBackColor = false;
            this.btnMarkAllDone.Click += new System.EventHandler(this.btnMarkAllDone_Click);
            // 
            // btnUnCheckAll
            // 
            this.btnUnCheckAll.BackColor = System.Drawing.Color.Black;
            this.btnUnCheckAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnCheckAll.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnUnCheckAll.Location = new System.Drawing.Point(1357, 588);
            this.btnUnCheckAll.Name = "btnUnCheckAll";
            this.btnUnCheckAll.Size = new System.Drawing.Size(177, 74);
            this.btnUnCheckAll.TabIndex = 16;
            this.btnUnCheckAll.Text = "Unmark All";
            this.btnUnCheckAll.UseVisualStyleBackColor = false;
            this.btnUnCheckAll.Click += new System.EventHandler(this.btnUnCheckAll_Click);
            // 
            // lblTotalTasks
            // 
            this.lblTotalTasks.AutoSize = true;
            this.lblTotalTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTasks.ForeColor = System.Drawing.Color.White;
            this.lblTotalTasks.Location = new System.Drawing.Point(1662, 389);
            this.lblTotalTasks.Name = "lblTotalTasks";
            this.lblTotalTasks.Size = new System.Drawing.Size(21, 22);
            this.lblTotalTasks.TabIndex = 17;
            this.lblTotalTasks.Text = "0";
            // 
            // lblCompletedTasks
            // 
            this.lblCompletedTasks.AutoSize = true;
            this.lblCompletedTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompletedTasks.ForeColor = System.Drawing.Color.White;
            this.lblCompletedTasks.Location = new System.Drawing.Point(1551, 389);
            this.lblCompletedTasks.Name = "lblCompletedTasks";
            this.lblCompletedTasks.Size = new System.Drawing.Size(21, 22);
            this.lblCompletedTasks.TabIndex = 18;
            this.lblCompletedTasks.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(1605, 381);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 38);
            this.label8.TabIndex = 19;
            this.label8.Text = "/";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1823, 812);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblCompletedTasks);
            this.Controls.Add(this.lblTotalTasks);
            this.Controls.Add(this.btnUnCheckAll);
            this.Controls.Add(this.btnMarkAllDone);
            this.Controls.Add(this.btnClearAllTasks);
            this.Controls.Add(this.btnDeleteTask);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.TreeTasks);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView TreeTasks;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.Button btnClearAllTasks;
        private System.Windows.Forms.Button btnMarkAllDone;
        private System.Windows.Forms.Button btnUnCheckAll;
        private System.Windows.Forms.Label lblTotalTasks;
        private System.Windows.Forms.Label lblCompletedTasks;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}


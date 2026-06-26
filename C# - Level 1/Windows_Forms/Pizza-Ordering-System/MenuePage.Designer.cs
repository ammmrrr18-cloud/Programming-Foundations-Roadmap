namespace pizza
{
    partial class MenuePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuePage));
            this.rdoSmallSize = new System.Windows.Forms.RadioButton();
            this.rdoMedSize = new System.Windows.Forms.RadioButton();
            this.rdoLargeSize = new System.Windows.Forms.RadioButton();
            this.grbox1 = new System.Windows.Forms.GroupBox();
            this.grbox2 = new System.Windows.Forms.GroupBox();
            this.rdoThin = new System.Windows.Forms.RadioButton();
            this.rdoThick = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoEatIn = new System.Windows.Forms.RadioButton();
            this.rdoTakeOut = new System.Windows.Forms.RadioButton();
            this.lablPrice = new System.Windows.Forms.Label();
            this.labelMoney = new System.Windows.Forms.Label();
            this.btnMenuePrices = new System.Windows.Forms.Button();
            this.btnBackToMainPage = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.lablDoller = new System.Windows.Forms.Label();
            this.grbox1.SuspendLayout();
            this.grbox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdoSmallSize
            // 
            this.rdoSmallSize.AutoSize = true;
            this.rdoSmallSize.BackColor = System.Drawing.Color.Transparent;
            this.rdoSmallSize.Checked = true;
            this.rdoSmallSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSmallSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdoSmallSize.Location = new System.Drawing.Point(40, 31);
            this.rdoSmallSize.Name = "rdoSmallSize";
            this.rdoSmallSize.Size = new System.Drawing.Size(82, 29);
            this.rdoSmallSize.TabIndex = 0;
            this.rdoSmallSize.TabStop = true;
            this.rdoSmallSize.Tag = "20";
            this.rdoSmallSize.Text = "Small";
            this.rdoSmallSize.UseVisualStyleBackColor = false;
            this.rdoSmallSize.CheckedChanged += new System.EventHandler(this.rdoSmallSize_CheckedChanged);
            // 
            // rdoMedSize
            // 
            this.rdoMedSize.AutoSize = true;
            this.rdoMedSize.BackColor = System.Drawing.Color.Transparent;
            this.rdoMedSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMedSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdoMedSize.Location = new System.Drawing.Point(40, 53);
            this.rdoMedSize.Name = "rdoMedSize";
            this.rdoMedSize.Size = new System.Drawing.Size(103, 29);
            this.rdoMedSize.TabIndex = 1;
            this.rdoMedSize.Tag = "30";
            this.rdoMedSize.Text = "Medium";
            this.rdoMedSize.UseVisualStyleBackColor = false;
            this.rdoMedSize.CheckedChanged += new System.EventHandler(this.rdoMedSize_CheckedChanged);
            // 
            // rdoLargeSize
            // 
            this.rdoLargeSize.AutoSize = true;
            this.rdoLargeSize.BackColor = System.Drawing.Color.Transparent;
            this.rdoLargeSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoLargeSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdoLargeSize.Location = new System.Drawing.Point(40, 76);
            this.rdoLargeSize.Name = "rdoLargeSize";
            this.rdoLargeSize.Size = new System.Drawing.Size(83, 29);
            this.rdoLargeSize.TabIndex = 2;
            this.rdoLargeSize.Tag = "40";
            this.rdoLargeSize.Text = "Large";
            this.rdoLargeSize.UseVisualStyleBackColor = false;
            this.rdoLargeSize.CheckedChanged += new System.EventHandler(this.rdoLargeSize_CheckedChanged);
            // 
            // grbox1
            // 
            this.grbox1.BackColor = System.Drawing.Color.Transparent;
            this.grbox1.Controls.Add(this.rdoSmallSize);
            this.grbox1.Controls.Add(this.rdoLargeSize);
            this.grbox1.Controls.Add(this.rdoMedSize);
            this.grbox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbox1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbox1.ForeColor = System.Drawing.Color.Coral;
            this.grbox1.Location = new System.Drawing.Point(1181, 167);
            this.grbox1.Name = "grbox1";
            this.grbox1.Size = new System.Drawing.Size(188, 125);
            this.grbox1.TabIndex = 3;
            this.grbox1.TabStop = false;
            this.grbox1.Text = "Size";
            // 
            // grbox2
            // 
            this.grbox2.BackColor = System.Drawing.Color.Transparent;
            this.grbox2.Controls.Add(this.rdoThin);
            this.grbox2.Controls.Add(this.rdoThick);
            this.grbox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbox2.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbox2.ForeColor = System.Drawing.Color.Coral;
            this.grbox2.Location = new System.Drawing.Point(157, 340);
            this.grbox2.Name = "grbox2";
            this.grbox2.Size = new System.Drawing.Size(188, 125);
            this.grbox2.TabIndex = 4;
            this.grbox2.TabStop = false;
            this.grbox2.Text = "Crust Type";
            // 
            // rdoThin
            // 
            this.rdoThin.AutoSize = true;
            this.rdoThin.BackColor = System.Drawing.Color.Transparent;
            this.rdoThin.Checked = true;
            this.rdoThin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoThin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdoThin.Location = new System.Drawing.Point(40, 31);
            this.rdoThin.Name = "rdoThin";
            this.rdoThin.Size = new System.Drawing.Size(124, 29);
            this.rdoThin.TabIndex = 0;
            this.rdoThin.TabStop = true;
            this.rdoThin.Tag = "0";
            this.rdoThin.Text = "Thin Crust";
            this.rdoThin.UseVisualStyleBackColor = false;
            this.rdoThin.CheckedChanged += new System.EventHandler(this.rdoThin_CheckedChanged);
            // 
            // rdoThick
            // 
            this.rdoThick.AutoSize = true;
            this.rdoThick.BackColor = System.Drawing.Color.Transparent;
            this.rdoThick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoThick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdoThick.Location = new System.Drawing.Point(40, 53);
            this.rdoThick.Name = "rdoThick";
            this.rdoThick.Size = new System.Drawing.Size(133, 29);
            this.rdoThick.TabIndex = 1;
            this.rdoThick.Tag = "10";
            this.rdoThick.Text = "Thick Crust";
            this.rdoThick.UseVisualStyleBackColor = false;
            this.rdoThick.CheckedChanged += new System.EventHandler(this.rdoThick_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rdoEatIn);
            this.groupBox1.Controls.Add(this.rdoTakeOut);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Coral;
            this.groupBox1.Location = new System.Drawing.Point(1190, 564);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 125);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Where to Eat";
            // 
            // rdoEatIn
            // 
            this.rdoEatIn.AutoSize = true;
            this.rdoEatIn.BackColor = System.Drawing.Color.Transparent;
            this.rdoEatIn.Checked = true;
            this.rdoEatIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoEatIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdoEatIn.Location = new System.Drawing.Point(40, 31);
            this.rdoEatIn.Name = "rdoEatIn";
            this.rdoEatIn.Size = new System.Drawing.Size(83, 29);
            this.rdoEatIn.TabIndex = 0;
            this.rdoEatIn.TabStop = true;
            this.rdoEatIn.Tag = "2";
            this.rdoEatIn.Text = "Eat In";
            this.rdoEatIn.UseVisualStyleBackColor = false;
            this.rdoEatIn.CheckedChanged += new System.EventHandler(this.rdoEatIn_CheckedChanged);
            // 
            // rdoTakeOut
            // 
            this.rdoTakeOut.AutoSize = true;
            this.rdoTakeOut.BackColor = System.Drawing.Color.Transparent;
            this.rdoTakeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTakeOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rdoTakeOut.Location = new System.Drawing.Point(40, 53);
            this.rdoTakeOut.Name = "rdoTakeOut";
            this.rdoTakeOut.Size = new System.Drawing.Size(115, 29);
            this.rdoTakeOut.TabIndex = 1;
            this.rdoTakeOut.Tag = "5";
            this.rdoTakeOut.Text = "Take Out";
            this.rdoTakeOut.UseVisualStyleBackColor = false;
            this.rdoTakeOut.CheckedChanged += new System.EventHandler(this.rdoTakeOut_CheckedChanged);
            // 
            // lablPrice
            // 
            this.lablPrice.AutoSize = true;
            this.lablPrice.BackColor = System.Drawing.Color.Transparent;
            this.lablPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablPrice.ForeColor = System.Drawing.Color.White;
            this.lablPrice.Location = new System.Drawing.Point(803, 688);
            this.lablPrice.Name = "lablPrice";
            this.lablPrice.Size = new System.Drawing.Size(137, 48);
            this.lablPrice.TabIndex = 6;
            this.lablPrice.Text = "Price : ";
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.BackColor = System.Drawing.Color.Transparent;
            this.labelMoney.Font = new System.Drawing.Font("Microsoft Tai Le", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoney.ForeColor = System.Drawing.Color.Yellow;
            this.labelMoney.Location = new System.Drawing.Point(958, 688);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(51, 48);
            this.labelMoney.TabIndex = 7;
            this.labelMoney.Text = " 0";
            // 
            // btnMenuePrices
            // 
            this.btnMenuePrices.BackColor = System.Drawing.Color.Maroon;
            this.btnMenuePrices.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenuePrices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuePrices.ForeColor = System.Drawing.Color.White;
            this.btnMenuePrices.Location = new System.Drawing.Point(774, 453);
            this.btnMenuePrices.Name = "btnMenuePrices";
            this.btnMenuePrices.Size = new System.Drawing.Size(152, 66);
            this.btnMenuePrices.TabIndex = 8;
            this.btnMenuePrices.Text = "Menu Prices";
            this.btnMenuePrices.UseVisualStyleBackColor = false;
            this.btnMenuePrices.Click += new System.EventHandler(this.btnMenuePrices_Click);
            // 
            // btnBackToMainPage
            // 
            this.btnBackToMainPage.BackColor = System.Drawing.Color.Black;
            this.btnBackToMainPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMainPage.ForeColor = System.Drawing.Color.Red;
            this.btnBackToMainPage.Location = new System.Drawing.Point(12, 688);
            this.btnBackToMainPage.Name = "btnBackToMainPage";
            this.btnBackToMainPage.Size = new System.Drawing.Size(187, 64);
            this.btnBackToMainPage.TabIndex = 9;
            this.btnBackToMainPage.Text = "Back";
            this.btnBackToMainPage.UseVisualStyleBackColor = false;
            this.btnBackToMainPage.Click += new System.EventHandler(this.btnBackToMainPage_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.Black;
            this.btnComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplete.ForeColor = System.Drawing.Color.Red;
            this.btnComplete.Location = new System.Drawing.Point(1597, 688);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(187, 64);
            this.btnComplete.TabIndex = 10;
            this.btnComplete.Text = "Complete ";
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // lablDoller
            // 
            this.lablDoller.AutoSize = true;
            this.lablDoller.BackColor = System.Drawing.Color.Transparent;
            this.lablDoller.Font = new System.Drawing.Font("Microsoft Tai Le", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablDoller.ForeColor = System.Drawing.Color.Yellow;
            this.lablDoller.Location = new System.Drawing.Point(921, 688);
            this.lablDoller.Name = "lablDoller";
            this.lablDoller.Size = new System.Drawing.Size(41, 48);
            this.lablDoller.TabIndex = 11;
            this.lablDoller.Text = "$";
            // 
            // MenuePage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1793, 768);
            this.Controls.Add(this.lablDoller);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnBackToMainPage);
            this.Controls.Add(this.btnMenuePrices);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.lablPrice);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbox2);
            this.Controls.Add(this.grbox1);
            this.Font = new System.Drawing.Font("Adobe Ming Std L", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1811, 815);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1811, 815);
            this.Name = "MenuePage";
            this.Text = "MenuePage";
            this.Load += new System.EventHandler(this.MenuePage_Load);
            this.grbox1.ResumeLayout(false);
            this.grbox1.PerformLayout();
            this.grbox2.ResumeLayout(false);
            this.grbox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoSmallSize;
        private System.Windows.Forms.RadioButton rdoMedSize;
        private System.Windows.Forms.RadioButton rdoLargeSize;
        private System.Windows.Forms.GroupBox grbox1;
        private System.Windows.Forms.GroupBox grbox2;
        private System.Windows.Forms.RadioButton rdoThin;
        private System.Windows.Forms.RadioButton rdoThick;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoEatIn;
        private System.Windows.Forms.RadioButton rdoTakeOut;
        private System.Windows.Forms.Label lablPrice;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Button btnMenuePrices;
        private System.Windows.Forms.Button btnBackToMainPage;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Label lablDoller;
    }
}
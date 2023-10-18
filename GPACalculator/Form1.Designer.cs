namespace GPACalculator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.isUnweighted = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteAll = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reqCredits = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.creditManagementButton = new System.Windows.Forms.Button();
            this.seniorValLabel = new System.Windows.Forms.Label();
            this.juniorValLabel = new System.Windows.Forms.Label();
            this.sophomoreValLabel = new System.Windows.Forms.Label();
            this.freshmanValLabel = new System.Windows.Forms.Label();
            this.overallValLabel = new System.Windows.Forms.Label();
            this.overallLabel = new System.Windows.Forms.Label();
            this.seniorLabel = new System.Windows.Forms.Label();
            this.juniorLabel = new System.Windows.Forms.Label();
            this.sophomoreLabel = new System.Windows.Forms.Label();
            this.freshmanLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.isUnweighted);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.reqCredits);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.creditManagementButton);
            this.panel1.Controls.Add(this.seniorValLabel);
            this.panel1.Controls.Add(this.juniorValLabel);
            this.panel1.Controls.Add(this.sophomoreValLabel);
            this.panel1.Controls.Add(this.freshmanValLabel);
            this.panel1.Controls.Add(this.overallValLabel);
            this.panel1.Controls.Add(this.overallLabel);
            this.panel1.Controls.Add(this.seniorLabel);
            this.panel1.Controls.Add(this.juniorLabel);
            this.panel1.Controls.Add(this.sophomoreLabel);
            this.panel1.Controls.Add(this.freshmanLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 619);
            this.panel1.TabIndex = 0;
            // 
            // isUnweighted
            // 
            this.isUnweighted.AutoSize = true;
            this.isUnweighted.Location = new System.Drawing.Point(22, 9);
            this.isUnweighted.Name = "isUnweighted";
            this.isUnweighted.Size = new System.Drawing.Size(132, 17);
            this.isUnweighted.TabIndex = 15;
            this.isUnweighted.Text = "Check for Unweighted";
            this.isUnweighted.UseVisualStyleBackColor = true;
            this.isUnweighted.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.deleteAll);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(308, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(840, 592);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credits List";
            // 
            // deleteAll
            // 
            this.deleteAll.AutoSize = true;
            this.deleteAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.deleteAll.Location = new System.Drawing.Point(603, 551);
            this.deleteAll.Name = "deleteAll";
            this.deleteAll.Size = new System.Drawing.Size(231, 35);
            this.deleteAll.TabIndex = 15;
            this.deleteAll.Text = "Delete All Classes";
            this.deleteAll.UseVisualStyleBackColor = true;
            this.deleteAll.Click += new System.EventHandler(this.deleteAll_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 27);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(834, 562);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Year";
            this.columnHeader2.Width = 145;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Grade%";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Credits";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "AP?";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Honors?";
            this.columnHeader6.Width = 100;
            // 
            // reqCredits
            // 
            this.reqCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqCredits.Location = new System.Drawing.Point(17, 529);
            this.reqCredits.Name = "reqCredits";
            this.reqCredits.Padding = new System.Windows.Forms.Padding(0, 25, 0, 25);
            this.reqCredits.Size = new System.Drawing.Size(231, 75);
            this.reqCredits.TabIndex = 13;
            this.reqCredits.Text = "0 / 0";
            this.reqCredits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 425);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 25, 0, 25);
            this.label1.Size = new System.Drawing.Size(231, 75);
            this.label1.TabIndex = 12;
            this.label1.Text = "Required Credits";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(17, 503);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(231, 23);
            this.progressBar1.TabIndex = 11;
            // 
            // creditManagementButton
            // 
            this.creditManagementButton.AutoSize = true;
            this.creditManagementButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.creditManagementButton.Location = new System.Drawing.Point(17, 387);
            this.creditManagementButton.Name = "creditManagementButton";
            this.creditManagementButton.Size = new System.Drawing.Size(231, 35);
            this.creditManagementButton.TabIndex = 10;
            this.creditManagementButton.Text = "Add / Remove Credits";
            this.creditManagementButton.UseVisualStyleBackColor = true;
            this.creditManagementButton.Click += new System.EventHandler(this.creditManagementButton_Click);
            // 
            // seniorValLabel
            // 
            this.seniorValLabel.AutoSize = true;
            this.seniorValLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seniorValLabel.Location = new System.Drawing.Point(192, 309);
            this.seniorValLabel.Name = "seniorValLabel";
            this.seniorValLabel.Padding = new System.Windows.Forms.Padding(0, 25, 0, 25);
            this.seniorValLabel.Size = new System.Drawing.Size(24, 75);
            this.seniorValLabel.TabIndex = 9;
            this.seniorValLabel.Text = "?";
            this.seniorValLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // juniorValLabel
            // 
            this.juniorValLabel.AutoSize = true;
            this.juniorValLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.juniorValLabel.Location = new System.Drawing.Point(192, 234);
            this.juniorValLabel.Name = "juniorValLabel";
            this.juniorValLabel.Padding = new System.Windows.Forms.Padding(0, 25, 0, 25);
            this.juniorValLabel.Size = new System.Drawing.Size(24, 75);
            this.juniorValLabel.TabIndex = 8;
            this.juniorValLabel.Text = "?";
            this.juniorValLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sophomoreValLabel
            // 
            this.sophomoreValLabel.AutoSize = true;
            this.sophomoreValLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sophomoreValLabel.Location = new System.Drawing.Point(192, 159);
            this.sophomoreValLabel.Name = "sophomoreValLabel";
            this.sophomoreValLabel.Padding = new System.Windows.Forms.Padding(0, 25, 0, 25);
            this.sophomoreValLabel.Size = new System.Drawing.Size(24, 75);
            this.sophomoreValLabel.TabIndex = 7;
            this.sophomoreValLabel.Text = "?";
            this.sophomoreValLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // freshmanValLabel
            // 
            this.freshmanValLabel.AutoSize = true;
            this.freshmanValLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freshmanValLabel.Location = new System.Drawing.Point(192, 84);
            this.freshmanValLabel.Name = "freshmanValLabel";
            this.freshmanValLabel.Padding = new System.Windows.Forms.Padding(0, 25, 0, 25);
            this.freshmanValLabel.Size = new System.Drawing.Size(24, 75);
            this.freshmanValLabel.TabIndex = 6;
            this.freshmanValLabel.Text = "?";
            this.freshmanValLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // overallValLabel
            // 
            this.overallValLabel.AutoSize = true;
            this.overallValLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overallValLabel.Location = new System.Drawing.Point(192, 9);
            this.overallValLabel.Name = "overallValLabel";
            this.overallValLabel.Padding = new System.Windows.Forms.Padding(0, 25, 0, 25);
            this.overallValLabel.Size = new System.Drawing.Size(24, 75);
            this.overallValLabel.TabIndex = 5;
            this.overallValLabel.Text = "?";
            this.overallValLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.overallValLabel.Click += new System.EventHandler(this.overallValLabel_Click);
            // 
            // overallLabel
            // 
            this.overallLabel.AutoSize = true;
            this.overallLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overallLabel.Location = new System.Drawing.Point(106, 9);
            this.overallLabel.Name = "overallLabel";
            this.overallLabel.Padding = new System.Windows.Forms.Padding(0, 25, 0, 25);
            this.overallLabel.Size = new System.Drawing.Size(80, 75);
            this.overallLabel.TabIndex = 4;
            this.overallLabel.Text = "Overall";
            this.overallLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.overallLabel.Click += new System.EventHandler(this.overallLabel_Click);
            // 
            // seniorLabel
            // 
            this.seniorLabel.AutoSize = true;
            this.seniorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seniorLabel.Location = new System.Drawing.Point(60, 309);
            this.seniorLabel.Name = "seniorLabel";
            this.seniorLabel.Padding = new System.Windows.Forms.Padding(0, 25, 0, 25);
            this.seniorLabel.Size = new System.Drawing.Size(126, 75);
            this.seniorLabel.TabIndex = 3;
            this.seniorLabel.Text = "Senior Year";
            this.seniorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // juniorLabel
            // 
            this.juniorLabel.AutoSize = true;
            this.juniorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.juniorLabel.Location = new System.Drawing.Point(63, 234);
            this.juniorLabel.Name = "juniorLabel";
            this.juniorLabel.Padding = new System.Windows.Forms.Padding(0, 25, 0, 25);
            this.juniorLabel.Size = new System.Drawing.Size(123, 75);
            this.juniorLabel.TabIndex = 2;
            this.juniorLabel.Text = "Junior Year";
            this.juniorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sophomoreLabel
            // 
            this.sophomoreLabel.AutoSize = true;
            this.sophomoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sophomoreLabel.Location = new System.Drawing.Point(12, 159);
            this.sophomoreLabel.Name = "sophomoreLabel";
            this.sophomoreLabel.Padding = new System.Windows.Forms.Padding(0, 25, 0, 25);
            this.sophomoreLabel.Size = new System.Drawing.Size(174, 75);
            this.sophomoreLabel.TabIndex = 1;
            this.sophomoreLabel.Text = "Sophomore Year";
            this.sophomoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // freshmanLabel
            // 
            this.freshmanLabel.AutoSize = true;
            this.freshmanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freshmanLabel.Location = new System.Drawing.Point(26, 84);
            this.freshmanLabel.Name = "freshmanLabel";
            this.freshmanLabel.Padding = new System.Windows.Forms.Padding(0, 25, 0, 25);
            this.freshmanLabel.Size = new System.Drawing.Size(160, 75);
            this.freshmanLabel.TabIndex = 0;
            this.freshmanLabel.Text = "Freshman Year";
            this.freshmanLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 619);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label seniorLabel;
        private System.Windows.Forms.Label juniorLabel;
        private System.Windows.Forms.Label sophomoreLabel;
        private System.Windows.Forms.Label freshmanLabel;
        private System.Windows.Forms.Button creditManagementButton;
        private System.Windows.Forms.Label seniorValLabel;
        private System.Windows.Forms.Label juniorValLabel;
        private System.Windows.Forms.Label sophomoreValLabel;
        private System.Windows.Forms.Label freshmanValLabel;
        private System.Windows.Forms.Label overallValLabel;
        private System.Windows.Forms.Label overallLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label reqCredits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteAll;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.CheckBox isUnweighted;
    }
}


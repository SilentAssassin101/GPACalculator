namespace GPACalculator
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.isHonorsCheck = new System.Windows.Forms.CheckBox();
            this.isAPCheck = new System.Windows.Forms.CheckBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.numCredits = new System.Windows.Forms.NumericUpDown();
            this.numGrade = new System.Windows.Forms.NumericUpDown();
            this.submitCreditsButton = new System.Windows.Forms.Button();
            this.txtYear = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numCredits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 25, 0, 25);
            this.label1.Size = new System.Drawing.Size(140, 75);
            this.label1.TabIndex = 5;
            this.label1.Text = "Class Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 25, 0, 25);
            this.label2.Size = new System.Drawing.Size(140, 75);
            this.label2.TabIndex = 6;
            this.label2.Text = "Num Credits";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 159);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 25, 0, 25);
            this.label3.Size = new System.Drawing.Size(140, 75);
            this.label3.TabIndex = 7;
            this.label3.Text = "Grade %";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // isHonorsCheck
            // 
            this.isHonorsCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.isHonorsCheck.Location = new System.Drawing.Point(8, 237);
            this.isHonorsCheck.Name = "isHonorsCheck";
            this.isHonorsCheck.Padding = new System.Windows.Forms.Padding(0, 25, 0, 25);
            this.isHonorsCheck.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.isHonorsCheck.Size = new System.Drawing.Size(140, 75);
            this.isHonorsCheck.TabIndex = 8;
            this.isHonorsCheck.Text = "Is Honors?";
            this.isHonorsCheck.UseVisualStyleBackColor = true;
            // 
            // isAPCheck
            // 
            this.isAPCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.isAPCheck.Location = new System.Drawing.Point(8, 322);
            this.isAPCheck.Name = "isAPCheck";
            this.isAPCheck.Padding = new System.Windows.Forms.Padding(0, 25, 0, 25);
            this.isAPCheck.Size = new System.Drawing.Size(140, 75);
            this.isAPCheck.TabIndex = 9;
            this.isAPCheck.Text = "Is AP?";
            this.isAPCheck.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtName.Location = new System.Drawing.Point(158, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(268, 31);
            this.txtName.TabIndex = 10;
            this.txtName.Text = "Enter Class Name";
            // 
            // numCredits
            // 
            this.numCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.numCredits.Location = new System.Drawing.Point(158, 107);
            this.numCredits.Name = "numCredits";
            this.numCredits.Size = new System.Drawing.Size(120, 31);
            this.numCredits.TabIndex = 11;
            // 
            // numGrade
            // 
            this.numGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.numGrade.Location = new System.Drawing.Point(158, 182);
            this.numGrade.Name = "numGrade";
            this.numGrade.Size = new System.Drawing.Size(120, 31);
            this.numGrade.TabIndex = 12;
            // 
            // submitCreditsButton
            // 
            this.submitCreditsButton.AutoSize = true;
            this.submitCreditsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitCreditsButton.Location = new System.Drawing.Point(154, 237);
            this.submitCreditsButton.Name = "submitCreditsButton";
            this.submitCreditsButton.Size = new System.Drawing.Size(272, 139);
            this.submitCreditsButton.TabIndex = 14;
            this.submitCreditsButton.Text = "Submit";
            this.submitCreditsButton.UseVisualStyleBackColor = true;
            this.submitCreditsButton.Click += new System.EventHandler(this.submitCreditsButton_Click);
            // 
            // txtYear
            // 
            this.txtYear.AutoCompleteCustomSource.AddRange(new string[] {
            "Freshman",
            "Sophomore",
            "Junior",
            "Senior"});
            this.txtYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtYear.FormattingEnabled = true;
            this.txtYear.Location = new System.Drawing.Point(285, 105);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(141, 33);
            this.txtYear.TabIndex = 15;
            this.txtYear.Text = "Class Year";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 395);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.submitCreditsButton);
            this.Controls.Add(this.numGrade);
            this.Controls.Add(this.numCredits);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.isAPCheck);
            this.Controls.Add(this.isHonorsCheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.numCredits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox isHonorsCheck;
        private System.Windows.Forms.CheckBox isAPCheck;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown numCredits;
        private System.Windows.Forms.NumericUpDown numGrade;
        private System.Windows.Forms.Button submitCreditsButton;
        private System.Windows.Forms.ComboBox txtYear;
    }
}
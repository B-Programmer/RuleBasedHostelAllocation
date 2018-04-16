namespace RuleBasedHostelAllocation
{
    partial class FrmAddNewHostel
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtHostelName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHostelLocation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboHostelCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboHostelType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblMarquee = new System.Windows.Forms.Label();
            this.txtNumberOfBlocks = new System.Windows.Forms.TextBox();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdNext = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::RuleBasedHostelAllocation.Properties.Resources.background1;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtHostelName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtHostelLocation);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cboHostelCategory);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cboHostelType);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblQuestion);
            this.panel1.Controls.Add(this.lblMarquee);
            this.panel1.Controls.Add(this.txtNumberOfBlocks);
            this.panel1.Controls.Add(this.CmdCancel);
            this.panel1.Controls.Add(this.CmdNext);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 475);
            this.panel1.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(241, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(321, 34);
            this.label3.TabIndex = 27;
            this.label3.Text = "Add New Hostel Form";
            // 
            // txtHostelName
            // 
            this.txtHostelName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtHostelName.Location = new System.Drawing.Point(473, 141);
            this.txtHostelName.Name = "txtHostelName";
            this.txtHostelName.Size = new System.Drawing.Size(265, 26);
            this.txtHostelName.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(86, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(274, 30);
            this.label6.TabIndex = 25;
            this.label6.Text = "Hostel Name:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHostelLocation
            // 
            this.txtHostelLocation.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.txtHostelLocation.Location = new System.Drawing.Point(473, 285);
            this.txtHostelLocation.Name = "txtHostelLocation";
            this.txtHostelLocation.Size = new System.Drawing.Size(265, 29);
            this.txtHostelLocation.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 30);
            this.label4.TabIndex = 21;
            this.label4.Text = "Address/Location:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboHostelCategory
            // 
            this.cboHostelCategory.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHostelCategory.FormattingEnabled = true;
            this.cboHostelCategory.Items.AddRange(new object[] {
            "Male-Hostel",
            "Female-Hostel"});
            this.cboHostelCategory.Location = new System.Drawing.Point(473, 179);
            this.cboHostelCategory.Name = "cboHostelCategory";
            this.cboHostelCategory.Size = new System.Drawing.Size(265, 29);
            this.cboHostelCategory.TabIndex = 19;
            this.cboHostelCategory.Text = "Male-Hostel";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 30);
            this.label2.TabIndex = 17;
            this.label2.Text = "Hostel Category:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboHostelType
            // 
            this.cboHostelType.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHostelType.FormattingEnabled = true;
            this.cboHostelType.Items.AddRange(new object[] {
            "Single-Block",
            "Multi-Blocks"});
            this.cboHostelType.Location = new System.Drawing.Point(473, 216);
            this.cboHostelType.Name = "cboHostelType";
            this.cboHostelType.Size = new System.Drawing.Size(265, 29);
            this.cboHostelType.TabIndex = 16;
            this.cboHostelType.Text = "Single-Block";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "Hostel Type:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(86, 250);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(304, 30);
            this.lblQuestion.TabIndex = 10;
            this.lblQuestion.Text = "Number of Blocks (Halls):";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMarquee
            // 
            this.lblMarquee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblMarquee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarquee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMarquee.Location = new System.Drawing.Point(145, 10);
            this.lblMarquee.Name = "lblMarquee";
            this.lblMarquee.Size = new System.Drawing.Size(575, 28);
            this.lblMarquee.TabIndex = 14;
            this.lblMarquee.Text = "Design and Implementation of A Rule-Based Hostel Allocation System";
            // 
            // txtNumberOfBlocks
            // 
            this.txtNumberOfBlocks.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.txtNumberOfBlocks.Location = new System.Drawing.Point(473, 249);
            this.txtNumberOfBlocks.Name = "txtNumberOfBlocks";
            this.txtNumberOfBlocks.Size = new System.Drawing.Size(265, 29);
            this.txtNumberOfBlocks.TabIndex = 11;
            this.txtNumberOfBlocks.Text = "1";
            // 
            // CmdCancel
            // 
            this.CmdCancel.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdCancel.Location = new System.Drawing.Point(435, 378);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(180, 44);
            this.CmdCancel.TabIndex = 13;
            this.CmdCancel.Text = "Cancel";
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // CmdNext
            // 
            this.CmdNext.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdNext.Location = new System.Drawing.Point(229, 378);
            this.CmdNext.Name = "CmdNext";
            this.CmdNext.Size = new System.Drawing.Size(180, 44);
            this.CmdNext.TabIndex = 12;
            this.CmdNext.Text = "Next>>>";
            this.CmdNext.UseVisualStyleBackColor = true;
            this.CmdNext.Click += new System.EventHandler(this.CmdNext_Click);
            // 
            // FrmAddNewHostel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RuleBasedHostelAllocation.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(887, 499);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddNewHostel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Hostel Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtHostelName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHostelLocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboHostelCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboHostelType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblMarquee;
        private System.Windows.Forms.TextBox txtNumberOfBlocks;
        private System.Windows.Forms.Button CmdCancel;
        private System.Windows.Forms.Button CmdNext;
        private System.Windows.Forms.Label label3;
    }
}
namespace RuleBasedHostelAllocation
{
    partial class AddHostelDetails
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNumberOfBlocks = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.grpMultiBlocks = new System.Windows.Forms.GroupBox();
            this.btnAddBlocks = new System.Windows.Forms.Button();
            this.txtMFirstRoomNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMNumberOfBedSpace = new System.Windows.Forms.TextBox();
            this.txtMNumberOfRooms = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMBlockName = new System.Windows.Forms.TextBox();
            this.grpSingleBlock = new System.Windows.Forms.GroupBox();
            this.txtFirstRoomNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumberOfBedSpace = new System.Windows.Forms.TextBox();
            this.txtNumberOfRooms = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtBlockName = new System.Windows.Forms.TextBox();
            this.txtHostelType = new System.Windows.Forms.TextBox();
            this.txtHostelName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMarquee = new System.Windows.Forms.Label();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.lstBlocks = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grpMultiBlocks.SuspendLayout();
            this.grpSingleBlock.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::RuleBasedHostelAllocation.Properties.Resources.background1;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblMarquee);
            this.panel1.Controls.Add(this.CmdCancel);
            this.panel1.Controls.Add(this.CmdSave);
            this.panel1.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.panel1.Location = new System.Drawing.Point(14, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 508);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.txtNumberOfBlocks);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.grpMultiBlocks);
            this.panel2.Controls.Add(this.grpSingleBlock);
            this.panel2.Controls.Add(this.txtHostelType);
            this.panel2.Controls.Add(this.txtHostelName);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(69, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(732, 367);
            this.panel2.TabIndex = 28;
            // 
            // txtNumberOfBlocks
            // 
            this.txtNumberOfBlocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfBlocks.Location = new System.Drawing.Point(420, 67);
            this.txtNumberOfBlocks.Name = "txtNumberOfBlocks";
            this.txtNumberOfBlocks.ReadOnly = true;
            this.txtNumberOfBlocks.Size = new System.Drawing.Size(265, 26);
            this.txtNumberOfBlocks.TabIndex = 32;
            this.txtNumberOfBlocks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label11.Location = new System.Drawing.Point(31, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(381, 22);
            this.label11.TabIndex = 31;
            this.label11.Text = "Number of Blocks(Halls):";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpMultiBlocks
            // 
            this.grpMultiBlocks.Controls.Add(this.lstBlocks);
            this.grpMultiBlocks.Controls.Add(this.btnAddBlocks);
            this.grpMultiBlocks.Controls.Add(this.txtMFirstRoomNumber);
            this.grpMultiBlocks.Controls.Add(this.label7);
            this.grpMultiBlocks.Controls.Add(this.txtMNumberOfBedSpace);
            this.grpMultiBlocks.Controls.Add(this.txtMNumberOfRooms);
            this.grpMultiBlocks.Controls.Add(this.label8);
            this.grpMultiBlocks.Controls.Add(this.label9);
            this.grpMultiBlocks.Controls.Add(this.label10);
            this.grpMultiBlocks.Controls.Add(this.txtMBlockName);
            this.grpMultiBlocks.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMultiBlocks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grpMultiBlocks.Location = new System.Drawing.Point(18, 99);
            this.grpMultiBlocks.Name = "grpMultiBlocks";
            this.grpMultiBlocks.Size = new System.Drawing.Size(690, 256);
            this.grpMultiBlocks.TabIndex = 30;
            this.grpMultiBlocks.TabStop = false;
            this.grpMultiBlocks.Text = "Multi-Blocks Hostel";
            // 
            // btnAddBlocks
            // 
            this.btnAddBlocks.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBlocks.Location = new System.Drawing.Point(531, 160);
            this.btnAddBlocks.Name = "btnAddBlocks";
            this.btnAddBlocks.Size = new System.Drawing.Size(140, 44);
            this.btnAddBlocks.TabIndex = 32;
            this.btnAddBlocks.Text = "Add Blocks";
            this.btnAddBlocks.UseVisualStyleBackColor = true;
            this.btnAddBlocks.Click += new System.EventHandler(this.btnAddBlocks_Click);
            // 
            // txtMFirstRoomNumber
            // 
            this.txtMFirstRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMFirstRoomNumber.Location = new System.Drawing.Point(406, 117);
            this.txtMFirstRoomNumber.Name = "txtMFirstRoomNumber";
            this.txtMFirstRoomNumber.Size = new System.Drawing.Size(265, 26);
            this.txtMFirstRoomNumber.TabIndex = 30;
            this.txtMFirstRoomNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.Location = new System.Drawing.Point(19, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(321, 30);
            this.label7.TabIndex = 29;
            this.label7.Text = "First Room Number:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMNumberOfBedSpace
            // 
            this.txtMNumberOfBedSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMNumberOfBedSpace.Location = new System.Drawing.Point(406, 87);
            this.txtMNumberOfBedSpace.Name = "txtMNumberOfBedSpace";
            this.txtMNumberOfBedSpace.Size = new System.Drawing.Size(265, 26);
            this.txtMNumberOfBedSpace.TabIndex = 28;
            this.txtMNumberOfBedSpace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMNumberOfRooms
            // 
            this.txtMNumberOfRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMNumberOfRooms.Location = new System.Drawing.Point(406, 57);
            this.txtMNumberOfRooms.Name = "txtMNumberOfRooms";
            this.txtMNumberOfRooms.Size = new System.Drawing.Size(265, 26);
            this.txtMNumberOfRooms.TabIndex = 23;
            this.txtMNumberOfRooms.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label8.Location = new System.Drawing.Point(19, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(262, 31);
            this.label8.TabIndex = 21;
            this.label8.Text = "Number of Rooms:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label9.Location = new System.Drawing.Point(19, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(321, 30);
            this.label9.TabIndex = 17;
            this.label9.Text = "Number of Bed Space(per room):";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label10.Location = new System.Drawing.Point(19, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(304, 24);
            this.label10.TabIndex = 10;
            this.label10.Text = "Block Name:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMBlockName
            // 
            this.txtMBlockName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMBlockName.Location = new System.Drawing.Point(406, 28);
            this.txtMBlockName.Name = "txtMBlockName";
            this.txtMBlockName.Size = new System.Drawing.Size(265, 26);
            this.txtMBlockName.TabIndex = 11;
            this.txtMBlockName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpSingleBlock
            // 
            this.grpSingleBlock.Controls.Add(this.txtFirstRoomNumber);
            this.grpSingleBlock.Controls.Add(this.label5);
            this.grpSingleBlock.Controls.Add(this.txtNumberOfBedSpace);
            this.grpSingleBlock.Controls.Add(this.txtNumberOfRooms);
            this.grpSingleBlock.Controls.Add(this.label4);
            this.grpSingleBlock.Controls.Add(this.label2);
            this.grpSingleBlock.Controls.Add(this.lblQuestion);
            this.grpSingleBlock.Controls.Add(this.txtBlockName);
            this.grpSingleBlock.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSingleBlock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grpSingleBlock.Location = new System.Drawing.Point(12, 134);
            this.grpSingleBlock.Name = "grpSingleBlock";
            this.grpSingleBlock.Size = new System.Drawing.Size(690, 184);
            this.grpSingleBlock.TabIndex = 29;
            this.grpSingleBlock.TabStop = false;
            this.grpSingleBlock.Text = "Single-Block Hostel";
            // 
            // txtFirstRoomNumber
            // 
            this.txtFirstRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstRoomNumber.Location = new System.Drawing.Point(406, 141);
            this.txtFirstRoomNumber.Name = "txtFirstRoomNumber";
            this.txtFirstRoomNumber.Size = new System.Drawing.Size(265, 26);
            this.txtFirstRoomNumber.TabIndex = 30;
            this.txtFirstRoomNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(19, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(321, 30);
            this.label5.TabIndex = 29;
            this.label5.Text = "First Room Number:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNumberOfBedSpace
            // 
            this.txtNumberOfBedSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfBedSpace.Location = new System.Drawing.Point(406, 101);
            this.txtNumberOfBedSpace.Name = "txtNumberOfBedSpace";
            this.txtNumberOfBedSpace.Size = new System.Drawing.Size(265, 26);
            this.txtNumberOfBedSpace.TabIndex = 28;
            this.txtNumberOfBedSpace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumberOfRooms
            // 
            this.txtNumberOfRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfRooms.Location = new System.Drawing.Point(406, 68);
            this.txtNumberOfRooms.Name = "txtNumberOfRooms";
            this.txtNumberOfRooms.Size = new System.Drawing.Size(265, 26);
            this.txtNumberOfRooms.TabIndex = 23;
            this.txtNumberOfRooms.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(19, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 31);
            this.label4.TabIndex = 21;
            this.label4.Text = "Number of Rooms:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(19, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 30);
            this.label2.TabIndex = 17;
            this.label2.Text = "Number of Bed Space(per room):";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblQuestion.Location = new System.Drawing.Point(19, 33);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(304, 24);
            this.lblQuestion.TabIndex = 10;
            this.lblQuestion.Text = "Block Name:";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBlockName
            // 
            this.txtBlockName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBlockName.Location = new System.Drawing.Point(406, 34);
            this.txtBlockName.Name = "txtBlockName";
            this.txtBlockName.Size = new System.Drawing.Size(265, 26);
            this.txtBlockName.TabIndex = 11;
            this.txtBlockName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHostelType
            // 
            this.txtHostelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHostelType.Location = new System.Drawing.Point(419, 36);
            this.txtHostelType.Name = "txtHostelType";
            this.txtHostelType.ReadOnly = true;
            this.txtHostelType.Size = new System.Drawing.Size(265, 26);
            this.txtHostelType.TabIndex = 27;
            this.txtHostelType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHostelName
            // 
            this.txtHostelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHostelName.Location = new System.Drawing.Point(419, 6);
            this.txtHostelName.Name = "txtHostelName";
            this.txtHostelName.ReadOnly = true;
            this.txtHostelName.Size = new System.Drawing.Size(265, 26);
            this.txtHostelName.TabIndex = 26;
            this.txtHostelName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.Location = new System.Drawing.Point(32, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(274, 26);
            this.label6.TabIndex = 25;
            this.label6.Text = "Hostel Name:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Hostel Type:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(241, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 34);
            this.label3.TabIndex = 27;
            this.label3.Text = "Add Hostel Details Form";
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
            // CmdCancel
            // 
            this.CmdCancel.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdCancel.Location = new System.Drawing.Point(624, 461);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(180, 44);
            this.CmdCancel.TabIndex = 13;
            this.CmdCancel.Text = "Cancel";
            this.CmdCancel.UseVisualStyleBackColor = true;
            // 
            // CmdSave
            // 
            this.CmdSave.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdSave.Location = new System.Drawing.Point(438, 461);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(180, 44);
            this.CmdSave.TabIndex = 12;
            this.CmdSave.Text = "Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // lstBlocks
            // 
            this.lstBlocks.Location = new System.Drawing.Point(12, 148);
            this.lstBlocks.Name = "lstBlocks";
            this.lstBlocks.Size = new System.Drawing.Size(499, 107);
            this.lstBlocks.TabIndex = 33;
            this.lstBlocks.UseCompatibleStateImageBehavior = false;
            // 
            // AddHostelDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RuleBasedHostelAllocation.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(882, 529);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddHostelDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Hostel Details Form";
            this.Load += new System.EventHandler(this.AddHostelDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grpMultiBlocks.ResumeLayout(false);
            this.grpMultiBlocks.PerformLayout();
            this.grpSingleBlock.ResumeLayout(false);
            this.grpSingleBlock.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHostelName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumberOfRooms;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblMarquee;
        private System.Windows.Forms.TextBox txtBlockName;
        private System.Windows.Forms.Button CmdCancel;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtHostelType;
        private System.Windows.Forms.TextBox txtNumberOfBedSpace;
        private System.Windows.Forms.GroupBox grpSingleBlock;
        private System.Windows.Forms.TextBox txtFirstRoomNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpMultiBlocks;
        private System.Windows.Forms.TextBox txtMFirstRoomNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMNumberOfBedSpace;
        private System.Windows.Forms.TextBox txtMNumberOfRooms;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMBlockName;
        private System.Windows.Forms.Button btnAddBlocks;
        private System.Windows.Forms.TextBox txtNumberOfBlocks;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView lstBlocks;
    }
}
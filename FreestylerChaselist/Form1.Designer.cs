﻿namespace FreestylerChaselist
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
            this.openProjectButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.connectionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.projectNameTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveProjectButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cueLabel = new System.Windows.Forms.Label();
            this.playChaseButton = new System.Windows.Forms.Button();
            this.stopChaseButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.insertChaseButton = new System.Windows.Forms.Button();
            this.addChaseButton = new System.Windows.Forms.Button();
            this.moveChaseUpButton = new System.Windows.Forms.Button();
            this.moveChaseDownButton = new System.Windows.Forms.Button();
            this.deleteChaseButton = new System.Windows.Forms.Button();
            this.editChaseButton = new System.Windows.Forms.Button();
            this.copyChaseButton = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openProjectButton
            // 
            this.openProjectButton.Location = new System.Drawing.Point(361, 10);
            this.openProjectButton.Name = "openProjectButton";
            this.openProjectButton.Size = new System.Drawing.Size(57, 23);
            this.openProjectButton.TabIndex = 1;
            this.openProjectButton.Text = "Open";
            this.openProjectButton.UseVisualStyleBackColor = true;
            this.openProjectButton.Click += new System.EventHandler(this.openProjectButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 239);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(554, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // connectionStatusLabel
            // 
            this.connectionStatusLabel.Name = "connectionStatusLabel";
            this.connectionStatusLabel.Size = new System.Drawing.Size(118, 17);
            this.connectionStatusLabel.Text = "toolStripStatusLabel1";
            // 
            // projectNameTextbox
            // 
            this.projectNameTextbox.Location = new System.Drawing.Point(193, 12);
            this.projectNameTextbox.Name = "projectNameTextbox";
            this.projectNameTextbox.Size = new System.Drawing.Size(162, 20);
            this.projectNameTextbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Project name";
            // 
            // saveProjectButton
            // 
            this.saveProjectButton.Enabled = false;
            this.saveProjectButton.Location = new System.Drawing.Point(424, 10);
            this.saveProjectButton.Name = "saveProjectButton";
            this.saveProjectButton.Size = new System.Drawing.Size(57, 23);
            this.saveProjectButton.TabIndex = 5;
            this.saveProjectButton.Text = "Save";
            this.saveProjectButton.UseVisualStyleBackColor = true;
            this.saveProjectButton.Click += new System.EventHandler(this.saveProjectButton_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.LabelWrap = false;
            this.listView1.Location = new System.Drawing.Point(12, 68);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(529, 97);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "1";
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 41;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Tag = "4";
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 86;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Tag = "6";
            this.columnHeader3.Text = "Cue";
            this.columnHeader3.Width = 268;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Tag = "3";
            this.columnHeader4.Text = "AEL";
            this.columnHeader4.Width = 73;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Tag = "2";
            this.columnHeader5.Text = "Time";
            this.columnHeader5.Width = 55;
            // 
            // cueLabel
            // 
            this.cueLabel.AutoSize = true;
            this.cueLabel.Location = new System.Drawing.Point(118, 41);
            this.cueLabel.Name = "cueLabel";
            this.cueLabel.Size = new System.Drawing.Size(32, 13);
            this.cueLabel.TabIndex = 7;
            this.cueLabel.Text = "Cue: ";
            // 
            // playChaseButton
            // 
            this.playChaseButton.Enabled = false;
            this.playChaseButton.Location = new System.Drawing.Point(12, 12);
            this.playChaseButton.Name = "playChaseButton";
            this.playChaseButton.Size = new System.Drawing.Size(44, 44);
            this.playChaseButton.TabIndex = 8;
            this.playChaseButton.Text = "PLAY";
            this.playChaseButton.UseVisualStyleBackColor = true;
            this.playChaseButton.Click += new System.EventHandler(this.playChaseButton_Click);
            // 
            // stopChaseButton
            // 
            this.stopChaseButton.Enabled = false;
            this.stopChaseButton.Location = new System.Drawing.Point(62, 12);
            this.stopChaseButton.Name = "stopChaseButton";
            this.stopChaseButton.Size = new System.Drawing.Size(44, 44);
            this.stopChaseButton.TabIndex = 9;
            this.stopChaseButton.Text = "STOP";
            this.stopChaseButton.UseVisualStyleBackColor = true;
            this.stopChaseButton.Click += new System.EventHandler(this.stopChaseButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.copyChaseButton);
            this.groupBox1.Controls.Add(this.editChaseButton);
            this.groupBox1.Controls.Add(this.deleteChaseButton);
            this.groupBox1.Controls.Add(this.moveChaseDownButton);
            this.groupBox1.Controls.Add(this.moveChaseUpButton);
            this.groupBox1.Controls.Add(this.addChaseButton);
            this.groupBox1.Controls.Add(this.insertChaseButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 47);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chase Options";
            // 
            // insertChaseButton
            // 
            this.insertChaseButton.Location = new System.Drawing.Point(6, 19);
            this.insertChaseButton.Name = "insertChaseButton";
            this.insertChaseButton.Size = new System.Drawing.Size(50, 23);
            this.insertChaseButton.TabIndex = 0;
            this.insertChaseButton.Text = "Insert";
            this.insertChaseButton.UseVisualStyleBackColor = true;
            // 
            // addChaseButton
            // 
            this.addChaseButton.Location = new System.Drawing.Point(62, 19);
            this.addChaseButton.Name = "addChaseButton";
            this.addChaseButton.Size = new System.Drawing.Size(46, 23);
            this.addChaseButton.TabIndex = 1;
            this.addChaseButton.Text = "Add";
            this.addChaseButton.UseVisualStyleBackColor = true;
            // 
            // moveChaseUpButton
            // 
            this.moveChaseUpButton.Location = new System.Drawing.Point(197, 18);
            this.moveChaseUpButton.Name = "moveChaseUpButton";
            this.moveChaseUpButton.Size = new System.Drawing.Size(65, 23);
            this.moveChaseUpButton.TabIndex = 2;
            this.moveChaseUpButton.Text = "Move Up";
            this.moveChaseUpButton.UseVisualStyleBackColor = true;
            this.moveChaseUpButton.Click += new System.EventHandler(this.moveChaseUpButton_Click);
            // 
            // moveChaseDownButton
            // 
            this.moveChaseDownButton.Location = new System.Drawing.Point(268, 18);
            this.moveChaseDownButton.Name = "moveChaseDownButton";
            this.moveChaseDownButton.Size = new System.Drawing.Size(75, 23);
            this.moveChaseDownButton.TabIndex = 3;
            this.moveChaseDownButton.Text = "Move Down";
            this.moveChaseDownButton.UseVisualStyleBackColor = true;
            this.moveChaseDownButton.Click += new System.EventHandler(this.moveChaseDownButton_Click);
            // 
            // deleteChaseButton
            // 
            this.deleteChaseButton.Location = new System.Drawing.Point(389, 19);
            this.deleteChaseButton.Name = "deleteChaseButton";
            this.deleteChaseButton.Size = new System.Drawing.Size(54, 23);
            this.deleteChaseButton.TabIndex = 4;
            this.deleteChaseButton.Text = "Delete";
            this.deleteChaseButton.UseVisualStyleBackColor = true;
            this.deleteChaseButton.Click += new System.EventHandler(this.deleteChaseButton_Click);
            // 
            // editChaseButton
            // 
            this.editChaseButton.Location = new System.Drawing.Point(449, 19);
            this.editChaseButton.Name = "editChaseButton";
            this.editChaseButton.Size = new System.Drawing.Size(75, 23);
            this.editChaseButton.TabIndex = 5;
            this.editChaseButton.Text = "Edit";
            this.editChaseButton.UseVisualStyleBackColor = true;
            // 
            // copyChaseButton
            // 
            this.copyChaseButton.Location = new System.Drawing.Point(114, 19);
            this.copyChaseButton.Name = "copyChaseButton";
            this.copyChaseButton.Size = new System.Drawing.Size(48, 23);
            this.copyChaseButton.TabIndex = 6;
            this.copyChaseButton.Text = "Copy";
            this.copyChaseButton.UseVisualStyleBackColor = true;
            this.copyChaseButton.Click += new System.EventHandler(this.copyChaseButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 261);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.stopChaseButton);
            this.Controls.Add(this.playChaseButton);
            this.Controls.Add(this.cueLabel);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.saveProjectButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.projectNameTextbox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.openProjectButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(570, 300);
            this.MinimumSize = new System.Drawing.Size(570, 300);
            this.Name = "Form1";
            this.Text = "Freestyler Chaselist";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button openProjectButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel connectionStatusLabel;
        private System.Windows.Forms.TextBox projectNameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveProjectButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label cueLabel;
        private System.Windows.Forms.Button playChaseButton;
        private System.Windows.Forms.Button stopChaseButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button moveChaseDownButton;
        private System.Windows.Forms.Button moveChaseUpButton;
        private System.Windows.Forms.Button addChaseButton;
        private System.Windows.Forms.Button insertChaseButton;
        private System.Windows.Forms.Button deleteChaseButton;
        private System.Windows.Forms.Button editChaseButton;
        private System.Windows.Forms.Button copyChaseButton;
    }
}


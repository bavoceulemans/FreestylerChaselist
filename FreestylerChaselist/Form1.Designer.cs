namespace FreestylerChaselist
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
            this.openProjectButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.connectionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.projectNameTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveProjectButton = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openProjectButton
            // 
            this.openProjectButton.Location = new System.Drawing.Point(255, 10);
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
            this.statusStrip1.Size = new System.Drawing.Size(390, 22);
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
            this.projectNameTextbox.Location = new System.Drawing.Point(87, 12);
            this.projectNameTextbox.Name = "projectNameTextbox";
            this.projectNameTextbox.Size = new System.Drawing.Size(162, 20);
            this.projectNameTextbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Project name";
            // 
            // saveProjectButton
            // 
            this.saveProjectButton.Enabled = false;
            this.saveProjectButton.Location = new System.Drawing.Point(318, 10);
            this.saveProjectButton.Name = "saveProjectButton";
            this.saveProjectButton.Size = new System.Drawing.Size(57, 23);
            this.saveProjectButton.TabIndex = 5;
            this.saveProjectButton.Text = "Save";
            this.saveProjectButton.UseVisualStyleBackColor = true;
            this.saveProjectButton.Click += new System.EventHandler(this.saveProjectButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 261);
            this.Controls.Add(this.saveProjectButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.projectNameTextbox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.openProjectButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
    }
}


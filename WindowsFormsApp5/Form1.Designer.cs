namespace WindowsFormsApp5
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
            this.getDriveInfoButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.newFolderButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.drivesListBox = new System.Windows.Forms.ListBox();
            this.foldersListBox = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pathLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.renameButton = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // getDriveInfoButton
            // 
            this.getDriveInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getDriveInfoButton.Location = new System.Drawing.Point(30, 29);
            this.getDriveInfoButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.getDriveInfoButton.Name = "getDriveInfoButton";
            this.getDriveInfoButton.Size = new System.Drawing.Size(250, 83);
            this.getDriveInfoButton.TabIndex = 0;
            this.getDriveInfoButton.Text = "Get Drive Info";
            this.getDriveInfoButton.UseVisualStyleBackColor = true;
            this.getDriveInfoButton.Click += new System.EventHandler(this.getDriveInfoButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(294, 29);
            this.backButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(297, 83);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // newFolderButton
            // 
            this.newFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newFolderButton.Location = new System.Drawing.Point(605, 30);
            this.newFolderButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.newFolderButton.Name = "newFolderButton";
            this.newFolderButton.Size = new System.Drawing.Size(261, 83);
            this.newFolderButton.TabIndex = 2;
            this.newFolderButton.Text = "New Folder";
            this.newFolderButton.UseVisualStyleBackColor = true;
            this.newFolderButton.Click += new System.EventHandler(this.newFolderButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(880, 30);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(237, 83);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // drivesListBox
            // 
            this.drivesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drivesListBox.FormattingEnabled = true;
            this.drivesListBox.ItemHeight = 24;
            this.drivesListBox.Location = new System.Drawing.Point(30, 127);
            this.drivesListBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.drivesListBox.Name = "drivesListBox";
            this.drivesListBox.Size = new System.Drawing.Size(909, 844);
            this.drivesListBox.TabIndex = 4;
            this.drivesListBox.SelectedIndexChanged += new System.EventHandler(this.drivesListBox_SelectedIndexChanged);
            // 
            // foldersListBox
            // 
            this.foldersListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foldersListBox.FormattingEnabled = true;
            this.foldersListBox.ItemHeight = 24;
            this.foldersListBox.Location = new System.Drawing.Point(959, 127);
            this.foldersListBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.foldersListBox.Name = "foldersListBox";
            this.foldersListBox.Size = new System.Drawing.Size(909, 844);
            this.foldersListBox.TabIndex = 5;
            this.foldersListBox.DoubleClick += new System.EventHandler(this.foldersListBox_DoubleClick);
            this.foldersListBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.foldersListBox_KeyPress);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pathLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1033);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 33, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1909, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pathLabel
            // 
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(29, 17);
            this.pathLabel.Text = "N/A";
            // 
            // renameButton
            // 
            this.renameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renameButton.Location = new System.Drawing.Point(1131, 29);
            this.renameButton.Margin = new System.Windows.Forms.Padding(7);
            this.renameButton.Name = "renameButton";
            this.renameButton.Size = new System.Drawing.Size(237, 83);
            this.renameButton.TabIndex = 7;
            this.renameButton.Text = "Rename";
            this.renameButton.UseVisualStyleBackColor = true;
            this.renameButton.Click += new System.EventHandler(this.renameButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1909, 1055);
            this.Controls.Add(this.renameButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.foldersListBox);
            this.Controls.Add(this.drivesListBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.newFolderButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.getDriveInfoButton);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getDriveInfoButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button newFolderButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ListBox drivesListBox;
        private System.Windows.Forms.ListBox foldersListBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel pathLabel;
        private System.Windows.Forms.Button renameButton;
    }
}


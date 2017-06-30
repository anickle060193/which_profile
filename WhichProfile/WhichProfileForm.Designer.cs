namespace WhichProfile
{
    partial class WhichProfileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LayoutSplitContainer = new System.Windows.Forms.SplitContainer();
            this.ChromeProfilesListView = new System.Windows.Forms.ListView();
            this.ChromeProfilesNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChromeProfilesDataDirectoryColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LayoutSplitContainer)).BeginInit();
            this.LayoutSplitContainer.Panel2.SuspendLayout();
            this.LayoutSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(765, 477);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // LayoutSplitContainer
            // 
            this.LayoutSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LayoutSplitContainer.Location = new System.Drawing.Point(12, 12);
            this.LayoutSplitContainer.Name = "LayoutSplitContainer";
            // 
            // LayoutSplitContainer.Panel2
            // 
            this.LayoutSplitContainer.Panel2.Controls.Add(this.ChromeProfilesListView);
            this.LayoutSplitContainer.Size = new System.Drawing.Size(828, 459);
            this.LayoutSplitContainer.SplitterDistance = 522;
            this.LayoutSplitContainer.TabIndex = 2;
            // 
            // ChromeProfilesListView
            // 
            this.ChromeProfilesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChromeProfilesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ChromeProfilesNameColumn,
            this.ChromeProfilesDataDirectoryColumn});
            this.ChromeProfilesListView.FullRowSelect = true;
            this.ChromeProfilesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ChromeProfilesListView.HideSelection = false;
            this.ChromeProfilesListView.LabelEdit = true;
            this.ChromeProfilesListView.Location = new System.Drawing.Point(0, 0);
            this.ChromeProfilesListView.MultiSelect = false;
            this.ChromeProfilesListView.Name = "ChromeProfilesListView";
            this.ChromeProfilesListView.Size = new System.Drawing.Size(302, 411);
            this.ChromeProfilesListView.TabIndex = 0;
            this.ChromeProfilesListView.UseCompatibleStateImageBehavior = false;
            this.ChromeProfilesListView.View = System.Windows.Forms.View.Details;
            // 
            // ChromeProfilesNameColumn
            // 
            this.ChromeProfilesNameColumn.Text = "Profile Name";
            this.ChromeProfilesNameColumn.Width = 72;
            // 
            // ChromeProfilesDataDirectoryColumn
            // 
            this.ChromeProfilesDataDirectoryColumn.Text = "Data Directory";
            this.ChromeProfilesDataDirectoryColumn.Width = 226;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 26);
            // 
            // WhichProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 512);
            this.Controls.Add(this.LayoutSplitContainer);
            this.Controls.Add(this.SaveButton);
            this.Name = "WhichProfileForm";
            this.Text = "WhichProfile";
            this.LayoutSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LayoutSplitContainer)).EndInit();
            this.LayoutSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.SplitContainer LayoutSplitContainer;
        private System.Windows.Forms.ListView ChromeProfilesListView;
        private System.Windows.Forms.ColumnHeader ChromeProfilesNameColumn;
        private System.Windows.Forms.ColumnHeader ChromeProfilesDataDirectoryColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

    }
}


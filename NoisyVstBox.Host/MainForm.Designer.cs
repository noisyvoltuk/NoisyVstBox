namespace NoisyVstBox.Host
{
    partial class MainForm
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
            System.Windows.Forms.Label label1;
            PluginListVw = new System.Windows.Forms.ListView();
            NameHdr = new System.Windows.Forms.ColumnHeader();
            ProductHdr = new System.Windows.Forms.ColumnHeader();
            VendorHdr = new System.Windows.Forms.ColumnHeader();
            VersionHdr = new System.Windows.Forms.ColumnHeader();
            AssemblyHdr = new System.Windows.Forms.ColumnHeader();
            PluginPathTxt = new System.Windows.Forms.TextBox();
            BrowseBtn = new System.Windows.Forms.Button();
            AddBtn = new System.Windows.Forms.Button();
            DeleteBtn = new System.Windows.Forms.Button();
            OpenFileDlg = new System.Windows.Forms.OpenFileDialog();
            ViewPluginBtn = new System.Windows.Forms.Button();
            lblStatus = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(17, 20);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(82, 20);
            label1.TabIndex = 2;
            label1.Text = "Plugin Path";
            // 
            // PluginListVw
            // 
            PluginListVw.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            PluginListVw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { NameHdr, ProductHdr, VendorHdr, VersionHdr, AssemblyHdr });
            PluginListVw.FullRowSelect = true;
            PluginListVw.Location = new System.Drawing.Point(16, 86);
            PluginListVw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            PluginListVw.MultiSelect = false;
            PluginListVw.Name = "PluginListVw";
            PluginListVw.Size = new System.Drawing.Size(727, 232);
            PluginListVw.TabIndex = 0;
            PluginListVw.UseCompatibleStateImageBehavior = false;
            PluginListVw.View = System.Windows.Forms.View.Details;
            // 
            // NameHdr
            // 
            NameHdr.Text = "Name";
            NameHdr.Width = 120;
            // 
            // ProductHdr
            // 
            ProductHdr.DisplayIndex = 2;
            ProductHdr.Text = "Product";
            ProductHdr.Width = 120;
            // 
            // VendorHdr
            // 
            VendorHdr.DisplayIndex = 3;
            VendorHdr.Text = "Vendor";
            VendorHdr.Width = 120;
            // 
            // VersionHdr
            // 
            VersionHdr.DisplayIndex = 1;
            VersionHdr.Text = "Version";
            // 
            // AssemblyHdr
            // 
            AssemblyHdr.Text = "Assemlby";
            AssemblyHdr.Width = 120;
            // 
            // PluginPathTxt
            // 
            PluginPathTxt.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            PluginPathTxt.Location = new System.Drawing.Point(16, 45);
            PluginPathTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            PluginPathTxt.Name = "PluginPathTxt";
            PluginPathTxt.Size = new System.Drawing.Size(572, 27);
            PluginPathTxt.TabIndex = 1;
            // 
            // BrowseBtn
            // 
            BrowseBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            BrowseBtn.Location = new System.Drawing.Point(597, 42);
            BrowseBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            BrowseBtn.Name = "BrowseBtn";
            BrowseBtn.Size = new System.Drawing.Size(41, 35);
            BrowseBtn.TabIndex = 3;
            BrowseBtn.Text = "...";
            BrowseBtn.UseVisualStyleBackColor = true;
            BrowseBtn.Click += BrowseBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            AddBtn.Location = new System.Drawing.Point(647, 42);
            AddBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new System.Drawing.Size(100, 35);
            AddBtn.TabIndex = 4;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            DeleteBtn.Location = new System.Drawing.Point(16, 329);
            DeleteBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new System.Drawing.Size(100, 35);
            DeleteBtn.TabIndex = 5;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // OpenFileDlg
            // 
            OpenFileDlg.Filter = "Plugins (*.dll)|*.dll|All Files (*.*)|*.*";
            // 
            // ViewPluginBtn
            // 
            ViewPluginBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            ViewPluginBtn.Location = new System.Drawing.Point(643, 329);
            ViewPluginBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ViewPluginBtn.Name = "ViewPluginBtn";
            ViewPluginBtn.Size = new System.Drawing.Size(100, 35);
            ViewPluginBtn.TabIndex = 6;
            ViewPluginBtn.Text = "View...";
            ViewPluginBtn.UseVisualStyleBackColor = true;
            ViewPluginBtn.Click += ViewPluginBtn_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new System.Drawing.Point(382, 339);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(50, 20);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "label2";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(760, 383);
            Controls.Add(lblStatus);
            Controls.Add(ViewPluginBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(AddBtn);
            Controls.Add(BrowseBtn);
            Controls.Add(label1);
            Controls.Add(PluginPathTxt);
            Controls.Add(PluginListVw);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "VST.NET Sample Host";
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListView PluginListVw;
        private System.Windows.Forms.TextBox PluginPathTxt;
        private System.Windows.Forms.Button BrowseBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.ColumnHeader NameHdr;
        private System.Windows.Forms.ColumnHeader VersionHdr;
        private System.Windows.Forms.ColumnHeader ProductHdr;
        private System.Windows.Forms.ColumnHeader VendorHdr;
        private System.Windows.Forms.ColumnHeader AssemblyHdr;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.OpenFileDialog OpenFileDlg;
        private System.Windows.Forms.Button ViewPluginBtn;
        private System.Windows.Forms.Label lblStatus;
    }
}


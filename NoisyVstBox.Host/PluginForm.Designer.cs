namespace NoisyVstBox.Host
{
    partial class PluginForm
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
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.GroupBox groupBox2;
            PluginPropertyListVw = new System.Windows.Forms.ListView();
            PropertyNameHdr = new System.Windows.Forms.ColumnHeader();
            PropertyValueHdr = new System.Windows.Forms.ColumnHeader();
            ProgramListCmb = new System.Windows.Forms.ComboBox();
            PluginParameterListVw = new System.Windows.Forms.ListView();
            ParameterNameHdr = new System.Windows.Forms.ColumnHeader();
            ParameterValueHdr = new System.Windows.Forms.ColumnHeader();
            ParameterLabelHdr = new System.Windows.Forms.ColumnHeader();
            ParameterShortLabelHdr = new System.Windows.Forms.ColumnHeader();
            ProgramIndexNud = new System.Windows.Forms.NumericUpDown();
            OKBtn = new System.Windows.Forms.Button();
            GenerateNoiseBtn = new System.Windows.Forms.Button();
            EditorBtn = new System.Windows.Forms.Button();
            GenerateMidiBtn = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProgramIndexNud).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox1.Controls.Add(PluginPropertyListVw);
            groupBox1.Location = new System.Drawing.Point(17, 20);
            groupBox1.Margin = new System.Windows.Forms.Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            groupBox1.Size = new System.Drawing.Size(527, 243);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Plugin Properties";
            // 
            // PluginPropertyListVw
            // 
            PluginPropertyListVw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { PropertyNameHdr, PropertyValueHdr });
            PluginPropertyListVw.Dock = System.Windows.Forms.DockStyle.Fill;
            PluginPropertyListVw.FullRowSelect = true;
            PluginPropertyListVw.Location = new System.Drawing.Point(7, 28);
            PluginPropertyListVw.Margin = new System.Windows.Forms.Padding(4);
            PluginPropertyListVw.MultiSelect = false;
            PluginPropertyListVw.Name = "PluginPropertyListVw";
            PluginPropertyListVw.Size = new System.Drawing.Size(513, 207);
            PluginPropertyListVw.TabIndex = 0;
            PluginPropertyListVw.UseCompatibleStateImageBehavior = false;
            PluginPropertyListVw.View = System.Windows.Forms.View.Details;
            // 
            // PropertyNameHdr
            // 
            PropertyNameHdr.Text = "Property Name";
            PropertyNameHdr.Width = 180;
            // 
            // PropertyValueHdr
            // 
            PropertyValueHdr.Text = "Property Value";
            PropertyValueHdr.Width = 180;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox2.Controls.Add(ProgramListCmb);
            groupBox2.Controls.Add(PluginParameterListVw);
            groupBox2.Controls.Add(ProgramIndexNud);
            groupBox2.Location = new System.Drawing.Point(17, 181);
            groupBox2.Margin = new System.Windows.Forms.Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(4);
            groupBox2.Size = new System.Drawing.Size(527, 274);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Programs && Parameters";
            // 
            // ProgramListCmb
            // 
            ProgramListCmb.FormattingEnabled = true;
            ProgramListCmb.Location = new System.Drawing.Point(72, 29);
            ProgramListCmb.Margin = new System.Windows.Forms.Padding(4);
            ProgramListCmb.Name = "ProgramListCmb";
            ProgramListCmb.Size = new System.Drawing.Size(445, 28);
            ProgramListCmb.TabIndex = 3;
            // 
            // PluginParameterListVw
            // 
            PluginParameterListVw.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            PluginParameterListVw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { ParameterNameHdr, ParameterValueHdr, ParameterLabelHdr, ParameterShortLabelHdr });
            PluginParameterListVw.FullRowSelect = true;
            PluginParameterListVw.Location = new System.Drawing.Point(9, 72);
            PluginParameterListVw.Margin = new System.Windows.Forms.Padding(4);
            PluginParameterListVw.MultiSelect = false;
            PluginParameterListVw.Name = "PluginParameterListVw";
            PluginParameterListVw.Size = new System.Drawing.Size(508, 190);
            PluginParameterListVw.TabIndex = 2;
            PluginParameterListVw.UseCompatibleStateImageBehavior = false;
            PluginParameterListVw.View = System.Windows.Forms.View.Details;
            // 
            // ParameterNameHdr
            // 
            ParameterNameHdr.Text = "Parameter Name";
            ParameterNameHdr.Width = 120;
            // 
            // ParameterValueHdr
            // 
            ParameterValueHdr.Text = "Value";
            ParameterValueHdr.Width = 50;
            // 
            // ParameterLabelHdr
            // 
            ParameterLabelHdr.Text = "Label";
            ParameterLabelHdr.Width = 80;
            // 
            // ParameterShortLabelHdr
            // 
            ParameterShortLabelHdr.Text = "Short Lbl";
            // 
            // ProgramIndexNud
            // 
            ProgramIndexNud.Location = new System.Drawing.Point(9, 31);
            ProgramIndexNud.Margin = new System.Windows.Forms.Padding(4);
            ProgramIndexNud.Name = "ProgramIndexNud";
            ProgramIndexNud.Size = new System.Drawing.Size(55, 27);
            ProgramIndexNud.TabIndex = 0;
            ProgramIndexNud.ValueChanged += ProgramIndexNud_ValueChanged;
            // 
            // OKBtn
            // 
            OKBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            OKBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            OKBtn.Location = new System.Drawing.Point(444, 464);
            OKBtn.Margin = new System.Windows.Forms.Padding(4);
            OKBtn.Name = "OKBtn";
            OKBtn.Size = new System.Drawing.Size(100, 36);
            OKBtn.TabIndex = 3;
            OKBtn.Text = "Close";
            OKBtn.UseVisualStyleBackColor = true;
            // 
            // GenerateNoiseBtn
            // 
            GenerateNoiseBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            GenerateNoiseBtn.Location = new System.Drawing.Point(27, 466);
            GenerateNoiseBtn.Margin = new System.Windows.Forms.Padding(4);
            GenerateNoiseBtn.Name = "GenerateNoiseBtn";
            GenerateNoiseBtn.Size = new System.Drawing.Size(112, 36);
            GenerateNoiseBtn.TabIndex = 4;
            GenerateNoiseBtn.Text = "Process Noise";
            GenerateNoiseBtn.UseVisualStyleBackColor = true;
            GenerateNoiseBtn.Click += GenerateNoiseBtn_Click;
            // 
            // EditorBtn
            // 
            EditorBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            EditorBtn.Location = new System.Drawing.Point(266, 466);
            EditorBtn.Margin = new System.Windows.Forms.Padding(4);
            EditorBtn.Name = "EditorBtn";
            EditorBtn.Size = new System.Drawing.Size(100, 36);
            EditorBtn.TabIndex = 5;
            EditorBtn.Text = "Editor...";
            EditorBtn.UseVisualStyleBackColor = true;
            EditorBtn.Click += EditorBtn_Click;
            // 
            // GenerateMidiBtn
            // 
            GenerateMidiBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            GenerateMidiBtn.Location = new System.Drawing.Point(146, 466);
            GenerateMidiBtn.Margin = new System.Windows.Forms.Padding(4);
            GenerateMidiBtn.Name = "GenerateMidiBtn";
            GenerateMidiBtn.Size = new System.Drawing.Size(112, 36);
            GenerateMidiBtn.TabIndex = 6;
            GenerateMidiBtn.Text = "Process Midi";
            GenerateMidiBtn.UseVisualStyleBackColor = true;
            GenerateMidiBtn.Click += GenerateMidiBtn_Click;
            // 
            // PluginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(561, 515);
            Controls.Add(GenerateMidiBtn);
            Controls.Add(EditorBtn);
            Controls.Add(GenerateNoiseBtn);
            Controls.Add(OKBtn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PluginForm";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Plugin Details";
            Load += PluginForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ProgramIndexNud).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListView PluginPropertyListVw;
        private System.Windows.Forms.ColumnHeader PropertyNameHdr;
        private System.Windows.Forms.ColumnHeader PropertyValueHdr;
        private System.Windows.Forms.ListView PluginParameterListVw;
        private System.Windows.Forms.NumericUpDown ProgramIndexNud;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.ColumnHeader ParameterNameHdr;
        private System.Windows.Forms.ColumnHeader ParameterValueHdr;
        private System.Windows.Forms.ColumnHeader ParameterLabelHdr;
        private System.Windows.Forms.ColumnHeader ParameterShortLabelHdr;
        private System.Windows.Forms.Button GenerateNoiseBtn;
        private System.Windows.Forms.Button EditorBtn;
        private System.Windows.Forms.ComboBox ProgramListCmb;
        private System.Windows.Forms.Button GenerateMidiBtn;
    }
}
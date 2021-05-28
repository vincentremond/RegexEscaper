namespace RegexEscaper
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonInit = new System.Windows.Forms.Button();
            this.checkBoxFull = new System.Windows.Forms.CheckBox();
            this.textBoxOriginal = new System.Windows.Forms.TextBox();
            this.textBoxGroupReplacement = new System.Windows.Forms.TextBox();
            this.labelReplacement = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxGroupName = new System.Windows.Forms.TextBox();
            this.buttonReplace = new System.Windows.Forms.Button();
            this.textBoxFullReplacement = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxReplacementExample = new System.Windows.Forms.TextBox();
            this.groupBoxSuggestions = new System.Windows.Forms.GroupBox();
            this.dataGridViewSuggestions = new System.Windows.Forms.DataGridView();
            this.groupBoxOriginal = new System.Windows.Forms.GroupBox();
            this.groupBoxRegex = new System.Windows.Forms.GroupBox();
            this.richTextBoxRegex = new System.Windows.Forms.RichTextBox();
            this.buttonCopyRegexAsCSharp = new System.Windows.Forms.Button();
            this.groupBoxReplacement = new System.Windows.Forms.GroupBox();
            this.buttonVSCode = new System.Windows.Forms.Button();
            this.groupBoxReplacementExample = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBoxSuggestions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewSuggestions)).BeginInit();
            this.groupBoxOriginal.SuspendLayout();
            this.groupBoxRegex.SuspendLayout();
            this.groupBoxReplacement.SuspendLayout();
            this.groupBoxReplacementExample.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonInit
            // 
            this.buttonInit.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInit.Location = new System.Drawing.Point(491, 22);
            this.buttonInit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInit.Name = "buttonInit";
            this.buttonInit.Size = new System.Drawing.Size(97, 25);
            this.buttonInit.TabIndex = 0;
            this.buttonInit.Text = "init";
            this.buttonInit.UseVisualStyleBackColor = true;
            this.buttonInit.Click += new System.EventHandler(this.buttonInit_Click);
            // 
            // checkBoxFull
            // 
            this.checkBoxFull.AutoSize = true;
            this.checkBoxFull.Location = new System.Drawing.Point(492, 50);
            this.checkBoxFull.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxFull.Name = "checkBoxFull";
            this.checkBoxFull.Size = new System.Drawing.Size(84, 20);
            this.checkBoxFull.TabIndex = 1;
            this.checkBoxFull.Text = "full match";
            this.checkBoxFull.UseVisualStyleBackColor = true;
            // 
            // textBoxOriginal
            // 
            this.textBoxOriginal.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOriginal.Font = new System.Drawing.Font("Consolas", 9F);
            this.textBoxOriginal.HideSelection = false;
            this.textBoxOriginal.Location = new System.Drawing.Point(6, 22);
            this.textBoxOriginal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxOriginal.Multiline = true;
            this.textBoxOriginal.Name = "textBoxOriginal";
            this.textBoxOriginal.Size = new System.Drawing.Size(480, 100);
            this.textBoxOriginal.TabIndex = 3;
            this.textBoxOriginal.Text = "paste the text to match here…";
            this.textBoxOriginal.TextChanged += new System.EventHandler(this.textBoxOriginal_TextChanged);
            // 
            // textBoxGroupReplacement
            // 
            this.textBoxGroupReplacement.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxGroupReplacement.Location = new System.Drawing.Point(102, 21);
            this.textBoxGroupReplacement.Name = "textBoxGroupReplacement";
            this.textBoxGroupReplacement.Size = new System.Drawing.Size(403, 22);
            this.textBoxGroupReplacement.TabIndex = 5;
            // 
            // labelReplacement
            // 
            this.labelReplacement.Location = new System.Drawing.Point(6, 29);
            this.labelReplacement.Name = "labelReplacement";
            this.labelReplacement.Size = new System.Drawing.Size(96, 19);
            this.labelReplacement.TabIndex = 6;
            this.labelReplacement.Text = "Regex";
            // 
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(6, 52);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(89, 19);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Group name";
            // 
            // textBoxGroupName
            // 
            this.textBoxGroupName.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxGroupName.Location = new System.Drawing.Point(102, 49);
            this.textBoxGroupName.Name = "textBoxGroupName";
            this.textBoxGroupName.Size = new System.Drawing.Size(403, 22);
            this.textBoxGroupName.TabIndex = 8;
            // 
            // buttonReplace
            // 
            this.buttonReplace.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReplace.Location = new System.Drawing.Point(511, 20);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(76, 51);
            this.buttonReplace.TabIndex = 9;
            this.buttonReplace.Text = "replace";
            this.buttonReplace.UseVisualStyleBackColor = true;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
            // 
            // textBoxFullReplacement
            // 
            this.textBoxFullReplacement.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFullReplacement.Font = new System.Drawing.Font("Consolas", 9F);
            this.textBoxFullReplacement.HideSelection = false;
            this.textBoxFullReplacement.Location = new System.Drawing.Point(6, 22);
            this.textBoxFullReplacement.Multiline = true;
            this.textBoxFullReplacement.Name = "textBoxFullReplacement";
            this.textBoxFullReplacement.Size = new System.Drawing.Size(480, 100);
            this.textBoxFullReplacement.TabIndex = 11;
            this.textBoxFullReplacement.TextChanged += new System.EventHandler(this.textBoxFullReplacement_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.labelReplacement);
            this.groupBox1.Controls.Add(this.textBoxGroupReplacement);
            this.groupBox1.Controls.Add(this.buttonReplace);
            this.groupBox1.Controls.Add(this.textBoxGroupName);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Location = new System.Drawing.Point(12, 551);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 78);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Replacement";
            // 
            // textBoxReplacementExample
            // 
            this.textBoxReplacementExample.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReplacementExample.Font = new System.Drawing.Font("Consolas", 9F);
            this.textBoxReplacementExample.HideSelection = false;
            this.textBoxReplacementExample.Location = new System.Drawing.Point(6, 22);
            this.textBoxReplacementExample.Multiline = true;
            this.textBoxReplacementExample.Name = "textBoxReplacementExample";
            this.textBoxReplacementExample.ReadOnly = true;
            this.textBoxReplacementExample.Size = new System.Drawing.Size(480, 100);
            this.textBoxReplacementExample.TabIndex = 18;
            // 
            // groupBoxSuggestions
            // 
            this.groupBoxSuggestions.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSuggestions.Controls.Add(this.dataGridViewSuggestions);
            this.groupBoxSuggestions.Location = new System.Drawing.Point(611, 10);
            this.groupBoxSuggestions.Name = "groupBoxSuggestions";
            this.groupBoxSuggestions.Size = new System.Drawing.Size(368, 620);
            this.groupBoxSuggestions.TabIndex = 20;
            this.groupBoxSuggestions.TabStop = false;
            this.groupBoxSuggestions.Text = "Suggestions";
            // 
            // dataGridViewSuggestions
            // 
            this.dataGridViewSuggestions.AllowUserToAddRows = false;
            this.dataGridViewSuggestions.AllowUserToDeleteRows = false;
            this.dataGridViewSuggestions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewSuggestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSuggestions.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSuggestions.Location = new System.Drawing.Point(14, 22);
            this.dataGridViewSuggestions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewSuggestions.Name = "dataGridViewSuggestions";
            this.dataGridViewSuggestions.ReadOnly = true;
            this.dataGridViewSuggestions.RowHeadersWidth = 51;
            this.dataGridViewSuggestions.RowTemplate.Height = 29;
            this.dataGridViewSuggestions.Size = new System.Drawing.Size(348, 590);
            this.dataGridViewSuggestions.TabIndex = 0;
            this.dataGridViewSuggestions.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSuggestions_CellContentClick);
            // 
            // groupBoxOriginal
            // 
            this.groupBoxOriginal.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOriginal.Controls.Add(this.textBoxOriginal);
            this.groupBoxOriginal.Controls.Add(this.buttonInit);
            this.groupBoxOriginal.Controls.Add(this.checkBoxFull);
            this.groupBoxOriginal.Location = new System.Drawing.Point(12, 10);
            this.groupBoxOriginal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxOriginal.Name = "groupBoxOriginal";
            this.groupBoxOriginal.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxOriginal.Size = new System.Drawing.Size(593, 130);
            this.groupBoxOriginal.TabIndex = 21;
            this.groupBoxOriginal.TabStop = false;
            this.groupBoxOriginal.Text = "Original text";
            // 
            // groupBoxRegex
            // 
            this.groupBoxRegex.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxRegex.Controls.Add(this.richTextBoxRegex);
            this.groupBoxRegex.Controls.Add(this.buttonCopyRegexAsCSharp);
            this.groupBoxRegex.Location = new System.Drawing.Point(12, 145);
            this.groupBoxRegex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxRegex.Name = "groupBoxRegex";
            this.groupBoxRegex.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxRegex.Size = new System.Drawing.Size(593, 130);
            this.groupBoxRegex.TabIndex = 4;
            this.groupBoxRegex.TabStop = false;
            this.groupBoxRegex.Text = "Regex";
            // 
            // richTextBoxRegex
            // 
            this.richTextBoxRegex.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxRegex.DetectUrls = false;
            this.richTextBoxRegex.Font = new System.Drawing.Font("Consolas", 9F);
            this.richTextBoxRegex.HideSelection = false;
            this.richTextBoxRegex.Location = new System.Drawing.Point(6, 20);
            this.richTextBoxRegex.Name = "richTextBoxRegex";
            this.richTextBoxRegex.Size = new System.Drawing.Size(480, 102);
            this.richTextBoxRegex.TabIndex = 15;
            this.richTextBoxRegex.Text = "";
            this.richTextBoxRegex.SelectionChanged += new System.EventHandler(this.richTextBoxRegex_SelectionChanged);
            this.richTextBoxRegex.TextChanged += new System.EventHandler(this.richTextBoxRegex_TextChanged);
            // 
            // buttonCopyRegexAsCSharp
            // 
            this.buttonCopyRegexAsCSharp.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCopyRegexAsCSharp.Location = new System.Drawing.Point(492, 22);
            this.buttonCopyRegexAsCSharp.Name = "buttonCopyRegexAsCSharp";
            this.buttonCopyRegexAsCSharp.Size = new System.Drawing.Size(95, 25);
            this.buttonCopyRegexAsCSharp.TabIndex = 14;
            this.buttonCopyRegexAsCSharp.Text = "📋 C#";
            this.buttonCopyRegexAsCSharp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCopyRegexAsCSharp.UseVisualStyleBackColor = true;
            this.buttonCopyRegexAsCSharp.Click += new System.EventHandler(this.buttonCopyCSharp_Click);
            // 
            // groupBoxReplacement
            // 
            this.groupBoxReplacement.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxReplacement.Controls.Add(this.buttonVSCode);
            this.groupBoxReplacement.Controls.Add(this.textBoxFullReplacement);
            this.groupBoxReplacement.Location = new System.Drawing.Point(12, 280);
            this.groupBoxReplacement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxReplacement.Name = "groupBoxReplacement";
            this.groupBoxReplacement.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxReplacement.Size = new System.Drawing.Size(593, 130);
            this.groupBoxReplacement.TabIndex = 22;
            this.groupBoxReplacement.TabStop = false;
            this.groupBoxReplacement.Text = "Replacement";
            // 
            // buttonVSCode
            // 
            this.buttonVSCode.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonVSCode.Location = new System.Drawing.Point(491, 22);
            this.buttonVSCode.Name = "buttonVSCode";
            this.buttonVSCode.Size = new System.Drawing.Size(95, 25);
            this.buttonVSCode.TabIndex = 16;
            this.buttonVSCode.Text = "📋 VS Code";
            this.buttonVSCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVSCode.UseVisualStyleBackColor = true;
            this.buttonVSCode.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBoxReplacementExample
            // 
            this.groupBoxReplacementExample.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxReplacementExample.Controls.Add(this.textBoxReplacementExample);
            this.groupBoxReplacementExample.Location = new System.Drawing.Point(12, 415);
            this.groupBoxReplacementExample.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxReplacementExample.Name = "groupBoxReplacementExample";
            this.groupBoxReplacementExample.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxReplacementExample.Size = new System.Drawing.Size(593, 130);
            this.groupBoxReplacementExample.TabIndex = 23;
            this.groupBoxReplacementExample.TabStop = false;
            this.groupBoxReplacementExample.Text = "Replacement example";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 637);
            this.Controls.Add(this.groupBoxReplacementExample);
            this.Controls.Add(this.groupBoxReplacement);
            this.Controls.Add(this.groupBoxRegex);
            this.Controls.Add(this.groupBoxOriginal);
            this.Controls.Add(this.groupBoxSuggestions);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(480, 480);
            this.Name = "MainForm";
            this.Text = "RegexReplacer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxSuggestions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewSuggestions)).EndInit();
            this.groupBoxOriginal.ResumeLayout(false);
            this.groupBoxOriginal.PerformLayout();
            this.groupBoxRegex.ResumeLayout(false);
            this.groupBoxReplacement.ResumeLayout(false);
            this.groupBoxReplacement.PerformLayout();
            this.groupBoxReplacementExample.ResumeLayout(false);
            this.groupBoxReplacementExample.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonVSCode;

        private System.Windows.Forms.RichTextBox richTextBoxRegex;

        private System.Windows.Forms.GroupBox groupBoxSuggestions;
        private System.Windows.Forms.TextBox textBoxReplacementExample;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.TextBox textBoxFullReplacement;

        private System.Windows.Forms.Button buttonInit;
        private System.Windows.Forms.CheckBox checkBoxFull;

        private System.Windows.Forms.Button buttonReplace;

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelReplacement;
        private System.Windows.Forms.TextBox textBoxGroupName;
        private System.Windows.Forms.TextBox textBoxGroupReplacement;

        private System.Windows.Forms.TextBox textBoxOriginal;

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSuggestions;
        private System.Windows.Forms.GroupBox groupBoxOriginal;
        private System.Windows.Forms.GroupBox groupBoxRegex;
        private System.Windows.Forms.Button buttonCopyRegexAsCSharp;
        private System.Windows.Forms.GroupBox groupBoxReplacement;
        private System.Windows.Forms.GroupBox groupBoxReplacementExample;
    }
}


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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.groupBoxSuggestions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuggestions)).BeginInit();
            this.groupBoxOriginal.SuspendLayout();
            this.groupBoxRegex.SuspendLayout();
            this.groupBoxReplacement.SuspendLayout();
            this.groupBoxReplacementExample.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonInit
            // 
            this.buttonInit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInit.Location = new System.Drawing.Point(591, 28);
            this.buttonInit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInit.Name = "buttonInit";
            this.buttonInit.Size = new System.Drawing.Size(97, 31);
            this.buttonInit.TabIndex = 0;
            this.buttonInit.Text = "init";
            this.buttonInit.UseVisualStyleBackColor = true;
            this.buttonInit.Click += new System.EventHandler(this.buttonInit_Click);
            // 
            // checkBoxFull
            // 
            this.checkBoxFull.AutoSize = true;
            this.checkBoxFull.Location = new System.Drawing.Point(422, 63);
            this.checkBoxFull.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxFull.Name = "checkBoxFull";
            this.checkBoxFull.Size = new System.Drawing.Size(97, 24);
            this.checkBoxFull.TabIndex = 1;
            this.checkBoxFull.Text = "full match";
            this.checkBoxFull.UseVisualStyleBackColor = true;
            // 
            // textBoxOriginal
            // 
            this.textBoxOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOriginal.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxOriginal.HideSelection = false;
            this.textBoxOriginal.Location = new System.Drawing.Point(6, 24);
            this.textBoxOriginal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxOriginal.Multiline = true;
            this.textBoxOriginal.Name = "textBoxOriginal";
            this.textBoxOriginal.Size = new System.Drawing.Size(580, 118);
            this.textBoxOriginal.TabIndex = 3;
            this.textBoxOriginal.Text = "paste the text to match here…";
            this.textBoxOriginal.TextChanged += new System.EventHandler(this.textBoxOriginal_TextChanged);
            // 
            // textBoxGroupReplacement
            // 
            this.textBoxGroupReplacement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxGroupReplacement.Location = new System.Drawing.Point(102, 33);
            this.textBoxGroupReplacement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxGroupReplacement.Name = "textBoxGroupReplacement";
            this.textBoxGroupReplacement.Size = new System.Drawing.Size(503, 27);
            this.textBoxGroupReplacement.TabIndex = 5;
            // 
            // labelReplacement
            // 
            this.labelReplacement.Location = new System.Drawing.Point(6, 36);
            this.labelReplacement.Name = "labelReplacement";
            this.labelReplacement.Size = new System.Drawing.Size(96, 24);
            this.labelReplacement.TabIndex = 6;
            this.labelReplacement.Text = "Regex";
            // 
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(6, 65);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(89, 24);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Group name";
            // 
            // textBoxGroupName
            // 
            this.textBoxGroupName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxGroupName.Location = new System.Drawing.Point(102, 61);
            this.textBoxGroupName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxGroupName.Name = "textBoxGroupName";
            this.textBoxGroupName.Size = new System.Drawing.Size(503, 27);
            this.textBoxGroupName.TabIndex = 8;
            // 
            // buttonReplace
            // 
            this.buttonReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReplace.Location = new System.Drawing.Point(610, 33);
            this.buttonReplace.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(76, 55);
            this.buttonReplace.TabIndex = 9;
            this.buttonReplace.Text = "replace";
            this.buttonReplace.UseVisualStyleBackColor = true;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
            // 
            // textBoxFullReplacement
            // 
            this.textBoxFullReplacement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFullReplacement.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxFullReplacement.HideSelection = false;
            this.textBoxFullReplacement.Location = new System.Drawing.Point(6, 28);
            this.textBoxFullReplacement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFullReplacement.Multiline = true;
            this.textBoxFullReplacement.Name = "textBoxFullReplacement";
            this.textBoxFullReplacement.Size = new System.Drawing.Size(580, 98);
            this.textBoxFullReplacement.TabIndex = 11;
            this.textBoxFullReplacement.TextChanged += new System.EventHandler(this.textBoxFullReplacement_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.labelReplacement);
            this.groupBox1.Controls.Add(this.textBoxGroupReplacement);
            this.groupBox1.Controls.Add(this.buttonReplace);
            this.groupBox1.Controls.Add(this.textBoxGroupName);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Location = new System.Drawing.Point(3, 777);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(693, 142);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Replacement";
            // 
            // textBoxReplacementExample
            // 
            this.textBoxReplacementExample.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReplacementExample.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxReplacementExample.HideSelection = false;
            this.textBoxReplacementExample.Location = new System.Drawing.Point(6, 28);
            this.textBoxReplacementExample.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxReplacementExample.Multiline = true;
            this.textBoxReplacementExample.Name = "textBoxReplacementExample";
            this.textBoxReplacementExample.ReadOnly = true;
            this.textBoxReplacementExample.Size = new System.Drawing.Size(580, 98);
            this.textBoxReplacementExample.TabIndex = 18;
            // 
            // groupBoxSuggestions
            // 
            this.groupBoxSuggestions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSuggestions.Controls.Add(this.dataGridViewSuggestions);
            this.groupBoxSuggestions.Location = new System.Drawing.Point(702, 4);
            this.groupBoxSuggestions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxSuggestions.Name = "groupBoxSuggestions";
            this.groupBoxSuggestions.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.SetRowSpan(this.groupBoxSuggestions, 5);
            this.groupBoxSuggestions.Size = new System.Drawing.Size(693, 915);
            this.groupBoxSuggestions.TabIndex = 20;
            this.groupBoxSuggestions.TabStop = false;
            this.groupBoxSuggestions.Text = "Suggestions";
            // 
            // dataGridViewSuggestions
            // 
            this.dataGridViewSuggestions.AllowUserToAddRows = false;
            this.dataGridViewSuggestions.AllowUserToDeleteRows = false;
            this.dataGridViewSuggestions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSuggestions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewSuggestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSuggestions.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSuggestions.Location = new System.Drawing.Point(14, 28);
            this.dataGridViewSuggestions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewSuggestions.Name = "dataGridViewSuggestions";
            this.dataGridViewSuggestions.ReadOnly = true;
            this.dataGridViewSuggestions.RowHeadersWidth = 51;
            this.dataGridViewSuggestions.RowTemplate.Height = 29;
            this.dataGridViewSuggestions.Size = new System.Drawing.Size(673, 881);
            this.dataGridViewSuggestions.TabIndex = 0;
            this.dataGridViewSuggestions.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSuggestions_CellContentClick);
            // 
            // groupBoxOriginal
            // 
            this.groupBoxOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOriginal.Controls.Add(this.textBoxOriginal);
            this.groupBoxOriginal.Controls.Add(this.buttonInit);
            this.groupBoxOriginal.Controls.Add(this.checkBoxFull);
            this.groupBoxOriginal.Location = new System.Drawing.Point(3, 2);
            this.groupBoxOriginal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxOriginal.Name = "groupBoxOriginal";
            this.groupBoxOriginal.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxOriginal.Size = new System.Drawing.Size(693, 146);
            this.groupBoxOriginal.TabIndex = 21;
            this.groupBoxOriginal.TabStop = false;
            this.groupBoxOriginal.Text = "Original text";
            // 
            // groupBoxRegex
            // 
            this.groupBoxRegex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxRegex.AutoSize = true;
            this.groupBoxRegex.Controls.Add(this.richTextBoxRegex);
            this.groupBoxRegex.Controls.Add(this.buttonCopyRegexAsCSharp);
            this.groupBoxRegex.Location = new System.Drawing.Point(3, 152);
            this.groupBoxRegex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxRegex.Name = "groupBoxRegex";
            this.groupBoxRegex.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxRegex.Size = new System.Drawing.Size(693, 319);
            this.groupBoxRegex.TabIndex = 4;
            this.groupBoxRegex.TabStop = false;
            this.groupBoxRegex.Text = "Regex";
            // 
            // richTextBoxRegex
            // 
            this.richTextBoxRegex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxRegex.DetectUrls = false;
            this.richTextBoxRegex.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBoxRegex.HideSelection = false;
            this.richTextBoxRegex.Location = new System.Drawing.Point(6, 26);
            this.richTextBoxRegex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBoxRegex.Name = "richTextBoxRegex";
            this.richTextBoxRegex.Size = new System.Drawing.Size(580, 291);
            this.richTextBoxRegex.TabIndex = 15;
            this.richTextBoxRegex.Text = "";
            this.richTextBoxRegex.SelectionChanged += new System.EventHandler(this.richTextBoxRegex_SelectionChanged);
            this.richTextBoxRegex.TextChanged += new System.EventHandler(this.richTextBoxRegex_TextChanged);
            // 
            // buttonCopyRegexAsCSharp
            // 
            this.buttonCopyRegexAsCSharp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCopyRegexAsCSharp.Location = new System.Drawing.Point(592, 28);
            this.buttonCopyRegexAsCSharp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCopyRegexAsCSharp.Name = "buttonCopyRegexAsCSharp";
            this.buttonCopyRegexAsCSharp.Size = new System.Drawing.Size(95, 31);
            this.buttonCopyRegexAsCSharp.TabIndex = 14;
            this.buttonCopyRegexAsCSharp.Text = "📋 C#";
            this.buttonCopyRegexAsCSharp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCopyRegexAsCSharp.UseVisualStyleBackColor = true;
            this.buttonCopyRegexAsCSharp.Click += new System.EventHandler(this.buttonCopyCSharp_Click);
            // 
            // groupBoxReplacement
            // 
            this.groupBoxReplacement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxReplacement.Controls.Add(this.buttonVSCode);
            this.groupBoxReplacement.Controls.Add(this.textBoxFullReplacement);
            this.groupBoxReplacement.Location = new System.Drawing.Point(3, 475);
            this.groupBoxReplacement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxReplacement.Name = "groupBoxReplacement";
            this.groupBoxReplacement.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxReplacement.Size = new System.Drawing.Size(693, 146);
            this.groupBoxReplacement.TabIndex = 22;
            this.groupBoxReplacement.TabStop = false;
            this.groupBoxReplacement.Text = "Replacement";
            // 
            // buttonVSCode
            // 
            this.buttonVSCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonVSCode.Location = new System.Drawing.Point(591, 28);
            this.buttonVSCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonVSCode.Name = "buttonVSCode";
            this.buttonVSCode.Size = new System.Drawing.Size(95, 31);
            this.buttonVSCode.TabIndex = 16;
            this.buttonVSCode.Text = "📋 VS Code";
            this.buttonVSCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVSCode.UseVisualStyleBackColor = true;
            this.buttonVSCode.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBoxReplacementExample
            // 
            this.groupBoxReplacementExample.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxReplacementExample.Controls.Add(this.textBoxReplacementExample);
            this.groupBoxReplacementExample.Location = new System.Drawing.Point(3, 625);
            this.groupBoxReplacementExample.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxReplacementExample.Name = "groupBoxReplacementExample";
            this.groupBoxReplacementExample.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxReplacementExample.Size = new System.Drawing.Size(693, 146);
            this.groupBoxReplacementExample.TabIndex = 23;
            this.groupBoxReplacementExample.TabStop = false;
            this.groupBoxReplacementExample.Text = "Replacement example";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBoxOriginal, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxSuggestions, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxReplacementExample, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxReplacement, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxRegex, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1398, 923);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 947);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(480, 588);
            this.Name = "MainForm";
            this.Text = "RegexReplacer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxSuggestions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuggestions)).EndInit();
            this.groupBoxOriginal.ResumeLayout(false);
            this.groupBoxOriginal.PerformLayout();
            this.groupBoxRegex.ResumeLayout(false);
            this.groupBoxReplacement.ResumeLayout(false);
            this.groupBoxReplacement.PerformLayout();
            this.groupBoxReplacementExample.ResumeLayout(false);
            this.groupBoxReplacementExample.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}


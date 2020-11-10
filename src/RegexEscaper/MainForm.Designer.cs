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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonInit = new System.Windows.Forms.Button();
            this.checkBoxFull = new System.Windows.Forms.CheckBox();
            this.textBoxOriginal = new System.Windows.Forms.TextBox();
            this.textBoxRegex = new System.Windows.Forms.TextBox();
            this.textBoxReplacement = new System.Windows.Forms.TextBox();
            this.labelReplacement = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxGroupName = new System.Windows.Forms.TextBox();
            this.buttonReplace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonInit
            // 
            this.buttonInit.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInit.Location = new System.Drawing.Point(356, 11);
            this.buttonInit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInit.Name = "buttonInit";
            this.buttonInit.Size = new System.Drawing.Size(94, 23);
            this.buttonInit.TabIndex = 0;
            this.buttonInit.Text = "init";
            this.buttonInit.UseVisualStyleBackColor = true;
            this.buttonInit.Click += new System.EventHandler(this.buttonInit_Click);
            // 
            // checkBoxFull
            // 
            this.checkBoxFull.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxFull.AutoSize = true;
            this.checkBoxFull.Checked = true;
            this.checkBoxFull.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFull.Location = new System.Drawing.Point(356, 38);
            this.checkBoxFull.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxFull.Name = "checkBoxFull";
            this.checkBoxFull.Size = new System.Drawing.Size(90, 21);
            this.checkBoxFull.TabIndex = 1;
            this.checkBoxFull.Text = "full match";
            this.checkBoxFull.UseVisualStyleBackColor = true;
            // 
            // textBoxOriginal
            // 
            this.textBoxOriginal.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOriginal.HideSelection = false;
            this.textBoxOriginal.Location = new System.Drawing.Point(12, 12);
            this.textBoxOriginal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxOriginal.Multiline = true;
            this.textBoxOriginal.Name = "textBoxOriginal";
            this.textBoxOriginal.Size = new System.Drawing.Size(327, 47);
            this.textBoxOriginal.TabIndex = 3;
            this.textBoxOriginal.Text = "paste the text to match here…";
            // 
            // textBoxRegex
            // 
            this.textBoxRegex.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRegex.HideSelection = false;
            this.textBoxRegex.Location = new System.Drawing.Point(12, 64);
            this.textBoxRegex.Multiline = true;
            this.textBoxRegex.Name = "textBoxRegex";
            this.textBoxRegex.Size = new System.Drawing.Size(438, 305);
            this.textBoxRegex.TabIndex = 4;
            // 
            // textBoxReplacement
            // 
            this.textBoxReplacement.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReplacement.Location = new System.Drawing.Point(115, 375);
            this.textBoxReplacement.Name = "textBoxReplacement";
            this.textBoxReplacement.Size = new System.Drawing.Size(235, 22);
            this.textBoxReplacement.TabIndex = 5;
            // 
            // labelReplacement
            // 
            this.labelReplacement.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelReplacement.Location = new System.Drawing.Point(13, 378);
            this.labelReplacement.Name = "labelReplacement";
            this.labelReplacement.Size = new System.Drawing.Size(96, 19);
            this.labelReplacement.TabIndex = 6;
            this.labelReplacement.Text = "replacement";
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelName.Location = new System.Drawing.Point(13, 406);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(96, 19);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "group name";
            // 
            // textBoxGroupName
            // 
            this.textBoxGroupName.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxGroupName.Location = new System.Drawing.Point(115, 403);
            this.textBoxGroupName.Name = "textBoxGroupName";
            this.textBoxGroupName.Size = new System.Drawing.Size(235, 22);
            this.textBoxGroupName.TabIndex = 8;
            // 
            // buttonReplace
            // 
            this.buttonReplace.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReplace.Location = new System.Drawing.Point(356, 375);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(94, 50);
            this.buttonReplace.TabIndex = 9;
            this.buttonReplace.Text = "replace";
            this.buttonReplace.UseVisualStyleBackColor = true;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 433);
            this.Controls.Add(this.buttonReplace);
            this.Controls.Add(this.textBoxGroupName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelReplacement);
            this.Controls.Add(this.textBoxReplacement);
            this.Controls.Add(this.textBoxRegex);
            this.Controls.Add(this.textBoxOriginal);
            this.Controls.Add(this.checkBoxFull);
            this.Controls.Add(this.buttonInit);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(480, 480);
            this.Name = "MainForm";
            this.Text = "RegexReplacer";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button buttonInit;
        private System.Windows.Forms.CheckBox checkBoxFull;

        private System.Windows.Forms.Button buttonReplace;

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelReplacement;
        private System.Windows.Forms.TextBox textBoxGroupName;
        private System.Windows.Forms.TextBox textBoxReplacement;

        private System.Windows.Forms.TextBox textBoxOriginal;
        private System.Windows.Forms.TextBox textBoxRegex;

        #endregion
    }
}


using System;
using System.Windows.Forms;
using Microsoft.FSharp.Core;
using RegexEscaperLib;

namespace RegexEscaper
{
    public partial class MainForm : Form
    {
        public MainForm(string text)
        {
            InitializeComponent();
            textBoxOriginal.Text = text;
        }

        private void buttonInit_Click(object sender, EventArgs e)
        {
            textBoxRegex.Text = RegexModifier.simpleEscape(textBoxOriginal.Text, checkBoxFull.Checked);
        }

        private void buttonReplace_Click(object sender, EventArgs e)
        {
            var result = RegexModifier.substitute(
                textBoxRegex.Text,
                textBoxRegex.SelectionStart,
                textBoxRegex.SelectionLength,
                textBoxReplacement.Text,
                Option(textBoxGroupName.Text),
                textBoxOriginal.Text
            );

            switch (result)
            {
                case RegexModifier.SubstitutionResult.Failure failure:
                {
                    MessageBox.Show(failure.Item.Message);
                    return;
                }

                case RegexModifier.SubstitutionResult.Success success:
                {
                    textBoxReplacement.Text = string.Empty;
                    textBoxGroupName.Text = string.Empty;
                    textBoxRegex.Text = success.Item.NewRegex;
                    return;
                }

                default: throw new NotImplementedException();
            }
        }

        private FSharpOption<string> Option(string value)
        {
            return string.IsNullOrWhiteSpace(value)
                ? FSharpOption<string>.None
                : FSharpOption<string>.Some(value);
        }

        private void textBoxRegex_TextChanged(object sender, EventArgs e)
        {
            textBoxCSharp.Text = ObjectDumper.Dump(textBoxRegex.Text, DumpStyle.CSharp);
        }
    }
}

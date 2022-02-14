using System;
using System.Drawing;
using System.Text.RegularExpressions;
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
            Init(text);
        }

        private void buttonInit_Click(object sender, EventArgs e) => Init(textBoxOriginal.Text);

        private void Init(string text)
        {
            textBoxOriginal.Text = text;
            richTextBoxRegex.Text = RegexEscape.simpleEscape(
                fullMatch: checkBoxFull.Checked,
                originalText: textBoxOriginal.Text
            );
            UpdateSuggestions();
        }

        private void buttonReplace_Click(object sender, EventArgs e)
        {
            ReplacePart(
                richTextBoxRegex.Text,
                richTextBoxRegex.SelectionStart,
                richTextBoxRegex.SelectionLength,
                textBoxGroupReplacement.Text,
                Option(textBoxGroupName.Text),
                textBoxOriginal.Text
            );
        }

        private void ReplacePart(string originalRegex, int selectionStart, int selectionLength, string replacement, FSharpOption<string> groupName, string sampleValue)
        {
            var result = RegexModifier.substitute(
                originalRegex,
                selectionStart,
                selectionLength,
                replacement,
                groupName,
                sampleValue
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
                    textBoxGroupReplacement.Text = string.Empty;
                    textBoxGroupName.Text = string.Empty;
                    richTextBoxRegex.Text = success.Item.NewRegex;
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

        private void buttonCopyCSharp_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ObjectDumper.Dump(richTextBoxRegex.Text, DumpStyle.CSharp));
        }

        private void richTextBoxRegex_TextChanged(object sender, EventArgs e)
        {
            ValidateRegex();
            ComputeTextReplacement();
        }

        private void richTextBoxRegex_SelectionChanged(object sender, EventArgs e) => UpdateSuggestions();
        private void textBoxOriginal_TextChanged(object sender, EventArgs e) => ComputeTextReplacement();
        private void textBoxFullReplacement_TextChanged(object sender, EventArgs e) => ComputeTextReplacement();

        private void ValidateRegex()
        {
            bool IsValid(string input, string pattern)
            {
                try
                {
                    return Regex.IsMatch(input, pattern);
                }
                catch (RegexParseException)
                {
                    return false;
                }
            }

            richTextBoxRegex.BackColor = IsValid(textBoxOriginal.Text, richTextBoxRegex.Text) ? default : Color.LightPink;
        }

        private void UpdateSuggestions()
        {
            try
            {
                var input = richTextBoxRegex.SelectedText.Length > 0 ? richTextBoxRegex.SelectedText : richTextBoxRegex.Text;
                var suggestions = RegexSuggestions.get(input);
                dataGridViewSuggestions.DataSource = suggestions;
            }
            catch (Exception e)
            {
                textBoxReplacementExample.Text = e.ToString();
            }
        }

        private void ComputeTextReplacement()
        {
            try
            {
                var pattern = richTextBoxRegex.Text;
                var input = textBoxOriginal.Text;
                var replacement = textBoxFullReplacement.Text;
                textBoxReplacementExample.Text = Regex.Replace(input, pattern, replacement);
            }
            catch (Exception e)
            {
                textBoxReplacementExample.Text = e.ToString();
            }
        }

        private void dataGridViewSuggestions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = (RegexSuggestions.SuggestionItem)dataGridViewSuggestions.Rows[e.RowIndex].DataBoundItem;
            var (start, length) = richTextBoxRegex.SelectionLength == 0
                ? (0, richTextBoxRegex.Text.Length)
                : (richTextBoxRegex.SelectionStart, richTextBoxRegex.SelectionLength);

            ReplacePart(
                richTextBoxRegex.Text,
                start,
                length,
                item.Regex,
                Option(textBoxGroupName.Text),
                textBoxOriginal.Text
            );

            if (!string.IsNullOrEmpty(item.Replacement) && textBoxFullReplacement.Text.Length == 0)
            {
                textBoxFullReplacement.Text = item.Replacement;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;
namespace TpgrphDZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
              InitializeComponent();
        }
        

        public void buttonRun_Click(object sender, EventArgs e)
        {
            string inputText = richTextBoxInput.Text;
            string outputText = TEdit(inputText);
            outputText = Defis(outputText);
            outputText = Znaki(outputText);
            outputText = ExtraSpaces(outputText);
            outputText = PlusMinus(outputText);
            outputText = Stepen(outputText);
            outputText = LetterD(outputText);
            label1.Text = outputText;
        }

        public string TEdit(string inputText)
        {
            return inputText.Replace("а", "a");
        }

        public string Defis(string inputText)
        {
            string editedText = Regex.Replace(inputText, @" - | -|- ", "-");
            return editedText;
        }

        public string Znaki(string inputText)
        {
            bool isOpeningQuote = true;
            return new string(inputText.Select(c => c == '"' ? (isOpeningQuote = !isOpeningQuote) ? '»' : '«' : c).ToArray());
        }

        public string ExtraSpaces(string inputText)
        {
            var reg = new Regex(@"\s+");
            string editedText = reg.Replace(inputText, " ");
            return editedText.Trim();
        }

        public string PlusMinus(string inputText)
        {
            string editedText = inputText.Replace("+,-", "±").Replace("+-", "±");
            return editedText;
        }

        public string Stepen(string inputText)
        {
            string editedText = inputText.Replace("^2", "²").Replace("^3", "³");
            return editedText;
        }

        public string LetterD(string inputText)
        {
            string editedText = inputText.Replace("д", "Д");
            return editedText;
        }

        public void richTextBoxInput_TextChanged(object sender, EventArgs e)
        {
        }

        public void label1_Click(object sender, EventArgs e)
        {
        }

        public void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        public void buttonCopy_Click(object sender, EventArgs e)
        {
            string labelText = label1.Text;
            Clipboard.SetText(labelText);
            

            Form3 form3 = new Form3();
            form3.Show();


        }
        
    }
    
}
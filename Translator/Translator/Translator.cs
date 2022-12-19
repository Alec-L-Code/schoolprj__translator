using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Translator
{
    // Form for translating English into Pig Latin and Pig Greek
    public partial class Translator_Form : Form
    {
        public Translator_Form()
        {
            InitializeComponent();
        }
        private void Translator_Form_Load(object sender, EventArgs e)
        {
            English_TextBox.Text = "Translate English Text into either Pig Latin or Pig Greek using the buttons\n" +
                "Then press translate to translate the text. Press clear to clear both text boxes.";
        }
        private void Exit_Button_Click(object sender, EventArgs e) { Close(); }
        private void Clear_Button_Click(object sender, EventArgs e) { English_TextBox.Text = string.Empty; Translated_TextBox.Text = string.Empty; }
        // Handles the translation call
        private void Translate_Button_Click(object sender, EventArgs e)
        {
            ITranslator translator;
            string translation = "";
            // Pig Greek and Pig Latin translations based off the selected radio
            if(PigLatin_Radio.Checked) { translator = new PigLatinTranslator(); translation = translator.Translate(English_TextBox.Text); }
            if(PigGreek_Radio.Checked) { translator = new PigGreekTranslator(); translation = translator.Translate(English_TextBox.Text); }
            Translated_TextBox.Text = translation;
        }
    }
}

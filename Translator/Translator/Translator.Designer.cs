namespace Translator
{
    partial class Translator_Form
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
            this.components = new System.ComponentModel.Container();
            this.English_TextBox = new System.Windows.Forms.TextBox();
            this.Translated_TextBox = new System.Windows.Forms.TextBox();
            this.English_Label = new System.Windows.Forms.Label();
            this.Translated_Label = new System.Windows.Forms.Label();
            this.PigLatin_Radio = new System.Windows.Forms.RadioButton();
            this.PigGreek_Radio = new System.Windows.Forms.RadioButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Translate_Button = new System.Windows.Forms.Button();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // English_TextBox
            // 
            this.English_TextBox.Location = new System.Drawing.Point(28, 28);
            this.English_TextBox.Multiline = true;
            this.English_TextBox.Name = "English_TextBox";
            this.English_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.English_TextBox.Size = new System.Drawing.Size(388, 128);
            this.English_TextBox.TabIndex = 2;
            // 
            // Translated_TextBox
            // 
            this.Translated_TextBox.Location = new System.Drawing.Point(28, 229);
            this.Translated_TextBox.Multiline = true;
            this.Translated_TextBox.Name = "Translated_TextBox";
            this.Translated_TextBox.ReadOnly = true;
            this.Translated_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Translated_TextBox.Size = new System.Drawing.Size(388, 135);
            this.Translated_TextBox.TabIndex = 3;
            // 
            // English_Label
            // 
            this.English_Label.AutoSize = true;
            this.English_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.English_Label.Location = new System.Drawing.Point(25, 9);
            this.English_Label.Name = "English_Label";
            this.English_Label.Size = new System.Drawing.Size(118, 16);
            this.English_Label.TabIndex = 4;
            this.English_Label.Text = "Enter English Text:";
            // 
            // Translated_Label
            // 
            this.Translated_Label.AutoSize = true;
            this.Translated_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Translated_Label.Location = new System.Drawing.Point(25, 210);
            this.Translated_Label.Name = "Translated_Label";
            this.Translated_Label.Size = new System.Drawing.Size(105, 16);
            this.Translated_Label.TabIndex = 5;
            this.Translated_Label.Text = "Translated Text:";
            // 
            // PigLatin_Radio
            // 
            this.PigLatin_Radio.AutoSize = true;
            this.PigLatin_Radio.Location = new System.Drawing.Point(28, 175);
            this.PigLatin_Radio.Name = "PigLatin_Radio";
            this.PigLatin_Radio.Size = new System.Drawing.Size(66, 17);
            this.PigLatin_Radio.TabIndex = 0;
            this.PigLatin_Radio.TabStop = true;
            this.PigLatin_Radio.Text = "Pig Latin";
            this.PigLatin_Radio.UseVisualStyleBackColor = true;
            // 
            // PigGreek_Radio
            // 
            this.PigGreek_Radio.AutoSize = true;
            this.PigGreek_Radio.Location = new System.Drawing.Point(119, 175);
            this.PigGreek_Radio.Name = "PigGreek_Radio";
            this.PigGreek_Radio.Size = new System.Drawing.Size(72, 17);
            this.PigGreek_Radio.TabIndex = 1;
            this.PigGreek_Radio.TabStop = true;
            this.PigGreek_Radio.Text = "Pig Greek";
            this.PigGreek_Radio.UseVisualStyleBackColor = true;
            // 
            // Translate_Button
            // 
            this.Translate_Button.Location = new System.Drawing.Point(240, 175);
            this.Translate_Button.Name = "Translate_Button";
            this.Translate_Button.Size = new System.Drawing.Size(75, 23);
            this.Translate_Button.TabIndex = 6;
            this.Translate_Button.Text = "Translate";
            this.Translate_Button.UseVisualStyleBackColor = true;
            this.Translate_Button.Click += new System.EventHandler(this.Translate_Button_Click);
            // 
            // Clear_Button
            // 
            this.Clear_Button.Location = new System.Drawing.Point(341, 175);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(75, 23);
            this.Clear_Button.TabIndex = 7;
            this.Clear_Button.Text = "Clear";
            this.Clear_Button.UseVisualStyleBackColor = true;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Location = new System.Drawing.Point(354, 370);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(75, 23);
            this.Exit_Button.TabIndex = 8;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Translator_Form
            // 
            this.AcceptButton = this.Translate_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 401);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.Translate_Button);
            this.Controls.Add(this.PigGreek_Radio);
            this.Controls.Add(this.PigLatin_Radio);
            this.Controls.Add(this.Translated_Label);
            this.Controls.Add(this.English_Label);
            this.Controls.Add(this.Translated_TextBox);
            this.Controls.Add(this.English_TextBox);
            this.Name = "Translator_Form";
            this.Text = "Pig Latin & Greek Translator";
            this.Load += new System.EventHandler(this.Translator_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox English_TextBox;
        private System.Windows.Forms.TextBox Translated_TextBox;
        private System.Windows.Forms.Label English_Label;
        private System.Windows.Forms.Label Translated_Label;
        private System.Windows.Forms.RadioButton PigLatin_Radio;
        private System.Windows.Forms.RadioButton PigGreek_Radio;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button Translate_Button;
        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.Button Exit_Button;
    }
}


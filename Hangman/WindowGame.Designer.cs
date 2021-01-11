
namespace Hangman
{
    partial class WindowGame
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
            this.submitCharacter = new System.Windows.Forms.Button();
            this.submitTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guessButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // submitCharacter
            // 
            this.submitCharacter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.submitCharacter.Location = new System.Drawing.Point(188, 224);
            this.submitCharacter.Name = "submitCharacter";
            this.submitCharacter.Size = new System.Drawing.Size(75, 20);
            this.submitCharacter.TabIndex = 0;
            this.submitCharacter.Text = "Încearcă";
            this.submitCharacter.UseVisualStyleBackColor = true;
            this.submitCharacter.Click += new System.EventHandler(this.submitCharacter_Click);
            // 
            // submitTextBox
            // 
            this.submitTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.submitTextBox.Location = new System.Drawing.Point(162, 224);
            this.submitTextBox.Name = "submitTextBox";
            this.submitTextBox.Size = new System.Drawing.Size(20, 20);
            this.submitTextBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(614, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Înapoi la meniu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.goToMenu_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Introduce-ți o literă";
            // 
            // guessButton
            // 
            this.guessButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guessButton.Location = new System.Drawing.Point(269, 224);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(345, 21);
            this.guessButton.TabIndex = 4;
            this.guessButton.Text = "Arată o litera";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.guessCharacter_button_Click);
            // 
            // WindowGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(614, 274);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.submitTextBox);
            this.Controls.Add(this.submitCharacter);
            this.Name = "WindowGame";
            this.Text = "WindowGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitCharacter;
        private System.Windows.Forms.TextBox submitTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button guessButton;
    }
}
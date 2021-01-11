using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form1 : Form
    {
        Label tutorialLabel;
        Button exitTutorialButton;
        int x = 239;
        int y = 249;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            verticalLine();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowGame form = new WindowGame(this);

            form.Show();
            this.Hide();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitTutorial(object sender, EventArgs e)
        {
            tutorialLabel.Visible = false;
            exitTutorialButton.Visible = false;
            this.Size = new Size(x, y);
        }

        private void howToPlay_Click(object sender, EventArgs e)
        {
            Tutorial tutorial = new Tutorial();
            if (exitTutorialButton == null && tutorialLabel == null)
            {                
                string hangmanTutorial = tutorial.getTutorial();
                enlargeTheWindow();
                goToMenuButton();
                showTutorial(hangmanTutorial);
            }
            else
            {
                enlargeTheWindow();
                exitTutorialButton.Visible = true;
                tutorialLabel.Visible = true;
            }
        }
        private void enlargeTheWindow()
        {
            this.Size = new Size(550, 249);
        }
        private void showTutorial(string hangmanTutorial)
        {
            Label tutorialLabel = createTutorialBox(hangmanTutorial);
            Controls.Add(tutorialLabel);
        }
        private void goToMenuButton()
        {
            exitTutorialButton = new Button();
            exitTutorialButton.Location = new Point(450, 180);
            exitTutorialButton.Text = "<-";
            exitTutorialButton.Anchor = (AnchorStyles.Right | AnchorStyles.Bottom);
            exitTutorialButton.Visible = true;
            exitTutorialButton.Enabled = true;
            exitTutorialButton.Click += new EventHandler(exitTutorial);
            Controls.Add(exitTutorialButton);
        }
        private Label createTutorialBox(string hangmanTutorial)
        {
            tutorialLabel = new Label();
            tutorialLabel.Location = new Point(180, 75);
            tutorialLabel.Text = hangmanTutorial;
            tutorialLabel.Font = new Font("Arial", 10);
            tutorialLabel.Anchor = (AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left);
            tutorialLabel.Size = new Size(300, 150);

            return tutorialLabel;
        }
        private void verticalLine()
        {
            Label verticalLine = new Label();
            verticalLine.BackColor = Color.Black;
            verticalLine.Text = "A";
            verticalLine.Location = new Point(50, 249);
            verticalLine.Size = new Size(100, 250);
            Controls.Add(verticalLine);
        }
    }
}

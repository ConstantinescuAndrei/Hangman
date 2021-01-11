using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class WindowGame : Form
    {
        Form mainForm;

        private Image tailImage = Image.FromFile("C:/Users/const/source/repos/Hangman/Images/tile.jpg");
        
        NewGame newGame;
        List<int> xCoordinates = new List<int>();
        int yCoordinate = 150;
        Label livesLabel = new Label();
        PictureBox pictureBox = new PictureBox();
        private List<string> hangImages = new List<string>();
        private string directory = @"C:\Users\const\source\repos\Hangman\Images\HangImages";

        int guess;

        public WindowGame(Form mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            foreach (string myFile in Directory.GetFiles(directory, "*.png", SearchOption.AllDirectories))
            {
                hangImages.Add(myFile);
            }

            xCoordinates.Add(25);

            newGame = new NewGame();
            guess = newGame.howManyGuess();
            createBoxes(newGame.getWord());
            updateLives();
            showCategorie();
            updateGuessText();
        }
        private void submitCharacter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(submitTextBox.Text))
            {
                inputError();
            }
            else
            {
                if(submitTextBox.Text.Length > 1)
                {
                    inputError();
                }
                else
                {
                    char submitedCharacter = submitTextBox.Text[0];
                    submitedCharacter = char.ToUpper(submitedCharacter);
                    checkLetter(submitedCharacter);                    
                }                
            }

            submitTextBox.Clear();

            isGameWon();
            
        }
        private void goToMenu_button_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Hide();
        }
        private void guessCharacter_button_Click(object sender, EventArgs e)
        {
            guess--;
            char guessChar = newGame.guessCharacter();
            updateGuessText();
            checkLetter(guessChar);            
            isGameWon();
            guessButtonIsValid();
        }
        private void updateGuessText()
        {
            guessButton.Text = "Arată o literă" + " | " + guess + " încercări";
        }
        private void guessButtonIsValid()
        {
            if(guess == 0)
            {
                guessButton.Enabled = false;
            }
        }
        private void updateLives()
        {
            int lives = newGame.getLives();

            livesLabel.Text = "Mai ai " + lives + " vieți rămase!";
            livesLabel.Location = new Point(0, 0);
            livesLabel.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            livesLabel.AutoSize = true;
            livesLabel.Font = new Font("Calibri", 18);
            livesLabel.ForeColor = Color.Black;

            // Adding this control to the form 
            Controls.Add(livesLabel);

            updateHangmanImage(lives);
        }
        private void showCategorie()
        {
            string wordCategorie = newGame.getCategorie();

            Label categorieLabel = new Label();
            categorieLabel.Text = "Cuvântul este din categoria " + wordCategorie;
            categorieLabel.Location = new Point(0, 30);
            categorieLabel.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            categorieLabel.AutoSize = true;
            categorieLabel.Font = new Font("Calibri", 18);
            categorieLabel.ForeColor = Color.Black;

            Controls.Add(categorieLabel);
        }
        private void updateHangmanImage(int lives)
        {
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            Bitmap MyImage = new Bitmap(hangImages[lives]);
            pictureBox.Image = MyImage;
            pictureBox.Location = new Point(500, 0);
            pictureBox.ClientSize = new Size(100, 200);
            Controls.Add(pictureBox);
        }
        private void createBoxes(string word)
        {
            int x = xCoordinates[0];
            int y = yCoordinate;

            foreach (char c in word)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
                pictureBox.Image = tailImage;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.ClientSize = new Size(32, 40);
                pictureBox.Location = new Point(x, y);
                Controls.Add(pictureBox);

                x = x + 50;
                xCoordinates.Add(x);
            }
        }
        private void addCharacterOnTop(int index, char ch)
        {
            int x = xCoordinates[index];
            int y = yCoordinate;

            Label mylab = new Label();
            mylab.Text = ch.ToString();
            mylab.Location = new Point(x, y - 50);
            mylab.AutoSize = true;
            mylab.Font = new Font("Calibri", 18);
            mylab.ForeColor = Color.Green;
            mylab.Padding = new Padding(6);
            mylab.BringToFront();

            // Adding this control to the form 
            Controls.Add(mylab);
        }
        private void checkLetter(char submitedLetter)
        {
            List<int> indexes = newGame.checkCharacter(submitedLetter);

            if (indexes[0] != -1)
            {
                foreach (int index in indexes)
                {
                    addCharacterOnTop(index, submitedLetter);
                }
            }
            else
            {
                decreaseLives();
            }
        }
        private void decreaseLives()
        {
            newGame.decreaseLives();
            updateLives();
            if (!checkIfPlayerIsAlive(newGame.getLives()))
            {
                gameOver();
            }
        }
        private bool checkIfPlayerIsAlive(int lives)
        {
            if(lives == 0)
            {
                return false;
            }
            return true;
        }
        private void inputError()
        {
            DialogResult result = MessageBox.Show(
                                "Introduce-ți o literă!",
                                "Eroare",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                               );
        }
        private void gameOver()
        {
            DialogResult result = MessageBox.Show("Ai rămas fără vieți!",
                                "Ai pierdut",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Error
                            );
            if(result == DialogResult.Yes)
            {
                mainForm.Show();
                this.Hide();
            }
            else
            {
                mainForm.Close();
                this.Close();
            }
        }
        private void winningMessage()
        {
            DialogResult result = MessageBox.Show("Ai ghicit cuvăntul!",
                                "Ai câștigat",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            if(result == DialogResult.OK)
            {
                mainForm.Show();
                this.Close();
            }
        }
        private void isGameWon()
        {
            if (newGame.isGameWon())
            {
                winningMessage();
            }
        }
    }
}

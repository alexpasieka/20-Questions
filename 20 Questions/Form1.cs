// Alex Pasieka

// Using statements.
using System;
using System.Windows.Forms;

namespace _20_Questions
{
    public partial class Form1 : Form
    {
        // Create a binary search tree.
        BinTree tree;
        // Create a "current" node, starting at the root.
        Node currentNode;
        // Create a string variable to hold the answer if the computer loses.
        string answer;
        // Create a string variable to hold the description of the answer if the computer loses.
        string description;

        // Windows form constructor.
        public Form1()
        {
            // Initialize the form.
            InitializeComponent();

            // Hide irrelevant controls.
            yesButton.Hide();
            noButton.Hide();
            answerTextBox.Hide();
            OKButton.Hide();

            // Create a new binary search tree.
            tree = new BinTree();
            // Build the new binary search tree.
            tree.FileInput();

            // If the tree is empty (meaning the text file is blank or nonexistant)...
            if (tree.root == null)
            {
                // ...hide irrelevant controls...
                startButton.Hide();
                questionLabel.Hide();
                promptLabel.Hide();

                // ...allow for multiple lines in the introduction text...
                introLabel.Size = new System.Drawing.Size(578, 200);
                // ...tell the player that the game cannot be played...
                introLabel.Text = "Sorry we can't play a game right now. Come back later after I learn something.";

                // ...and reposition the quit button to the center.
                quitButton.Location = new System.Drawing.Point(302, 316);
            }
        }

        // Function when the start button is clicked.
        private void startButton_Click(object sender, EventArgs e)
        {
            // Change the welcome text back if the game has been restarted.
            introLabel.Text = "LET'S PLAY 20 QUESTIONS";

            // Hide the initial prompt.
            promptLabel.Hide();

            // Hide the text input controls if the game has been restarted.
            answerTextBox.Hide();
            OKButton.Hide();

            // Show the "yes" and "no" buttons.
            yesButton.Show();
            noButton.Show();

            // Change the start button's text accordingly.
            startButton.Text = "START OVER";

            // Initialize the current node to the root.
            currentNode = tree.root;

            // Display the first question.
            questionLabel.Text = "Are they " + currentNode.Data + "?";
        }

        // Function when the "yes" button is clicked.
        private void yesButton_Click(object sender, EventArgs e)
        {
            // If the current node is the last in the tree traversal...
            if (currentNode.No == null && currentNode.Yes == null)
            {
                // ...the computer wins...
                introLabel.Text = "I win! Good game!";

                // ...hide the answer controls...
                yesButton.Hide();
                noButton.Hide();

                // ...and prompt the player for another game.
                questionLabel.Text = "Would you like to play again?";
            }
            else
            {
                // But if this isn't the last node in the tree traversal, move to the question node's "yes" leaf node...
                currentNode = currentNode.Yes;
                // ...and ask the next question.
                questionLabel.Text = "Are they " + currentNode.Data + "?";
            }
        }

        // Function when the "no" button is clicked.
        private void noButton_Click(object sender, EventArgs e)
        {
            // If the current node is the last in the tree traversal...
            if (currentNode.No == null && currentNode.Yes == null)
            {
                // ...the player wins...
                introLabel.Text = "You win! Good game!";

                // ...hide the "yes" and "no" buttons...
                yesButton.Hide();
                noButton.Hide();

                // ...show the text input controls...
                answerTextBox.Show();
                OKButton.Show();

                // ...and the computer asks who it was.
                questionLabel.Text = "Who is it?";
            }
            else
            {
                // But if this isn't the last node in the tree traversal, move to the question node's "no" leaf node...
                currentNode = currentNode.No;
                // ...and ask the next question.
                questionLabel.Text = "Are they " + currentNode.Data + "?";
            }
        }

        // Function when the OK button has been clicked after text has been typed into the text box.
        private void OKButton_Click(object sender, EventArgs e)
        {
            // If the computer is asking who it was...
            if (questionLabel.Text == "Who is it?")
            {
                // ...the answer is taken from the text typed into the text box...
                answer = answerTextBox.Text;

                // ...the computer asks how these people are different...
                questionLabel.Text = "How is " + answer + " different from " + currentNode.Data + "? " + answer + " is...";

                // ...and clear the text box for the next time it is used.
                answerTextBox.Clear();
            }
            // If the computer is asking how they are different...
            else
            {
                // ...the description is taken from the text typed into the text box...
                description = answerTextBox.Text;

                // ...save the current node's data to a string...
                string no = currentNode.Data;
                // ...the user tells the computer how they are different...
                string newQuestion = description;
                // ...the current node turns into a question node rather than an answer leaf node, holding the new question...
                currentNode.Data = newQuestion;
                // ...the new node's "no" leaf node holds the current node's original data...
                currentNode.No = new Node(no);
                // ...the new node's "yes" leaf node holds the user's answer...
                currentNode.Yes = new Node(answer);

                // ...save the new information to the text file...
                tree.FileOutput();

                // ...hide the text input controls...
                answerTextBox.Hide();
                OKButton.Hide();

                // ...ask the player if they would like to play another game...
                questionLabel.Text = "Would you like to play again?";

                // ...and clear the text box for the next time it is used.
                answerTextBox.Clear();
            }
        }
        
        // Function for when the quit button is clicked.
        private void quitButton_Click(object sender, EventArgs e)
        {
            // Close the application.
            Close();
        }
    }
}
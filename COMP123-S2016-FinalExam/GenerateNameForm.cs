using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_FinalExam
{
    public partial class GenerateNameForm : Form

    {
        Random rnd = new Random();
        public GenerateNameForm()
        {
            InitializeComponent();
        }

        /*
         * This will generate random numbers, 
         * then use those numbers to pick random names from
         *  the corresponding list boxes.
         *  @method
         */

        private void GenerateNames()
        {
            
            int lastName = rnd.Next(50);     // creates a number between 0 and 50
            int firstName = rnd.Next(50);
     
           // int i = FirstNameListBox.Items.Count - 1;
           // int chosenItem = rnd.Next(card);
            FirstNameListBox.SelectedIndex = firstName;
            FirstNameTextBox.Text = FirstNameListBox.SelectedItem.ToString();
         //   int b = LastNameListBox.Items.Count - 1;
          //  int chosenItem2 = rnd.Next(i);
            LastNameListBox.SelectedIndex = lastName;
            LastNameTextBox.Text = LastNameListBox.SelectedItem.ToString();
        }


        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GenerateNames();    //This calls the generate names method when the user clicks the button.
        }

        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            GenerateNames();    //This calls the generate names method when form opens
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Hide();                                             //This closes the GenerateNameForm on mouse click of the 
            AbilityGeneratorForm abilitygeneratorform = new AbilityGeneratorForm();  //Next button, and opens the AbilityGeneratorForm.
            abilitygeneratorform.Show();
        }
    }
 }


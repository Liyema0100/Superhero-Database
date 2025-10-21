using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq.Expressions;

namespace Superhero_Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // tuple fuction is a function that uses the C# tuple syntax in its return type
        // it is used when a method needs to return multiple related values to the caller
        // tuple function that calculates the rank and threal level automatically based on the exam score entered by the user
        private (string rank,string threat) CalculatedRankAndThreat(int score)
        {
            if (score >= 81)
                return ("S-Rank", "Finals Week (threat to the entire academy)");
            else if (score >= 61)
                return ("A-Rank", "Midterm Madness (threat to a department)");
            else if (score >= 41)
                return ("B-Rank", "Group Project Gone Wrong (threat to a study group)");
            else
                return ("C-Rank","Pop Quiz (potential threat to an individual student)");
        }
        // function that lads the heros into the grid
        private void LoadHeroesIntoGrid()
        {
            // clearing the rows of the Data Grid View
            Heroesdgv.Rows.Clear();
            // the location of the file
            string filePath = "superheroes.txt";
            // stops the program if the file does not exist
            if (!File.Exists(filePath)) return;

            // reads every line from the superheroes text file and stores that as an array of strings
            string[] lines = File.ReadAllLines(filePath);
            // loop that adds each complete record as a new row in the Data Grid View
            foreach (var line in lines)
            {
                // splits the data into an array of individual strings
                var data = line.Split(',');
                // validation to ensure that the data array has exactly 8 elements
                if (data.Length == 8)
                // adds data to the Grid
                Heroesdgv.Rows.Add(data);
            }
        }
        // function that adds a new superhero to the Grid
        private void Addbtn_Click(object sender, EventArgs e)
        {
            try
            {
            // input validation of number entered as the score 
            if (!int.TryParse(ExamScoretxt.Text, out int score))
            {
                MessageBox.Show("Enter a valid number for the score");
                return;
            }
            // input validation of number entered as the age
            if (!int.TryParse(Agetxt.Text, out int ageValue))
            {
                MessageBox.Show("Enter a valid number for the Age.");
                return;
            }
            // the calculation of the Rank and Threat
            // keyword var is C#s modern way of as it tells the C# compiler to automatically determine the type of the variables being declared based on the parameter of the function
            // this syntax is called tuple deconstruction  as it immeadiatley unpacks the 2 return values from the function into 2 separate usable variable
            var (rank, threat) = CalculatedRankAndThreat(score);
            Rankcmb.Text = rank;
            ThreatLevelcmb.Text = threat;

            // creating a hero object from the class Superhero
            Superhero hero = new Superhero()
            {
                // the .Trim removes leading and trailing whitespace characters from the strings retrived from the text boxes
                SuperheroID = SuperheroIDtxt.Text.Trim(),
                Name = Nametxt.Text.Trim(),
                Age = ageValue,
                Superpower = SuperPowertxt.Text.Trim(),
                City = Citytxt.Text.Trim(),
                ExamScore = score,
                Rank = rank,
                ThreatLevel = threat,
            };

            // saving to the file 

            // creating a file
            string filePath = "superheroes.txt";
            // declaring the variable heroLine and assigning it the values of the information of the differnt superheroes
            string heroLine = $"{hero.SuperheroID},{hero.Name},{hero.Age},{hero.Superpower},{hero.City},{hero.ExamScore},{hero.Rank},{hero.ThreatLevel}";
            // method that opens a file and appends a collection of strings to the end of the file and then closes the file automatically
            // it is saving the single superhero record to the text file created
            File.AppendAllLines(filePath, new[] { heroLine });

            // confirming and clearing the fields
            // method that shows the user a confirmation message after the superhero data has been saved
            /*
             MessageBox.Show is the core method that opens a small window to interact with the user
             SuperHero added successfully! is the string displayed to the user
             Success is the title that appears in the title bar of the dialog window
             MessageBoxButtons.OK specifies that the OK button should appear on the dialog box
             MessageBoxIcon.Information specifies the icon to be displayed in the dialog box
            */
            MessageBox.Show("SuperHero added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // clearing the fields of the form 
            SuperheroIDtxt.Clear();
            Nametxt.Clear();
            Agetxt.Clear();
            SuperPowertxt.Clear();
            Citytxt.Clear();
            ExamScoretxt.Clear();
            Rankcmb.Text = "";
            ThreatLevelcmb.Text = "";
            // loading the superheroes to the grid
            LoadHeroesIntoGrid();
        }
        catch(Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

    }
        private void Updatebtn_Click(object sender, EventArgs e)
        {

        }

        private void Deletebtn_Click(object sender, EventArgs e)
        { try
            {
                // function checking if the user has not selected a row
                if (Heroesdgv.SelectedRows.Count == 0)
                {
                    /*
                MessageBox.Show is the core method that opens a small window to interact with the user
                Please select a hero to delete. is the string displayed to the user
                No Selection is the title that appears in the title bar of the dialog window
                MessageBoxButtons.OK specifies that the OK button should appear on the dialog box
                MessageBoxIcon.Warning specifies the warning icon to be displayed in the dialog box
               */
                    MessageBox.Show("Please select a hero to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // retrieving the superheroID and accessing the first row in the collection of rows and accesses the specific row that was selected by the user then converts the object into a string
                string SuperheroID = Heroesdgv.SelectedRows[0].Cells["SuperheroID"].Value.ToString();
                /*
              MessageBox.Show is the core method that opens a small window to interact with the user
             Are you sure you want to delete Superhero ID is the string displayed to the user
              Confirm Delete is the title that appears in the title bar of the dialog window
              MessageBoxButtons.YesNo specifies that the Yes and No button should appear on the dialog box
              MessageBoxIcon.Question specifies the question icon to be displayed in the dialog box
             */
                // asking the user for confirmation before deleting a record
                DialogResult confirm = MessageBox.Show($"Are you sure you want to delete Superhero ID {SuperheroID}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.No)
                    return;

                string filePath = "superheroes.txt";
                if (!File.Exists(filePath))
                {
                    /*
              MessageBox.Show is the core method that opens a small window to interact with the user
              No data file found.is the string displayed to the user
              Error is the title that appears in the title bar of the dialog window
              MessageBoxButtons.OK specifies that the OK button should appear on the dialog box
              MessageBoxIcon.Error specifies the error icon to be displayed in the dialog box
             */
                    // what displays if the file does not exist
                    MessageBox.Show("No data file found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // reads all the text lines from the file and converts them into a collection of strings
                var heroes = File.ReadAllLines(filePath).ToList();
                // filters the list of all hero records and creates a new list that excludes the hero that was selected to be deleted
                var updatedHeroes = heroes.Where(line => !line.StartsWith(SuperheroID + ",")).ToList();

                // Saving updated list
                File.WriteAllLines(filePath, updatedHeroes);

                /*
               MessageBox.Show is the core method that opens a small window to interact with the user
               SuperHero deleted successfully! is the string displayed to the user
               Success is the title that appears in the title bar of the dialog window
               MessageBoxButtons.OK specifies that the OK button should appear on the dialog box
               MessageBoxIcon.Information specifies the icon to be displayed in the dialog box
              */
                MessageBox.Show("Hero deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refreshing the grid
                LoadHeroesIntoGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting hero:" + ex.Message, "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void ViewAllbtn_Click(object sender, EventArgs e)
        {

        }

        private void Summarybtn_Click(object sender, EventArgs e)
        {

        }

       
    }
}
